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
                /// <summary>
                /// <b>Example:</b>
                /// <para>industry_center</para>
                /// </summary>
                [NameInMap("cardBizCode")]
                [Validation(Required=false)]
                public string CardBizCode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>234234234</para>
                /// </summary>
                [NameInMap("cardId")]
                [Validation(Required=false)]
                public long? CardId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("cardStatus")]
                [Validation(Required=false)]
                public int? CardStatus { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>打卡任务</para>
                /// </summary>
                [NameInMap("content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>dingdf19b4ee0d73233735c2f4657eb6378f</para>
                /// </summary>
                [NameInMap("corpId")]
                [Validation(Required=false)]
                public string CorpId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2023-11-16</para>
                /// </summary>
                [NameInMap("effectTime")]
                [Validation(Required=false)]
                public string EffectTime { get; set; }

                [NameInMap("finished")]
                [Validation(Required=false)]
                public bool? Finished { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2023-11-19</para>
                /// </summary>
                [NameInMap("gmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2023-11-16</para>
                /// </summary>
                [NameInMap("optEndTime")]
                [Validation(Required=false)]
                public string OptEndTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>234234234</para>
                /// </summary>
                [NameInMap("optEndUserId")]
                [Validation(Required=false)]
                public string OptEndUserId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>张三</para>
                /// </summary>
                [NameInMap("optEndUserName")]
                [Validation(Required=false)]
                public string OptEndUserName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2023-11-16</para>
                /// </summary>
                [NameInMap("sendTime")]
                [Validation(Required=false)]
                public string SendTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2023-11-16</para>
                /// </summary>
                [NameInMap("startTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>23234234</para>
                /// </summary>
                [NameInMap("teacherId")]
                [Validation(Required=false)]
                public string TeacherId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>张三</para>
                /// </summary>
                [NameInMap("teacherName")]
                [Validation(Required=false)]
                public string TeacherName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>每日锻炼</para>
                /// </summary>
                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
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
