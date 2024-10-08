// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkassistant_1_0.Models
{
    public class AddDomainWordsRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("assistantId")]
        [Validation(Required=false)]
        public string AssistantId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("domainWords")]
        [Validation(Required=false)]
        public List<AddDomainWordsRequestDomainWords> DomainWords { get; set; }
        public class AddDomainWordsRequestDomainWords : TeaModel {
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("domainWord")]
            [Validation(Required=false)]
            public string DomainWord { get; set; }

            [NameInMap("formalWords")]
            [Validation(Required=false)]
            public List<string> FormalWords { get; set; }

        }

    }

}
