// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkats_1_0.Models
{
    public class SyncInterviewInfoToAIInterviewAssistantRequest : TeaModel {
        [NameInMap("conferenceInfoVO")]
        [Validation(Required=false)]
        public SyncInterviewInfoToAIInterviewAssistantRequestConferenceInfoVO ConferenceInfoVO { get; set; }
        public class SyncInterviewInfoToAIInterviewAssistantRequestConferenceInfoVO : TeaModel {
            [NameInMap("conferenceBookerInfoVO")]
            [Validation(Required=false)]
            public SyncInterviewInfoToAIInterviewAssistantRequestConferenceInfoVOConferenceBookerInfoVO ConferenceBookerInfoVO { get; set; }
            public class SyncInterviewInfoToAIInterviewAssistantRequestConferenceInfoVOConferenceBookerInfoVO : TeaModel {
                [NameInMap("id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            [NameInMap("roomCode")]
            [Validation(Required=false)]
            public string RoomCode { get; set; }

            [NameInMap("scheduleConferenceId")]
            [Validation(Required=false)]
            public string ScheduleConferenceId { get; set; }

            [NameInMap("scheduleConferenceUrl")]
            [Validation(Required=false)]
            public string ScheduleConferenceUrl { get; set; }

        }

        [NameInMap("interviewEndTime")]
        [Validation(Required=false)]
        public long? InterviewEndTime { get; set; }

        [NameInMap("interviewId")]
        [Validation(Required=false)]
        public string InterviewId { get; set; }

        [NameInMap("interviewStartTime")]
        [Validation(Required=false)]
        public long? InterviewStartTime { get; set; }

        [NameInMap("interviewType")]
        [Validation(Required=false)]
        public string InterviewType { get; set; }

        [NameInMap("intervieweeInfoVOList")]
        [Validation(Required=false)]
        public List<SyncInterviewInfoToAIInterviewAssistantRequestIntervieweeInfoVOList> IntervieweeInfoVOList { get; set; }
        public class SyncInterviewInfoToAIInterviewAssistantRequestIntervieweeInfoVOList : TeaModel {
            [NameInMap("bizIntervieweeId")]
            [Validation(Required=false)]
            public string BizIntervieweeId { get; set; }

            [NameInMap("historyInterviewInfoVOList")]
            [Validation(Required=false)]
            public List<SyncInterviewInfoToAIInterviewAssistantRequestIntervieweeInfoVOListHistoryInterviewInfoVOList> HistoryInterviewInfoVOList { get; set; }
            public class SyncInterviewInfoToAIInterviewAssistantRequestIntervieweeInfoVOListHistoryInterviewInfoVOList : TeaModel {
                [NameInMap("canViewUserIdList")]
                [Validation(Required=false)]
                public List<string> CanViewUserIdList { get; set; }

                [NameInMap("evaluation")]
                [Validation(Required=false)]
                public string Evaluation { get; set; }

                [NameInMap("historyInterviewId")]
                [Validation(Required=false)]
                public string HistoryInterviewId { get; set; }

                [NameInMap("historyInterviewResult")]
                [Validation(Required=false)]
                public string HistoryInterviewResult { get; set; }

                [NameInMap("interviewRounds")]
                [Validation(Required=false)]
                public string InterviewRounds { get; set; }

                [NameInMap("interviewerName")]
                [Validation(Required=false)]
                public string InterviewerName { get; set; }

            }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("phone")]
            [Validation(Required=false)]
            public string Phone { get; set; }

            [NameInMap("resumeContent")]
            [Validation(Required=false)]
            public string ResumeContent { get; set; }

        }

        [NameInMap("interviewerInfoVOList")]
        [Validation(Required=false)]
        public List<SyncInterviewInfoToAIInterviewAssistantRequestInterviewerInfoVOList> InterviewerInfoVOList { get; set; }
        public class SyncInterviewInfoToAIInterviewAssistantRequestInterviewerInfoVOList : TeaModel {
            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("interviewEvaluationFormConfigVO")]
            [Validation(Required=false)]
            public SyncInterviewInfoToAIInterviewAssistantRequestInterviewerInfoVOListInterviewEvaluationFormConfigVO InterviewEvaluationFormConfigVO { get; set; }
            public class SyncInterviewInfoToAIInterviewAssistantRequestInterviewerInfoVOListInterviewEvaluationFormConfigVO : TeaModel {
                [NameInMap("content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                [NameInMap("id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("position")]
            [Validation(Required=false)]
            public string Position { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>moka</para>
        /// </summary>
        [NameInMap("isvId")]
        [Validation(Required=false)]
        public string IsvId { get; set; }

        [NameInMap("jobContentVO")]
        [Validation(Required=false)]
        public SyncInterviewInfoToAIInterviewAssistantRequestJobContentVO JobContentVO { get; set; }
        public class SyncInterviewInfoToAIInterviewAssistantRequestJobContentVO : TeaModel {
            [NameInMap("commitment")]
            [Validation(Required=false)]
            public string Commitment { get; set; }

            [NameInMap("hireCount")]
            [Validation(Required=false)]
            public int? HireCount { get; set; }

            [NameInMap("jobContent")]
            [Validation(Required=false)]
            public string JobContent { get; set; }

            [NameInMap("jobName")]
            [Validation(Required=false)]
            public string JobName { get; set; }

            [NameInMap("maxSalary")]
            [Validation(Required=false)]
            public int? MaxSalary { get; set; }

            [NameInMap("minSalary")]
            [Validation(Required=false)]
            public int? MinSalary { get; set; }

        }

    }

}
