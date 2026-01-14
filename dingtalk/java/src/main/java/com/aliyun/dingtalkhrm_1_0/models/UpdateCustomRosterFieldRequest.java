// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class UpdateCustomRosterFieldRequest extends TeaModel {
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

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("editFromEmployeeFlag")
    public Boolean editFromEmployeeFlag;

    @NameInMap("editableByHr")
    public Boolean editableByHr;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("fieldCode")
    public String fieldCode;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("fieldName")
    public String fieldName;

    @NameInMap("fieldTip")
    public String fieldTip;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("fieldType")
    public String fieldType;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("groupId")
    public String groupId;

    /**
     * <p>This parameter is required.</p>
     */
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
    public Integer numberDecimalPlace;

    @NameInMap("numberFormatType")
    public String numberFormatType;

    @NameInMap("numberValueType")
    public String numberValueType;

    @NameInMap("optionText")
    public String optionText;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("required")
    public Boolean required;

    @NameInMap("sourceFieldCode")
    public String sourceFieldCode;

    @NameInMap("systemFlag")
    public Boolean systemFlag;

    @NameInMap("textToSelectField")
    public Boolean textToSelectField;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("updateUserId")
    public String updateUserId;

    @NameInMap("value")
    public String value;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("visibleByEmp")
    public Boolean visibleByEmp;

    public static UpdateCustomRosterFieldRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateCustomRosterFieldRequest self = new UpdateCustomRosterFieldRequest();
        return TeaModel.build(map, self);
    }

    public UpdateCustomRosterFieldRequest setContactClientFlag(Boolean contactClientFlag) {
        this.contactClientFlag = contactClientFlag;
        return this;
    }
    public Boolean getContactClientFlag() {
        return this.contactClientFlag;
    }

    public UpdateCustomRosterFieldRequest setContactFlag(Boolean contactFlag) {
        this.contactFlag = contactFlag;
        return this;
    }
    public Boolean getContactFlag() {
        return this.contactFlag;
    }

    public UpdateCustomRosterFieldRequest setContactSource(Integer contactSource) {
        this.contactSource = contactSource;
        return this;
    }
    public Integer getContactSource() {
        return this.contactSource;
    }

    public UpdateCustomRosterFieldRequest setContactSystemFlag(Boolean contactSystemFlag) {
        this.contactSystemFlag = contactSystemFlag;
        return this;
    }
    public Boolean getContactSystemFlag() {
        return this.contactSystemFlag;
    }

    public UpdateCustomRosterFieldRequest setDeleted(Boolean deleted) {
        this.deleted = deleted;
        return this;
    }
    public Boolean getDeleted() {
        return this.deleted;
    }

    public UpdateCustomRosterFieldRequest setDerived(Boolean derived) {
        this.derived = derived;
        return this;
    }
    public Boolean getDerived() {
        return this.derived;
    }

    public UpdateCustomRosterFieldRequest setDisabled(Integer disabled) {
        this.disabled = disabled;
        return this;
    }
    public Integer getDisabled() {
        return this.disabled;
    }

    public UpdateCustomRosterFieldRequest setEditFromEmployeeFlag(Boolean editFromEmployeeFlag) {
        this.editFromEmployeeFlag = editFromEmployeeFlag;
        return this;
    }
    public Boolean getEditFromEmployeeFlag() {
        return this.editFromEmployeeFlag;
    }

    public UpdateCustomRosterFieldRequest setEditableByHr(Boolean editableByHr) {
        this.editableByHr = editableByHr;
        return this;
    }
    public Boolean getEditableByHr() {
        return this.editableByHr;
    }

    public UpdateCustomRosterFieldRequest setFieldCode(String fieldCode) {
        this.fieldCode = fieldCode;
        return this;
    }
    public String getFieldCode() {
        return this.fieldCode;
    }

    public UpdateCustomRosterFieldRequest setFieldName(String fieldName) {
        this.fieldName = fieldName;
        return this;
    }
    public String getFieldName() {
        return this.fieldName;
    }

    public UpdateCustomRosterFieldRequest setFieldTip(String fieldTip) {
        this.fieldTip = fieldTip;
        return this;
    }
    public String getFieldTip() {
        return this.fieldTip;
    }

    public UpdateCustomRosterFieldRequest setFieldType(String fieldType) {
        this.fieldType = fieldType;
        return this;
    }
    public String getFieldType() {
        return this.fieldType;
    }

    public UpdateCustomRosterFieldRequest setGroupId(String groupId) {
        this.groupId = groupId;
        return this;
    }
    public String getGroupId() {
        return this.groupId;
    }

    public UpdateCustomRosterFieldRequest setHiddenFromEmployeeFlag(Boolean hiddenFromEmployeeFlag) {
        this.hiddenFromEmployeeFlag = hiddenFromEmployeeFlag;
        return this;
    }
    public Boolean getHiddenFromEmployeeFlag() {
        return this.hiddenFromEmployeeFlag;
    }

    public UpdateCustomRosterFieldRequest setHint(String hint) {
        this.hint = hint;
        return this;
    }
    public String getHint() {
        return this.hint;
    }

    public UpdateCustomRosterFieldRequest setHistoryField(Boolean historyField) {
        this.historyField = historyField;
        return this;
    }
    public Boolean getHistoryField() {
        return this.historyField;
    }

    public UpdateCustomRosterFieldRequest setIndex(Integer index) {
        this.index = index;
        return this;
    }
    public Integer getIndex() {
        return this.index;
    }

    public UpdateCustomRosterFieldRequest setModifyOptions(Boolean modifyOptions) {
        this.modifyOptions = modifyOptions;
        return this;
    }
    public Boolean getModifyOptions() {
        return this.modifyOptions;
    }

    public UpdateCustomRosterFieldRequest setNoWatermark(Boolean noWatermark) {
        this.noWatermark = noWatermark;
        return this;
    }
    public Boolean getNoWatermark() {
        return this.noWatermark;
    }

    public UpdateCustomRosterFieldRequest setNumberDecimalPlace(Integer numberDecimalPlace) {
        this.numberDecimalPlace = numberDecimalPlace;
        return this;
    }
    public Integer getNumberDecimalPlace() {
        return this.numberDecimalPlace;
    }

    public UpdateCustomRosterFieldRequest setNumberFormatType(String numberFormatType) {
        this.numberFormatType = numberFormatType;
        return this;
    }
    public String getNumberFormatType() {
        return this.numberFormatType;
    }

    public UpdateCustomRosterFieldRequest setNumberValueType(String numberValueType) {
        this.numberValueType = numberValueType;
        return this;
    }
    public String getNumberValueType() {
        return this.numberValueType;
    }

    public UpdateCustomRosterFieldRequest setOptionText(String optionText) {
        this.optionText = optionText;
        return this;
    }
    public String getOptionText() {
        return this.optionText;
    }

    public UpdateCustomRosterFieldRequest setRequired(Boolean required) {
        this.required = required;
        return this;
    }
    public Boolean getRequired() {
        return this.required;
    }

    public UpdateCustomRosterFieldRequest setSourceFieldCode(String sourceFieldCode) {
        this.sourceFieldCode = sourceFieldCode;
        return this;
    }
    public String getSourceFieldCode() {
        return this.sourceFieldCode;
    }

    public UpdateCustomRosterFieldRequest setSystemFlag(Boolean systemFlag) {
        this.systemFlag = systemFlag;
        return this;
    }
    public Boolean getSystemFlag() {
        return this.systemFlag;
    }

    public UpdateCustomRosterFieldRequest setTextToSelectField(Boolean textToSelectField) {
        this.textToSelectField = textToSelectField;
        return this;
    }
    public Boolean getTextToSelectField() {
        return this.textToSelectField;
    }

    public UpdateCustomRosterFieldRequest setUpdateUserId(String updateUserId) {
        this.updateUserId = updateUserId;
        return this;
    }
    public String getUpdateUserId() {
        return this.updateUserId;
    }

    public UpdateCustomRosterFieldRequest setValue(String value) {
        this.value = value;
        return this;
    }
    public String getValue() {
        return this.value;
    }

    public UpdateCustomRosterFieldRequest setVisibleByEmp(Boolean visibleByEmp) {
        this.visibleByEmp = visibleByEmp;
        return this;
    }
    public Boolean getVisibleByEmp() {
        return this.visibleByEmp;
    }

}
