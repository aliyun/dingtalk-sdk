// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class IndustryMmanufactureMaterialCostGetRequest : TeaModel {
        [NameInMap("appId")]
        [Validation(Required=false)]
        public long? AppId { get; set; }

        [NameInMap("appIds")]
        [Validation(Required=false)]
        public List<long?> AppIds { get; set; }

        [NameInMap("appName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("corpId")]
        [Validation(Required=false)]
        public string CorpId { get; set; }

        [NameInMap("cursor")]
        [Validation(Required=false)]
        public long? Cursor { get; set; }

        [NameInMap("endTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        [NameInMap("instanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("isvOrgId")]
        [Validation(Required=false)]
        public long? IsvOrgId { get; set; }

        [NameInMap("materialNo")]
        [Validation(Required=false)]
        public string MaterialNo { get; set; }

        [NameInMap("microappAgentId")]
        [Validation(Required=false)]
        public long? MicroappAgentId { get; set; }

        [NameInMap("orgId")]
        [Validation(Required=false)]
        public long? OrgId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("startTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        [NameInMap("suiteKey")]
        [Validation(Required=false)]
        public string SuiteKey { get; set; }

        [NameInMap("tokenGrantType")]
        [Validation(Required=false)]
        public int? TokenGrantType { get; set; }

    }

}
