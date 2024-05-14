// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkvillage_1_0.Models
{
    public class ListResidentSubDeptsResponseBody : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("departmentList")]
        [Validation(Required=false)]
        public List<ListResidentSubDeptsResponseBodyDepartmentList> DepartmentList { get; set; }
        public class ListResidentSubDeptsResponseBodyDepartmentList : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("departmentId")]
            [Validation(Required=false)]
            public long? DepartmentId { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("departmentName")]
            [Validation(Required=false)]
            public string DepartmentName { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("superDepartmentId")]
            [Validation(Required=false)]
            public long? SuperDepartmentId { get; set; }

        }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("hasMore")]
        [Validation(Required=false)]
        public bool? HasMore { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("nextCursor")]
        [Validation(Required=false)]
        public long? NextCursor { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
