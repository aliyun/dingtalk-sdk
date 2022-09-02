// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class QueryPhysicalClassroomResponseBody : TeaModel {
        /// <summary>
        /// 返回结果
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public QueryPhysicalClassroomResponseBodyResult Result { get; set; }
        public class QueryPhysicalClassroomResponseBodyResult : TeaModel {
            /// <summary>
            /// 教室教学楼
            /// </summary>
            [NameInMap("classroomBuilding")]
            [Validation(Required=false)]
            public string ClassroomBuilding { get; set; }

            /// <summary>
            /// 教室校区
            /// </summary>
            [NameInMap("classroomCampus")]
            [Validation(Required=false)]
            public string ClassroomCampus { get; set; }

            /// <summary>
            /// 教室楼层
            /// </summary>
            [NameInMap("classroomFloor")]
            [Validation(Required=false)]
            public string ClassroomFloor { get; set; }

            /// <summary>
            /// 教室ID
            /// </summary>
            [NameInMap("classroomId")]
            [Validation(Required=false)]
            public long? ClassroomId { get; set; }

            /// <summary>
            /// 教室名称
            /// </summary>
            [NameInMap("classroomName")]
            [Validation(Required=false)]
            public string ClassroomName { get; set; }

            /// <summary>
            /// 教室房间号
            /// </summary>
            [NameInMap("classroomNumber")]
            [Validation(Required=false)]
            public string ClassroomNumber { get; set; }

            /// <summary>
            /// 是否支持直播
            /// </summary>
            [NameInMap("directBroadcast")]
            [Validation(Required=false)]
            public string DirectBroadcast { get; set; }

        }

        /// <summary>
        /// 请求是否成功
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
