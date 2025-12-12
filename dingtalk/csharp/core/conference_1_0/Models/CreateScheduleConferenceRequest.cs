// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkconference_1_0.Models
{
    public class CreateScheduleConferenceRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>qzR1iSMDvzR9iP7Pxxxxxxxxxxxx</para>
        /// </summary>
        [NameInMap("creatorUnionId")]
        [Validation(Required=false)]
        public string CreatorUnionId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1687928400000</para>
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

            /// <summary>
            /// <b>Example:</b>
            /// <para>dingc02f685fa06381c44ac5d6980864d335</para>
            /// </summary>
            [NameInMap("confAllowedCorpId")]
            [Validation(Required=false)]
            public string ConfAllowedCorpId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2iPOLbpUNMLzB5LuwggiiqiPwiEiE</para>
            /// </summary>
            [NameInMap("hostUnionId")]
            [Validation(Required=false)]
            public string HostUnionId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0：取消锁定 1：锁定</para>
            /// </summary>
            [NameInMap("lockRoom")]
            [Validation(Required=false)]
            public int? LockRoom { get; set; }

            [NameInMap("moziConfOpenRecordSetting")]
            [Validation(Required=false)]
            public CreateScheduleConferenceRequestScheduleConfSettingModelMoziConfOpenRecordSetting MoziConfOpenRecordSetting { get; set; }
            public class CreateScheduleConferenceRequestScheduleConfSettingModelMoziConfOpenRecordSetting : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>true：跟随 false：不跟随</para>
                /// </summary>
                [NameInMap("isFollowHost")]
                [Validation(Required=false)]
                public bool? IsFollowHost { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>grid：宫格模式,默认9宫格(3x3) speech：演讲者模式 full_screen：全屏模式 auto_grid：自动宫格模式，默认最大4x4宫格 screen_cast：屏幕共享模式，仅放置屏幕共享流 p2p：双人通话模式 full_screen_and_speaker：共享内容+发言人模式</para>
                /// </summary>
                [NameInMap("mode")]
                [Validation(Required=false)]
                public string Mode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0：不自动开启 1：自动开启</para>
                /// </summary>
                [NameInMap("recordAutoStart")]
                [Validation(Required=false)]
                public int? RecordAutoStart { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0：我以主持人身份入会后自动开启 1：其他人以联席主持人身份入会后开启 2：任何人以任何身份入会后开启</para>
                /// </summary>
                [NameInMap("recordAutoStartType")]
                [Validation(Required=false)]
                public int? RecordAutoStartType { get; set; }

            }

            [NameInMap("moziConfVirtualExtraSetting")]
            [Validation(Required=false)]
            public CreateScheduleConferenceRequestScheduleConfSettingModelMoziConfVirtualExtraSetting MoziConfVirtualExtraSetting { get; set; }
            public class CreateScheduleConferenceRequestScheduleConfSettingModelMoziConfVirtualExtraSetting : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>2iPOLbpUNMLzB5LuwggiiqiPwiEiE</para>
                /// </summary>
                [NameInMap("cloudRecordOwnerUnionId")]
                [Validation(Required=false)]
                public string CloudRecordOwnerUnionId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0：未开启 1：开启</para>
                /// </summary>
                [NameInMap("enableChat")]
                [Validation(Required=false)]
                public int? EnableChat { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true：允许匿名登录入会 false：不允许匿名登录入会</para>
                /// </summary>
                [NameInMap("enableWebAnonymousJoin")]
                [Validation(Required=false)]
                public bool? EnableWebAnonymousJoin { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0：未开启 1：开启</para>
                /// </summary>
                [NameInMap("joinBeforeHost")]
                [Validation(Required=false)]
                public int? JoinBeforeHost { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0：未开启 1：开启</para>
                /// </summary>
                [NameInMap("lockMediaStatusMicMute")]
                [Validation(Required=false)]
                public int? LockMediaStatusMicMute { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0：未开启 1：开启</para>
                /// </summary>
                [NameInMap("lockNick")]
                [Validation(Required=false)]
                public int? LockNick { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2iPOLbpUNMLzB5LuwggiiqiPwiEiE</para>
                /// </summary>
                [NameInMap("minutesOwnerUnionId")]
                [Validation(Required=false)]
                public string MinutesOwnerUnionId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("minutesSummaryDiyTemplateVersion")]
                [Validation(Required=false)]
                public string MinutesSummaryDiyTemplateVersion { get; set; }

                [NameInMap("minutesSummaryTemplateId")]
                [Validation(Required=false)]
                public string MinutesSummaryTemplateId { get; set; }

                [NameInMap("minutesSummaryTemplateType")]
                [Validation(Required=false)]
                public string MinutesSummaryTemplateType { get; set; }

                [NameInMap("moziConfExtensionAppSettings")]
                [Validation(Required=false)]
                public List<CreateScheduleConferenceRequestScheduleConfSettingModelMoziConfVirtualExtraSettingMoziConfExtensionAppSettings> MoziConfExtensionAppSettings { get; set; }
                public class CreateScheduleConferenceRequestScheduleConfSettingModelMoziConfVirtualExtraSettingMoziConfExtensionAppSettings : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0：不自动打开 1：仅主持人/联席主持人自动打开 2：全员自动打开</para>
                    /// </summary>
                    [NameInMap("autoOpenMode")]
                    [Validation(Required=false)]
                    public int? AutoOpenMode { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>COOLAPP-0-1026633886192127xxxB000W</para>
                    /// </summary>
                    [NameInMap("coolAppCode")]
                    [Validation(Required=false)]
                    public string CoolAppCode { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>bizData</para>
                    /// </summary>
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

                /// <summary>
                /// <b>Example:</b>
                /// <para>0：未开启 1：开启</para>
                /// </summary>
                [NameInMap("waitingRoom")]
                [Validation(Required=false)]
                public int? WaitingRoom { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>-1：开启 0：未开启 6：超过6人自动开启静音</para>
            /// </summary>
            [NameInMap("muteOnJoin")]
            [Validation(Required=false)]
            public int? MuteOnJoin { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0：允许共享 1：禁止共享</para>
            /// </summary>
            [NameInMap("screenShareForbidden")]
            [Validation(Required=false)]
            public int? ScreenShareForbidden { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1687924800000</para>
        /// </summary>
        [NameInMap("startTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>预约会议标题</para>
        /// </summary>
        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

    }

}
