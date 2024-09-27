// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkservice_group_1_0.Models
{
    public class DeleteKnowledgeRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>xuvw1245</para>
        /// </summary>
        [NameInMap("libraryKey")]
        [Validation(Required=false)]
        public string LibraryKey { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Js1i0w3k</para>
        /// </summary>
        [NameInMap("openTeamId")]
        [Validation(Required=false)]
        public string OpenTeamId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>CCM</para>
        /// </summary>
        [NameInMap("source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>CCM-123</para>
        /// </summary>
        [NameInMap("sourcePrimaryKey")]
        [Validation(Required=false)]
        public string SourcePrimaryKey { get; set; }

    }

}
