// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class AddCustomRosterFieldRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("editFromEmployeeFlag")
    public Boolean editFromEmployeeFlag;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("fieldName")
    public String fieldName;

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

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("visibleByEmp")
    public Boolean visibleByEmp;

    public static AddCustomRosterFieldRequest build(java.util.Map<String, ?> map) throws Exception {
        AddCustomRosterFieldRequest self = new AddCustomRosterFieldRequest();
        return TeaModel.build(map, self);
    }

    public AddCustomRosterFieldRequest setEditFromEmployeeFlag(Boolean editFromEmployeeFlag) {
        this.editFromEmployeeFlag = editFromEmployeeFlag;
        return this;
    }
    public Boolean getEditFromEmployeeFlag() {
        return this.editFromEmployeeFlag;
    }

    public AddCustomRosterFieldRequest setFieldName(String fieldName) {
        this.fieldName = fieldName;
        return this;
    }
    public String getFieldName() {
        return this.fieldName;
    }

    public AddCustomRosterFieldRequest setFieldType(String fieldType) {
        this.fieldType = fieldType;
        return this;
    }
    public String getFieldType() {
        return this.fieldType;
    }

    public AddCustomRosterFieldRequest setGroupId(String groupId) {
        this.groupId = groupId;
        return this;
    }
    public String getGroupId() {
        return this.groupId;
    }

    public AddCustomRosterFieldRequest setHiddenFromEmployeeFlag(Boolean hiddenFromEmployeeFlag) {
        this.hiddenFromEmployeeFlag = hiddenFromEmployeeFlag;
        return this;
    }
    public Boolean getHiddenFromEmployeeFlag() {
        return this.hiddenFromEmployeeFlag;
    }

    public AddCustomRosterFieldRequest setHint(String hint) {
        this.hint = hint;
        return this;
    }
    public String getHint() {
        return this.hint;
    }

    public AddCustomRosterFieldRequest setNoWatermark(Boolean noWatermark) {
        this.noWatermark = noWatermark;
        return this;
    }
    public Boolean getNoWatermark() {
        return this.noWatermark;
    }

    public AddCustomRosterFieldRequest setNumberDecimalPlace(Integer numberDecimalPlace) {
        this.numberDecimalPlace = numberDecimalPlace;
        return this;
    }
    public Integer getNumberDecimalPlace() {
        return this.numberDecimalPlace;
    }

    public AddCustomRosterFieldRequest setNumberFormatType(String numberFormatType) {
        this.numberFormatType = numberFormatType;
        return this;
    }
    public String getNumberFormatType() {
        return this.numberFormatType;
    }

    public AddCustomRosterFieldRequest setNumberValueType(String numberValueType) {
        this.numberValueType = numberValueType;
        return this;
    }
    public String getNumberValueType() {
        return this.numberValueType;
    }

    public AddCustomRosterFieldRequest setOptionText(String optionText) {
        this.optionText = optionText;
        return this;
    }
    public String getOptionText() {
        return this.optionText;
    }

    public AddCustomRosterFieldRequest setRequired(Boolean required) {
        this.required = required;
        return this;
    }
    public Boolean getRequired() {
        return this.required;
    }

    public AddCustomRosterFieldRequest setVisibleByEmp(Boolean visibleByEmp) {
        this.visibleByEmp = visibleByEmp;
        return this;
    }
    public Boolean getVisibleByEmp() {
        return this.visibleByEmp;
    }

}
