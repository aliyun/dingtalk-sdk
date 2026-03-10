// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkai_search_ask_1_0.Models
{
    public class RetrieveResponseBody : TeaModel {
        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("errorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public List<RetrieveResponseBodyResult> Result { get; set; }
        public class RetrieveResponseBodyResult : TeaModel {
            [NameInMap("calendars")]
            [Validation(Required=false)]
            public List<RetrieveResponseBodyResultCalendars> Calendars { get; set; }
            public class RetrieveResponseBodyResultCalendars : TeaModel {
                [NameInMap("creatorStaffId")]
                [Validation(Required=false)]
                public long? CreatorStaffId { get; set; }

                [NameInMap("endTime")]
                [Validation(Required=false)]
                public long? EndTime { get; set; }

                [NameInMap("gmtCreate")]
                [Validation(Required=false)]
                public long? GmtCreate { get; set; }

                [NameInMap("gmtModified")]
                [Validation(Required=false)]
                public long? GmtModified { get; set; }

                [NameInMap("icon")]
                [Validation(Required=false)]
                public string Icon { get; set; }

                [NameInMap("matchIntimacy")]
                [Validation(Required=false)]
                public bool? MatchIntimacy { get; set; }

                [NameInMap("material")]
                [Validation(Required=false)]
                public string Material { get; set; }

                [NameInMap("meetingRoom")]
                [Validation(Required=false)]
                public string MeetingRoom { get; set; }

                [NameInMap("participantStaffIds")]
                [Validation(Required=false)]
                public List<string> ParticipantStaffIds { get; set; }

                [NameInMap("rawComment")]
                [Validation(Required=false)]
                public string RawComment { get; set; }

                [NameInMap("refType")]
                [Validation(Required=false)]
                public string RefType { get; set; }

                [NameInMap("score")]
                [Validation(Required=false)]
                public double? Score { get; set; }

                [NameInMap("scoreItem")]
                [Validation(Required=false)]
                public RetrieveResponseBodyResultCalendarsScoreItem ScoreItem { get; set; }
                public class RetrieveResponseBodyResultCalendarsScoreItem : TeaModel {
                    [NameInMap("finallyScore")]
                    [Validation(Required=false)]
                    public double? FinallyScore { get; set; }

                    [NameInMap("scoreMap")]
                    [Validation(Required=false)]
                    public Dictionary<string, double?> ScoreMap { get; set; }

                    [NameInMap("scoreThreshold")]
                    [Validation(Required=false)]
                    public double? ScoreThreshold { get; set; }

                    [NameInMap("selectedBranch")]
                    [Validation(Required=false)]
                    public List<string> SelectedBranch { get; set; }

                    [NameInMap("selectedCategory")]
                    [Validation(Required=false)]
                    public string SelectedCategory { get; set; }

                }

                [NameInMap("startTime")]
                [Validation(Required=false)]
                public long? StartTime { get; set; }

                [NameInMap("timestamp")]
                [Validation(Required=false)]
                public long? Timestamp { get; set; }

                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

            [NameInMap("dingHelperDocs")]
            [Validation(Required=false)]
            public List<RetrieveResponseBodyResultDingHelperDocs> DingHelperDocs { get; set; }
            public class RetrieveResponseBodyResultDingHelperDocs : TeaModel {
                [NameInMap("ableDashboardModel")]
                [Validation(Required=false)]
                public RetrieveResponseBodyResultDingHelperDocsAbleDashboardModel AbleDashboardModel { get; set; }
                public class RetrieveResponseBodyResultDingHelperDocsAbleDashboardModel : TeaModel {
                    [NameInMap("chartName")]
                    [Validation(Required=false)]
                    public string ChartName { get; set; }

                    [NameInMap("chartType")]
                    [Validation(Required=false)]
                    public string ChartType { get; set; }

                    [NameInMap("dashboardName")]
                    [Validation(Required=false)]
                    public string DashboardName { get; set; }

                    [NameInMap("data")]
                    [Validation(Required=false)]
                    public string Data { get; set; }

                    [NameInMap("sheetName")]
                    [Validation(Required=false)]
                    public string SheetName { get; set; }

                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                [NameInMap("chunkId")]
                [Validation(Required=false)]
                public int? ChunkId { get; set; }

                [NameInMap("chunkIds")]
                [Validation(Required=false)]
                public List<int?> ChunkIds { get; set; }

                [NameInMap("chunkModel")]
                [Validation(Required=false)]
                public string ChunkModel { get; set; }

                [NameInMap("creator")]
                [Validation(Required=false)]
                public string Creator { get; set; }

                [NameInMap("dentryUuid")]
                [Validation(Required=false)]
                public string DentryUuid { get; set; }

                [NameInMap("extension")]
                [Validation(Required=false)]
                public string Extension { get; set; }

                [NameInMap("gmtCreate")]
                [Validation(Required=false)]
                public long? GmtCreate { get; set; }

                [NameInMap("gmtModified")]
                [Validation(Required=false)]
                public long? GmtModified { get; set; }

                [NameInMap("hasExtendChunk")]
                [Validation(Required=false)]
                public bool? HasExtendChunk { get; set; }

                [NameInMap("icon")]
                [Validation(Required=false)]
                public string Icon { get; set; }

                [NameInMap("matchIntimacy")]
                [Validation(Required=false)]
                public bool? MatchIntimacy { get; set; }

                [NameInMap("material")]
                [Validation(Required=false)]
                public string Material { get; set; }

                [NameInMap("refType")]
                [Validation(Required=false)]
                public string RefType { get; set; }

                [NameInMap("score")]
                [Validation(Required=false)]
                public double? Score { get; set; }

                [NameInMap("scoreItem")]
                [Validation(Required=false)]
                public RetrieveResponseBodyResultDingHelperDocsScoreItem ScoreItem { get; set; }
                public class RetrieveResponseBodyResultDingHelperDocsScoreItem : TeaModel {
                    [NameInMap("finallyScore")]
                    [Validation(Required=false)]
                    public double? FinallyScore { get; set; }

                    [NameInMap("scoreMap")]
                    [Validation(Required=false)]
                    public Dictionary<string, double?> ScoreMap { get; set; }

                    [NameInMap("scoreThreshold")]
                    [Validation(Required=false)]
                    public double? ScoreThreshold { get; set; }

                    [NameInMap("selectedBranch")]
                    [Validation(Required=false)]
                    public List<string> SelectedBranch { get; set; }

                    [NameInMap("selectedCategory")]
                    [Validation(Required=false)]
                    public string SelectedCategory { get; set; }

                }

                [NameInMap("small2bigText")]
                [Validation(Required=false)]
                public string Small2bigText { get; set; }

                [NameInMap("text")]
                [Validation(Required=false)]
                public string Text { get; set; }

                [NameInMap("timestamp")]
                [Validation(Required=false)]
                public long? Timestamp { get; set; }

                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("uploadSource")]
                [Validation(Required=false)]
                public string UploadSource { get; set; }

                [NameInMap("url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

            [NameInMap("docs")]
            [Validation(Required=false)]
            public List<RetrieveResponseBodyResultDocs> Docs { get; set; }
            public class RetrieveResponseBodyResultDocs : TeaModel {
                [NameInMap("ableDashboardModel")]
                [Validation(Required=false)]
                public RetrieveResponseBodyResultDocsAbleDashboardModel AbleDashboardModel { get; set; }
                public class RetrieveResponseBodyResultDocsAbleDashboardModel : TeaModel {
                    [NameInMap("chartName")]
                    [Validation(Required=false)]
                    public string ChartName { get; set; }

                    [NameInMap("chartType")]
                    [Validation(Required=false)]
                    public string ChartType { get; set; }

                    [NameInMap("dashboardName")]
                    [Validation(Required=false)]
                    public string DashboardName { get; set; }

                    [NameInMap("data")]
                    [Validation(Required=false)]
                    public string Data { get; set; }

                    [NameInMap("sheetName")]
                    [Validation(Required=false)]
                    public string SheetName { get; set; }

                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                [NameInMap("chunkId")]
                [Validation(Required=false)]
                public int? ChunkId { get; set; }

                [NameInMap("chunkIds")]
                [Validation(Required=false)]
                public List<int?> ChunkIds { get; set; }

                [NameInMap("chunkModel")]
                [Validation(Required=false)]
                public string ChunkModel { get; set; }

                [NameInMap("creator")]
                [Validation(Required=false)]
                public string Creator { get; set; }

                [NameInMap("dentryUuid")]
                [Validation(Required=false)]
                public string DentryUuid { get; set; }

                [NameInMap("extension")]
                [Validation(Required=false)]
                public string Extension { get; set; }

                [NameInMap("gmtCreate")]
                [Validation(Required=false)]
                public long? GmtCreate { get; set; }

                [NameInMap("gmtModified")]
                [Validation(Required=false)]
                public long? GmtModified { get; set; }

                [NameInMap("hasExtendChunk")]
                [Validation(Required=false)]
                public bool? HasExtendChunk { get; set; }

                [NameInMap("icon")]
                [Validation(Required=false)]
                public string Icon { get; set; }

                [NameInMap("matchIntimacy")]
                [Validation(Required=false)]
                public bool? MatchIntimacy { get; set; }

                [NameInMap("material")]
                [Validation(Required=false)]
                public string Material { get; set; }

                [NameInMap("refType")]
                [Validation(Required=false)]
                public string RefType { get; set; }

                [NameInMap("score")]
                [Validation(Required=false)]
                public double? Score { get; set; }

                [NameInMap("scoreItem")]
                [Validation(Required=false)]
                public RetrieveResponseBodyResultDocsScoreItem ScoreItem { get; set; }
                public class RetrieveResponseBodyResultDocsScoreItem : TeaModel {
                    [NameInMap("finallyScore")]
                    [Validation(Required=false)]
                    public double? FinallyScore { get; set; }

                    [NameInMap("scoreMap")]
                    [Validation(Required=false)]
                    public Dictionary<string, double?> ScoreMap { get; set; }

                    [NameInMap("scoreThreshold")]
                    [Validation(Required=false)]
                    public double? ScoreThreshold { get; set; }

                    [NameInMap("selectedBranch")]
                    [Validation(Required=false)]
                    public List<string> SelectedBranch { get; set; }

                    [NameInMap("selectedCategory")]
                    [Validation(Required=false)]
                    public string SelectedCategory { get; set; }

                }

                [NameInMap("small2bigText")]
                [Validation(Required=false)]
                public string Small2bigText { get; set; }

                [NameInMap("text")]
                [Validation(Required=false)]
                public string Text { get; set; }

                [NameInMap("timestamp")]
                [Validation(Required=false)]
                public long? Timestamp { get; set; }

                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("uploadSource")]
                [Validation(Required=false)]
                public string UploadSource { get; set; }

                [NameInMap("url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

            [NameInMap("faqs")]
            [Validation(Required=false)]
            public List<RetrieveResponseBodyResultFaqs> Faqs { get; set; }
            public class RetrieveResponseBodyResultFaqs : TeaModel {
                [NameInMap("icon")]
                [Validation(Required=false)]
                public string Icon { get; set; }

                [NameInMap("matchIntimacy")]
                [Validation(Required=false)]
                public bool? MatchIntimacy { get; set; }

                [NameInMap("material")]
                [Validation(Required=false)]
                public string Material { get; set; }

                [NameInMap("refType")]
                [Validation(Required=false)]
                public string RefType { get; set; }

                [NameInMap("score")]
                [Validation(Required=false)]
                public double? Score { get; set; }

                [NameInMap("scoreItem")]
                [Validation(Required=false)]
                public RetrieveResponseBodyResultFaqsScoreItem ScoreItem { get; set; }
                public class RetrieveResponseBodyResultFaqsScoreItem : TeaModel {
                    [NameInMap("finallyScore")]
                    [Validation(Required=false)]
                    public double? FinallyScore { get; set; }

                    [NameInMap("scoreMap")]
                    [Validation(Required=false)]
                    public Dictionary<string, double?> ScoreMap { get; set; }

                    [NameInMap("scoreThreshold")]
                    [Validation(Required=false)]
                    public double? ScoreThreshold { get; set; }

                    [NameInMap("selectedBranch")]
                    [Validation(Required=false)]
                    public List<string> SelectedBranch { get; set; }

                    [NameInMap("selectedCategory")]
                    [Validation(Required=false)]
                    public string SelectedCategory { get; set; }

                }

                [NameInMap("timestamp")]
                [Validation(Required=false)]
                public long? Timestamp { get; set; }

                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

            [NameInMap("finalResults")]
            [Validation(Required=false)]
            public List<RetrieveResponseBodyResultFinalResults> FinalResults { get; set; }
            public class RetrieveResponseBodyResultFinalResults : TeaModel {
                [NameInMap("icon")]
                [Validation(Required=false)]
                public string Icon { get; set; }

                [NameInMap("matchIntimacy")]
                [Validation(Required=false)]
                public bool? MatchIntimacy { get; set; }

                [NameInMap("material")]
                [Validation(Required=false)]
                public string Material { get; set; }

                [NameInMap("refType")]
                [Validation(Required=false)]
                public string RefType { get; set; }

                [NameInMap("score")]
                [Validation(Required=false)]
                public double? Score { get; set; }

                [NameInMap("scoreItem")]
                [Validation(Required=false)]
                public RetrieveResponseBodyResultFinalResultsScoreItem ScoreItem { get; set; }
                public class RetrieveResponseBodyResultFinalResultsScoreItem : TeaModel {
                    [NameInMap("finallyScore")]
                    [Validation(Required=false)]
                    public double? FinallyScore { get; set; }

                    [NameInMap("scoreMap")]
                    [Validation(Required=false)]
                    public Dictionary<string, double?> ScoreMap { get; set; }

                    [NameInMap("scoreThreshold")]
                    [Validation(Required=false)]
                    public double? ScoreThreshold { get; set; }

                    [NameInMap("selectedBranch")]
                    [Validation(Required=false)]
                    public List<string> SelectedBranch { get; set; }

                    [NameInMap("selectedCategory")]
                    [Validation(Required=false)]
                    public string SelectedCategory { get; set; }

                }

                [NameInMap("timestamp")]
                [Validation(Required=false)]
                public long? Timestamp { get; set; }

                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

            [NameInMap("minutes")]
            [Validation(Required=false)]
            public List<RetrieveResponseBodyResultMinutes> Minutes { get; set; }
            public class RetrieveResponseBodyResultMinutes : TeaModel {
                [NameInMap("corpId")]
                [Validation(Required=false)]
                public long? CorpId { get; set; }

                [NameInMap("creator")]
                [Validation(Required=false)]
                public string Creator { get; set; }

                [NameInMap("extension")]
                [Validation(Required=false)]
                public string Extension { get; set; }

                [NameInMap("fullTextSummary")]
                [Validation(Required=false)]
                public string FullTextSummary { get; set; }

                [NameInMap("gmtModified")]
                [Validation(Required=false)]
                public long? GmtModified { get; set; }

                [NameInMap("icon")]
                [Validation(Required=false)]
                public string Icon { get; set; }

                [NameInMap("matchIntimacy")]
                [Validation(Required=false)]
                public bool? MatchIntimacy { get; set; }

                [NameInMap("material")]
                [Validation(Required=false)]
                public string Material { get; set; }

                [NameInMap("originText")]
                [Validation(Required=false)]
                public string OriginText { get; set; }

                [NameInMap("refType")]
                [Validation(Required=false)]
                public string RefType { get; set; }

                [NameInMap("score")]
                [Validation(Required=false)]
                public double? Score { get; set; }

                [NameInMap("scoreItem")]
                [Validation(Required=false)]
                public RetrieveResponseBodyResultMinutesScoreItem ScoreItem { get; set; }
                public class RetrieveResponseBodyResultMinutesScoreItem : TeaModel {
                    [NameInMap("finallyScore")]
                    [Validation(Required=false)]
                    public double? FinallyScore { get; set; }

                    [NameInMap("scoreMap")]
                    [Validation(Required=false)]
                    public Dictionary<string, double?> ScoreMap { get; set; }

                    [NameInMap("scoreThreshold")]
                    [Validation(Required=false)]
                    public double? ScoreThreshold { get; set; }

                    [NameInMap("selectedBranch")]
                    [Validation(Required=false)]
                    public List<string> SelectedBranch { get; set; }

                    [NameInMap("selectedCategory")]
                    [Validation(Required=false)]
                    public string SelectedCategory { get; set; }

                }

                [NameInMap("timestamp")]
                [Validation(Required=false)]
                public long? Timestamp { get; set; }

                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

            [NameInMap("reports")]
            [Validation(Required=false)]
            public List<RetrieveResponseBodyResultReports> Reports { get; set; }
            public class RetrieveResponseBodyResultReports : TeaModel {
                [NameInMap("content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                [NameInMap("corpId")]
                [Validation(Required=false)]
                public long? CorpId { get; set; }

                [NameInMap("creator")]
                [Validation(Required=false)]
                public string Creator { get; set; }

                [NameInMap("gmtCreate")]
                [Validation(Required=false)]
                public long? GmtCreate { get; set; }

                [NameInMap("gmtModified")]
                [Validation(Required=false)]
                public long? GmtModified { get; set; }

                [NameInMap("icon")]
                [Validation(Required=false)]
                public string Icon { get; set; }

                [NameInMap("matchIntimacy")]
                [Validation(Required=false)]
                public bool? MatchIntimacy { get; set; }

                [NameInMap("material")]
                [Validation(Required=false)]
                public string Material { get; set; }

                [NameInMap("refType")]
                [Validation(Required=false)]
                public string RefType { get; set; }

                [NameInMap("score")]
                [Validation(Required=false)]
                public double? Score { get; set; }

                [NameInMap("scoreItem")]
                [Validation(Required=false)]
                public RetrieveResponseBodyResultReportsScoreItem ScoreItem { get; set; }
                public class RetrieveResponseBodyResultReportsScoreItem : TeaModel {
                    [NameInMap("finallyScore")]
                    [Validation(Required=false)]
                    public double? FinallyScore { get; set; }

                    [NameInMap("scoreMap")]
                    [Validation(Required=false)]
                    public Dictionary<string, double?> ScoreMap { get; set; }

                    [NameInMap("scoreThreshold")]
                    [Validation(Required=false)]
                    public double? ScoreThreshold { get; set; }

                    [NameInMap("selectedBranch")]
                    [Validation(Required=false)]
                    public List<string> SelectedBranch { get; set; }

                    [NameInMap("selectedCategory")]
                    [Validation(Required=false)]
                    public string SelectedCategory { get; set; }

                }

                [NameInMap("timestamp")]
                [Validation(Required=false)]
                public long? Timestamp { get; set; }

                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

            [NameInMap("wikis")]
            [Validation(Required=false)]
            public List<RetrieveResponseBodyResultWikis> Wikis { get; set; }
            public class RetrieveResponseBodyResultWikis : TeaModel {
                [NameInMap("corpId")]
                [Validation(Required=false)]
                public long? CorpId { get; set; }

                [NameInMap("icon")]
                [Validation(Required=false)]
                public string Icon { get; set; }

                [NameInMap("matchIntimacy")]
                [Validation(Required=false)]
                public bool? MatchIntimacy { get; set; }

                [NameInMap("material")]
                [Validation(Required=false)]
                public string Material { get; set; }

                [NameInMap("refType")]
                [Validation(Required=false)]
                public string RefType { get; set; }

                [NameInMap("score")]
                [Validation(Required=false)]
                public double? Score { get; set; }

                [NameInMap("scoreItem")]
                [Validation(Required=false)]
                public RetrieveResponseBodyResultWikisScoreItem ScoreItem { get; set; }
                public class RetrieveResponseBodyResultWikisScoreItem : TeaModel {
                    [NameInMap("finallyScore")]
                    [Validation(Required=false)]
                    public double? FinallyScore { get; set; }

                    [NameInMap("scoreMap")]
                    [Validation(Required=false)]
                    public Dictionary<string, double?> ScoreMap { get; set; }

                    [NameInMap("scoreThreshold")]
                    [Validation(Required=false)]
                    public double? ScoreThreshold { get; set; }

                    [NameInMap("selectedBranch")]
                    [Validation(Required=false)]
                    public List<string> SelectedBranch { get; set; }

                    [NameInMap("selectedCategory")]
                    [Validation(Required=false)]
                    public string SelectedCategory { get; set; }

                }

                [NameInMap("timestamp")]
                [Validation(Required=false)]
                public long? Timestamp { get; set; }

                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
