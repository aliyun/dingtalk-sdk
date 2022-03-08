// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class QueryAllSubjectsFromClassScheduleResponseBody : TeaModel {
        /// <summary>
        /// 查询结果。
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<QueryAllSubjectsFromClassScheduleResponseBodyResult> Result { get; set; }
        public class QueryAllSubjectsFromClassScheduleResponseBodyResult : TeaModel {
            /// <summary>
            /// creatorOrgId
            /// </summary>
            [NameInMap("creatorOrgId")]
            [Validation(Required=false)]
            public long? CreatorOrgId { get; set; }

            /// <summary>
            /// 拓展信息
            /// </summary>
            [NameInMap("ext")]
            [Validation(Required=false)]
            public QueryAllSubjectsFromClassScheduleResponseBodyResultExt Ext { get; set; }
            public class QueryAllSubjectsFromClassScheduleResponseBodyResultExt : TeaModel {
                [NameInMap("backgroundColor")]
                [Validation(Required=false)]
                public string BackgroundColor { get; set; }
                [NameInMap("classId")]
                [Validation(Required=false)]
                public long? ClassId { get; set; }
                [NameInMap("fontColor")]
                [Validation(Required=false)]
                public string FontColor { get; set; }
                [NameInMap("teacherList")]
                [Validation(Required=false)]
                public List<QueryAllSubjectsFromClassScheduleResponseBodyResultExtTeacherList> TeacherList { get; set; }
                public class QueryAllSubjectsFromClassScheduleResponseBodyResultExtTeacherList : TeaModel {
                    public string Avator { get; set; }
                    public string Name { get; set; }
                    public long? Uid { get; set; }
                    public string UserId { get; set; }
                }
            };

            /// <summary>
            /// 学段编码：  KINDERGARTEN：小学 PRIMARY_SCHOOL：小学 MODDLE_SCHOOL： 初中 HIGH_SCHOOL： 高中 UNIVERSITY：大学 NOT_SCHOOL：无学段
            /// </summary>
            [NameInMap("periodCode")]
            [Validation(Required=false)]
            public string PeriodCode { get; set; }

            /// <summary>
            /// 学科code。
            /// </summary>
            [NameInMap("subjectCode")]
            [Validation(Required=false)]
            public string SubjectCode { get; set; }

            /// <summary>
            /// 学科名称。
            /// </summary>
            [NameInMap("subjectName")]
            [Validation(Required=false)]
            public string SubjectName { get; set; }

        }

    }

}
