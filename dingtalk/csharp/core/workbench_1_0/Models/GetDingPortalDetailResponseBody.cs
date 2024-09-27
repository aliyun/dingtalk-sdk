// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkworkbench_1_0.Models
{
    public class GetDingPortalDetailResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>SWAPP-XXX</para>
        /// </summary>
        [NameInMap("appUuid")]
        [Validation(Required=false)]
        public string AppUuid { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>我的自定义工作台</para>
        /// </summary>
        [NameInMap("dingPortalName")]
        [Validation(Required=false)]
        public string DingPortalName { get; set; }

        [NameInMap("pages")]
        [Validation(Required=false)]
        public List<GetDingPortalDetailResponseBodyPages> Pages { get; set; }
        public class GetDingPortalDetailResponseBodyPages : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("allVisible")]
            [Validation(Required=false)]
            public bool? AllVisible { get; set; }

            [NameInMap("deptIds")]
            [Validation(Required=false)]
            public List<long?> DeptIds { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>我的工作台页面</para>
            /// </summary>
            [NameInMap("pageName")]
            [Validation(Required=false)]
            public string PageName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>XX-XX-XX</para>
            /// </summary>
            [NameInMap("pageUuid")]
            [Validation(Required=false)]
            public string PageUuid { get; set; }

            [NameInMap("roleIds")]
            [Validation(Required=false)]
            public List<long?> RoleIds { get; set; }

            [NameInMap("userids")]
            [Validation(Required=false)]
            public List<string> Userids { get; set; }

        }

    }

}
