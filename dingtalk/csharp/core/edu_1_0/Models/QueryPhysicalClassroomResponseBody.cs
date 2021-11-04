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
            [NameInMap("classroomBuilding")]
            [Validation(Required=false)]
            public string ClassroomBuilding { get; set; }
            [NameInMap("classroomCampus")]
            [Validation(Required=false)]
            public string ClassroomCampus { get; set; }
            [NameInMap("classroomFloor")]
            [Validation(Required=false)]
            public string ClassroomFloor { get; set; }
            [NameInMap("classroomId")]
            [Validation(Required=false)]
            public long? ClassroomId { get; set; }
            [NameInMap("classroomName")]
            [Validation(Required=false)]
            public string ClassroomName { get; set; }
            [NameInMap("classroomNumber")]
            [Validation(Required=false)]
            public string ClassroomNumber { get; set; }
            [NameInMap("directBroadcast")]
            [Validation(Required=false)]
            public string DirectBroadcast { get; set; }
        };

        /// <summary>
        /// 请求是否成功
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
