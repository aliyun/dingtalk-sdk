// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkattendance_1_0.Models
{
    public class GroupUpdateRequest : TeaModel {
        /// <summary>
        /// 补卡规则settingId。
        /// </summary>
        [NameInMap("adjustmentSettingId")]
        [Validation(Required=false)]
        public long? AdjustmentSettingId { get; set; }

        /// <summary>
        /// 休息日打卡是否需审批：true：需要false：不需要
        /// </summary>
        [NameInMap("disableCheckWhenRest")]
        [Validation(Required=false)]
        public bool? DisableCheckWhenRest { get; set; }

        /// <summary>
        /// 未排班时是否禁止员工打卡。
        /// </summary>
        [NameInMap("disableCheckWithoutSchedule")]
        [Validation(Required=false)]
        public bool? DisableCheckWithoutSchedule { get; set; }

        /// <summary>
        /// 是否开启拍照打卡。true：开启false：关闭（默认值）
        /// </summary>
        [NameInMap("enableCameraCheck")]
        [Validation(Required=false)]
        public bool? EnableCameraCheck { get; set; }

        /// <summary>
        /// 未排班时是否允许员工选择班次打卡。
        /// </summary>
        [NameInMap("enableEmpSelectClass")]
        [Validation(Required=false)]
        public bool? EnableEmpSelectClass { get; set; }

        /// <summary>
        /// 是否开启人脸检测。true：开启false：关闭（默认值）
        /// </summary>
        [NameInMap("enableFaceCheck")]
        [Validation(Required=false)]
        public bool? EnableFaceCheck { get; set; }

        /// <summary>
        /// 是否开启真人验证。
        /// </summary>
        [NameInMap("enableFaceStrictMode")]
        [Validation(Required=false)]
        public bool? EnableFaceStrictMode { get; set; }

        /// <summary>
        /// 是否允许外勤卡更新内勤卡。
        /// </summary>
        [NameInMap("enableOutSideUpdateNormalCheck")]
        [Validation(Required=false)]
        public bool? EnableOutSideUpdateNormalCheck { get; set; }

        /// <summary>
        /// 外勤打卡是否需要审批。
        /// </summary>
        [NameInMap("enableOutsideApply")]
        [Validation(Required=false)]
        public bool? EnableOutsideApply { get; set; }

        /// <summary>
        /// 是否可以外勤打卡。true：允许（默认值）false：不允许
        /// </summary>
        [NameInMap("enableOutsideCheck")]
        [Validation(Required=false)]
        public bool? EnableOutsideCheck { get; set; }

        /// <summary>
        /// 外勤打卡是否需要拍照备注。
        /// </summary>
        [NameInMap("enableOutsideRemark")]
        [Validation(Required=false)]
        public bool? EnableOutsideRemark { get; set; }

        /// <summary>
        /// 是否允许地点微调距离。
        /// </summary>
        [NameInMap("enableTrimDistance")]
        [Validation(Required=false)]
        public bool? EnableTrimDistance { get; set; }

        /// <summary>
        /// 是否禁止员工隐藏详细地址。
        /// </summary>
        [NameInMap("forbidHideOutSideAddress")]
        [Validation(Required=false)]
        public bool? ForbidHideOutSideAddress { get; set; }

        /// <summary>
        /// 休息日打卡规则。
        /// </summary>
        [NameInMap("freeCheckSetting")]
        [Validation(Required=false)]
        public GroupUpdateRequestFreeCheckSetting FreeCheckSetting { get; set; }
        public class GroupUpdateRequestFreeCheckSetting : TeaModel {
            [NameInMap("freeCheckGap")]
            [Validation(Required=false)]
            public GroupUpdateRequestFreeCheckSettingFreeCheckGap FreeCheckGap { get; set; }
            public class GroupUpdateRequestFreeCheckSettingFreeCheckGap : TeaModel {
                /// <summary>
                /// 下班打卡最小打卡间隔（单位分钟）。
                /// </summary>
                [NameInMap("offOnCheckGapMinutes")]
                [Validation(Required=false)]
                public int? OffOnCheckGapMinutes { get; set; }

                /// <summary>
                /// 上班打卡最小打卡间隔（单位分钟）。
                /// </summary>
                [NameInMap("onOffCheckGapMinutes")]
                [Validation(Required=false)]
                public int? OnOffCheckGapMinutes { get; set; }

            }
        };

        /// <summary>
        /// 休息日打卡方式。0严格打卡模式 1标准打卡模式
        /// </summary>
        [NameInMap("freeCheckTypeId")]
        [Validation(Required=false)]
        public int? FreeCheckTypeId { get; set; }

        /// <summary>
        /// 考勤组ID。
        /// </summary>
        [NameInMap("groupId")]
        [Validation(Required=false)]
        public long? GroupId { get; set; }

        /// <summary>
        /// 考勤组名。
        /// </summary>
        [NameInMap("groupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

        /// <summary>
        /// 考勤组子管理员userid列表。
        /// </summary>
        [NameInMap("managerList")]
        [Validation(Required=false)]
        public List<string> ManagerList { get; set; }

        /// <summary>
        /// 考勤范围。
        /// </summary>
        [NameInMap("offset")]
        [Validation(Required=false)]
        public int? Offset { get; set; }

        /// <summary>
        /// 是否开启人脸打卡。
        /// </summary>
        [NameInMap("openFaceCheck")]
        [Validation(Required=false)]
        public bool? OpenFaceCheck { get; set; }

        /// <summary>
        /// 外勤打卡审批模式-1无需审批，0先审批后打卡是1先打卡后审批
        /// </summary>
        [NameInMap("outsideCheckApproveModeId")]
        [Validation(Required=false)]
        public int? OutsideCheckApproveModeId { get; set; }

        /// <summary>
        /// 加班规则settingId。
        /// </summary>
        [NameInMap("overtimeSettingId")]
        [Validation(Required=false)]
        public long? OvertimeSettingId { get; set; }

        /// <summary>
        /// 考勤组负责人。
        /// </summary>
        [NameInMap("owner")]
        [Validation(Required=false)]
        public string Owner { get; set; }

        /// <summary>
        /// 考勤地点相关设置信息。
        /// </summary>
        [NameInMap("positions")]
        [Validation(Required=false)]
        public List<GroupUpdateRequestPositions> Positions { get; set; }
        public class GroupUpdateRequestPositions : TeaModel {
            /// <summary>
            /// 考勤地址。
            /// </summary>
            [NameInMap("address")]
            [Validation(Required=false)]
            public string Address { get; set; }

            /// <summary>
            /// 纬度。
            /// </summary>
            [NameInMap("latitude")]
            [Validation(Required=false)]
            public string Latitude { get; set; }

            /// <summary>
            /// 经度。
            /// </summary>
            [NameInMap("longitude")]
            [Validation(Required=false)]
            public string Longitude { get; set; }

            /// <summary>
            /// 考勤范围。
            /// </summary>
            [NameInMap("offset")]
            [Validation(Required=false)]
            public int? Offset { get; set; }

            /// <summary>
            /// 考勤标题。
            /// </summary>
            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

        /// <summary>
        /// 子管理员权限范围。w：可管理r：可读
        /// </summary>
        [NameInMap("resourcePermissionMap")]
        [Validation(Required=false)]
        public List<GroupUpdateRequestResourcePermissionMap> ResourcePermissionMap { get; set; }
        public class GroupUpdateRequestResourcePermissionMap : TeaModel {
            /// <summary>
            /// 设置拍照打卡规则。
            /// </summary>
            [NameInMap("cameraCheck")]
            [Validation(Required=false)]
            public string CameraCheck { get; set; }

            /// <summary>
            /// 设置打卡方式。
            /// </summary>
            [NameInMap("checkPositionType")]
            [Validation(Required=false)]
            public string CheckPositionType { get; set; }

            /// <summary>
            /// 设置考勤时间。
            /// </summary>
            [NameInMap("checkTime")]
            [Validation(Required=false)]
            public string CheckTime { get; set; }

            /// <summary>
            /// 设置参与考勤人员。
            /// </summary>
            [NameInMap("groupMember")]
            [Validation(Required=false)]
            public string GroupMember { get; set; }

            /// <summary>
            /// 设置考勤类型。
            /// </summary>
            [NameInMap("groupType")]
            [Validation(Required=false)]
            public string GroupType { get; set; }

            /// <summary>
            /// 设置外勤打卡。
            /// </summary>
            [NameInMap("outSideCheck")]
            [Validation(Required=false)]
            public string OutSideCheck { get; set; }

            /// <summary>
            /// 设置加班规则。
            /// </summary>
            [NameInMap("overTimeRule")]
            [Validation(Required=false)]
            public string OverTimeRule { get; set; }

            /// <summary>
            /// 员工排班。
            /// </summary>
            [NameInMap("schedule")]
            [Validation(Required=false)]
            public string Schedule { get; set; }

        }

        /// <summary>
        /// 班次相关配置信息。
        /// </summary>
        [NameInMap("shiftVOList")]
        [Validation(Required=false)]
        public List<GroupUpdateRequestShiftVOList> ShiftVOList { get; set; }
        public class GroupUpdateRequestShiftVOList : TeaModel {
            /// <summary>
            /// 班次ID，可通过获取班次摘要信息接口获取。
            /// </summary>
            [NameInMap("shiftId")]
            [Validation(Required=false)]
            public long? ShiftId { get; set; }

        }

        /// <summary>
        /// 是否跳过节假日。true：跳过（默认值）false：不跳过
        /// </summary>
        [NameInMap("skipHolidays")]
        [Validation(Required=false)]
        public bool? SkipHolidays { get; set; }

        /// <summary>
        /// 地点微调范围（单位米）。
        /// </summary>
        [NameInMap("trimDistance")]
        [Validation(Required=false)]
        public int? TrimDistance { get; set; }

        /// <summary>
        /// 周班次列表。说明固定班制必填，0表示休息。数组内的值，从左到右依次代表周日到周六，每日的排班情况。
        /// </summary>
        [NameInMap("workdayClassList")]
        [Validation(Required=false)]
        public List<long?> WorkdayClassList { get; set; }

        /// <summary>
        /// 操作人的userid。
        /// </summary>
        [NameInMap("opUserId")]
        [Validation(Required=false)]
        public string OpUserId { get; set; }

    }

}
