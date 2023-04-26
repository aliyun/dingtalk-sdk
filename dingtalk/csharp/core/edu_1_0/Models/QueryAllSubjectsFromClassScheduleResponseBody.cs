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
            [NameInMap("creatorOrgId")]
            [Validation(Required=false)]
            public long? CreatorOrgId { get; set; }

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
                    [NameInMap("avator")]
                    [Validation(Required=false)]
                    public string Avator { get; set; }

                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("uid")]
                    [Validation(Required=false)]
                    public long? Uid { get; set; }

                    [NameInMap("userId")]
                    [Validation(Required=false)]
                    public string UserId { get; set; }

                }

            }

            [NameInMap("periodCode")]
            [Validation(Required=false)]
            public string PeriodCode { get; set; }

            [NameInMap("subjectCode")]
            [Validation(Required=false)]
            public string SubjectCode { get; set; }

            [NameInMap("subjectName")]
            [Validation(Required=false)]
            public string SubjectName { get; set; }

        }

    }

}
