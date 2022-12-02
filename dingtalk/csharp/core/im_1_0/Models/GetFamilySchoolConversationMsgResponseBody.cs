// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkim_1_0.Models
{
    public class GetFamilySchoolConversationMsgResponseBody : TeaModel {
        /// <summary>
        /// 企业名称，corp123
        /// </summary>
        [NameInMap("corpId")]
        [Validation(Required=false)]
        public string CorpId { get; set; }

        /// <summary>
        /// 是否有更多数据
        /// </summary>
        [NameInMap("hasMore")]
        [Validation(Required=false)]
        public string HasMore { get; set; }

        /// <summary>
        /// 消息数据
        /// </summary>
        [NameInMap("messages")]
        [Validation(Required=false)]
        public List<GetFamilySchoolConversationMsgResponseBodyMessages> Messages { get; set; }
        public class GetFamilySchoolConversationMsgResponseBodyMessages : TeaModel {
            /// <summary>
            /// 消息类型，2-图片、202视频、3100富文本消息
            /// </summary>
            [NameInMap("contentType")]
            [Validation(Required=false)]
            public int? ContentType { get; set; }

            /// <summary>
            /// 消息的创建时间
            /// </summary>
            [NameInMap("createAt")]
            [Validation(Required=false)]
            public long? CreateAt { get; set; }

            /// <summary>
            /// media文件对象列表
            /// </summary>
            [NameInMap("mediaModels")]
            [Validation(Required=false)]
            public List<GetFamilySchoolConversationMsgResponseBodyMessagesMediaModels> MediaModels { get; set; }
            public class GetFamilySchoolConversationMsgResponseBodyMessagesMediaModels : TeaModel {
                /// <summary>
                /// 消息mediaId文件名称
                /// </summary>
                [NameInMap("fileName")]
                [Validation(Required=false)]
                public string FileName { get; set; }

                /// <summary>
                /// 消息mediaId文件类型
                /// </summary>
                [NameInMap("fileType")]
                [Validation(Required=false)]
                public string FileType { get; set; }

                /// <summary>
                /// 消息mediaId
                /// </summary>
                [NameInMap("mediaId")]
                [Validation(Required=false)]
                public string MediaId { get; set; }

                /// <summary>
                /// 消息mediaId文件大小
                /// </summary>
                [NameInMap("size")]
                [Validation(Required=false)]
                public string Size { get; set; }

                /// <summary>
                /// 消息mediaId对应的下载地址
                /// </summary>
                [NameInMap("url")]
                [Validation(Required=false)]
                public string Url { get; set; }

                /// <summary>
                /// 视频文件缩略图mediaId
                /// </summary>
                [NameInMap("videoPicMediaId")]
                [Validation(Required=false)]
                public string VideoPicMediaId { get; set; }

            }

            /// <summary>
            /// 消息的唯一标识
            /// </summary>
            [NameInMap("openMsgId")]
            [Validation(Required=false)]
            public string OpenMsgId { get; set; }

        }

        /// <summary>
        /// 查询下次消息的游标,时间毫秒值
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// 开放群Id
        /// </summary>
        [NameInMap("openConversationId")]
        [Validation(Required=false)]
        public string OpenConversationId { get; set; }

    }

}
