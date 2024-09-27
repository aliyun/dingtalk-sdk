// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkchengfeng_1_0.Models
{
    public class GetOrgInfoResponseBody : TeaModel {
        [NameInMap("content")]
        [Validation(Required=false)]
        public GetOrgInfoResponseBodyContent Content { get; set; }
        public class GetOrgInfoResponseBodyContent : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("deptCode")]
            [Validation(Required=false)]
            public string DeptCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>开发技术部</para>
            /// </summary>
            [NameInMap("deptName")]
            [Validation(Required=false)]
            public string DeptName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("deptNum")]
            [Validation(Required=false)]
            public string DeptNum { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("level")]
            [Validation(Required=false)]
            public string Level { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>/1/123</para>
            /// </summary>
            [NameInMap("organizationCodePath")]
            [Validation(Required=false)]
            public string OrganizationCodePath { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>/开发技术部</para>
            /// </summary>
            [NameInMap("organizationPath")]
            [Validation(Required=false)]
            public string OrganizationPath { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("parentDeptCode")]
            [Validation(Required=false)]
            public string ParentDeptCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>开发部</para>
            /// </summary>
            [NameInMap("shortName")]
            [Validation(Required=false)]
            public string ShortName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1678886770065</para>
            /// </summary>
            [NameInMap("startDate")]
            [Validation(Required=false)]
            public string StartDate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1678886770065</para>
            /// </summary>
            [NameInMap("stopDate")]
            [Validation(Required=false)]
            public string StopDate { get; set; }

        }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
