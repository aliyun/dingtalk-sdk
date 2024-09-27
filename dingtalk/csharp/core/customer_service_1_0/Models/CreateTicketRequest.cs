// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcustomer_service_1_0.Models
{
    public class CreateTicketRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("foreignId")]
        [Validation(Required=false)]
        public string ForeignId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("foreignName")]
        [Validation(Required=false)]
        public string ForeignName { get; set; }

        [NameInMap("openInstanceId")]
        [Validation(Required=false)]
        public string OpenInstanceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("productionType")]
        [Validation(Required=false)]
        public int? ProductionType { get; set; }

        [NameInMap("properties")]
        [Validation(Required=false)]
        public List<CreateTicketRequestProperties> Properties { get; set; }
        public class CreateTicketRequestProperties : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>字段名称</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>字段取值</para>
            /// </summary>
            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("sourceId")]
        [Validation(Required=false)]
        public string SourceId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("templateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

    }

}
