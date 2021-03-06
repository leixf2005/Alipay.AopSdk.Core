using System.Xml.Serialization;
using Alipay.AopSdk.Core.Domain;

namespace Alipay.AopSdk.Core.Response
{
    /// <summary>
    /// AlipayMarketingToolFengdieSpaceQueryResponse.
    /// </summary>
    public class AlipayMarketingToolFengdieSpaceQueryResponse : AopResponse
    {
        /// <summary>
        /// 空间详情信息，比如空间名称、空间管理员等信息
        /// </summary>
        [XmlElement("data")]
        public FengdieSpaceDetailModel Data { get; set; }
    }
}
