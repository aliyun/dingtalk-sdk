// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkim_1_0.Models
{
    public class CreateGroupFromOldGroupRequest : TeaModel {
        [NameInMap("notQuitWhenEmpLeave")]
        [Validation(Required=false)]
        public long? NotQuitWhenEmpLeave { get; set; }

        [NameInMap("srcCorpId")]
        [Validation(Required=false)]
        public string SrcCorpId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("srcOpenConversationId")]
        [Validation(Required=false)]
        public string SrcOpenConversationId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("templateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

    }

}
