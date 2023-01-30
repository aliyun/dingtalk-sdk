// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdatacenter_1_0.Models
{
    public class GetInvestmentAbroadResponseBody : TeaModel {
        /// <summary>
        /// 返回结果
        /// EntName:企业名称	
        /// InvestName:被投资企业名称	北京德润华日投资顾问有限公司
        /// InvestCreditCode:被投资企业社会信用编码	911101073991890434
        /// InvestLicenseNo:被投资企业注册号	110107017240281
        /// InvestEsDate:被投资企业成立日期	2014-05-19
        /// InvestLegalName:被投资企业法定代表人	北京星际智慧投资基金管理有限公司
        /// InvestRegCap:被投资企业注册资本	13500.0万人民币
        /// InvestStatus:被投资企业经营状态	在营
        /// ShouldCap:投资数额	4000.0万人民币
        /// StockPercentage:投资比例	19.5%
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public string Data { get; set; }

        /// <summary>
        /// 总条数
        /// </summary>
        [NameInMap("total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
