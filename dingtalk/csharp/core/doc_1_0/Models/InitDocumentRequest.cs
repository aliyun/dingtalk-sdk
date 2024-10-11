// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdoc_1_0.Models
{
    public class InitDocumentRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>attachments_key</para>
        /// </summary>
        [NameInMap("attachmentsKey")]
        [Validation(Required=false)]
        public string AttachmentsKey { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>attachments_map</para>
        /// </summary>
        [NameInMap("attachmentsMap")]
        [Validation(Required=false)]
        public Dictionary<string, AttachmentsMapValue> AttachmentsMap { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>import_type</para>
        /// </summary>
        [NameInMap("importType")]
        [Validation(Required=false)]
        public int? ImportType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>links_key</para>
        /// </summary>
        [NameInMap("linksKey")]
        [Validation(Required=false)]
        public string LinksKey { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>union_id</para>
        /// </summary>
        [NameInMap("operatorId")]
        [Validation(Required=false)]
        public string OperatorId { get; set; }

    }

}
