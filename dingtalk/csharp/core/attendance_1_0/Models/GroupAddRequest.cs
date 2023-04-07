// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkattendance_1_0.Models
{
    public class GroupAddRequest : TeaModel {
        /// <summary>
        /// 补卡规则settingId。
        /// </summary>
        [NameInMap("adjustmentSettingId")]
        [Validation(Required=false)]
        public long? AdjustmentSettingId { get; set; }

        /// <summary>
        /// 蓝牙打卡相关配置信息。
        /// </summary>
        [NameInMap("bleDeviceList")]
        [Validation(Required=false)]
        public List<GroupAddRequestBleDeviceList> BleDeviceList { get; set; }
        public class GroupAddRequestBleDeviceList : TeaModel {
            /// <summary>
            /// 设备ID，调用查询员工智能考勤机列表获取。
            /// </summary>
            [NameInMap("deviceId")]
            [Validation(Required=false)]
            public long? DeviceId { get; set; }

        }

        /// <summary>
        /// 打卡是否需要健康码：
        /// 
        /// true：开启
        /// 
        /// false：关闭（默认值）
        /// </summary>
        [NameInMap("checkNeedHealthyCode")]
        [Validation(Required=false)]
        public bool? CheckNeedHealthyCode { get; set; }

        /// <summary>
        /// 默认班次ID。
        /// 
        /// 说明 固定班制必填，可通过获取班次摘要信息接口获取
        /// </summary>
        [NameInMap("defaultClassId")]
        [Validation(Required=false)]
        public long? DefaultClassId { get; set; }

        /// <summary>
        /// 休息日打卡是否需审批：
        /// 
        /// true：需要
        /// 
        /// false：不需要
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
        /// 是否开启拍照打卡。
        /// 
        /// true：开启
        /// 
        /// false：关闭（默认值）
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
        /// 是否开启人脸检测。
        /// 
        /// true：开启
        /// 
        /// false：关闭（默认值）
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
        /// 是否第二天生效。
        /// true：是
        /// false：否
        /// </summary>
        [NameInMap("enableNextDay")]
        [Validation(Required=false)]
        public bool? EnableNextDay { get; set; }

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
        /// 是否开启外勤打卡必须拍照。
        /// 
        /// true：开启
        /// 
        /// false：关闭（默认值）
        /// </summary>
        [NameInMap("enableOutsideCameraCheck")]
        [Validation(Required=false)]
        public bool? EnableOutsideCameraCheck { get; set; }

        /// <summary>
        /// 是否可以外勤打卡。
        /// 
        /// true：允许（默认值）
        /// 
        /// false：不允许
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
        /// 是否启用蓝牙定位。
        /// </summary>
        [NameInMap("enablePositionBle")]
        [Validation(Required=false)]
        public bool? EnablePositionBle { get; set; }

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
        public GroupAddRequestFreeCheckSetting FreeCheckSetting { get; set; }
        public class GroupAddRequestFreeCheckSetting : TeaModel {
            /// <summary>
            /// 自由工时考勤组考勤开始时间与当天0点偏移分钟数。
            /// 
            /// 例如：540表示9:00
            /// </summary>
            [NameInMap("delimitOffsetMinutesBetweenDays")]
            [Validation(Required=false)]
            public int? DelimitOffsetMinutesBetweenDays { get; set; }

            /// <summary>
            /// 休息日打卡间隔设置。
            /// </summary>
            [NameInMap("freeCheckGap")]
            [Validation(Required=false)]
            public GroupAddRequestFreeCheckSettingFreeCheckGap FreeCheckGap { get; set; }
            public class GroupAddRequestFreeCheckSettingFreeCheckGap : TeaModel {
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

        }

        /// <summary>
        /// 休息日打卡方式。
        /// 0严格打卡模式 
        /// 1标准打卡模式
        /// </summary>
        [NameInMap("freeCheckTypeId")]
        [Validation(Required=false)]
        public int? FreeCheckTypeId { get; set; }

        /// <summary>
        /// 自由工时考勤组考勤开始时间与当天0点偏移分钟数。
        /// 
        /// 例如：540表示9:00
        /// </summary>
        [NameInMap("freecheckDayStartMinOffset")]
        [Validation(Required=false)]
        public int? FreecheckDayStartMinOffset { get; set; }

        /// <summary>
        /// 自由工时考勤组工作日。
        /// 说明
        /// 0表示休息。
        /// 数组内的值，从左到右依次代表周日到周六，每日的排班情况。
        /// </summary>
        [NameInMap("freecheckWorkDays")]
        [Validation(Required=false)]
        public List<long?> FreecheckWorkDays { get; set; }

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
        /// 考勤组成员相关设置信息。
        /// </summary>
        [NameInMap("members")]
        [Validation(Required=false)]
        public List<GroupAddRequestMembers> Members { get; set; }
        public class GroupAddRequestMembers : TeaModel {
            /// <summary>
            /// 角色，固定值Attendance。
            /// </summary>
            [NameInMap("role")]
            [Validation(Required=false)]
            public string Role { get; set; }

            /// <summary>
            /// 类型，固定值StaffMember。
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// 用户userid。
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        /// <summary>
        /// 是否有修改考勤组成员相关信息。
        /// </summary>
        [NameInMap("modifyMember")]
        [Validation(Required=false)]
        public bool? ModifyMember { get; set; }

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
        public List<GroupAddRequestPositions> Positions { get; set; }
        public class GroupAddRequestPositions : TeaModel {
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
        /// 子管理员权限范围。
        /// 
        /// w：可管理
        /// 
        /// r：可读
        /// </summary>
        [NameInMap("resourcePermissionMap")]
        [Validation(Required=false)]
        public List<GroupAddRequestResourcePermissionMap> ResourcePermissionMap { get; set; }
        public class GroupAddRequestResourcePermissionMap : TeaModel {
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
        public List<GroupAddRequestShiftVOList> ShiftVOList { get; set; }
        public class GroupAddRequestShiftVOList : TeaModel {
            /// <summary>
            /// 班次ID，可通过获取班次摘要信息接口获取。
            /// </summary>
            [NameInMap("shiftId")]
            [Validation(Required=false)]
            public long? ShiftId { get; set; }

        }

        /// <summary>
        /// 是否跳过节假日。
        /// 
        /// true：跳过（默认值）
        /// 
        /// false：不跳过
        /// </summary>
        [NameInMap("skipHolidays")]
        [Validation(Required=false)]
        public bool? SkipHolidays { get; set; }

        /// <summary>
        /// 特殊日期配置。
        /// </summary>
        [NameInMap("specialDays")]
        [Validation(Required=false)]
        public string SpecialDays { get; set; }

        /// <summary>
        /// 地点微调范围（单位米）。
        /// </summary>
        [NameInMap("trimDistance")]
        [Validation(Required=false)]
        public int? TrimDistance { get; set; }

        /// <summary>
        /// 考勤组类型：
        /// 
        /// FIXED：固定班制考勤组
        /// 
        /// TURN：排班制考勤组
        /// 
        /// NONE：自由工时考勤组
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// 考勤wifi打卡相关配置信息。
        /// </summary>
        [NameInMap("wifis")]
        [Validation(Required=false)]
        public List<GroupAddRequestWifis> Wifis { get; set; }
        public class GroupAddRequestWifis : TeaModel {
            /// <summary>
            /// mac地址。
            /// </summary>
            [NameInMap("macAddr")]
            [Validation(Required=false)]
            public string MacAddr { get; set; }

            /// <summary>
            /// wifi的ssid。
            /// </summary>
            [NameInMap("ssid")]
            [Validation(Required=false)]
            public string Ssid { get; set; }

        }

        /// <summary>
        /// 周班次列表。
        /// 说明
        /// 固定班制必填，0表示休息。
        /// 数组内的值，从左到右依次代表周日到周六，每日的排班情况。
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
