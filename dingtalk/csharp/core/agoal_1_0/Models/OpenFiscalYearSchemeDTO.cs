// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkagoal_1_0.Models
{
    public class OpenFiscalYearSchemeDTO : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("enabled")]
        [Validation(Required=false)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>12起财年方案</para>
        /// </summary>
        [NameInMap("schemeName")]
        [Validation(Required=false)]
        public string SchemeName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>xxxxxxx</para>
        /// </summary>
        [NameInMap("schemeUid")]
        [Validation(Required=false)]
        public string SchemeUid { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>12</para>
        /// </summary>
        [NameInMap("startMonth")]
        [Validation(Required=false)]
        public long? StartMonth { get; set; }

        [NameInMap("subPeriodConfigs")]
        [Validation(Required=false)]
        public List<OpenFiscalYearSchemeDTOSubPeriodConfigs> SubPeriodConfigs { get; set; }
        public class OpenFiscalYearSchemeDTOSubPeriodConfigs : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("intervalMonth")]
            [Validation(Required=false)]
            public long? IntervalMonth { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>FY_HALF_YEAR</para>
            /// </summary>
            [NameInMap("subPeriodType")]
            [Validation(Required=false)]
            public string SubPeriodType { get; set; }

        }

    }

}
