using System.Xml.Serialization;
using Alipay.AopSdk.Core.Domain;

namespace Alipay.AopSdk.Core.Response
{
    /// <summary>
    /// AlipayMicropayOrderConfirmpayurlGetResponse.
    /// </summary>
    public class AlipayMicropayOrderConfirmpayurlGetResponse : AopResponse
    {
        /// <summary>
        /// SinglePayDetail信息
        /// </summary>
        [XmlElement("single_pay_detail")]
        public SinglePayDetail SinglePayDetail { get; set; }
    }
}
