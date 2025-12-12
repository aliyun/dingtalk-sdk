// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkhrm_1_0.Models
{
    public class UpdateCustomRosterFieldRequest : TeaModel {
        [NameInMap("contactClientFlag")]
        [Validation(Required=false)]
        public bool? ContactClientFlag { get; set; }

        [NameInMap("contactFlag")]
        [Validation(Required=false)]
        public bool? ContactFlag { get; set; }

        [NameInMap("contactSource")]
        [Validation(Required=false)]
        public int? ContactSource { get; set; }

        [NameInMap("contactSystemFlag")]
        [Validation(Required=false)]
        public bool? ContactSystemFlag { get; set; }

        [NameInMap("deleted")]
        [Validation(Required=false)]
        public bool? Deleted { get; set; }

        [NameInMap("derived")]
        [Validation(Required=false)]
        public bool? Derived { get; set; }

        [NameInMap("disabled")]
        [Validation(Required=false)]
        public int? Disabled { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("editFromEmployeeFlag")]
        [Validation(Required=false)]
        public bool? EditFromEmployeeFlag { get; set; }

        [NameInMap("editableByHr")]
        [Validation(Required=false)]
        public bool? EditableByHr { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("fieldCode")]
        [Validation(Required=false)]
        public string FieldCode { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("fieldName")]
        [Validation(Required=false)]
        public string FieldName { get; set; }

        [NameInMap("fieldTip")]
        [Validation(Required=false)]
        public string FieldTip { get; set; }

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

        [NameInMap("historyField")]
        [Validation(Required=false)]
        public bool? HistoryField { get; set; }

        [NameInMap("index")]
        [Validation(Required=false)]
        public int? Index { get; set; }

        [NameInMap("modifyOptions")]
        [Validation(Required=false)]
        public bool? ModifyOptions { get; set; }

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

        [NameInMap("sourceFieldCode")]
        [Validation(Required=false)]
        public string SourceFieldCode { get; set; }

        [NameInMap("systemFlag")]
        [Validation(Required=false)]
        public bool? SystemFlag { get; set; }

        [NameInMap("textToSelectField")]
        [Validation(Required=false)]
        public bool? TextToSelectField { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("updateUserId")]
        [Validation(Required=false)]
        public string UpdateUserId { get; set; }

        [NameInMap("value")]
        [Validation(Required=false)]
        public string Value { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("visibleByEmp")]
        [Validation(Required=false)]
        public bool? VisibleByEmp { get; set; }

    }

}
