// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class UpdateUniversityCourseGroupRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("courseGroupCode")]
        [Validation(Required=false)]
        public string CourseGroupCode { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("courseGroupIntroduce")]
        [Validation(Required=false)]
        public string CourseGroupIntroduce { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("courseGroupName")]
        [Validation(Required=false)]
        public string CourseGroupName { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("courserGroupItemModels")]
        [Validation(Required=false)]
        public List<UpdateUniversityCourseGroupRequestCourserGroupItemModels> CourserGroupItemModels { get; set; }
        public class UpdateUniversityCourseGroupRequestCourserGroupItemModels : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("classPeriodType")]
            [Validation(Required=false)]
            public int? ClassPeriodType { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("classroomId")]
            [Validation(Required=false)]
            public long? ClassroomId { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("courseType")]
            [Validation(Required=false)]
            public int? CourseType { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("courserGroupItemEndDate")]
            [Validation(Required=false)]
            public UpdateUniversityCourseGroupRequestCourserGroupItemModelsCourserGroupItemEndDate CourserGroupItemEndDate { get; set; }
            public class UpdateUniversityCourseGroupRequestCourserGroupItemModelsCourserGroupItemEndDate : TeaModel {
                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("dayOfMonth")]
                [Validation(Required=false)]
                public int? DayOfMonth { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("month")]
                [Validation(Required=false)]
                public int? Month { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("year")]
                [Validation(Required=false)]
                public int? Year { get; set; }

            }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("courserGroupItemStartDate")]
            [Validation(Required=false)]
            public UpdateUniversityCourseGroupRequestCourserGroupItemModelsCourserGroupItemStartDate CourserGroupItemStartDate { get; set; }
            public class UpdateUniversityCourseGroupRequestCourserGroupItemModelsCourserGroupItemStartDate : TeaModel {
                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("dayOfMonth")]
                [Validation(Required=false)]
                public int? DayOfMonth { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("month")]
                [Validation(Required=false)]
                public int? Month { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("year")]
                [Validation(Required=false)]
                public int? Year { get; set; }

            }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("dayOfWeek")]
            [Validation(Required=false)]
            public int? DayOfWeek { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("sectionIndex")]
            [Validation(Required=false)]
            public List<int?> SectionIndex { get; set; }

        }

        [NameInMap("ext")]
        [Validation(Required=false)]
        public string Ext { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("opUserId")]
        [Validation(Required=false)]
        public string OpUserId { get; set; }

    }

}
