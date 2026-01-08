// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class GetMsgRecordDetailResponseBody : TeaModel {
        [NameInMap("errmsg")]
        [Validation(Required=false)]
        public string Errmsg { get; set; }

        [NameInMap("errorcode")]
        [Validation(Required=false)]
        public string Errorcode { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public GetMsgRecordDetailResponseBodyResult Result { get; set; }
        public class GetMsgRecordDetailResponseBodyResult : TeaModel {
            [NameInMap("action_card")]
            [Validation(Required=false)]
            public GetMsgRecordDetailResponseBodyResultActionCard ActionCard { get; set; }
            public class GetMsgRecordDetailResponseBodyResultActionCard : TeaModel {
                [NameInMap("bnt_orientation")]
                [Validation(Required=false)]
                public string BntOrientation { get; set; }

                [NameInMap("button_list")]
                [Validation(Required=false)]
                public List<GetMsgRecordDetailResponseBodyResultActionCardButtonList> ButtonList { get; set; }
                public class GetMsgRecordDetailResponseBodyResultActionCardButtonList : TeaModel {
                    [NameInMap("action_url")]
                    [Validation(Required=false)]
                    public string ActionUrl { get; set; }

                    [NameInMap("title")]
                    [Validation(Required=false)]
                    public string Title { get; set; }

                }

                [NameInMap("markdown")]
                [Validation(Required=false)]
                public string Markdown { get; set; }

                [NameInMap("single_title")]
                [Validation(Required=false)]
                public string SingleTitle { get; set; }

                [NameInMap("single_url")]
                [Validation(Required=false)]
                public string SingleUrl { get; set; }

                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

            }

            [NameInMap("allow_comment")]
            [Validation(Required=false)]
            public bool? AllowComment { get; set; }

            [NameInMap("allow_forward")]
            [Validation(Required=false)]
            public bool? AllowForward { get; set; }

            [NameInMap("articles")]
            [Validation(Required=false)]
            public List<GetMsgRecordDetailResponseBodyResultArticles> Articles { get; set; }
            public class GetMsgRecordDetailResponseBodyResultArticles : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>129003</para>
                /// </summary>
                [NameInMap("article_id")]
                [Validation(Required=false)]
                public long? ArticleId { get; set; }

                [NameInMap("content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                [NameInMap("create_time")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                [NameInMap("digest")]
                [Validation(Required=false)]
                public string Digest { get; set; }

                [NameInMap("publish_status")]
                [Validation(Required=false)]
                public long? PublishStatus { get; set; }

                [NameInMap("publish_time")]
                [Validation(Required=false)]
                public long? PublishTime { get; set; }

                [NameInMap("thumb_media_id")]
                [Validation(Required=false)]
                public string ThumbMediaId { get; set; }

                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                [NameInMap("update_time")]
                [Validation(Required=false)]
                public long? UpdateTime { get; set; }

                [NameInMap("url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1766028831000</para>
            /// </summary>
            [NameInMap("create_time")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            [NameInMap("dep_id_list")]
            [Validation(Required=false)]
            public List<string> DepIdList { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("is_to_all")]
            [Validation(Required=false)]
            public bool? IsToAll { get; set; }

            [NameInMap("link")]
            [Validation(Required=false)]
            public GetMsgRecordDetailResponseBodyResultLink Link { get; set; }
            public class GetMsgRecordDetailResponseBodyResultLink : TeaModel {
                [NameInMap("cover_image_media_id")]
                [Validation(Required=false)]
                public string CoverImageMediaId { get; set; }

                [NameInMap("link_url")]
                [Validation(Required=false)]
                public string LinkUrl { get; set; }

                [NameInMap("open_type")]
                [Validation(Required=false)]
                public int? OpenType { get; set; }

                [NameInMap("summary")]
                [Validation(Required=false)]
                public string Summary { get; set; }

                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

            }

            [NameInMap("markdown")]
            [Validation(Required=false)]
            public GetMsgRecordDetailResponseBodyResultMarkdown Markdown { get; set; }
            public class GetMsgRecordDetailResponseBodyResultMarkdown : TeaModel {
                [NameInMap("text")]
                [Validation(Required=false)]
                public string Text { get; set; }

                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>@sdafgffxxrgdssa1123</para>
            /// </summary>
            [NameInMap("mediaId")]
            [Validation(Required=false)]
            public string MediaId { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>text</para>
            /// </summary>
            [NameInMap("msg_type")]
            [Validation(Required=false)]
            public string MsgType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2569131246</para>
            /// </summary>
            [NameInMap("operator_user_id")]
            [Validation(Required=false)]
            public string OperatorUserId { get; set; }

            [NameInMap("roleIdList")]
            [Validation(Required=false)]
            public List<string> RoleIdList { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1766028831000</para>
            /// </summary>
            [NameInMap("send_time")]
            [Validation(Required=false)]
            public long? SendTime { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pushkxQ2b2DTDAb0qkTjNdKLmwiEiE</para>
            /// </summary>
            [NameInMap("task_id")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>文本消息</para>
            /// </summary>
            [NameInMap("textContent")]
            [Validation(Required=false)]
            public string TextContent { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>文本消息</para>
            /// </summary>
            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            [NameInMap("userid_list")]
            [Validation(Required=false)]
            public List<string> UseridList { get; set; }

            [NameInMap("view_scope_type")]
            [Validation(Required=false)]
            public string ViewScopeType { get; set; }

        }

    }

}
