// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class CardQueryCardFeedsResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public CardQueryCardFeedsResponseBodyResult Result { get; set; }
        public class CardQueryCardFeedsResponseBodyResult : TeaModel {
            [NameInMap("hasMore")]
            [Validation(Required=false)]
            public bool? HasMore { get; set; }

            [NameInMap("posts")]
            [Validation(Required=false)]
            public List<CardQueryCardFeedsResponseBodyResultPosts> Posts { get; set; }
            public class CardQueryCardFeedsResponseBodyResultPosts : TeaModel {
                [NameInMap("author")]
                [Validation(Required=false)]
                public CardQueryCardFeedsResponseBodyResultPostsAuthor Author { get; set; }
                public class CardQueryCardFeedsResponseBodyResultPostsAuthor : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>博澜爸爸</para>
                    /// </summary>
                    [NameInMap("showName")]
                    [Validation(Required=false)]
                    public string ShowName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>234234234</para>
                    /// </summary>
                    [NameInMap("userId")]
                    [Validation(Required=false)]
                    public string UserId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>guardian</para>
                    /// </summary>
                    [NameInMap("userRole")]
                    [Validation(Required=false)]
                    public string UserRole { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("bizType")]
                [Validation(Required=false)]
                public int? BizType { get; set; }

                [NameInMap("content")]
                [Validation(Required=false)]
                public CardQueryCardFeedsResponseBodyResultPostsContent Content { get; set; }
                public class CardQueryCardFeedsResponseBodyResultPostsContent : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("contentType")]
                    [Validation(Required=false)]
                    public int? ContentType { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>{&quot;cardEditRedirectDTO&quot;:{&quot;jumpType&quot;:&quot;internal&quot;},&quot;content&quot;:&quot;测试&quot;,&quot;medias&quot;:&quot;\&quot;[{\\\&quot;type\\\&quot;:\\\&quot;image\\\&quot;,\\\&quot;data\\\&quot;:{\\\&quot;mediaUrl\\\&quot;:\\\&quot;<a href="https://static.dingtalk.com/media/lQDPNDWzHQNv3fjNBQDNAlCwKIvuyoJrOfAFLEMmYrpsAA_592_1280.jpg%5C%5C%5C%5C%5C%5C%5C%22,%5C%5C%5C%5C%5C%5C%5C%22thumbnailUrl%5C%5C%5C%5C%5C%5C%5C%22:%5C%5C%5C%5C%5C%5C%5C%22https://static.dingtalk.com/media/lQDPNDWzHQNv3fjNBQDNAlCwKIvuyoJrOfAFLEMmYrpsAA_592_1280.jpg_200x200.jpg?bizType=edu_card%5C%5C%5C%5C%5C%5C%5C%22%7D%7D%5D%5C%5C%5C%22%5C%22,%5C%22reissueCard%5C%22:false,%5C%22resultEvaluation%5C%22:%5C%22%5C%22,%5C%22showName%5C%22:%5C%22%E5%8D%9A%E6%BE%9C%E7%88%B8%E7%88%B8%5C%22,%5C%22sourceType%5C%22:%5C%22%5C%22,%5C%22studentId%5C%22:%5C%223000000000847390208%5C%22,%5C%22unitOfMeasurement%5C%22:%5C%22%5C%22%7D">https://static.dingtalk.com/media/lQDPNDWzHQNv3fjNBQDNAlCwKIvuyoJrOfAFLEMmYrpsAA_592_1280.jpg\\\\\\\&quot;,\\\\\\\&quot;thumbnailUrl\\\\\\\&quot;:\\\\\\\&quot;https://static.dingtalk.com/media/lQDPNDWzHQNv3fjNBQDNAlCwKIvuyoJrOfAFLEMmYrpsAA_592_1280.jpg_200x200.jpg?bizType=edu_card\\\\\\\&quot;}}]\\\&quot;\&quot;,\&quot;reissueCard\&quot;:false,\&quot;resultEvaluation\&quot;:\&quot;\&quot;,\&quot;showName\&quot;:\&quot;博澜爸爸\&quot;,\&quot;sourceType\&quot;:\&quot;\&quot;,\&quot;studentId\&quot;:\&quot;3000000000847390208\&quot;,\&quot;unitOfMeasurement\&quot;:\&quot;\&quot;}</a></para>
                    /// </summary>
                    [NameInMap("text")]
                    [Validation(Required=false)]
                    public string Text { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>23424234234</para>
                /// </summary>
                [NameInMap("createAt")]
                [Validation(Required=false)]
                public long? CreateAt { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("feedType")]
                [Validation(Required=false)]
                public int? FeedType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>232423423</para>
                /// </summary>
                [NameInMap("postId")]
                [Validation(Required=false)]
                public long? PostId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

            }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
