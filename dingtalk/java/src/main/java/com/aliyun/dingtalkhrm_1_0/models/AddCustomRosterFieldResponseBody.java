// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class AddCustomRosterFieldResponseBody extends TeaModel {
    @NameInMap("dingOpenErrcode")
    public Integer dingOpenErrcode;

    @NameInMap("errorMsg")
    public String errorMsg;

    @NameInMap("result")
    public AddCustomRosterFieldResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static AddCustomRosterFieldResponseBody build(java.util.Map<String, ?> map) throws Exception {
        AddCustomRosterFieldResponseBody self = new AddCustomRosterFieldResponseBody();
        return TeaModel.build(map, self);
    }

    public AddCustomRosterFieldResponseBody setDingOpenErrcode(Integer dingOpenErrcode) {
        this.dingOpenErrcode = dingOpenErrcode;
        return this;
    }
    public Integer getDingOpenErrcode() {
        return this.dingOpenErrcode;
    }

    public AddCustomRosterFieldResponseBody setErrorMsg(String errorMsg) {
        this.errorMsg = errorMsg;
        return this;
    }
    public String getErrorMsg() {
        return this.errorMsg;
    }

    public AddCustomRosterFieldResponseBody setResult(AddCustomRosterFieldResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public AddCustomRosterFieldResponseBodyResult getResult() {
        return this.result;
    }

    public AddCustomRosterFieldResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class AddCustomRosterFieldResponseBodyResult extends TeaModel {
        @NameInMap("contactClientFlag")
        public Boolean contactClientFlag;

        @NameInMap("contactFlag")
        public Boolean contactFlag;

        @NameInMap("contactSource")
        public Integer contactSource;

        @NameInMap("contactSystemFlag")
        public Boolean contactSystemFlag;

        @NameInMap("deleted")
        public Boolean deleted;

        @NameInMap("derived")
        public Boolean derived;

        @NameInMap("disabled")
        public Integer disabled;

        @NameInMap("editFromEmployeeFlag")
        public Boolean editFromEmployeeFlag;

        @NameInMap("editableByHr")
        public Boolean editableByHr;

        @NameInMap("fieldCode")
        public String fieldCode;

        @NameInMap("fieldName")
        public String fieldName;

        @NameInMap("fieldTip")
        public String fieldTip;

        @NameInMap("fieldType")
        public String fieldType;

        @NameInMap("groupId")
        public String groupId;

        @NameInMap("hiddenFromEmployeeFlag")
        public Boolean hiddenFromEmployeeFlag;

        @NameInMap("hint")
        public String hint;

        @NameInMap("historyField")
        public Boolean historyField;

        @NameInMap("index")
        public Integer index;

        @NameInMap("modifyOptions")
        public Boolean modifyOptions;

        @NameInMap("noWatermark")
        public Boolean noWatermark;

        @NameInMap("numberDecimalPlace")
        public String numberDecimalPlace;

        @NameInMap("numberFormatType")
        public String numberFormatType;

        @NameInMap("numberValueType")
        public String numberValueType;

        @NameInMap("optionText")
        public String optionText;

        @NameInMap("required")
        public Boolean required;

        @NameInMap("sourceFieldCode")
        public String sourceFieldCode;

        @NameInMap("systemFlag")
        public Boolean systemFlag;

        @NameInMap("textToSelectField")
        public Boolean textToSelectField;

        @NameInMap("value")
        public String value;

        @NameInMap("visibleByEmp")
        public Boolean visibleByEmp;

        public static AddCustomRosterFieldResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            AddCustomRosterFieldResponseBodyResult self = new AddCustomRosterFieldResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public AddCustomRosterFieldResponseBodyResult setContactClientFlag(Boolean contactClientFlag) {
            this.contactClientFlag = contactClientFlag;
            return this;
        }
        public Boolean getContactClientFlag() {
            return this.contactClientFlag;
        }

        public AddCustomRosterFieldResponseBodyResult setContactFlag(Boolean contactFlag) {
            this.contactFlag = contactFlag;
            return this;
        }
        public Boolean getContactFlag() {
            return this.contactFlag;
        }

        public AddCustomRosterFieldResponseBodyResult setContactSource(Integer contactSource) {
            this.contactSource = contactSource;
            return this;
        }
        public Integer getContactSource() {
            return this.contactSource;
        }

        public AddCustomRosterFieldResponseBodyResult setContactSystemFlag(Boolean contactSystemFlag) {
            this.contactSystemFlag = contactSystemFlag;
            return this;
        }
        public Boolean getContactSystemFlag() {
            return this.contactSystemFlag;
        }

        public AddCustomRosterFieldResponseBodyResult setDeleted(Boolean deleted) {
            this.deleted = deleted;
            return this;
        }
        public Boolean getDeleted() {
            return this.deleted;
        }

        public AddCustomRosterFieldResponseBodyResult setDerived(Boolean derived) {
            this.derived = derived;
            return this;
        }
        public Boolean getDerived() {
            return this.derived;
        }

        public AddCustomRosterFieldResponseBodyResult setDisabled(Integer disabled) {
            this.disabled = disabled;
            return this;
        }
        public Integer getDisabled() {
            return this.disabled;
        }

        public AddCustomRosterFieldResponseBodyResult setEditFromEmployeeFlag(Boolean editFromEmployeeFlag) {
            this.editFromEmployeeFlag = editFromEmployeeFlag;
            return this;
        }
        public Boolean getEditFromEmployeeFlag() {
            return this.editFromEmployeeFlag;
        }

        public AddCustomRosterFieldResponseBodyResult setEditableByHr(Boolean editableByHr) {
            this.editableByHr = editableByHr;
            return this;
        }
        public Boolean getEditableByHr() {
            return this.editableByHr;
        }

        public AddCustomRosterFieldResponseBodyResult setFieldCode(String fieldCode) {
            this.fieldCode = fieldCode;
            return this;
        }
        public String getFieldCode() {
            return this.fieldCode;
        }

        public AddCustomRosterFieldResponseBodyResult setFieldName(String fieldName) {
            this.fieldName = fieldName;
            return this;
        }
        public String getFieldName() {
            return this.fieldName;
        }

        public AddCustomRosterFieldResponseBodyResult setFieldTip(String fieldTip) {
            this.fieldTip = fieldTip;
            return this;
        }
        public String getFieldTip() {
            return this.fieldTip;
        }

        public AddCustomRosterFieldResponseBodyResult setFieldType(String fieldType) {
            this.fieldType = fieldType;
            return this;
        }
        public String getFieldType() {
            return this.fieldType;
        }

        public AddCustomRosterFieldResponseBodyResult setGroupId(String groupId) {
            this.groupId = groupId;
            return this;
        }
        public String getGroupId() {
            return this.groupId;
        }

        public AddCustomRosterFieldResponseBodyResult setHiddenFromEmployeeFlag(Boolean hiddenFromEmployeeFlag) {
            this.hiddenFromEmployeeFlag = hiddenFromEmployeeFlag;
            return this;
        }
        public Boolean getHiddenFromEmployeeFlag() {
            return this.hiddenFromEmployeeFlag;
        }

        public AddCustomRosterFieldResponseBodyResult setHint(String hint) {
            this.hint = hint;
            return this;
        }
        public String getHint() {
            return this.hint;
        }

        public AddCustomRosterFieldResponseBodyResult setHistoryField(Boolean historyField) {
            this.historyField = historyField;
            return this;
        }
        public Boolean getHistoryField() {
            return this.historyField;
        }

        public AddCustomRosterFieldResponseBodyResult setIndex(Integer index) {
            this.index = index;
            return this;
        }
        public Integer getIndex() {
            return this.index;
        }

        public AddCustomRosterFieldResponseBodyResult setModifyOptions(Boolean modifyOptions) {
            this.modifyOptions = modifyOptions;
            return this;
        }
        public Boolean getModifyOptions() {
            return this.modifyOptions;
        }

        public AddCustomRosterFieldResponseBodyResult setNoWatermark(Boolean noWatermark) {
            this.noWatermark = noWatermark;
            return this;
        }
        public Boolean getNoWatermark() {
            return this.noWatermark;
        }

        public AddCustomRosterFieldResponseBodyResult setNumberDecimalPlace(String numberDecimalPlace) {
            this.numberDecimalPlace = numberDecimalPlace;
            return this;
        }
        public String getNumberDecimalPlace() {
            return this.numberDecimalPlace;
        }

        public AddCustomRosterFieldResponseBodyResult setNumberFormatType(String numberFormatType) {
            this.numberFormatType = numberFormatType;
            return this;
        }
        public String getNumberFormatType() {
            return this.numberFormatType;
        }

        public AddCustomRosterFieldResponseBodyResult setNumberValueType(String numberValueType) {
            this.numberValueType = numberValueType;
            return this;
        }
        public String getNumberValueType() {
            return this.numberValueType;
        }

        public AddCustomRosterFieldResponseBodyResult setOptionText(String optionText) {
            this.optionText = optionText;
            return this;
        }
        public String getOptionText() {
            return this.optionText;
        }

        public AddCustomRosterFieldResponseBodyResult setRequired(Boolean required) {
            this.required = required;
            return this;
        }
        public Boolean getRequired() {
            return this.required;
        }

        public AddCustomRosterFieldResponseBodyResult setSourceFieldCode(String sourceFieldCode) {
            this.sourceFieldCode = sourceFieldCode;
            return this;
        }
        public String getSourceFieldCode() {
            return this.sourceFieldCode;
        }

        public AddCustomRosterFieldResponseBodyResult setSystemFlag(Boolean systemFlag) {
            this.systemFlag = systemFlag;
            return this;
        }
        public Boolean getSystemFlag() {
            return this.systemFlag;
        }

        public AddCustomRosterFieldResponseBodyResult setTextToSelectField(Boolean textToSelectField) {
            this.textToSelectField = textToSelectField;
            return this;
        }
        public Boolean getTextToSelectField() {
            return this.textToSelectField;
        }

        public AddCustomRosterFieldResponseBodyResult setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

        public AddCustomRosterFieldResponseBodyResult setVisibleByEmp(Boolean visibleByEmp) {
            this.visibleByEmp = visibleByEmp;
            return this;
        }
        public Boolean getVisibleByEmp() {
            return this.visibleByEmp;
        }

    }

}
