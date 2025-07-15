// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkattendance_1_0.Models
{
    public class GroupAddRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>123L</para>
        /// </summary>
        [NameInMap("adjustmentSettingId")]
        [Validation(Required=false)]
        public long? AdjustmentSettingId { get; set; }

        [NameInMap("bleDeviceList")]
        [Validation(Required=false)]
        public List<GroupAddRequestBleDeviceList> BleDeviceList { get; set; }
        public class GroupAddRequestBleDeviceList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1311089987</para>
            /// </summary>
            [NameInMap("deviceId")]
            [Validation(Required=false)]
            public long? DeviceId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("checkNeedHealthyCode")]
        [Validation(Required=false)]
        public bool? CheckNeedHealthyCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1234</para>
        /// </summary>
        [NameInMap("defaultClassId")]
        [Validation(Required=false)]
        public long? DefaultClassId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("disableCheckWhenRest")]
        [Validation(Required=false)]
        public bool? DisableCheckWhenRest { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("disableCheckWithoutSchedule")]
        [Validation(Required=false)]
        public bool? DisableCheckWithoutSchedule { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("enableCameraCheck")]
        [Validation(Required=false)]
        public bool? EnableCameraCheck { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("enableEmpSelectClass")]
        [Validation(Required=false)]
        public bool? EnableEmpSelectClass { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("enableFaceCheck")]
        [Validation(Required=false)]
        public bool? EnableFaceCheck { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("enableFaceStrictMode")]
        [Validation(Required=false)]
        public bool? EnableFaceStrictMode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("enableNextDay")]
        [Validation(Required=false)]
        public bool? EnableNextDay { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("enableOutSideUpdateNormalCheck")]
        [Validation(Required=false)]
        public bool? EnableOutSideUpdateNormalCheck { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("enableOutsideApply")]
        [Validation(Required=false)]
        public bool? EnableOutsideApply { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("enableOutsideCameraCheck")]
        [Validation(Required=false)]
        public bool? EnableOutsideCameraCheck { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("enableOutsideCheck")]
        [Validation(Required=false)]
        public bool? EnableOutsideCheck { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("enableOutsideRemark")]
        [Validation(Required=false)]
        public bool? EnableOutsideRemark { get; set; }

        [NameInMap("enablePositionBle")]
        [Validation(Required=false)]
        public bool? EnablePositionBle { get; set; }

        [NameInMap("enableTrimDistance")]
        [Validation(Required=false)]
        public bool? EnableTrimDistance { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("forbidHideOutSideAddress")]
        [Validation(Required=false)]
        public bool? ForbidHideOutSideAddress { get; set; }

        [NameInMap("freeCheckDemandWorkMinutes")]
        [Validation(Required=false)]
        public int? FreeCheckDemandWorkMinutes { get; set; }

        [NameInMap("freeCheckSetting")]
        [Validation(Required=false)]
        public GroupAddRequestFreeCheckSetting FreeCheckSetting { get; set; }
        public class GroupAddRequestFreeCheckSetting : TeaModel {
            [NameInMap("delimitOffsetMinutesBetweenDays")]
            [Validation(Required=false)]
            public int? DelimitOffsetMinutesBetweenDays { get; set; }

            [NameInMap("freeCheckGap")]
            [Validation(Required=false)]
            public GroupAddRequestFreeCheckSettingFreeCheckGap FreeCheckGap { get; set; }
            public class GroupAddRequestFreeCheckSettingFreeCheckGap : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("offOnCheckGapMinutes")]
                [Validation(Required=false)]
                public int? OffOnCheckGapMinutes { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("onOffCheckGapMinutes")]
                [Validation(Required=false)]
                public int? OnOffCheckGapMinutes { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("freeCheckTypeId")]
        [Validation(Required=false)]
        public int? FreeCheckTypeId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>240</para>
        /// </summary>
        [NameInMap("freecheckDayStartMinOffset")]
        [Validation(Required=false)]
        public int? FreecheckDayStartMinOffset { get; set; }

        [NameInMap("freecheckWorkDays")]
        [Validation(Required=false)]
        public List<int?> FreecheckWorkDays { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("groupId")]
        [Validation(Required=false)]
        public long? GroupId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>白班考勤</para>
        /// </summary>
        [NameInMap("groupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

        [NameInMap("managerList")]
        [Validation(Required=false)]
        public List<string> ManagerList { get; set; }

        [NameInMap("members")]
        [Validation(Required=false)]
        public List<GroupAddRequestMembers> Members { get; set; }
        public class GroupAddRequestMembers : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>Attendance</para>
            /// </summary>
            [NameInMap("role")]
            [Validation(Required=false)]
            public string Role { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>StaffMember</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1212jfkd</para>
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("modifyMember")]
        [Validation(Required=false)]
        public bool? ModifyMember { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>500</para>
        /// </summary>
        [NameInMap("offset")]
        [Validation(Required=false)]
        public int? Offset { get; set; }

        [NameInMap("onlyMachineCheck")]
        [Validation(Required=false)]
        public bool? OnlyMachineCheck { get; set; }

        [NameInMap("openCameraCheck")]
        [Validation(Required=false)]
        public bool? OpenCameraCheck { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("openFaceCheck")]
        [Validation(Required=false)]
        public bool? OpenFaceCheck { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>-1</para>
        /// </summary>
        [NameInMap("outsideCheckApproveModeId")]
        [Validation(Required=false)]
        public int? OutsideCheckApproveModeId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>123L</para>
        /// </summary>
        [NameInMap("overtimeSettingId")]
        [Validation(Required=false)]
        public long? OvertimeSettingId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>123dfdf</para>
        /// </summary>
        [NameInMap("owner")]
        [Validation(Required=false)]
        public string Owner { get; set; }

        [NameInMap("positions")]
        [Validation(Required=false)]
        public List<GroupAddRequestPositions> Positions { get; set; }
        public class GroupAddRequestPositions : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>生物科技产业园区经二路21号</para>
            /// </summary>
            [NameInMap("address")]
            [Validation(Required=false)]
            public string Address { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>36.687495</para>
            /// </summary>
            [NameInMap("latitude")]
            [Validation(Required=false)]
            public string Latitude { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>101.750329</para>
            /// </summary>
            [NameInMap("longitude")]
            [Validation(Required=false)]
            public string Longitude { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>500</para>
            /// </summary>
            [NameInMap("offset")]
            [Validation(Required=false)]
            public int? Offset { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>青藏高原自然博物馆</para>
            /// </summary>
            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

        [NameInMap("resourcePermissionMap")]
        [Validation(Required=false)]
        public Dictionary<string, object> ResourcePermissionMap { get; set; }

        [NameInMap("shiftVOList")]
        [Validation(Required=false)]
        public List<GroupAddRequestShiftVOList> ShiftVOList { get; set; }
        public class GroupAddRequestShiftVOList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("shiftId")]
            [Validation(Required=false)]
            public long? ShiftId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("skipHolidays")]
        [Validation(Required=false)]
        public bool? SkipHolidays { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;onDuty&quot;:{1400000:123,1400001:123},&quot;offDuty&quot;:[1400000,1400001]}</para>
        /// </summary>
        [NameInMap("specialDays")]
        [Validation(Required=false)]
        public string SpecialDays { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("trimDistance")]
        [Validation(Required=false)]
        public int? TrimDistance { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TURN</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        [NameInMap("wifis")]
        [Validation(Required=false)]
        public List<GroupAddRequestWifis> Wifis { get; set; }
        public class GroupAddRequestWifis : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>C0:E0:D0:E0:C0:0F</para>
            /// </summary>
            [NameInMap("macAddr")]
            [Validation(Required=false)]
            public string MacAddr { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>OFFICE-WiFi</para>
            /// </summary>
            [NameInMap("ssid")]
            [Validation(Required=false)]
            public string Ssid { get; set; }

        }

        [NameInMap("workdayClassList")]
        [Validation(Required=false)]
        public List<long?> WorkdayClassList { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123dfd</para>
        /// </summary>
        [NameInMap("opUserId")]
        [Validation(Required=false)]
        public string OpUserId { get; set; }

    }

}
