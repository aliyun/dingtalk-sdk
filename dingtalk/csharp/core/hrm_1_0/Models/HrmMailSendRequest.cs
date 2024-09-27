// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkhrm_1_0.Models
{
    public class HrmMailSendRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
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
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>测试.pdf</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>@asdc12312</para>
                /// </summary>
                [NameInMap("path")]
                [Validation(Required=false)]
                public string Path { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>media</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="mailto:abd@aaa.com">abd@aaa.com</a>,<a href="mailto:bcd@aaa.com">bcd@aaa.com</a>,</para>
            /// </summary>
            [NameInMap("bccAddress")]
            [Validation(Required=false)]
            public string BccAddress { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="mailto:abd@aaa.com">abd@aaa.com</a>,<a href="mailto:bcd@aaa.com">bcd@aaa.com</a>,</para>
            /// </summary>
            [NameInMap("ccAddress")]
            [Validation(Required=false)]
            public string CcAddress { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>请及时填写请填写入职登记表</para>
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
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>还有10分钟开始</para>
                    /// </summary>
                    [NameInMap("alarmDesc")]
                    [Validation(Required=false)]
                    public string AlarmDesc { get; set; }

                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("alarmMinutes")]
                    [Validation(Required=false)]
                    public int? AlarmMinutes { get; set; }

                    /// <summary>
                    /// <para>This parameter is required.</para>
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
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para><a href="mailto:abc@aaa.com">abc@aaa.com</a></para>
                    /// </summary>
                    [NameInMap("address")]
                    [Validation(Required=false)]
                    public string Address { get; set; }

                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>参会人1</para>
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>会议描述</para>
                /// </summary>
                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1701692590881</para>
                /// </summary>
                [NameInMap("endTime")]
                [Validation(Required=false)]
                public long? EndTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>会议室</para>
                /// </summary>
                [NameInMap("location")]
                [Validation(Required=false)]
                public string Location { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>REQUEST</para>
                /// </summary>
                [NameInMap("method")]
                [Validation(Required=false)]
                public string Method { get; set; }

                [NameInMap("organizer")]
                [Validation(Required=false)]
                public HrmMailSendRequestMailMeetingOrganizer Organizer { get; set; }
                public class HrmMailSendRequestMailMeetingOrganizer : TeaModel {
                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para><a href="mailto:abc@aaa.com">abc@aaa.com</a></para>
                    /// </summary>
                    [NameInMap("address")]
                    [Validation(Required=false)]
                    public string Address { get; set; }

                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>系统</para>
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("sequence")]
                [Validation(Required=false)]
                public int? Sequence { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1701692590881</para>
                /// </summary>
                [NameInMap("startTime")]
                [Validation(Required=false)]
                public long? StartTime { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>测试会议</para>
                /// </summary>
                [NameInMap("summary")]
                [Validation(Required=false)]
                public string Summary { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>uuidssssss</para>
                /// </summary>
                [NameInMap("uuid")]
                [Validation(Required=false)]
                public string Uuid { get; set; }

            }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="mailto:abd@aaa.com">abd@aaa.com</a>,<a href="mailto:bcd@aaa.com">bcd@aaa.com</a>,</para>
            /// </summary>
            [NameInMap("receiverAddress")]
            [Validation(Required=false)]
            public string ReceiverAddress { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>智能人事入职</para>
            /// </summary>
            [NameInMap("senderAlias")]
            [Validation(Required=false)]
            public string SenderAlias { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>请填写入职登记表</para>
            /// </summary>
            [NameInMap("subject")]
            [Validation(Required=false)]
            public string Subject { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("operator")]
        [Validation(Required=false)]
        public HrmMailSendRequestOperator Operator { get; set; }
        public class HrmMailSendRequestOperator : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>biz222ddd</para>
            /// </summary>
            [NameInMap("bizId")]
            [Validation(Required=false)]
            public string BizId { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>hrm</para>
            /// </summary>
            [NameInMap("mailAccountType")]
            [Validation(Required=false)]
            public string MailAccountType { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tokenabcd</para>
            /// </summary>
            [NameInMap("token")]
            [Validation(Required=false)]
            public string Token { get; set; }

        }

    }

}
