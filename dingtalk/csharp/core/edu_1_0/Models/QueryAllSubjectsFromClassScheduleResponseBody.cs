// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class QueryAllSubjectsFromClassScheduleResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<QueryAllSubjectsFromClassScheduleResponseBodyResult> Result { get; set; }
        public class QueryAllSubjectsFromClassScheduleResponseBodyResult : TeaModel {
            /// <summary>
            /// subjectName
            /// </summary>
            [NameInMap("subjectName")]
            [Validation(Required=false)]
            public string SubjectName { get; set; }

            /// <summary>
            /// subjectCode
            /// </summary>
            [NameInMap("subjectCode")]
            [Validation(Required=false)]
            public string SubjectCode { get; set; }

            /// <summary>
            /// periodCode
            /// </summary>
            [NameInMap("periodCode")]
            [Validation(Required=false)]
            public string PeriodCode { get; set; }

            /// <summary>
            /// creatorOrgId
            /// </summary>
            [NameInMap("creatorOrgId")]
            [Validation(Required=false)]
            public long? CreatorOrgId { get; set; }

            [NameInMap("ext")]
            [Validation(Required=false)]
            public QueryAllSubjectsFromClassScheduleResponseBodyResultExt Ext { get; set; }
            public class QueryAllSubjectsFromClassScheduleResponseBodyResultExt : TeaModel {
                [NameInMap("fontColor")]
                [Validation(Required=false)]
                public string FontColor { get; set; }
                [NameInMap("backgroundColor")]
                [Validation(Required=false)]
                public string BackgroundColor { get; set; }
                [NameInMap("classId")]
                [Validation(Required=false)]
                public long? ClassId { get; set; }
                [NameInMap("teacherList")]
                [Validation(Required=false)]
                public List<QueryAllSubjectsFromClassScheduleResponseBodyResultExtTeacherList> TeacherList { get; set; }
                public class QueryAllSubjectsFromClassScheduleResponseBodyResultExtTeacherList : TeaModel {
                    public string UserId { get; set; }
                    public string Name { get; set; }
                    public string Avator { get; set; }
                    public long? Uid { get; set; }
                }
            };

        }

    }

}
