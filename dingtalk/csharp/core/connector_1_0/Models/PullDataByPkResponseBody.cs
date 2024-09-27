// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkconnector_1_0.Models
{
    public class PullDataByPkResponseBody : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("dataCreateAppId")]
        [Validation(Required=false)]
        public string DataCreateAppId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("dataCreateAppType")]
        [Validation(Required=false)]
        public string DataCreateAppType { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("dataGmtCreate")]
        [Validation(Required=false)]
        public long? DataGmtCreate { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("dataGmtModified")]
        [Validation(Required=false)]
        public long? DataGmtModified { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("dataModifiedAppId")]
        [Validation(Required=false)]
        public string DataModifiedAppId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("dataModifiedAppType")]
        [Validation(Required=false)]
        public string DataModifiedAppType { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("jsonData")]
        [Validation(Required=false)]
        public string JsonData { get; set; }

    }

}
