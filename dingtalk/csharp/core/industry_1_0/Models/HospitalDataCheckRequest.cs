// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class HospitalDataCheckRequest : TeaModel {
        /// <summary>
        /// 所有状态的科室数量
        /// </summary>
        [NameInMap("allDeptCount")]
        [Validation(Required=false)]
        public long? AllDeptCount { get; set; }

        /// <summary>
        /// 正常状态的科室人员数量
        /// </summary>
        [NameInMap("allDeptUserCount")]
        [Validation(Required=false)]
        public long? AllDeptUserCount { get; set; }

        /// <summary>
        /// 所有状态的医疗组数量
        /// </summary>
        [NameInMap("allGroupCount")]
        [Validation(Required=false)]
        public long? AllGroupCount { get; set; }

        /// <summary>
        /// 所有状态的医疗组人员数量
        /// </summary>
        [NameInMap("allGroupUserCount")]
        [Validation(Required=false)]
        public long? AllGroupUserCount { get; set; }

        /// <summary>
        /// 状态为0的科室数量
        /// </summary>
        [NameInMap("deptCount")]
        [Validation(Required=false)]
        public long? DeptCount { get; set; }

        /// <summary>
        /// 正常状态的科室人员数量
        /// </summary>
        [NameInMap("deptUserCount")]
        [Validation(Required=false)]
        public long? DeptUserCount { get; set; }

        /// <summary>
        /// 正常状态的医疗组数量
        /// </summary>
        [NameInMap("groupCount")]
        [Validation(Required=false)]
        public long? GroupCount { get; set; }

        /// <summary>
        /// 正常状态的医疗组人员数量
        /// </summary>
        [NameInMap("groupUserCount")]
        [Validation(Required=false)]
        public long? GroupUserCount { get; set; }

    }

}
