// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkattendance_1_0.Models
{
    public class GroupUpdateRequest : TeaModel {
        [NameInMap("adjustmentSettingId")]
        [Validation(Required=false)]
        public long? AdjustmentSettingId { get; set; }

        [NameInMap("disableCheckWhenRest")]
        [Validation(Required=false)]
        public bool? DisableCheckWhenRest { get; set; }

        [NameInMap("disableCheckWithoutSchedule")]
        [Validation(Required=false)]
        public bool? DisableCheckWithoutSchedule { get; set; }

        [NameInMap("enableCameraCheck")]
        [Validation(Required=false)]
        public bool? EnableCameraCheck { get; set; }

        [NameInMap("enableEmpSelectClass")]
        [Validation(Required=false)]
        public bool? EnableEmpSelectClass { get; set; }

        [NameInMap("enableFaceCheck")]
        [Validation(Required=false)]
        public bool? EnableFaceCheck { get; set; }

        [NameInMap("enableFaceStrictMode")]
        [Validation(Required=false)]
        public bool? EnableFaceStrictMode { get; set; }

        [NameInMap("enableOutSideUpdateNormalCheck")]
        [Validation(Required=false)]
        public bool? EnableOutSideUpdateNormalCheck { get; set; }

        [NameInMap("enableOutsideApply")]
        [Validation(Required=false)]
        public bool? EnableOutsideApply { get; set; }

        [NameInMap("enableOutsideCheck")]
        [Validation(Required=false)]
        public bool? EnableOutsideCheck { get; set; }

        [NameInMap("enableOutsideRemark")]
        [Validation(Required=false)]
        public bool? EnableOutsideRemark { get; set; }

        [NameInMap("enableTrimDistance")]
        [Validation(Required=false)]
        public bool? EnableTrimDistance { get; set; }

        [NameInMap("forbidHideOutSideAddress")]
        [Validation(Required=false)]
        public bool? ForbidHideOutSideAddress { get; set; }

        [NameInMap("freeCheckSetting")]
        [Validation(Required=false)]
        public GroupUpdateRequestFreeCheckSetting FreeCheckSetting { get; set; }
        public class GroupUpdateRequestFreeCheckSetting : TeaModel {
            [NameInMap("delimitOffsetMinutesBetweenDays")]
            [Validation(Required=false)]
            public int? DelimitOffsetMinutesBetweenDays { get; set; }

            [NameInMap("freeCheckGap")]
            [Validation(Required=false)]
            public GroupUpdateRequestFreeCheckSettingFreeCheckGap FreeCheckGap { get; set; }
            public class GroupUpdateRequestFreeCheckSettingFreeCheckGap : TeaModel {
                [NameInMap("offOnCheckGapMinutes")]
                [Validation(Required=false)]
                public int? OffOnCheckGapMinutes { get; set; }

                [NameInMap("onOffCheckGapMinutes")]
                [Validation(Required=false)]
                public int? OnOffCheckGapMinutes { get; set; }

            }

        }

        [NameInMap("freeCheckTypeId")]
        [Validation(Required=false)]
        public int? FreeCheckTypeId { get; set; }

        [NameInMap("groupId")]
        [Validation(Required=false)]
        public long? GroupId { get; set; }

        [NameInMap("groupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

        [NameInMap("managerList")]
        [Validation(Required=false)]
        public List<string> ManagerList { get; set; }

        [NameInMap("offset")]
        [Validation(Required=false)]
        public int? Offset { get; set; }

        [NameInMap("openFaceCheck")]
        [Validation(Required=false)]
        public bool? OpenFaceCheck { get; set; }

        [NameInMap("outsideCheckApproveModeId")]
        [Validation(Required=false)]
        public int? OutsideCheckApproveModeId { get; set; }

        [NameInMap("overtimeSettingId")]
        [Validation(Required=false)]
        public long? OvertimeSettingId { get; set; }

        [NameInMap("owner")]
        [Validation(Required=false)]
        public string Owner { get; set; }

        [NameInMap("positions")]
        [Validation(Required=false)]
        public List<GroupUpdateRequestPositions> Positions { get; set; }
        public class GroupUpdateRequestPositions : TeaModel {
            [NameInMap("address")]
            [Validation(Required=false)]
            public string Address { get; set; }

            [NameInMap("latitude")]
            [Validation(Required=false)]
            public string Latitude { get; set; }

            [NameInMap("longitude")]
            [Validation(Required=false)]
            public string Longitude { get; set; }

            [NameInMap("offset")]
            [Validation(Required=false)]
            public int? Offset { get; set; }

            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

        [NameInMap("resourcePermissionMap")]
        [Validation(Required=false)]
        public Dictionary<string, object> ResourcePermissionMap { get; set; }

        [NameInMap("shiftVOList")]
        [Validation(Required=false)]
        public List<GroupUpdateRequestShiftVOList> ShiftVOList { get; set; }
        public class GroupUpdateRequestShiftVOList : TeaModel {
            [NameInMap("shiftId")]
            [Validation(Required=false)]
            public long? ShiftId { get; set; }

        }

        [NameInMap("skipHolidays")]
        [Validation(Required=false)]
        public bool? SkipHolidays { get; set; }

        [NameInMap("trimDistance")]
        [Validation(Required=false)]
        public int? TrimDistance { get; set; }

        [NameInMap("workdayClassList")]
        [Validation(Required=false)]
        public List<long?> WorkdayClassList { get; set; }

        [NameInMap("opUserId")]
        [Validation(Required=false)]
        public string OpUserId { get; set; }

    }

}
