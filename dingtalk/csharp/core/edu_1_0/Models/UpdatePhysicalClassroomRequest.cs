// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class UpdatePhysicalClassroomRequest : TeaModel {
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
        /// 教室id
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

        /// <summary>
        /// 扩展信息
        /// </summary>
        [NameInMap("ext")]
        [Validation(Required=false)]
        public string Ext { get; set; }

        /// <summary>
        /// 操作人id
        /// </summary>
        [NameInMap("opUserId")]
        [Validation(Required=false)]
        public string OpUserId { get; set; }

    }

}
