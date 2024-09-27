// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkrobot_1_0.Models
{
    public class OrgGroupQueryRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cid6KeBBLoveMJOGXoYKF5x7EeiodoA==</para>
        /// </summary>
        [NameInMap("openConversationId")]
        [Validation(Required=false)]
        public string OpenConversationId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Kna29Ra5pdJznx1ghavbumkQKwDzgfxZLapw55G7x0Q=</para>
        /// </summary>
        [NameInMap("processQueryKey")]
        [Validation(Required=false)]
        public string ProcessQueryKey { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>dingue4kfzdxbyn0pjqd</para>
        /// </summary>
        [NameInMap("robotCode")]
        [Validation(Required=false)]
        public string RobotCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>02feb1cd4ncmed92998723813a6bfa89eea1df91a750721979992870dd90bdfa</para>
        /// </summary>
        [NameInMap("token")]
        [Validation(Required=false)]
        public string Token { get; set; }

    }

}
