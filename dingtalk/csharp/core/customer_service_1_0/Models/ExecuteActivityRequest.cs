// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcustomer_service_1_0.Models
{
    public class ExecuteActivityRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("activityCode")]
        [Validation(Required=false)]
        public string ActivityCode { get; set; }

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

        /// <summary>
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
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
        public List<ExecuteActivityRequestProperties> Properties { get; set; }
        public class ExecuteActivityRequestProperties : TeaModel {
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dcd6cb6b-b537-493c-8953-3507700e9c4b</para>
        /// </summary>
        [NameInMap("sourceId")]
        [Validation(Required=false)]
        public string SourceId { get; set; }

    }

}
