// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkhrm_1_0.Models
{
    public class HrmMailSendRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("mail")]
        [Validation(Required=false)]
        public HrmMailSendRequestMail Mail { get; set; }
        public class HrmMailSendRequestMail : TeaModel {
            [NameInMap("attachments")]
            [Validation(Required=false)]
            public List<HrmMailSendRequestMailAttachments> Attachments { get; set; }
            public class HrmMailSendRequestMailAttachments : TeaModel {
                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("path")]
                [Validation(Required=false)]
                public string Path { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            [NameInMap("bccAddress")]
            [Validation(Required=false)]
            public string BccAddress { get; set; }

            [NameInMap("ccAddress")]
            [Validation(Required=false)]
            public string CcAddress { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            [NameInMap("meeting")]
            [Validation(Required=false)]
            public HrmMailSendRequestMailMeeting Meeting { get; set; }
            public class HrmMailSendRequestMailMeeting : TeaModel {
                [NameInMap("alarm")]
                [Validation(Required=false)]
                public HrmMailSendRequestMailMeetingAlarm Alarm { get; set; }
                public class HrmMailSendRequestMailMeetingAlarm : TeaModel {
                    /// <summary>
                    /// This parameter is required.
                    /// </summary>
                    [NameInMap("alarmDesc")]
                    [Validation(Required=false)]
                    public string AlarmDesc { get; set; }

                    /// <summary>
                    /// This parameter is required.
                    /// </summary>
                    [NameInMap("alarmMinutes")]
                    [Validation(Required=false)]
                    public int? AlarmMinutes { get; set; }

                    /// <summary>
                    /// This parameter is required.
                    /// </summary>
                    [NameInMap("alarmSummary")]
                    [Validation(Required=false)]
                    public string AlarmSummary { get; set; }

                }

                [NameInMap("attendees")]
                [Validation(Required=false)]
                public List<HrmMailSendRequestMailMeetingAttendees> Attendees { get; set; }
                public class HrmMailSendRequestMailMeetingAttendees : TeaModel {
                    /// <summary>
                    /// This parameter is required.
                    /// </summary>
                    [NameInMap("address")]
                    [Validation(Required=false)]
                    public string Address { get; set; }

                    /// <summary>
                    /// This parameter is required.
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("endTime")]
                [Validation(Required=false)]
                public long? EndTime { get; set; }

                [NameInMap("location")]
                [Validation(Required=false)]
                public string Location { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("method")]
                [Validation(Required=false)]
                public string Method { get; set; }

                [NameInMap("organizer")]
                [Validation(Required=false)]
                public HrmMailSendRequestMailMeetingOrganizer Organizer { get; set; }
                public class HrmMailSendRequestMailMeetingOrganizer : TeaModel {
                    /// <summary>
                    /// This parameter is required.
                    /// </summary>
                    [NameInMap("address")]
                    [Validation(Required=false)]
                    public string Address { get; set; }

                    /// <summary>
                    /// This parameter is required.
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

                [NameInMap("sequence")]
                [Validation(Required=false)]
                public int? Sequence { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("startTime")]
                [Validation(Required=false)]
                public long? StartTime { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("summary")]
                [Validation(Required=false)]
                public string Summary { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("uuid")]
                [Validation(Required=false)]
                public string Uuid { get; set; }

            }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("receiverAddress")]
            [Validation(Required=false)]
            public string ReceiverAddress { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("senderAlias")]
            [Validation(Required=false)]
            public string SenderAlias { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("subject")]
            [Validation(Required=false)]
            public string Subject { get; set; }

        }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("operator")]
        [Validation(Required=false)]
        public HrmMailSendRequestOperator Operator { get; set; }
        public class HrmMailSendRequestOperator : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("bizId")]
            [Validation(Required=false)]
            public string BizId { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("mailAccountType")]
            [Validation(Required=false)]
            public string MailAccountType { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("token")]
            [Validation(Required=false)]
            public string Token { get; set; }

        }

    }

}
