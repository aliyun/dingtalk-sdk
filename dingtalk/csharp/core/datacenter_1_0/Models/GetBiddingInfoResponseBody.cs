// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdatacenter_1_0.Models
{
    public class GetBiddingInfoResponseBody : TeaModel {
        /// <summary>
        /// 返回结果
        /// EntName:企业名称
        /// BidTitle:标文标题
        /// BidType:招标方式
        /// RegionName:地区
        /// BidIndustry:标的所属行业
        /// PublicDate:发布时间
        /// ProjectNum:项目编号
        /// ProjectName:项目名称
        /// ProjectAmount:项目金额
        /// TenderEntName:招标企业
        /// AgentEntName:代理企业
        /// WinnerEntName:中标企业
        /// Content:正文
        /// InfoType:标文类型
        /// SubType:子类型
        /// OpeningTime:开标时间
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
