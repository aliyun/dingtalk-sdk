// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class FormComponentProps extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>增加明细</p>
     */
    @NameInMap("actionName")
    public String actionName;

    @NameInMap("addressModel")
    public String addressModel;

    /**
     * <strong>example:</strong>
     * <p>top</p>
     */
    @NameInMap("align")
    public String align;

    /**
     * <strong>example:</strong>
     * <p>true</p>
     */
    @NameInMap("asyncCondition")
    public Boolean asyncCondition;

    @NameInMap("availableTemplates")
    public java.util.List<AvaliableTemplate> availableTemplates;

    /**
     * <strong>example:</strong>
     * <p>finance_name</p>
     */
    @NameInMap("bizAlias")
    public String bizAlias;

    /**
     * <strong>example:</strong>
     * <p>attendance.leave</p>
     */
    @NameInMap("bizType")
    public String bizType;

    /**
     * <strong>example:</strong>
     * <p>0</p>
     * 
     * <strong>if can be null:</strong>
     * <p>true</p>
     */
    @NameInMap("choice")
    public String choice;

    /**
     * <strong>example:</strong>
     * <p>custom_view</p>
     */
    @NameInMap("commonBizType")
    public String commonBizType;

    /**
     * <strong>example:</strong>
     * <p>TextField-abcd</p>
     */
    @NameInMap("componentId")
    public String componentId;

    /**
     * <strong>example:</strong>
     * <p>我是说明文字控件</p>
     */
    @NameInMap("content")
    public String content;

    @NameInMap("dataSource")
    public FormDataSource dataSource;

    /**
     * <strong>example:</strong>
     * <p>true</p>
     */
    @NameInMap("disabled")
    public Boolean disabled;

    /**
     * <strong>example:</strong>
     * <p>true</p>
     */
    @NameInMap("duration")
    public Boolean duration;

    /**
     * <strong>example:</strong>
     * <p>时长</p>
     */
    @NameInMap("durationLabel")
    public String durationLabel;

    /**
     * <strong>example:</strong>
     * <p>yyyy-MM-dd</p>
     */
    @NameInMap("format")
    public String format;

    @NameInMap("formula")
    public String formula;

    /**
     * <strong>example:</strong>
     * <p>true</p>
     */
    @NameInMap("invisible")
    public Boolean invisible;

    /**
     * <strong>example:</strong>
     * <p>姓名</p>
     */
    @NameInMap("label")
    public String label;

    /**
     * <strong>example:</strong>
     * <p>5</p>
     */
    @NameInMap("limit")
    public Integer limit;

    /**
     * <strong>example:</strong>
     * <p><a href="http://www">http://www</a>.</p>
     */
    @NameInMap("link")
    public String link;

    /**
     * <strong>example:</strong>
     * <p>20</p>
     */
    @NameInMap("maxLength")
    public Integer maxLength;

    /**
     * <strong>example:</strong>
     * <p>phone_tel</p>
     */
    @NameInMap("mode")
    public String mode;

    /**
     * <strong>example:</strong>
     * <p>true</p>
     */
    @NameInMap("multiple")
    public Boolean multiple;

    @NameInMap("options")
    public java.util.List<SelectOption> options;

    /**
     * <strong>example:</strong>
     * <p>请输入</p>
     */
    @NameInMap("placeholder")
    public String placeholder;

    /**
     * <strong>example:</strong>
     * <p>2</p>
     * 
     * <strong>if can be null:</strong>
     * <p>true</p>
     */
    @NameInMap("precision")
    public Integer precision;

    /**
     * <strong>example:</strong>
     * <p>1</p>
     * 
     * <strong>if can be null:</strong>
     * <p>true</p>
     */
    @NameInMap("print")
    public String print;

    /**
     * <strong>example:</strong>
     * <p>true</p>
     */
    @NameInMap("required")
    public Boolean required;

    @NameInMap("statField")
    public java.util.List<FormComponentPropsStatField> statField;

    /**
     * <strong>example:</strong>
     * <p>table</p>
     */
    @NameInMap("tableViewMode")
    public String tableViewMode;

    /**
     * <strong>example:</strong>
     * <p>天</p>
     */
    @NameInMap("unit")
    public String unit;

    /**
     * <strong>example:</strong>
     * <p>1</p>
     * 
     * <strong>if can be null:</strong>
     * <p>true</p>
     */
    @NameInMap("upper")
    public String upper;

    /**
     * <strong>example:</strong>
     * <p>true</p>
     */
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
        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>NumberField-abcd</p>
         */
        @NameInMap("componentId")
        public String componentId;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>金额</p>
         */
        @NameInMap("label")
        public String label;

        /**
         * <strong>example:</strong>
         * <p>1</p>
         * 
         * <strong>if can be null:</strong>
         * <p>true</p>
         */
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
