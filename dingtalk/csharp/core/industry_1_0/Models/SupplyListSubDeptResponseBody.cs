// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class SupplyListSubDeptResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<SupplyListSubDeptResponseBodyResult> Result { get; set; }
        public class SupplyListSubDeptResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1111</para>
            /// </summary>
            [NameInMap("deptId")]
            [Validation(Required=false)]
            public long? DeptId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ROOT</para>
            /// </summary>
            [NameInMap("deptType")]
            [Validation(Required=false)]
            public string DeptType { get; set; }

            [NameInMap("hasSubDept")]
            [Validation(Required=false)]
            public bool? HasSubDept { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>xxxx 有限公司</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>111111</para>
            /// </summary>
            [NameInMap("partnerNumber")]
            [Validation(Required=false)]
            public string PartnerNumber { get; set; }

            [NameInMap("partnerTypeInfoList")]
            [Validation(Required=false)]
            public List<SupplyListSubDeptResponseBodyResultPartnerTypeInfoList> PartnerTypeInfoList { get; set; }
            public class SupplyListSubDeptResponseBodyResultPartnerTypeInfoList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>111</para>
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>11111</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1111</para>
                /// </summary>
                [NameInMap("superId")]
                [Validation(Required=false)]
                public long? SuperId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1111</para>
                /// </summary>
                [NameInMap("superName")]
                [Validation(Required=false)]
                public string SuperName { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1111</para>
            /// </summary>
            [NameInMap("superId")]
            [Validation(Required=false)]
            public long? SuperId { get; set; }

        }

    }

}
