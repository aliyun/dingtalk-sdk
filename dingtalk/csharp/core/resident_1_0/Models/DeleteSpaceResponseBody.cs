// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkresident_1_0.Models
{
    public class DeleteSpaceResponseBody : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("delFailedDept")]
        [Validation(Required=false)]
        public List<DeleteSpaceResponseBodyDelFailedDept> DelFailedDept { get; set; }
        public class DeleteSpaceResponseBodyDelFailedDept : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>122222</para>
            /// </summary>
            [NameInMap("deptId")]
            [Validation(Required=false)]
            public long? DeptId { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("delSuccessCount")]
        [Validation(Required=false)]
        public bool? DelSuccessCount { get; set; }

    }

}
