using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Response
{
    /// <summary>
    /// AlipayMarketingCouponTemplateCreateResponse.
    /// </summary>
    public class AlipayMarketingCouponTemplateCreateResponse : AopResponse
    {
        /// <summary>
        /// 模板支付确认链接
        /// </summary>
        [XmlElement("confirm_uri")]
        public string ConfirmUri { get; set; }

        /// <summary>
        /// 资金订单号，模板支付时需要
        /// </summary>
        [XmlElement("fund_order_no")]
        public string FundOrderNo { get; set; }

        /// <summary>
        /// 红包模板ID
        /// </summary>
        [XmlElement("template_id")]
        public string TemplateId { get; set; }
    }
}
