// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class BatchOrgCreateHWRequest : TeaModel {
        [NameInMap("attributes")]
        [Validation(Required=false)]
        public string Attributes { get; set; }

        [NameInMap("bizCode")]
        [Validation(Required=false)]
        public string BizCode { get; set; }

        [NameInMap("courseName")]
        [Validation(Required=false)]
        public string CourseName { get; set; }

        [NameInMap("hwContent")]
        [Validation(Required=false)]
        public string HwContent { get; set; }

        [NameInMap("hwDeadline")]
        [Validation(Required=false)]
        public long? HwDeadline { get; set; }

        [NameInMap("hwDeadlineOpen")]
        [Validation(Required=false)]
        public string HwDeadlineOpen { get; set; }

        [NameInMap("hwMedia")]
        [Validation(Required=false)]
        public string HwMedia { get; set; }

        [NameInMap("hwPhoto")]
        [Validation(Required=false)]
        public string HwPhoto { get; set; }

        [NameInMap("hwTitle")]
        [Validation(Required=false)]
        public string HwTitle { get; set; }

        [NameInMap("hwType")]
        [Validation(Required=false)]
        public string HwType { get; set; }

        [NameInMap("hwVideo")]
        [Validation(Required=false)]
        public string HwVideo { get; set; }

        [NameInMap("identifier")]
        [Validation(Required=false)]
        public string Identifier { get; set; }

        [NameInMap("openSelectItemList")]
        [Validation(Required=false)]
        public List<BatchOrgCreateHWRequestOpenSelectItemList> OpenSelectItemList { get; set; }
        public class BatchOrgCreateHWRequestOpenSelectItemList : TeaModel {
            [NameInMap("classList")]
            [Validation(Required=false)]
            public List<BatchOrgCreateHWRequestOpenSelectItemListClassList> ClassList { get; set; }
            public class BatchOrgCreateHWRequestOpenSelectItemListClassList : TeaModel {
                [NameInMap("all")]
                [Validation(Required=false)]
                public bool? All { get; set; }

                [NameInMap("classId")]
                [Validation(Required=false)]
                public string ClassId { get; set; }

                [NameInMap("className")]
                [Validation(Required=false)]
                public string ClassName { get; set; }

                [NameInMap("students")]
                [Validation(Required=false)]
                public List<BatchOrgCreateHWRequestOpenSelectItemListClassListStudents> Students { get; set; }
                public class BatchOrgCreateHWRequestOpenSelectItemListClassListStudents : TeaModel {
                    [NameInMap("avatar")]
                    [Validation(Required=false)]
                    public string Avatar { get; set; }

                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("staffId")]
                    [Validation(Required=false)]
                    public string StaffId { get; set; }

                }

            }

            [NameInMap("corpId")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            [NameInMap("selectedClassesDesc")]
            [Validation(Required=false)]
            public string SelectedClassesDesc { get; set; }

        }

        [NameInMap("scheduledRelease")]
        [Validation(Required=false)]
        public string ScheduledRelease { get; set; }

        [NameInMap("scheduledTime")]
        [Validation(Required=false)]
        public string ScheduledTime { get; set; }

        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("targetRole")]
        [Validation(Required=false)]
        public string TargetRole { get; set; }

        [NameInMap("teacherName")]
        [Validation(Required=false)]
        public string TeacherName { get; set; }

        [NameInMap("teacherUserId")]
        [Validation(Required=false)]
        public string TeacherUserId { get; set; }

    }

}
