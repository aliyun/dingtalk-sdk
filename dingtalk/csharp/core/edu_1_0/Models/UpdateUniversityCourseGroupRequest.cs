// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class UpdateUniversityCourseGroupRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>GS1001</para>
        /// </summary>
        [NameInMap("courseGroupCode")]
        [Validation(Required=false)]
        public string CourseGroupCode { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>高等数学</para>
        /// </summary>
        [NameInMap("courseGroupIntroduce")]
        [Validation(Required=false)]
        public string CourseGroupIntroduce { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>高等数学</para>
        /// </summary>
        [NameInMap("courseGroupName")]
        [Validation(Required=false)]
        public string CourseGroupName { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("courserGroupItemModels")]
        [Validation(Required=false)]
        public List<UpdateUniversityCourseGroupRequestCourserGroupItemModels> CourserGroupItemModels { get; set; }
        public class UpdateUniversityCourseGroupRequestCourserGroupItemModels : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1、单周；2、双周；3、全周</para>
            /// </summary>
            [NameInMap("classPeriodType")]
            [Validation(Required=false)]
            public int? ClassPeriodType { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1:音视频直播\2:线下课程\4:音视频及线下</para>
            /// </summary>
            [NameInMap("classroomId")]
            [Validation(Required=false)]
            public long? ClassroomId { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("courseType")]
            [Validation(Required=false)]
            public int? CourseType { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("courserGroupItemEndDate")]
            [Validation(Required=false)]
            public UpdateUniversityCourseGroupRequestCourserGroupItemModelsCourserGroupItemEndDate CourserGroupItemEndDate { get; set; }
            public class UpdateUniversityCourseGroupRequestCourserGroupItemModelsCourserGroupItemEndDate : TeaModel {
                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>31</para>
                /// </summary>
                [NameInMap("dayOfMonth")]
                [Validation(Required=false)]
                public int? DayOfMonth { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("month")]
                [Validation(Required=false)]
                public int? Month { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021</para>
                /// </summary>
                [NameInMap("year")]
                [Validation(Required=false)]
                public int? Year { get; set; }

            }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("courserGroupItemStartDate")]
            [Validation(Required=false)]
            public UpdateUniversityCourseGroupRequestCourserGroupItemModelsCourserGroupItemStartDate CourserGroupItemStartDate { get; set; }
            public class UpdateUniversityCourseGroupRequestCourserGroupItemModelsCourserGroupItemStartDate : TeaModel {
                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("dayOfMonth")]
                [Validation(Required=false)]
                public int? DayOfMonth { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("month")]
                [Validation(Required=false)]
                public int? Month { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021</para>
                /// </summary>
                [NameInMap("year")]
                [Validation(Required=false)]
                public int? Year { get; set; }

            }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>7</para>
            /// </summary>
            [NameInMap("dayOfWeek")]
            [Validation(Required=false)]
            public int? DayOfWeek { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("sectionIndex")]
            [Validation(Required=false)]
            public List<int?> SectionIndex { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("ext")]
        [Validation(Required=false)]
        public string Ext { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>manger1234</para>
        /// </summary>
        [NameInMap("opUserId")]
        [Validation(Required=false)]
        public string OpUserId { get; set; }

    }

}
