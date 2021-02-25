// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class BatchOrgCreateHWRequest : TeaModel {
        /// <summary>
        /// 作业视频
        /// </summary>
        [NameInMap("hwMedia")]
        [Validation(Required=false)]
        public string HwMedia { get; set; }

        /// <summary>
        /// 作业内容
        /// </summary>
        [NameInMap("hwContent")]
        [Validation(Required=false)]
        public string HwContent { get; set; }

        /// <summary>
        /// 作业标题
        /// </summary>
        [NameInMap("hwTitle")]
        [Validation(Required=false)]
        public string HwTitle { get; set; }

        /// <summary>
        /// 作业课程名称
        /// </summary>
        [NameInMap("courseName")]
        [Validation(Required=false)]
        public string CourseName { get; set; }

        /// <summary>
        /// 作业图片
        /// </summary>
        [NameInMap("hwPhoto")]
        [Validation(Required=false)]
        public string HwPhoto { get; set; }

        /// <summary>
        /// 作业音视频
        /// </summary>
        [NameInMap("hwVideo")]
        [Validation(Required=false)]
        public string HwVideo { get; set; }

        /// <summary>
        /// 老师名称
        /// </summary>
        [NameInMap("teacherName")]
        [Validation(Required=false)]
        public string TeacherName { get; set; }

        /// <summary>
        /// 老师userid
        /// </summary>
        [NameInMap("teacherUserId")]
        [Validation(Required=false)]
        public string TeacherUserId { get; set; }

        /// <summary>
        /// 幂等ID字段
        /// </summary>
        [NameInMap("identifier")]
        [Validation(Required=false)]
        public string Identifier { get; set; }

        /// <summary>
        /// 扩展属性
        /// </summary>
        [NameInMap("attributes")]
        [Validation(Required=false)]
        public string Attributes { get; set; }

        /// <summary>
        /// 发送对象
        /// </summary>
        [NameInMap("targetRole")]
        [Validation(Required=false)]
        public string TargetRole { get; set; }

        /// <summary>
        /// 业务编码
        /// </summary>
        [NameInMap("bizCode")]
        [Validation(Required=false)]
        public string BizCode { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// 定时调度
        /// </summary>
        [NameInMap("scheduledRelease")]
        [Validation(Required=false)]
        public string ScheduledRelease { get; set; }

        /// <summary>
        /// 定时调度时间
        /// </summary>
        [NameInMap("scheduledTime")]
        [Validation(Required=false)]
        public string ScheduledTime { get; set; }

        /// <summary>
        /// 截止时间开启
        /// </summary>
        [NameInMap("hwDeadlineOpen")]
        [Validation(Required=false)]
        public string HwDeadlineOpen { get; set; }

        /// <summary>
        /// 截止时间
        /// </summary>
        [NameInMap("hwDeadline")]
        [Validation(Required=false)]
        public long? HwDeadline { get; set; }

        /// <summary>
        /// 作业类型
        /// </summary>
        [NameInMap("hwType")]
        [Validation(Required=false)]
        public string HwType { get; set; }

        /// <summary>
        /// 选择跨组织班级
        /// </summary>
        [NameInMap("openSelectItemList")]
        [Validation(Required=false)]
        public List<BatchOrgCreateHWRequestOpenSelectItemList> OpenSelectItemList { get; set; }
        public class BatchOrgCreateHWRequestOpenSelectItemList : TeaModel {
            /// <summary>
            /// 组织corpId
            /// </summary>
            [NameInMap("corpId")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            /// <summary>
            /// 选择内容
            /// </summary>
            [NameInMap("selectedClassesDesc")]
            [Validation(Required=false)]
            public string SelectedClassesDesc { get; set; }

            /// <summary>
            /// 班级列表
            /// </summary>
            [NameInMap("classList")]
            [Validation(Required=false)]
            public List<BatchOrgCreateHWRequestOpenSelectItemListClassList> ClassList { get; set; }
            public class BatchOrgCreateHWRequestOpenSelectItemListClassList : TeaModel {
                /// <summary>
                /// 班级id
                /// </summary>
                [NameInMap("classId")]
                [Validation(Required=false)]
                public string ClassId { get; set; }

                /// <summary>
                /// 班级名称
                /// </summary>
                [NameInMap("className")]
                [Validation(Required=false)]
                public string ClassName { get; set; }

                /// <summary>
                /// 是否全选
                /// </summary>
                [NameInMap("all")]
                [Validation(Required=false)]
                public bool? All { get; set; }

                /// <summary>
                /// 学生列表
                /// </summary>
                [NameInMap("students")]
                [Validation(Required=false)]
                public List<BatchOrgCreateHWRequestOpenSelectItemListClassListStudents> Students { get; set; }
                public class BatchOrgCreateHWRequestOpenSelectItemListClassListStudents : TeaModel {
                    /// <summary>
                    /// 学生姓名
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// 学生userid
                    /// </summary>
                    [NameInMap("staffId")]
                    [Validation(Required=false)]
                    public string StaffId { get; set; }

                    /// <summary>
                    /// 学生头像
                    /// </summary>
                    [NameInMap("avatar")]
                    [Validation(Required=false)]
                    public string Avatar { get; set; }

                }

            }

        }

        /// <summary>
        /// 组织ID
        /// </summary>
        [NameInMap("dingOrgId")]
        [Validation(Required=false)]
        public long? DingOrgId { get; set; }

    }

}
