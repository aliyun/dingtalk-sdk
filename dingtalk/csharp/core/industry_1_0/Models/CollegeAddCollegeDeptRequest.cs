// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class CollegeAddCollegeDeptRequest : TeaModel {
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

        /// <summary>
        /// 排序因子
        /// </summary>
        [NameInMap("sortFactor")]
        [Validation(Required=false)]
        public long? SortFactor { get; set; }

        /// <summary>
        /// 父部门id
        /// </summary>
        [NameInMap("superId")]
        [Validation(Required=false)]
        public long? SuperId { get; set; }

    }

}
