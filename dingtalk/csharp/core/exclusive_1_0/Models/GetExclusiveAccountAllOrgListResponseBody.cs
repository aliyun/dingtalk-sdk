// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class GetExclusiveAccountAllOrgListResponseBody : TeaModel {
        /// <summary>
        /// 组织信息列表
        /// </summary>
        [NameInMap("orgInfoList")]
        [Validation(Required=false)]
        public List<GetExclusiveAccountAllOrgListResponseBodyOrgInfoList> OrgInfoList { get; set; }
        public class GetExclusiveAccountAllOrgListResponseBodyOrgInfoList : TeaModel {
            /// <summary>
            /// 组织ID
            /// </summary>
            [NameInMap("corpId")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            /// <summary>
            /// 是否是主组织
            /// </summary>
            [NameInMap("isMainOrg")]
            [Validation(Required=false)]
            public bool? IsMainOrg { get; set; }

            /// <summary>
            /// 组织图标地址
            /// </summary>
            [NameInMap("logoUrl")]
            [Validation(Required=false)]
            public string LogoUrl { get; set; }

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
            public string OrgName { get; set; }

        }

    }

}
