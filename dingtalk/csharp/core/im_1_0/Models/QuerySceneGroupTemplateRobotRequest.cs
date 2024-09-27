// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkim_1_0.Models
{
    public class QuerySceneGroupTemplateRobotRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>cidCtneF+XyQjcyF2ROdgSeIg==</para>
        /// </summary>
        [NameInMap("openConversationId")]
        [Validation(Required=false)]
        public string OpenConversationId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ding5nbbeXXXXXXX</para>
        /// </summary>
        [NameInMap("robotCode")]
        [Validation(Required=false)]
        public string RobotCode { get; set; }

    }

}
