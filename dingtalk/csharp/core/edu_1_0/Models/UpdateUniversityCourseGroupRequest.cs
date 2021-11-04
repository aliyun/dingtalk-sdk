// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class UpdateUniversityCourseGroupRequest : TeaModel {
        /// <summary>
        /// 课程组编码
        /// </summary>
        [NameInMap("courseGroupCode")]
        [Validation(Required=false)]
        public string CourseGroupCode { get; set; }

        /// <summary>
        /// 课程组介绍
        /// </summary>
        [NameInMap("courseGroupIntroduce")]
        [Validation(Required=false)]
        public string CourseGroupIntroduce { get; set; }

        /// <summary>
        /// 课程组名称
        /// </summary>
        [NameInMap("courseGroupName")]
        [Validation(Required=false)]
        public string CourseGroupName { get; set; }

        /// <summary>
        /// 课程组详细
        /// </summary>
        [NameInMap("courserGroupItemModels")]
        [Validation(Required=false)]
        public List<UpdateUniversityCourseGroupRequestCourserGroupItemModels> CourserGroupItemModels { get; set; }
        public class UpdateUniversityCourseGroupRequestCourserGroupItemModels : TeaModel {
            /// <summary>
            /// 一周的第几天
            /// </summary>
            [NameInMap("dayOfWeek")]
            [Validation(Required=false)]
            public int? DayOfWeek { get; set; }

            /// <summary>
            /// 上课周期
            /// </summary>
            [NameInMap("classPeriodType")]
            [Validation(Required=false)]
            public int? ClassPeriodType { get; set; }

            /// <summary>
            /// 开始时间
            /// </summary>
            [NameInMap("start")]
            [Validation(Required=false)]
            public UpdateUniversityCourseGroupRequestCourserGroupItemModelsStart Start { get; set; }
            public class UpdateUniversityCourseGroupRequestCourserGroupItemModelsStart : TeaModel {
                [NameInMap("month")]
                [Validation(Required=false)]
                public int? Month { get; set; }
                [NameInMap("year")]
                [Validation(Required=false)]
                public int? Year { get; set; }
                [NameInMap("dayOfMonth")]
                [Validation(Required=false)]
                public int? DayOfMonth { get; set; }
            };

            /// <summary>
            /// 课节
            /// </summary>
            [NameInMap("sectionIndex")]
            [Validation(Required=false)]
            public List<int?> SectionIndex { get; set; }

            /// <summary>
            /// 结束时间
            /// </summary>
            [NameInMap("end")]
            [Validation(Required=false)]
            public UpdateUniversityCourseGroupRequestCourserGroupItemModelsEnd End { get; set; }
            public class UpdateUniversityCourseGroupRequestCourserGroupItemModelsEnd : TeaModel {
                [NameInMap("month")]
                [Validation(Required=false)]
                public int? Month { get; set; }
                [NameInMap("year")]
                [Validation(Required=false)]
                public int? Year { get; set; }
                [NameInMap("dayOfMonth")]
                [Validation(Required=false)]
                public int? DayOfMonth { get; set; }
            };

            /// <summary>
            /// 课程类型
            /// </summary>
            [NameInMap("courseType")]
            [Validation(Required=false)]
            public int? CourseType { get; set; }

            /// <summary>
            /// classroomId
            /// </summary>
            [NameInMap("classroomId")]
            [Validation(Required=false)]
            public long? ClassroomId { get; set; }

        }

        /// <summary>
        /// 扩展信息
        /// </summary>
        [NameInMap("ext")]
        [Validation(Required=false)]
        public string Ext { get; set; }

        /// <summary>
        /// opUserId
        /// </summary>
        [NameInMap("opUserId")]
        [Validation(Required=false)]
        public string OpUserId { get; set; }

    }

}
