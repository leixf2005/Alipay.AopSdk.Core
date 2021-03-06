using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Response
{
    /// <summary>
    /// AlipayOpenAppQrcodeCreateResponse.
    /// </summary>
    public class AlipayOpenAppQrcodeCreateResponse : AopResponse
    {
        /// <summary>
        /// 二维码图片链接地址
        /// </summary>
        [XmlElement("qr_code_url")]
        public string QrCodeUrl { get; set; }
    }
}
