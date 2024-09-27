// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class HospitalDataCheckRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("allDeptCount")]
        [Validation(Required=false)]
        public long? AllDeptCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("allDeptUserCount")]
        [Validation(Required=false)]
        public long? AllDeptUserCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("allGroupCount")]
        [Validation(Required=false)]
        public long? AllGroupCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("allGroupUserCount")]
        [Validation(Required=false)]
        public long? AllGroupUserCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("deptCount")]
        [Validation(Required=false)]
        public long? DeptCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("deptUserCount")]
        [Validation(Required=false)]
        public long? DeptUserCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("groupCount")]
        [Validation(Required=false)]
        public long? GroupCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("groupUserCount")]
        [Validation(Required=false)]
        public long? GroupUserCount { get; set; }

    }

}
