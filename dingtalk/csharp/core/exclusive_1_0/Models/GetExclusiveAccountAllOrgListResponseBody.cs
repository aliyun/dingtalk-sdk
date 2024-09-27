// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class GetExclusiveAccountAllOrgListResponseBody : TeaModel {
        [NameInMap("orgInfoList")]
        [Validation(Required=false)]
        public List<GetExclusiveAccountAllOrgListResponseBodyOrgInfoList> OrgInfoList { get; set; }
        public class GetExclusiveAccountAllOrgListResponseBodyOrgInfoList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>ding32xxxxxxxxe0105d</para>
            /// </summary>
            [NameInMap("corpId")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("isMainOrg")]
            [Validation(Required=false)]
            public bool? IsMainOrg { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="http://xxx.dingtalk.com/xxx.jpg">http://xxx.dingtalk.com/xxx.jpg</a></para>
            /// </summary>
            [NameInMap("logoUrl")]
            [Validation(Required=false)]
            public string LogoUrl { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>钉钉(中国)信息技术有限公司</para>
            /// </summary>
            [NameInMap("orgFullName")]
            [Validation(Required=false)]
            public string OrgFullName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>钉钉</para>
            /// </summary>
            [NameInMap("orgName")]
            [Validation(Required=false)]
            public string OrgName { get; set; }

        }

    }

}
