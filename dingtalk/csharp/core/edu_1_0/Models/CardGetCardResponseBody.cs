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
            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="http://www.dingtalk.com">www.dingtalk.com</a></para>
            /// </summary>
            [NameInMap("attr")]
            [Validation(Required=false)]
            public string Attr { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>industry_center</para>
            /// </summary>
            [NameInMap("cardBizCode")]
            [Validation(Required=false)]
            public string CardBizCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>23424234</para>
            /// </summary>
            [NameInMap("cardBizId")]
            [Validation(Required=false)]
            public string CardBizId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("cardContentCount")]
            [Validation(Required=false)]
            public int? CardContentCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("cardCycle")]
            [Validation(Required=false)]
            public int? CardCycle { get; set; }

            [NameInMap("cardFrequency")]
            [Validation(Required=false)]
            public List<int?> CardFrequency { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>234234234324</para>
            /// </summary>
            [NameInMap("cardId")]
            [Validation(Required=false)]
            public long? CardId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("cardStatus")]
            [Validation(Required=false)]
            public int? CardStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="http://www.dingtalk.com">www.dingtalk.com</a></para>
            /// </summary>
            [NameInMap("cardUrl")]
            [Validation(Required=false)]
            public string CardUrl { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>音乐</para>
            /// </summary>
            [NameInMap("categoryContentTag")]
            [Validation(Required=false)]
            public string CategoryContentTag { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="http://www.dingtalk.com">www.dingtalk.com</a></para>
            /// </summary>
            [NameInMap("categoryCoverImageUrl")]
            [Validation(Required=false)]
            public string CategoryCoverImageUrl { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="http://www.dingtalk.com">www.dingtalk.com</a></para>
            /// </summary>
            [NameInMap("categoryCreateCardSmallImageUrl")]
            [Validation(Required=false)]
            public string CategoryCreateCardSmallImageUrl { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="http://www.dingtalk.com">www.dingtalk.com</a></para>
            /// </summary>
            [NameInMap("categoryListSmallImageUrl")]
            [Validation(Required=false)]
            public string CategoryListSmallImageUrl { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>美术</para>
            /// </summary>
            [NameInMap("categoryName")]
            [Validation(Required=false)]
            public string CategoryName { get; set; }

            [NameInMap("classIds")]
            [Validation(Required=false)]
            public List<string> ClassIds { get; set; }

            [NameInMap("classNames")]
            [Validation(Required=false)]
            public List<string> ClassNames { get; set; }

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
            /// <para>2023-11-15</para>
            /// </summary>
            [NameInMap("effectTime")]
            [Validation(Required=false)]
            public string EffectTime { get; set; }

            [NameInMap("finished")]
            [Validation(Required=false)]
            public bool? Finished { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="http://www.dingtalk.com">www.dingtalk.com</a></para>
            /// </summary>
            [NameInMap("media")]
            [Validation(Required=false)]
            public string Media { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2023-11-15</para>
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
            /// <para>20</para>
            /// </summary>
            [NameInMap("remindNotPunchCardHour")]
            [Validation(Required=false)]
            public int? RemindNotPunchCardHour { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("remindNotPunchCardMinute")]
            [Validation(Required=false)]
            public int? RemindNotPunchCardMinute { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2023-11-15</para>
            /// </summary>
            [NameInMap("sendTime")]
            [Validation(Required=false)]
            public string SendTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>YUFANAI</para>
            /// </summary>
            [NameInMap("sourceType")]
            [Validation(Required=false)]
            public string SourceType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2023-11-15</para>
            /// </summary>
            [NameInMap("startTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>424234324324</para>
            /// </summary>
            [NameInMap("systemTime")]
            [Validation(Required=false)]
            public long? SystemTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>234234234</para>
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
            /// <para><a href="http://www.dingtalk.com">www.dingtalk.com</a></para>
            /// </summary>
            [NameInMap("templateCoverImageUrl")]
            [Validation(Required=false)]
            public string TemplateCoverImageUrl { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>每日复习</para>
            /// </summary>
            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public int? Type { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
