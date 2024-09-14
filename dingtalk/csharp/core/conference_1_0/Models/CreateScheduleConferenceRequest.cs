// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkconference_1_0.Models
{
    public class CreateScheduleConferenceRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("creatorUnionId")]
        [Validation(Required=false)]
        public string CreatorUnionId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("endTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        [NameInMap("scheduleConfSettingModel")]
        [Validation(Required=false)]
        public CreateScheduleConferenceRequestScheduleConfSettingModel ScheduleConfSettingModel { get; set; }
        public class CreateScheduleConferenceRequestScheduleConfSettingModel : TeaModel {
            [NameInMap("cohostUnionIds")]
            [Validation(Required=false)]
            public List<string> CohostUnionIds { get; set; }

            [NameInMap("confAllowedCorpId")]
            [Validation(Required=false)]
            public string ConfAllowedCorpId { get; set; }

            [NameInMap("hostUnionId")]
            [Validation(Required=false)]
            public string HostUnionId { get; set; }

            [NameInMap("lockRoom")]
            [Validation(Required=false)]
            public int? LockRoom { get; set; }

            [NameInMap("moziConfOpenRecordSetting")]
            [Validation(Required=false)]
            public CreateScheduleConferenceRequestScheduleConfSettingModelMoziConfOpenRecordSetting MoziConfOpenRecordSetting { get; set; }
            public class CreateScheduleConferenceRequestScheduleConfSettingModelMoziConfOpenRecordSetting : TeaModel {
                [NameInMap("isFollowHost")]
                [Validation(Required=false)]
                public bool? IsFollowHost { get; set; }

                [NameInMap("mode")]
                [Validation(Required=false)]
                public string Mode { get; set; }

                [NameInMap("recordAutoStart")]
                [Validation(Required=false)]
                public int? RecordAutoStart { get; set; }

                [NameInMap("recordAutoStartType")]
                [Validation(Required=false)]
                public int? RecordAutoStartType { get; set; }

            }

            [NameInMap("moziConfVirtualExtraSetting")]
            [Validation(Required=false)]
            public CreateScheduleConferenceRequestScheduleConfSettingModelMoziConfVirtualExtraSetting MoziConfVirtualExtraSetting { get; set; }
            public class CreateScheduleConferenceRequestScheduleConfSettingModelMoziConfVirtualExtraSetting : TeaModel {
                [NameInMap("cloudRecordOwnerUnionId")]
                [Validation(Required=false)]
                public string CloudRecordOwnerUnionId { get; set; }

                [NameInMap("enableChat")]
                [Validation(Required=false)]
                public int? EnableChat { get; set; }

                [NameInMap("enableWebAnonymousJoin")]
                [Validation(Required=false)]
                public bool? EnableWebAnonymousJoin { get; set; }

                [NameInMap("joinBeforeHost")]
                [Validation(Required=false)]
                public int? JoinBeforeHost { get; set; }

                [NameInMap("lockMediaStatusMicMute")]
                [Validation(Required=false)]
                public int? LockMediaStatusMicMute { get; set; }

                [NameInMap("lockNick")]
                [Validation(Required=false)]
                public int? LockNick { get; set; }

                [NameInMap("minutesOwnerUnionId")]
                [Validation(Required=false)]
                public string MinutesOwnerUnionId { get; set; }

                [NameInMap("moziConfExtensionAppSettings")]
                [Validation(Required=false)]
                public List<CreateScheduleConferenceRequestScheduleConfSettingModelMoziConfVirtualExtraSettingMoziConfExtensionAppSettings> MoziConfExtensionAppSettings { get; set; }
                public class CreateScheduleConferenceRequestScheduleConfSettingModelMoziConfVirtualExtraSettingMoziConfExtensionAppSettings : TeaModel {
                    [NameInMap("autoOpenMode")]
                    [Validation(Required=false)]
                    public int? AutoOpenMode { get; set; }

                    [NameInMap("coolAppCode")]
                    [Validation(Required=false)]
                    public string CoolAppCode { get; set; }

                    [NameInMap("extensionAppBizData")]
                    [Validation(Required=false)]
                    public string ExtensionAppBizData { get; set; }

                }

                [NameInMap("pushAllMeetingRecords")]
                [Validation(Required=false)]
                public bool? PushAllMeetingRecords { get; set; }

                [NameInMap("pushCloudRecordCard")]
                [Validation(Required=false)]
                public bool? PushCloudRecordCard { get; set; }

                [NameInMap("pushMinutesCard")]
                [Validation(Required=false)]
                public bool? PushMinutesCard { get; set; }

                [NameInMap("waitingRoom")]
                [Validation(Required=false)]
                public int? WaitingRoom { get; set; }

            }

            [NameInMap("muteOnJoin")]
            [Validation(Required=false)]
            public int? MuteOnJoin { get; set; }

            [NameInMap("screenShareForbidden")]
            [Validation(Required=false)]
            public int? ScreenShareForbidden { get; set; }

        }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("startTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

    }

}
