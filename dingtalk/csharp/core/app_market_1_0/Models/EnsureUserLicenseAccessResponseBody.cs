// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkapp_market_1_0.Models
{
    public class EnsureUserLicenseAccessResponseBody : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("allowed")]
        [Validation(Required=false)]
        public bool? Allowed { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>LICENSE_ASSIGNED_NOW</para>
        /// </summary>
        [NameInMap("decisionCode")]
        [Validation(Required=false)]
        public string DecisionCode { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("licenseAssigned")]
        [Validation(Required=false)]
        public bool? LicenseAssigned { get; set; }

    }

}
