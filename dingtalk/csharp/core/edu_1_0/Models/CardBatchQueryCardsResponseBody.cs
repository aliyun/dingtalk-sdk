// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class CardBatchQueryCardsResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public CardBatchQueryCardsResponseBodyResult Result { get; set; }
        public class CardBatchQueryCardsResponseBodyResult : TeaModel {
            [NameInMap("cards")]
            [Validation(Required=false)]
            public List<CardBatchQueryCardsResponseBodyResultCards> Cards { get; set; }
            public class CardBatchQueryCardsResponseBodyResultCards : TeaModel {
                [NameInMap("cardBizCode")]
                [Validation(Required=false)]
                public string CardBizCode { get; set; }

                [NameInMap("cardId")]
                [Validation(Required=false)]
                public long? CardId { get; set; }

                [NameInMap("cardStatus")]
                [Validation(Required=false)]
                public int? CardStatus { get; set; }

                [NameInMap("content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                [NameInMap("corpId")]
                [Validation(Required=false)]
                public string CorpId { get; set; }

                [NameInMap("effectTime")]
                [Validation(Required=false)]
                public string EffectTime { get; set; }

                [NameInMap("finished")]
                [Validation(Required=false)]
                public bool? Finished { get; set; }

                [NameInMap("gmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                [NameInMap("optEndTime")]
                [Validation(Required=false)]
                public string OptEndTime { get; set; }

                [NameInMap("optEndUserId")]
                [Validation(Required=false)]
                public string OptEndUserId { get; set; }

                [NameInMap("optEndUserName")]
                [Validation(Required=false)]
                public string OptEndUserName { get; set; }

                [NameInMap("sendTime")]
                [Validation(Required=false)]
                public string SendTime { get; set; }

                [NameInMap("startTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                [NameInMap("status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                [NameInMap("teacherId")]
                [Validation(Required=false)]
                public string TeacherId { get; set; }

                [NameInMap("teacherName")]
                [Validation(Required=false)]
                public string TeacherName { get; set; }

                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                [NameInMap("type")]
                [Validation(Required=false)]
                public int? Type { get; set; }

            }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
