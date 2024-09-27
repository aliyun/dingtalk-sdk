// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class GetOpenCourseDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>fdjakl-fdaf-ds</para>
        /// </summary>
        [NameInMap("courseId")]
        [Validation(Required=false)]
        public string CourseId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("courseType")]
        [Validation(Required=false)]
        public long? CourseType { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://static.dingtalk.com/media/lALPDgCwRt4FagzMi8yZ_153_139.png">https://static.dingtalk.com/media/lALPDgCwRt4FagzMi8yZ_153_139.png</a></para>
        /// </summary>
        [NameInMap("coverUrl")]
        [Validation(Required=false)]
        public string CoverUrl { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>开学的第一堂课</para>
        /// </summary>
        [NameInMap("introduction")]
        [Validation(Required=false)]
        public string Introduction { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("pushModel")]
        [Validation(Required=false)]
        public GetOpenCourseDetailResponseBodyPushModel PushModel { get; set; }
        public class GetOpenCourseDetailResponseBodyPushModel : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("pushOrgNameList")]
            [Validation(Required=false)]
            public List<string> PushOrgNameList { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("pushRoleNameList")]
            [Validation(Required=false)]
            public List<string> PushRoleNameList { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1618369786000</para>
        /// </summary>
        [NameInMap("startTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123124312314</para>
        /// </summary>
        [NameInMap("teacherId")]
        [Validation(Required=false)]
        public string TeacherId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>张老师</para>
        /// </summary>
        [NameInMap("teacherName")]
        [Validation(Required=false)]
        public string TeacherName { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>开学第一课</para>
        /// </summary>
        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

    }

}
