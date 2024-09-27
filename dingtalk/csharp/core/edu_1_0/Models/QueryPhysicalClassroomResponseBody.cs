// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class QueryPhysicalClassroomResponseBody : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public QueryPhysicalClassroomResponseBodyResult Result { get; set; }
        public class QueryPhysicalClassroomResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>主楼</para>
            /// </summary>
            [NameInMap("classroomBuilding")]
            [Validation(Required=false)]
            public string ClassroomBuilding { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>主校区</para>
            /// </summary>
            [NameInMap("classroomCampus")]
            [Validation(Required=false)]
            public string ClassroomCampus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3层</para>
            /// </summary>
            [NameInMap("classroomFloor")]
            [Validation(Required=false)]
            public string ClassroomFloor { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10001</para>
            /// </summary>
            [NameInMap("classroomId")]
            [Validation(Required=false)]
            public long? ClassroomId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>实验教室</para>
            /// </summary>
            [NameInMap("classroomName")]
            [Validation(Required=false)]
            public string ClassroomName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>301</para>
            /// </summary>
            [NameInMap("classroomNumber")]
            [Validation(Required=false)]
            public string ClassroomNumber { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Y</para>
            /// </summary>
            [NameInMap("directBroadcast")]
            [Validation(Required=false)]
            public string DirectBroadcast { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
