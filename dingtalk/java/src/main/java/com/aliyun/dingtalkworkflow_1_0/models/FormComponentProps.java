// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class FormComponentProps extends TeaModel {
    @NameInMap("actionName")
    public String actionName;

    @NameInMap("addressModel")
    public String addressModel;

    @NameInMap("align")
    public String align;

    @NameInMap("asyncCondition")
    public Boolean asyncCondition;

    @NameInMap("availableTemplates")
    public java.util.List<AvaliableTemplate> availableTemplates;

    @NameInMap("bizAlias")
    public String bizAlias;

    @NameInMap("bizType")
    public String bizType;

    @NameInMap("choice")
    public String choice;

    @NameInMap("commonBizType")
    public String commonBizType;

    @NameInMap("componentId")
    public String componentId;

    @NameInMap("content")
    public String content;

    @NameInMap("dataSource")
    public FormDataSource dataSource;

    @NameInMap("disabled")
    public Boolean disabled;

    @NameInMap("duration")
    public Boolean duration;

    @NameInMap("durationLabel")
    public String durationLabel;

    @NameInMap("format")
    public String format;

    @NameInMap("formula")
    public String formula;

    @NameInMap("invisible")
    public Boolean invisible;

    @NameInMap("label")
    public String label;

    @NameInMap("limit")
    public Integer limit;

    @NameInMap("link")
    public String link;

    @NameInMap("maxLength")
    public Integer maxLength;

    @NameInMap("mode")
    public String mode;

    @NameInMap("multiple")
    public Boolean multiple;

    @NameInMap("options")
    public java.util.List<SelectOption> options;

    @NameInMap("placeholder")
    public String placeholder;

    @NameInMap("precision")
    public Integer precision;

    @NameInMap("print")
    public String print;

    @NameInMap("required")
    public Boolean required;

    @NameInMap("statField")
    public java.util.List<FormComponentPropsStatField> statField;

    @NameInMap("tableViewMode")
    public String tableViewMode;

    @NameInMap("unit")
    public String unit;

    @NameInMap("upper")
    public String upper;

    @NameInMap("verticalPrint")
    public Boolean verticalPrint;

    public static FormComponentProps build(java.util.Map<String, ?> map) throws Exception {
        FormComponentProps self = new FormComponentProps();
        return TeaModel.build(map, self);
    }

    public FormComponentProps setActionName(String actionName) {
        this.actionName = actionName;
        return this;
    }
    public String getActionName() {
        return this.actionName;
    }

    public FormComponentProps setAddressModel(String addressModel) {
        this.addressModel = addressModel;
        return this;
    }
    public String getAddressModel() {
        return this.addressModel;
    }

    public FormComponentProps setAlign(String align) {
        this.align = align;
        return this;
    }
    public String getAlign() {
        return this.align;
    }

    public FormComponentProps setAsyncCondition(Boolean asyncCondition) {
        this.asyncCondition = asyncCondition;
        return this;
    }
    public Boolean getAsyncCondition() {
        return this.asyncCondition;
    }

    public FormComponentProps setAvailableTemplates(java.util.List<AvaliableTemplate> availableTemplates) {
        this.availableTemplates = availableTemplates;
        return this;
    }
    public java.util.List<AvaliableTemplate> getAvailableTemplates() {
        return this.availableTemplates;
    }

    public FormComponentProps setBizAlias(String bizAlias) {
        this.bizAlias = bizAlias;
        return this;
    }
    public String getBizAlias() {
        return this.bizAlias;
    }

    public FormComponentProps setBizType(String bizType) {
        this.bizType = bizType;
        return this;
    }
    public String getBizType() {
        return this.bizType;
    }

    public FormComponentProps setChoice(String choice) {
        this.choice = choice;
        return this;
    }
    public String getChoice() {
        return this.choice;
    }

    public FormComponentProps setCommonBizType(String commonBizType) {
        this.commonBizType = commonBizType;
        return this;
    }
    public String getCommonBizType() {
        return this.commonBizType;
    }

    public FormComponentProps setComponentId(String componentId) {
        this.componentId = componentId;
        return this;
    }
    public String getComponentId() {
        return this.componentId;
    }

    public FormComponentProps setContent(String content) {
        this.content = content;
        return this;
    }
    public String getContent() {
        return this.content;
    }

    public FormComponentProps setDataSource(FormDataSource dataSource) {
        this.dataSource = dataSource;
        return this;
    }
    public FormDataSource getDataSource() {
        return this.dataSource;
    }

    public FormComponentProps setDisabled(Boolean disabled) {
        this.disabled = disabled;
        return this;
    }
    public Boolean getDisabled() {
        return this.disabled;
    }

    public FormComponentProps setDuration(Boolean duration) {
        this.duration = duration;
        return this;
    }
    public Boolean getDuration() {
        return this.duration;
    }

    public FormComponentProps setDurationLabel(String durationLabel) {
        this.durationLabel = durationLabel;
        return this;
    }
    public String getDurationLabel() {
        return this.durationLabel;
    }

    public FormComponentProps setFormat(String format) {
        this.format = format;
        return this;
    }
    public String getFormat() {
        return this.format;
    }

    public FormComponentProps setFormula(String formula) {
        this.formula = formula;
        return this;
    }
    public String getFormula() {
        return this.formula;
    }

    public FormComponentProps setInvisible(Boolean invisible) {
        this.invisible = invisible;
        return this;
    }
    public Boolean getInvisible() {
        return this.invisible;
    }

    public FormComponentProps setLabel(String label) {
        this.label = label;
        return this;
    }
    public String getLabel() {
        return this.label;
    }

    public FormComponentProps setLimit(Integer limit) {
        this.limit = limit;
        return this;
    }
    public Integer getLimit() {
        return this.limit;
    }

    public FormComponentProps setLink(String link) {
        this.link = link;
        return this;
    }
    public String getLink() {
        return this.link;
    }

    public FormComponentProps setMaxLength(Integer maxLength) {
        this.maxLength = maxLength;
        return this;
    }
    public Integer getMaxLength() {
        return this.maxLength;
    }

    public FormComponentProps setMode(String mode) {
        this.mode = mode;
        return this;
    }
    public String getMode() {
        return this.mode;
    }

    public FormComponentProps setMultiple(Boolean multiple) {
        this.multiple = multiple;
        return this;
    }
    public Boolean getMultiple() {
        return this.multiple;
    }

    public FormComponentProps setOptions(java.util.List<SelectOption> options) {
        this.options = options;
        return this;
    }
    public java.util.List<SelectOption> getOptions() {
        return this.options;
    }

    public FormComponentProps setPlaceholder(String placeholder) {
        this.placeholder = placeholder;
        return this;
    }
    public String getPlaceholder() {
        return this.placeholder;
    }

    public FormComponentProps setPrecision(Integer precision) {
        this.precision = precision;
        return this;
    }
    public Integer getPrecision() {
        return this.precision;
    }

    public FormComponentProps setPrint(String print) {
        this.print = print;
        return this;
    }
    public String getPrint() {
        return this.print;
    }

    public FormComponentProps setRequired(Boolean required) {
        this.required = required;
        return this;
    }
    public Boolean getRequired() {
        return this.required;
    }

    public FormComponentProps setStatField(java.util.List<FormComponentPropsStatField> statField) {
        this.statField = statField;
        return this;
    }
    public java.util.List<FormComponentPropsStatField> getStatField() {
        return this.statField;
    }

    public FormComponentProps setTableViewMode(String tableViewMode) {
        this.tableViewMode = tableViewMode;
        return this;
    }
    public String getTableViewMode() {
        return this.tableViewMode;
    }

    public FormComponentProps setUnit(String unit) {
        this.unit = unit;
        return this;
    }
    public String getUnit() {
        return this.unit;
    }

    public FormComponentProps setUpper(String upper) {
        this.upper = upper;
        return this;
    }
    public String getUpper() {
        return this.upper;
    }

    public FormComponentProps setVerticalPrint(Boolean verticalPrint) {
        this.verticalPrint = verticalPrint;
        return this;
    }
    public Boolean getVerticalPrint() {
        return this.verticalPrint;
    }

    public static class FormComponentPropsStatField extends TeaModel {
        @NameInMap("componentId")
        public String componentId;

        @NameInMap("label")
        public String label;

        @NameInMap("upper")
        public String upper;

        public static FormComponentPropsStatField build(java.util.Map<String, ?> map) throws Exception {
            FormComponentPropsStatField self = new FormComponentPropsStatField();
            return TeaModel.build(map, self);
        }

        public FormComponentPropsStatField setComponentId(String componentId) {
            this.componentId = componentId;
            return this;
        }
        public String getComponentId() {
            return this.componentId;
        }

        public FormComponentPropsStatField setLabel(String label) {
            this.label = label;
            return this;
        }
        public String getLabel() {
            return this.label;
        }

        public FormComponentPropsStatField setUpper(String upper) {
            this.upper = upper;
            return this;
        }
        public String getUpper() {
            return this.upper;
        }

    }

}
