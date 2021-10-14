// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkvillage_1_0.Models
{
    public class ListResidentSubDeptsResponseBody : TeaModel {
        /// <summary>
        /// 组户列表
        /// </summary>
        [NameInMap("departmentList")]
        [Validation(Required=false)]
        public List<ListResidentSubDeptsResponseBodyDepartmentList> DepartmentList { get; set; }
        public class ListResidentSubDeptsResponseBodyDepartmentList : TeaModel {
            /// <summary>
            /// 下属组织的部门ID
            /// </summary>
            [NameInMap("departmentId")]
            [Validation(Required=false)]
            public long? DepartmentId { get; set; }

            /// <summary>
            /// 组户名称
            /// </summary>
            [NameInMap("departmentName")]
            [Validation(Required=false)]
            public string DepartmentName { get; set; }

            /// <summary>
            /// 父部门ID
            /// </summary>
            [NameInMap("superDepartmentId")]
            [Validation(Required=false)]
            public long? SuperDepartmentId { get; set; }

        }

        /// <summary>
        /// 是否还有记录
        /// </summary>
        [NameInMap("hasMore")]
        [Validation(Required=false)]
        public bool? HasMore { get; set; }

        /// <summary>
        /// 游标
        /// </summary>
        [NameInMap("nextCursor")]
        [Validation(Required=false)]
        public long? NextCursor { get; set; }

        /// <summary>
        /// 总数
        /// </summary>
        [NameInMap("total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
