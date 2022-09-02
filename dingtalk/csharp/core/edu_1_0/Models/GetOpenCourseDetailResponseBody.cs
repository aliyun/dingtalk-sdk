// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class GetOpenCourseDetailResponseBody : TeaModel {
        /// <summary>
        /// 课程id
        /// </summary>
        [NameInMap("courseId")]
        [Validation(Required=false)]
        public string CourseId { get; set; }

        /// <summary>
        /// 课程类型: 0-直播 2-视频内容
        /// </summary>
        [NameInMap("courseType")]
        [Validation(Required=false)]
        public long? CourseType { get; set; }

        /// <summary>
        /// 封面图片地址
        /// </summary>
        [NameInMap("coverUrl")]
        [Validation(Required=false)]
        public string CoverUrl { get; set; }

        /// <summary>
        /// 课程介绍
        /// </summary>
        [NameInMap("introduction")]
        [Validation(Required=false)]
        public string Introduction { get; set; }

        /// <summary>
        /// 发布详情model
        /// </summary>
        [NameInMap("pushModel")]
        [Validation(Required=false)]
        public GetOpenCourseDetailResponseBodyPushModel PushModel { get; set; }
        public class GetOpenCourseDetailResponseBodyPushModel : TeaModel {
            /// <summary>
            /// 参与学校的名称列表
            /// </summary>
            [NameInMap("pushOrgNameList")]
            [Validation(Required=false)]
            public List<string> PushOrgNameList { get; set; }

            /// <summary>
            /// 参与角色的名称列表
            /// </summary>
            [NameInMap("pushRoleNameList")]
            [Validation(Required=false)]
            public List<string> PushRoleNameList { get; set; }

        }

        /// <summary>
        /// 课程开始时间
        /// </summary>
        [NameInMap("startTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        /// <summary>
        /// 老师的userId
        /// </summary>
        [NameInMap("teacherId")]
        [Validation(Required=false)]
        public string TeacherId { get; set; }

        /// <summary>
        /// 老师名称
        /// </summary>
        [NameInMap("teacherName")]
        [Validation(Required=false)]
        public string TeacherName { get; set; }

        /// <summary>
        /// 课程标题
        /// </summary>
        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

    }

}
