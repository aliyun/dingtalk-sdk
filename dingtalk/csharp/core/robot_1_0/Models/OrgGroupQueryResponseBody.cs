// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkrobot_1_0.Models
{
    public class OrgGroupQueryResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("hasMore")]
        [Validation(Required=false)]
        public bool? HasMore { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Kna29Ra5pdJznx1ghavbumkQKwDzgfxZLapw55G7x0Q=</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("readUserIds")]
        [Validation(Required=false)]
        public List<string> ReadUserIds { get; set; }

        [NameInMap("readUsers")]
        [Validation(Required=false)]
        public List<OrgGroupQueryResponseBodyReadUsers> ReadUsers { get; set; }
        public class OrgGroupQueryResponseBodyReadUsers : TeaModel {
            [NameInMap("unionId")]
            [Validation(Required=false)]
            public string UnionId { get; set; }

            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("sendStatus")]
        [Validation(Required=false)]
        public string SendStatus { get; set; }

    }

}
