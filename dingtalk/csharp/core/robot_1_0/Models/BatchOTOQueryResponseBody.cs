// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkrobot_1_0.Models
{
    public class BatchOTOQueryResponseBody : TeaModel {
        [NameInMap("messageReadInfoList")]
        [Validation(Required=false)]
        public List<BatchOTOQueryResponseBodyMessageReadInfoList> MessageReadInfoList { get; set; }
        public class BatchOTOQueryResponseBodyMessageReadInfoList : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>曲大岳</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>READ</para>
            /// </summary>
            [NameInMap("readStatus")]
            [Validation(Required=false)]
            public string ReadStatus { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1433138400000</para>
            /// </summary>
            [NameInMap("readTimestamp")]
            [Validation(Required=false)]
            public long? ReadTimestamp { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>201382020</para>
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>SUCESS</para>
        /// </summary>
        [NameInMap("sendStatus")]
        [Validation(Required=false)]
        public string SendStatus { get; set; }

    }

}
