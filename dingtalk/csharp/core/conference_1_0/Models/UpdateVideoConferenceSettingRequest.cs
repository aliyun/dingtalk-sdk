// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkconference_1_0.Models
{
    public class UpdateVideoConferenceSettingRequest : TeaModel {
        /// <summary>
        /// 允许参会人员取消静音
        /// </summary>
        [NameInMap("allowUnmuteSelf")]
        [Validation(Required=false)]
        public bool? AllowUnmuteSelf { get; set; }

        /// <summary>
        /// 主持人离会，是否自动转移主持人角色
        /// </summary>
        [NameInMap("autoTransferHost")]
        [Validation(Required=false)]
        public bool? AutoTransferHost { get; set; }

        /// <summary>
        /// 禁止共享屏幕
        /// </summary>
        [NameInMap("forbiddenShareScreen")]
        [Validation(Required=false)]
        public bool? ForbiddenShareScreen { get; set; }

        /// <summary>
        /// 锁定会议，禁止邀请入会
        /// </summary>
        [NameInMap("lockConference")]
        [Validation(Required=false)]
        public bool? LockConference { get; set; }

        /// <summary>
        /// 全员静音
        /// </summary>
        [NameInMap("muteAll")]
        [Validation(Required=false)]
        public bool? MuteAll { get; set; }

        /// <summary>
        /// 仅允许企业内员工加入会议
        /// </summary>
        [NameInMap("onlyInternalEmployeesJoin")]
        [Validation(Required=false)]
        public bool? OnlyInternalEmployeesJoin { get; set; }

    }

}
