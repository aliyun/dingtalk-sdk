// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class CollegeListCollegeSubDeptResponseBody : TeaModel {
        /// <summary>
        /// 部门信息列表
        /// </summary>
        [NameInMap("collegeDeptInfoSimpleList")]
        [Validation(Required=false)]
        public List<CollegeListCollegeSubDeptResponseBodyCollegeDeptInfoSimpleList> CollegeDeptInfoSimpleList { get; set; }
        public class CollegeListCollegeSubDeptResponseBodyCollegeDeptInfoSimpleList : TeaModel {
            /// <summary>
            /// 部门id
            /// </summary>
            [NameInMap("deptId")]
            [Validation(Required=false)]
            public long? DeptId { get; set; }

            /// <summary>
            /// 部门名称
            /// </summary>
            [NameInMap("deptName")]
            [Validation(Required=false)]
            public string DeptName { get; set; }

            /// <summary>
            /// 部门类型
            /// </summary>
            [NameInMap("deptType")]
            [Validation(Required=false)]
            public string DeptType { get; set; }

        }

    }

}
