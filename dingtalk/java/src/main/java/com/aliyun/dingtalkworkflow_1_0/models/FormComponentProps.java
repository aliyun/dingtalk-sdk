// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class FormComponentProps extends TeaModel {
    /**
     * <p>明细控件按钮显示文案</p>
     */
    @NameInMap("actionName")
    public String actionName;

    /**
     * <p>地址控件模式city省市,district省市区,street省市区街道</p>
     */
    @NameInMap("addressModel")
    public String addressModel;

    /**
     * <p>文字提示控件显示方式:top|middle|bottom</p>
     */
    @NameInMap("align")
    public String align;

    /**
     * <p>套件中控件是否可设置为分条件字段</p>
     */
    @NameInMap("asyncCondition")
    public Boolean asyncCondition;

    /**
     * <p>关联审批单控件限定模板列表</p>
     */
    @NameInMap("availableTemplates")
    public java.util.List<AvaliableTemplate> availableTemplates;

    /**
     * <p>业务别名</p>
     */
    @NameInMap("bizAlias")
    public String bizAlias;

    /**
     * <p>套件的业务标识</p>
     */
    @NameInMap("bizType")
    public String bizType;

    /**
     * <p>联系人控件是否支持多选，1多选，0单选</p>
     */
    @NameInMap("choice")
    public String choice;

    /**
     * <p>自定义控件渲染标识</p>
     */
    @NameInMap("commonBizType")
    public String commonBizType;

    /**
     * <p>控件表单内唯一id</p>
     */
    @NameInMap("componentId")
    public String componentId;

    /**
     * <p>说明文字控件内容</p>
     */
    @NameInMap("content")
    public String content;

    /**
     * <p>关联数据源配置</p>
     */
    @NameInMap("dataSource")
    public FormDataSource dataSource;

    /**
     * <p>是否不可编辑</p>
     */
    @NameInMap("disabled")
    public Boolean disabled;

    /**
     * <p>是否自动计算时长</p>
     */
    @NameInMap("duration")
    public Boolean duration;

    /**
     * <p>时间格式</p>
     */
    @NameInMap("format")
    public String format;

    /**
     * <p>公式</p>
     */
    @NameInMap("formula")
    public String formula;

    /**
     * <p>是否隐藏字段</p>
     */
    @NameInMap("invisible")
    public Boolean invisible;

    /**
     * <p>控件标题</p>
     */
    @NameInMap("label")
    public String label;

    /**
     * <p>评分控件上限</p>
     */
    @NameInMap("limit")
    public Integer limit;

    /**
     * <p>说明文字控件链接地址</p>
     */
    @NameInMap("link")
    public String link;

    /**
     * <p>文本控件支持的最大长度</p>
     */
    @NameInMap("maxLength")
    public Integer maxLength;

    /**
     * <p>电话控件支持的类型</p>
     */
    @NameInMap("mode")
    public String mode;

    /**
     * <p>部门控件是否可多选</p>
     */
    @NameInMap("multiple")
    public Boolean multiple;

    /**
     * <p>单选多选控件选项列表</p>
     */
    @NameInMap("options")
    public java.util.List<SelectOption> options;

    /**
     * <p>输入提示</p>
     */
    @NameInMap("placeholder")
    public String placeholder;

    /**
     * <p>小数点位数</p>
     */
    @NameInMap("precision")
    public Integer precision;

    /**
     * <p>字段是否可打印，1打印，0不打印，默认打印</p>
     */
    @NameInMap("print")
    public String print;

    /**
     * <p>是否必填</p>
     */
    @NameInMap("required")
    public Boolean required;

    /**
     * <p>明细控件数据汇总统计</p>
     */
    @NameInMap("statField")
    public java.util.List<FormComponentPropsStatField> statField;

    /**
     * <p>明细填写方式，table（表格）、list（列表）</p>
     */
    @NameInMap("tableViewMode")
    public String tableViewMode;

    /**
     * <p>时间单位（天、小时）</p>
     */
    @NameInMap("unit")
    public String unit;

    /**
     * <p>金额控件是否需要大写，1不需要大写，其他需要大写</p>
     */
    @NameInMap("upper")
    public String upper;

    /**
     * <p>明细打印方式false横向，true纵向</p>
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
         * <p>需要统计的明细控件内子控件id</p>
         */
        @NameInMap("componentId")
        public String componentId;

        /**
         * <p>子控件标题</p>
         */
        @NameInMap("label")
        public String label;

        /**
         * <p>金额控件是否需要大写，1不需要大写，其他需要大写</p>
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
