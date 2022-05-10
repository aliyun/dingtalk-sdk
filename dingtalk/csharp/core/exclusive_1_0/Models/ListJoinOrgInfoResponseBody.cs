// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class ListJoinOrgInfoResponseBody : TeaModel {
        /// <summary>
        /// 组织信息列表
        /// </summary>
        [NameInMap("orgInfoList")]
        [Validation(Required=false)]
        public List<ListJoinOrgInfoResponseBodyOrgInfoList> OrgInfoList { get; set; }
        public class ListJoinOrgInfoResponseBodyOrgInfoList : TeaModel {
            /// <summary>
            /// 组织ID
            /// </summary>
            [NameInMap("corpId")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            /// <summary>
            /// 组织代码
            /// </summary>
            [NameInMap("domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            /// <summary>
            /// 组织全称
            /// </summary>
            [NameInMap("orgFullName")]
            [Validation(Required=false)]
            public string OrgFullName { get; set; }

            /// <summary>
            /// 组织名称
            /// </summary>
            [NameInMap("orgName")]
            [Validation(Required=false)]
            public long? OrgName { get; set; }

        }

    }

}
