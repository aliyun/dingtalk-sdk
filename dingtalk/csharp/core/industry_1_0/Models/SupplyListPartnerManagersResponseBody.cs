// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class SupplyListPartnerManagersResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<SupplyListPartnerManagersResponseBodyResult> Result { get; set; }
        public class SupplyListPartnerManagersResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>56789123</para>
            /// </summary>
            [NameInMap("deptId")]
            [Validation(Required=false)]
            public string DeptId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>对接部门名称</para>
            /// </summary>
            [NameInMap("deptName")]
            [Validation(Required=false)]
            public string DeptName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>user</para>
            /// </summary>
            [NameInMap("interfaceType")]
            [Validation(Required=false)]
            public string InterfaceType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>121234567</para>
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>名称</para>
            /// </summary>
            [NameInMap("userName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

        }

    }

}
