/*  
===============================================================================
 2007-2008 Copyright © Microsoft Corporation.  All rights reserved.
 THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY
 OF ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT
 LIMITED TO THE IMPLIED WARRANTIES OF MERCHANTABILITY AND
 FITNESS FOR A PARTICULAR PURPOSE.
===============================================================================
*/
using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Collections.Generic;
using System.Threading;
using System.Drawing;
using System.Xml;


namespace TerraViewer
{
    public class HttpXmlRpc : RequestHandler
    {
        private string _sig = "post /xmlrpc";
        public override bool Handles(string request)
        {
            return request.ToLower().StartsWith(_sig);
        }


        public override void ProcessRequest(string request, ref Socket socket, bool authenticated, string body)
        {
            QueryString query = new QueryString(request);

            String sMimeType = "_Text/xml";

            String data = XmlRpcMethod.DispatchRpcCall(body);
            SendHeaderAndData(data, ref socket, sMimeType);
        }
    }
    public delegate void CoordPointAtSkyDelegate(double ra, double dec);

    public class SampCoordPointAtSky : SampMessageHandler
    {
        CoordPointAtSkyDelegate coordPointAtSky;
        public SampCoordPointAtSky(CoordPointAtSkyDelegate callback)
        {
            Name = "coord.pointAt.sky";
            coordPointAtSky += callback;
        }

        public override string Dispatch(XmlNode node)
        {
            double ra=0;
            double dec=0;
            ra = Convert.ToDouble(node.SelectSingleNode("value/struct/member[name='ra']")["value"].InnerText)/15;
            dec = Convert.ToDouble(node.SelectSingleNode("value/struct/member[name='dec']")["value"].InnerText);
            if (coordPointAtSky != null)
            {
                coordPointAtSky.Invoke(ra, dec);
            }
            return "<?xml version='1.0' encoding='UTF-8'?>\r\n<methodResponse>\r\n<params>\r\n<param>\r\n<value></value>\r\n</param>\r\n</params>\n</methodResponse>\r\n";
        }
    }

    public delegate void TableLoadVoTableDelegate(string url, string id, string name);

    public class SampTableLoadVoTable : SampMessageHandler
    {
        TableLoadVoTableDelegate tableLoadVoTable;
        public SampTableLoadVoTable(TableLoadVoTableDelegate callback)
        {
            Name = "table.load.votable";
            tableLoadVoTable += callback;
        }

        public override string Dispatch(XmlNode node)
        {
            string url = node.SelectSingleNode("value/struct/member[name='url']")["value"].InnerText;
            string id = "";
            XmlNode idNode = node.SelectSingleNode("value/struct/member[name='table-id']");
            if (idNode != null)
            {
                id = idNode["value"].InnerText;
            }
            XmlNode nameNode = node.SelectSingleNode("value/struct/member[name='name']");
            string name = "";
            if (nameNode != null)
            {
                name = nameNode["value"].InnerText;
            }
            if (tableLoadVoTable != null)
            {
                tableLoadVoTable.Invoke(url, id, name);
            }
            return "<?xml version='1.0' encoding='UTF-8'?>\r\n<methodResponse>\r\n<params>\r\n<param>\r\n<value></value>\r\n</param>\r\n</params>\n</methodResponse>\r\n";
        }
    }

    public delegate void TableHighlightRowDelegate(string url, string id, int row);

    public class SampTableHighlightRow : SampMessageHandler
    {
        TableHighlightRowDelegate tableHighlightRow;
        public SampTableHighlightRow(TableHighlightRowDelegate callback)
        {
            Name = "table.highlight.row";
            tableHighlightRow += callback;
        }

