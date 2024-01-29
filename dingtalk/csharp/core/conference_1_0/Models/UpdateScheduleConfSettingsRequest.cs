// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkconference_1_0.Models
{
    public class UpdateScheduleConfSettingsRequest : TeaModel {
        [NameInMap("creatorUnionId")]
        [Validation(Required=false)]
        public string CreatorUnionId { get; set; }

        [NameInMap("scheduleConfSettingModel")]
        [Validation(Required=false)]
        public UpdateScheduleConfSettingsRequestScheduleConfSettingModel ScheduleConfSettingModel { get; set; }
        public class UpdateScheduleConfSettingsRequestScheduleConfSettingModel : TeaModel {
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

            [NameInMap("moziConfVirtualExtraSetting")]
            [Validation(Required=false)]
            public UpdateScheduleConfSettingsRequestScheduleConfSettingModelMoziConfVirtualExtraSetting MoziConfVirtualExtraSetting { get; set; }
            public class UpdateScheduleConfSettingsRequestScheduleConfSettingModelMoziConfVirtualExtraSetting : TeaModel {
                [NameInMap("enableChat")]
                [Validation(Required=false)]
                public int? EnableChat { get; set; }

                [NameInMap("joinBeforeHost")]
                [Validation(Required=false)]
                public int? JoinBeforeHost { get; set; }

                [NameInMap("lockMediaStatusMicMute")]
                [Validation(Required=false)]
                public int? LockMediaStatusMicMute { get; set; }

                [NameInMap("lockNick")]
                [Validation(Required=false)]
                public int? LockNick { get; set; }

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

        [NameInMap("scheduleConferenceId")]
        [Validation(Required=false)]
        public string ScheduleConferenceId { get; set; }

    }

}
