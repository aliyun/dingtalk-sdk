// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdatacenter_1_0.Models
{
    public class GetPatentInfoResponseBody : TeaModel {
        /// <summary>
        /// 返回结果
        /// EntName:企业名称
        /// PatentType:专利类型
        /// PatentName:专利名
        /// PatentStatus:专利状态
        /// RequestNum:申请号
        /// RequestDate:申请日
        /// PublicNum:公开(公告)号
        /// PublicDate:公开(公告)日
        /// InventorList:发明人
        /// PatenteeList:专利权人
        /// CateNum:分类号
        /// PrioNum:优先权号
        /// PrioDate:优先权日
        /// Agency:专利代理机构
        /// Agent:代理人
        /// Brief:简要说明
        /// MainClaim:主权项
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
