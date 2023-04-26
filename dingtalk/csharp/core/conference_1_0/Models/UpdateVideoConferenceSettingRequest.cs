// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkconference_1_0.Models
{
    public class UpdateVideoConferenceSettingRequest : TeaModel {
        [NameInMap("allowUnmuteSelf")]
        [Validation(Required=false)]
        public bool? AllowUnmuteSelf { get; set; }

        [NameInMap("autoTransferHost")]
        [Validation(Required=false)]
        public bool? AutoTransferHost { get; set; }

        [NameInMap("forbiddenShareScreen")]
        [Validation(Required=false)]
        public bool? ForbiddenShareScreen { get; set; }

        [NameInMap("lockConference")]
        [Validation(Required=false)]
        public bool? LockConference { get; set; }

        [NameInMap("muteAll")]
        [Validation(Required=false)]
        public bool? MuteAll { get; set; }

        [NameInMap("onlyInternalEmployeesJoin")]
        [Validation(Required=false)]
        public bool? OnlyInternalEmployeesJoin { get; set; }

    }

}
