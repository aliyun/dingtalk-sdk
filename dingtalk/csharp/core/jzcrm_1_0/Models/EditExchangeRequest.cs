// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkjzcrm_1_0.Models
{
    public class EditExchangeRequest : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public EditExchangeRequestData Data { get; set; }
        public class EditExchangeRequestData : TeaModel {
            [NameInMap("child_mx")]
            [Validation(Required=false)]
            public string ChildMx { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("data_userid")]
            [Validation(Required=false)]
            public string DataUserid { get; set; }

            [NameInMap("hh_customerid")]
            [Validation(Required=false)]
            public string HhCustomerid { get; set; }

            [NameInMap("hh_date")]
            [Validation(Required=false)]
            public string HhDate { get; set; }

            [NameInMap("hh_inempid")]
            [Validation(Required=false)]
            public string HhInempid { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("hh_inlibid")]
            [Validation(Required=false)]
            public string HhInlibid { get; set; }

            [NameInMap("hh_intime")]
            [Validation(Required=false)]
            public string HhIntime { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("hh_number")]
            [Validation(Required=false)]
            public string HhNumber { get; set; }

            [NameInMap("hh_orderid")]
            [Validation(Required=false)]
            public string HhOrderid { get; set; }

            [NameInMap("hh_outempid")]
            [Validation(Required=false)]
            public string HhOutempid { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("hh_outlibid")]
            [Validation(Required=false)]
            public string HhOutlibid { get; set; }

            [NameInMap("hh_outtime")]
            [Validation(Required=false)]
            public string HhOuttime { get; set; }

            [NameInMap("hh_remark")]
            [Validation(Required=false)]
            public string HhRemark { get; set; }

            [NameInMap("hh_state")]
            [Validation(Required=false)]
            public string HhState { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("hh_title")]
            [Validation(Required=false)]
            public string HhTitle { get; set; }

            [NameInMap("hh_type")]
            [Validation(Required=false)]
            public string HhType { get; set; }

        }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("datatype")]
        [Validation(Required=false)]
        public long? Datatype { get; set; }

        [NameInMap("msgid")]
        [Validation(Required=false)]
        public long? Msgid { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("stamp")]
        [Validation(Required=false)]
        public long? Stamp { get; set; }

    }

}
