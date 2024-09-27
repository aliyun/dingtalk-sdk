// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkbadge_1_0.Models
{
    public class CreateBadgeCodeUserInstanceResponseBody : TeaModel {
        [NameInMap("codeDetailUrl")]
        [Validation(Required=false)]
        public string CodeDetailUrl { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>codexxxxxx</para>
        /// </summary>
        [NameInMap("codeId")]
        [Validation(Required=false)]
        public string CodeId { get; set; }

    }

}
