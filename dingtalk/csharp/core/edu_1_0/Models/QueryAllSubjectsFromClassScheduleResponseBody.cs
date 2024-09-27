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
            /// <b>Example:</b>
            /// <para>创建者orgId</para>
            /// </summary>
            [NameInMap("creatorOrgId")]
            [Validation(Required=false)]
            public long? CreatorOrgId { get; set; }

            [NameInMap("ext")]
            [Validation(Required=false)]
            public QueryAllSubjectsFromClassScheduleResponseBodyResultExt Ext { get; set; }
            public class QueryAllSubjectsFromClassScheduleResponseBodyResultExt : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>#000000</para>
                /// </summary>
                [NameInMap("backgroundColor")]
                [Validation(Required=false)]
                public string BackgroundColor { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2345</para>
                /// </summary>
                [NameInMap("classId")]
                [Validation(Required=false)]
                public long? ClassId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>#000000</para>
                /// </summary>
                [NameInMap("fontColor")]
                [Validation(Required=false)]
                public string FontColor { get; set; }

                [NameInMap("teacherList")]
                [Validation(Required=false)]
                public List<QueryAllSubjectsFromClassScheduleResponseBodyResultExtTeacherList> TeacherList { get; set; }
                public class QueryAllSubjectsFromClassScheduleResponseBodyResultExtTeacherList : TeaModel {
                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>url</para>
                    /// </summary>
                    [NameInMap("avator")]
                    [Validation(Required=false)]
                    public string Avator { get; set; }

                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>李老师</para>
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>5824343</para>
                    /// </summary>
                    [NameInMap("uid")]
                    [Validation(Required=false)]
                    public long? Uid { get; set; }

                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2534523452</para>
                    /// </summary>
                    [NameInMap("userId")]
                    [Validation(Required=false)]
                    public string UserId { get; set; }

                }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>HIGH_SCHOOL</para>
            /// </summary>
            [NameInMap("periodCode")]
            [Validation(Required=false)]
            public string PeriodCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn_yuwen</para>
            /// </summary>
            [NameInMap("subjectCode")]
            [Validation(Required=false)]
            public string SubjectCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>语文</para>
            /// </summary>
            [NameInMap("subjectName")]
            [Validation(Required=false)]
            public string SubjectName { get; set; }

        }

    }

}
