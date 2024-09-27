// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkim_1_0.Models
{
    public class GetFamilySchoolConversationMsgResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>corp123</para>
        /// </summary>
        [NameInMap("corpId")]
        [Validation(Required=false)]
        public string CorpId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("hasMore")]
        [Validation(Required=false)]
        public string HasMore { get; set; }

        [NameInMap("messages")]
        [Validation(Required=false)]
        public List<GetFamilySchoolConversationMsgResponseBodyMessages> Messages { get; set; }
        public class GetFamilySchoolConversationMsgResponseBodyMessages : TeaModel {
            [NameInMap("contentType")]
            [Validation(Required=false)]
            public int? ContentType { get; set; }

            [NameInMap("createAt")]
            [Validation(Required=false)]
            public long? CreateAt { get; set; }

            [NameInMap("mediaModels")]
            [Validation(Required=false)]
            public List<GetFamilySchoolConversationMsgResponseBodyMessagesMediaModels> MediaModels { get; set; }
            public class GetFamilySchoolConversationMsgResponseBodyMessagesMediaModels : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>aa.png</para>
                /// </summary>
                [NameInMap("fileName")]
                [Validation(Required=false)]
                public string FileName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>png</para>
                /// </summary>
                [NameInMap("fileType")]
                [Validation(Required=false)]
                public string FileType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>@12xxx34</para>
                /// </summary>
                [NameInMap("mediaId")]
                [Validation(Required=false)]
                public string MediaId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1234</para>
                /// </summary>
                [NameInMap("size")]
                [Validation(Required=false)]
                public string Size { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="https://wukong-xxxx">https://wukong-xxxx</a></para>
                /// </summary>
                [NameInMap("url")]
                [Validation(Required=false)]
                public string Url { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>@12xx34</para>
                /// </summary>
                [NameInMap("videoPicMediaId")]
                [Validation(Required=false)]
                public string VideoPicMediaId { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>msgxxx</para>
            /// </summary>
            [NameInMap("openMsgId")]
            [Validation(Required=false)]
            public string OpenMsgId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1666671122000</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("openConversationId")]
        [Validation(Required=false)]
        public string OpenConversationId { get; set; }

    }

}