        public override string Dispatch(XmlNode node)
        {
            string url = "";
            try
            {
                if (node.SelectSingleNode("value/struct/member[name='url']") != null)
                {

                    url = node.SelectSingleNode("value/struct/member[name='url']")["value"].InnerText;
                }
            }
            catch
            {
            }

            string id = null;
            XmlNode idNode = node.SelectSingleNode("value/struct/member[name='table-id']");
            if (idNode != null)
            {
                id = idNode["value"].InnerText;
            }
            XmlNode nameNode = node.SelectSingleNode("value/struct/member[name='row']");
            int row = 0;
            bool valid = false;
            if (nameNode != null)
            {
                try
                {
                    row = int.Parse(nameNode["value"].InnerText);
                    valid = true;
                }
                catch
                {
                }
            }

            if (tableHighlightRow != null && valid)
            {
                tableHighlightRow.Invoke(url, id, row);
            }
            return "<?xml version='1.0' encoding='UTF-8'?>\r\n<methodResponse>\r\n<params>\r\n<param>\r\n<value></value>\r\n</param>\r\n</params>\n</methodResponse>\r\n";
        }
    }



    public delegate void ImageLoadFitsDelegate(string url, string id, string name);
    public class SampImageLoadFits : SampMessageHandler
    {
        ImageLoadFitsDelegate imageLoadFits;
        public SampImageLoadFits(ImageLoadFitsDelegate callback)
        {
            Name = "image.load.fits";
            imageLoadFits += callback;
        }

        public override string Dispatch(XmlNode node)
        {
            string url = node.SelectSingleNode("value/struct/member[name='url']")["value"].InnerText;
            string id = "";
            XmlNode idNode = node.SelectSingleNode("value/struct/member[name='image-id']");
            if (idNode != null)
            {
                id = idNode["value"].InnerText;
            }
            XmlNode nameNode = node.SelectSingleNode("value/struct/member[name='name']");
            string name = "";
            if (nameNode != null)
            {
                name = nameNode["value"].InnerText;
            }
            if (imageLoadFits != null)
            {
                imageLoadFits.Invoke(url, id, name);
            }
            return "<?xml version='1.0' encoding='UTF-8'?>\r\n<methodResponse>\r\n<params>\r\n<param>\r\n<value></value>\r\n</param>\r\n</params>\n</methodResponse>\r\n";
        }
    }
    public abstract class SampMessageHandler
    {
        public string Name;
        abstract public string Dispatch(XmlNode node);
        static Dictionary<String, SampMessageHandler> SampHandlerMap = new Dictionary<string, SampMessageHandler>();
        public static void RegiseterMessage(SampMessageHandler handler)
        {
            SampHandlerMap.Add(handler.Name, handler);
        }

        public static string DispatchHandler(XmlNode node)
        {
            XmlNode messageNode = node.SelectSingleNode("params/param/value/struct/member[name='samp.mtype']");
            string mType = messageNode["value"].InnerText;

            if (SampHandlerMap.ContainsKey(mType))
            {
                SampHandlerMap[mType].Dispatch(node.SelectSingleNode("params/param/value/struct/member[name='samp.params']"));
            }

            return "<?xml version='1.0' encoding='UTF-8'?>\r\n<methodResponse>\r\n<params>\r\n<param>\r\n<value></value>\r\n</param>\r\n</params>\n</methodResponse>\r\n";
        }
    }




    public class SampClientReceiveNotification : XmlRpcMethod
    {
        public SampClientReceiveNotification()
        {
            Name = "samp.client.receiveNotification";
        }
        public override string Dispatch(XmlNode node)
        {
            return SampMessageHandler.DispatchHandler(node);
        }

    }

    public abstract class XmlRpcMethod
    {
        public string Name;
        public XmlRpcMethod()
        {

        }
        abstract public string Dispatch(XmlNode node);
        static Dictionary<string, XmlRpcMethod> RpcDispatchMap = new Dictionary<string, XmlRpcMethod>();
        public static void RegisterDispatchMap(XmlRpcMethod method)
        {
            RpcDispatchMap.Add(method.Name, method);
        }

        public static string DispatchRpcCall(string data)
        {
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(data);

            XmlNode nodeMethod = doc["methodCall"];

            string methodName = nodeMethod["methodName"].InnerText;

            if (RpcDispatchMap.ContainsKey(methodName))
            {
                XmlRpcMethod method = RpcDispatchMap[methodName];
                return method.Dispatch(nodeMethod);
            }
            return "<?xml version='1.0' encoding='UTF-8'?>\r\n<methodResponse>\r\n<params>\r\n<param>\r\n<value></value>\r\n</param>\r\n</params>\n</methodResponse>\r\n";
        }
    }
}
