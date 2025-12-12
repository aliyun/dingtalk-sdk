// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkhrm_1_0.Models
{
    public class AddCustomRosterFieldRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("editFromEmployeeFlag")]
        [Validation(Required=false)]
        public bool? EditFromEmployeeFlag { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("fieldName")]
        [Validation(Required=false)]
        public string FieldName { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("fieldType")]
        [Validation(Required=false)]
        public string FieldType { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("groupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("hiddenFromEmployeeFlag")]
        [Validation(Required=false)]
        public bool? HiddenFromEmployeeFlag { get; set; }

        [NameInMap("hint")]
        [Validation(Required=false)]
        public string Hint { get; set; }

        [NameInMap("noWatermark")]
        [Validation(Required=false)]
        public bool? NoWatermark { get; set; }

        [NameInMap("numberDecimalPlace")]
        [Validation(Required=false)]
        public int? NumberDecimalPlace { get; set; }

        [NameInMap("numberFormatType")]
        [Validation(Required=false)]
        public string NumberFormatType { get; set; }

        [NameInMap("numberValueType")]
        [Validation(Required=false)]
        public string NumberValueType { get; set; }

        [NameInMap("optionText")]
        [Validation(Required=false)]
        public string OptionText { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("required")]
        [Validation(Required=false)]
        public bool? Required { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("visibleByEmp")]
        [Validation(Required=false)]
        public bool? VisibleByEmp { get; set; }

    }

}
