// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkhrm_1_0.Models
{
    public class HrmMailSendRequest : TeaModel {
        [NameInMap("mail")]
        [Validation(Required=false)]
        public HrmMailSendRequestMail Mail { get; set; }
        public class HrmMailSendRequestMail : TeaModel {
            [NameInMap("attachments")]
            [Validation(Required=false)]
            public List<HrmMailSendRequestMailAttachments> Attachments { get; set; }
            public class HrmMailSendRequestMailAttachments : TeaModel {
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("path")]
                [Validation(Required=false)]
                public string Path { get; set; }

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

            [NameInMap("content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            [NameInMap("meeting")]
            [Validation(Required=false)]
            public HrmMailSendRequestMailMeeting Meeting { get; set; }
            public class HrmMailSendRequestMailMeeting : TeaModel {
                [NameInMap("alarmDesc")]
                [Validation(Required=false)]
                public string AlarmDesc { get; set; }

                [NameInMap("alarmMinutes")]
                [Validation(Required=false)]
                public int? AlarmMinutes { get; set; }

                [NameInMap("attendees")]
                [Validation(Required=false)]
                public List<HrmMailSendRequestMailMeetingAttendees> Attendees { get; set; }
                public class HrmMailSendRequestMailMeetingAttendees : TeaModel {
                    [NameInMap("address")]
                    [Validation(Required=false)]
                    public string Address { get; set; }

                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("endTime")]
                [Validation(Required=false)]
                public long? EndTime { get; set; }

                [NameInMap("location")]
                [Validation(Required=false)]
                public string Location { get; set; }

                [NameInMap("method")]
                [Validation(Required=false)]
                public string Method { get; set; }

                [NameInMap("organizer")]
                [Validation(Required=false)]
                public HrmMailSendRequestMailMeetingOrganizer Organizer { get; set; }
                public class HrmMailSendRequestMailMeetingOrganizer : TeaModel {
                    [NameInMap("address")]
                    [Validation(Required=false)]
                    public string Address { get; set; }

                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

                [NameInMap("startTime")]
                [Validation(Required=false)]
                public long? StartTime { get; set; }

                [NameInMap("summary")]
                [Validation(Required=false)]
                public string Summary { get; set; }

                [NameInMap("uuid")]
                [Validation(Required=false)]
                public string Uuid { get; set; }

            }

            [NameInMap("receiverAddress")]
            [Validation(Required=false)]
            public string ReceiverAddress { get; set; }

            [NameInMap("senderAlias")]
            [Validation(Required=false)]
            public string SenderAlias { get; set; }

            [NameInMap("subject")]
            [Validation(Required=false)]
            public string Subject { get; set; }

        }

        [NameInMap("operator")]
        [Validation(Required=false)]
        public HrmMailSendRequestOperator Operator { get; set; }
        public class HrmMailSendRequestOperator : TeaModel {
            [NameInMap("bizId")]
            [Validation(Required=false)]
            public string BizId { get; set; }

            [NameInMap("mailAccountType")]
            [Validation(Required=false)]
            public string MailAccountType { get; set; }

            [NameInMap("token")]
            [Validation(Required=false)]
            public string Token { get; set; }

        }

    }

}
