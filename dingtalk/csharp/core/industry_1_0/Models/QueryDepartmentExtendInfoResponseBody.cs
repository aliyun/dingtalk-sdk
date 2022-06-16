// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class QueryDepartmentExtendInfoResponseBody : TeaModel {
        /// <summary>
        /// 扩展属性列表
        /// </summary>
        [NameInMap("content")]
        [Validation(Required=false)]
        public List<QueryDepartmentExtendInfoResponseBodyContent> Content { get; set; }
        public class QueryDepartmentExtendInfoResponseBodyContent : TeaModel {
            /// <summary>
            /// 科室或医疗组code
            /// </summary>
            [NameInMap("deptCode")]
            [Validation(Required=false)]
            public string DeptCode { get; set; }

            /// <summary>
            /// 扩展属性显示名称
            /// </summary>
            [NameInMap("deptExtendDisplayName")]
            [Validation(Required=false)]
            public string DeptExtendDisplayName { get; set; }

            /// <summary>
            /// 扩展属性key
            /// </summary>
            [NameInMap("deptExtendKey")]
            [Validation(Required=false)]
            public string DeptExtendKey { get; set; }

            /// <summary>
            /// 扩展属性value
            /// </summary>
            [NameInMap("deptExtendValue")]
            [Validation(Required=false)]
            public string DeptExtendValue { get; set; }

            /// <summary>
            /// 创建时间
            /// </summary>
            [NameInMap("gmtCreateStr")]
            [Validation(Required=false)]
            public string GmtCreateStr { get; set; }

            /// <summary>
            /// 修改时间
            /// </summary>
            [NameInMap("gmtModifiedStr")]
            [Validation(Required=false)]
            public string GmtModifiedStr { get; set; }

            /// <summary>
            /// id
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// 删除标识
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

        }

    }

}
