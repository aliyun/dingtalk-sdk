// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class BatchCreateTeacherCourseRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>dingxxx</para>
        /// </summary>
        [NameInMap("corpId")]
        [Validation(Required=false)]
        public string CorpId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ISV_XXX</para>
        /// </summary>
        [NameInMap("isvCode")]
        [Validation(Required=false)]
        public string IsvCode { get; set; }

        [NameInMap("teacherCourseDetailItemList")]
        [Validation(Required=false)]
        public List<BatchCreateTeacherCourseRequestTeacherCourseDetailItemList> TeacherCourseDetailItemList { get; set; }
        public class BatchCreateTeacherCourseRequestTeacherCourseDetailItemList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>{&quot;key&quot;:&quot;value&quot;}</para>
            /// </summary>
            [NameInMap("attributes")]
            [Validation(Required=false)]
            public string Attributes { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>courseIdxxx</para>
            /// </summary>
            [NameInMap("isvCourseId")]
            [Validation(Required=false)]
            public string IsvCourseId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>李老师</para>
        /// </summary>
        [NameInMap("teacherName")]
        [Validation(Required=false)]
        public string TeacherName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>staffxxx</para>
        /// </summary>
        [NameInMap("teacherUserId")]
        [Validation(Required=false)]
        public string TeacherUserId { get; set; }

    }

}
