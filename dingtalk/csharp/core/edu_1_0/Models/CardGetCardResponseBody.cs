// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class CardGetCardResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public CardGetCardResponseBodyResult Result { get; set; }
        public class CardGetCardResponseBodyResult : TeaModel {
            [NameInMap("attr")]
            [Validation(Required=false)]
            public string Attr { get; set; }

            [NameInMap("cardBizCode")]
            [Validation(Required=false)]
            public string CardBizCode { get; set; }

            [NameInMap("cardBizId")]
            [Validation(Required=false)]
            public string CardBizId { get; set; }

            [NameInMap("cardContentCount")]
            [Validation(Required=false)]
            public int? CardContentCount { get; set; }

            [NameInMap("cardCycle")]
            [Validation(Required=false)]
            public int? CardCycle { get; set; }

            [NameInMap("cardFrequency")]
            [Validation(Required=false)]
            public List<int?> CardFrequency { get; set; }

            [NameInMap("cardId")]
            [Validation(Required=false)]
            public long? CardId { get; set; }

            [NameInMap("cardStatus")]
            [Validation(Required=false)]
            public int? CardStatus { get; set; }

            [NameInMap("cardUrl")]
            [Validation(Required=false)]
            public string CardUrl { get; set; }

            [NameInMap("categoryContentTag")]
            [Validation(Required=false)]
            public string CategoryContentTag { get; set; }

            [NameInMap("categoryCoverImageUrl")]
            [Validation(Required=false)]
            public string CategoryCoverImageUrl { get; set; }

            [NameInMap("categoryCreateCardSmallImageUrl")]
            [Validation(Required=false)]
            public string CategoryCreateCardSmallImageUrl { get; set; }

            [NameInMap("categoryListSmallImageUrl")]
            [Validation(Required=false)]
            public string CategoryListSmallImageUrl { get; set; }

            [NameInMap("categoryName")]
            [Validation(Required=false)]
            public string CategoryName { get; set; }

            [NameInMap("classIds")]
            [Validation(Required=false)]
            public List<string> ClassIds { get; set; }

            [NameInMap("classNames")]
            [Validation(Required=false)]
            public List<string> ClassNames { get; set; }

            [NameInMap("content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            [NameInMap("corpId")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            [NameInMap("effectTime")]
            [Validation(Required=false)]
            public long? EffectTime { get; set; }

            [NameInMap("finished")]
            [Validation(Required=false)]
            public bool? Finished { get; set; }

            [NameInMap("media")]
            [Validation(Required=false)]
            public string Media { get; set; }

            [NameInMap("optEndTime")]
            [Validation(Required=false)]
            public long? OptEndTime { get; set; }

            [NameInMap("optEndUserId")]
            [Validation(Required=false)]
            public string OptEndUserId { get; set; }

            [NameInMap("optEndUserName")]
            [Validation(Required=false)]
            public string OptEndUserName { get; set; }

            [NameInMap("remindNotPunchCardHour")]
            [Validation(Required=false)]
            public int? RemindNotPunchCardHour { get; set; }

            [NameInMap("remindNotPunchCardMinute")]
            [Validation(Required=false)]
            public int? RemindNotPunchCardMinute { get; set; }

            [NameInMap("sendTime")]
            [Validation(Required=false)]
            public long? SendTime { get; set; }

            [NameInMap("sourceType")]
            [Validation(Required=false)]
            public string SourceType { get; set; }

            [NameInMap("startTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            [NameInMap("status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            [NameInMap("systemTime")]
            [Validation(Required=false)]
            public long? SystemTime { get; set; }

            [NameInMap("teacherId")]
            [Validation(Required=false)]
            public string TeacherId { get; set; }

            [NameInMap("teacherName")]
            [Validation(Required=false)]
            public string TeacherName { get; set; }

            [NameInMap("templateCoverImageUrl")]
            [Validation(Required=false)]
            public string TemplateCoverImageUrl { get; set; }

            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            [NameInMap("type")]
            [Validation(Required=false)]
            public int? Type { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
