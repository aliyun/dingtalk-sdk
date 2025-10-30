// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class SendMessageRequest : TeaModel {
        [NameInMap("allow_comment")]
        [Validation(Required=false)]
        public bool? AllowComment { get; set; }

        [NameInMap("comment_type")]
        [Validation(Required=false)]
        public int? CommentType { get; set; }

        [NameInMap("dep_id_list")]
        [Validation(Required=false)]
        public List<long?> DepIdList { get; set; }

        [NameInMap("is_preview")]
        [Validation(Required=false)]
        public bool? IsPreview { get; set; }

        [NameInMap("is_to_all")]
        [Validation(Required=false)]
        public bool? IsToAll { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>P16mHftLYX8iE</para>
        /// </summary>
        [NameInMap("media_id")]
        [Validation(Required=false)]
        public string MediaId { get; set; }

        [NameInMap("msg_body")]
        [Validation(Required=false)]
        public SendMessageRequestMsgBody MsgBody { get; set; }
        public class SendMessageRequestMsgBody : TeaModel {
            [NameInMap("action_card")]
            [Validation(Required=false)]
            public SendMessageRequestMsgBodyActionCard ActionCard { get; set; }
            public class SendMessageRequestMsgBodyActionCard : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("btn_orientation")]
                [Validation(Required=false)]
                public string BtnOrientation { get; set; }

                [NameInMap("button_list")]
                [Validation(Required=false)]
                public List<SendMessageRequestMsgBodyActionCardButtonList> ButtonList { get; set; }
                public class SendMessageRequestMsgBodyActionCardButtonList : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>btn_action_url1</para>
                    /// </summary>
                    [NameInMap("action_url")]
                    [Validation(Required=false)]
                    public string ActionUrl { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>btn_title1</para>
                    /// </summary>
                    [NameInMap("title")]
                    [Validation(Required=false)]
                    public string Title { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>markdown text</para>
                /// </summary>
                [NameInMap("markdown")]
                [Validation(Required=false)]
                public string Markdown { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>single title</para>
                /// </summary>
                [NameInMap("single_title")]
                [Validation(Required=false)]
                public string SingleTitle { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="https://dingtalk.com">https://dingtalk.com</a></para>
                /// </summary>
                [NameInMap("single_url")]
                [Validation(Required=false)]
                public string SingleUrl { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>title</para>
                /// </summary>
                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

            }

            [NameInMap("link")]
            [Validation(Required=false)]
            public SendMessageRequestMsgBodyLink Link { get; set; }
            public class SendMessageRequestMsgBodyLink : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>P16mHftLYX8iE</para>
                /// </summary>
                [NameInMap("cover_image_media_id")]
                [Validation(Required=false)]
                public string CoverImageMediaId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="https://dingtalk.com">https://dingtalk.com</a></para>
                /// </summary>
                [NameInMap("link_url")]
                [Validation(Required=false)]
                public string LinkUrl { get; set; }

                [NameInMap("open_type")]
                [Validation(Required=false)]
                public int? OpenType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>描述信息</para>
                /// </summary>
                [NameInMap("summary")]
                [Validation(Required=false)]
                public string Summary { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>title</para>
                /// </summary>
                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

            }

            [NameInMap("markdown")]
            [Validation(Required=false)]
            public SendMessageRequestMsgBodyMarkdown Markdown { get; set; }
            public class SendMessageRequestMsgBodyMarkdown : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>markdown text</para>
                /// </summary>
                [NameInMap("text")]
                [Validation(Required=false)]
                public string Text { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>title</para>
                /// </summary>
                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>text</para>
        /// </summary>
        [NameInMap("msg_type")]
        [Validation(Required=false)]
        public string MsgType { get; set; }

        [NameInMap("roleIds")]
        [Validation(Required=false)]
        public List<long?> RoleIds { get; set; }

        [NameInMap("show_homepage")]
        [Validation(Required=false)]
        public int? ShowHomepage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>hello</para>
        /// </summary>
        [NameInMap("text_content")]
        [Validation(Required=false)]
        public string TextContent { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>jYdrJoCmTo0iE</para>
        /// </summary>
        [NameInMap("unionid")]
        [Validation(Required=false)]
        public string Unionid { get; set; }

        [NameInMap("userid_list")]
        [Validation(Required=false)]
        public List<string> UseridList { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>48566508-3f35</para>
        /// </summary>
        [NameInMap("uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

    }

}
