// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class StartCoursePrepareRequest : TeaModel {
        /// <summary>
        /// 上课日期
        /// </summary>
        [NameInMap("courseDate")]
        [Validation(Required=false)]
        public string CourseDate { get; set; }

        /// <summary>
        /// 课程组编号
        /// </summary>
        [NameInMap("courseGroupCode")]
        [Validation(Required=false)]
        public string CourseGroupCode { get; set; }

        /// <summary>
        /// 设备id
        /// </summary>
        [NameInMap("deviceId")]
        [Validation(Required=false)]
        public string DeviceId { get; set; }

        /// <summary>
        /// 拓展信息
        /// </summary>
        [NameInMap("ext")]
        [Validation(Required=false)]
        public string Ext { get; set; }

        /// <summary>
        /// isv编号
        /// </summary>
        [NameInMap("isvCode")]
        [Validation(Required=false)]
        public string IsvCode { get; set; }

        /// <summary>
        /// 封面url
        /// </summary>
        [NameInMap("liveCoverImage")]
        [Validation(Required=false)]
        public string LiveCoverImage { get; set; }

        /// <summary>
        /// 课节信息
        /// </summary>
        [NameInMap("sectionIndex")]
        [Validation(Required=false)]
        public List<int?> SectionIndex { get; set; }

        /// <summary>
        /// 操作人
        /// </summary>
        [NameInMap("opUserId")]
        [Validation(Required=false)]
        public string OpUserId { get; set; }

    }

}
