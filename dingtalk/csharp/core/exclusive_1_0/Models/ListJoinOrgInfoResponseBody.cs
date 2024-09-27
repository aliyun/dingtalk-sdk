// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class ListJoinOrgInfoResponseBody : TeaModel {
        [NameInMap("orgInfoList")]
        [Validation(Required=false)]
        public List<ListJoinOrgInfoResponseBodyOrgInfoList> OrgInfoList { get; set; }
        public class ListJoinOrgInfoResponseBodyOrgInfoList : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ding32xxxxxxxxe0105d</para>
            /// </summary>
            [NameInMap("corpId")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testCode</para>
            /// </summary>
            [NameInMap("domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>钉钉(中国)信息技术有限公司</para>
            /// </summary>
            [NameInMap("orgFullName")]
            [Validation(Required=false)]
            public string OrgFullName { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>钉钉</para>
            /// </summary>
            [NameInMap("orgName")]
            [Validation(Required=false)]
            public long? OrgName { get; set; }

        }

    }

}
