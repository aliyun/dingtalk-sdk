// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class FormComponentProps extends TeaModel {
    // 地址控件模式city省市,district省市区,street省市区街道
    @NameInMap("addressModel")
    public String addressModel;

    // 文字提示控件显示方式:top|middle|bottom
    @NameInMap("align")
    public String align;

    // 套件中控件是否可设置为分条件字段
    @NameInMap("asyncCondition")
    public Boolean asyncCondition;

    // 关联审批单控件限定模板列表
    @NameInMap("availableTemplates")
    public java.util.List<AvaliableTemplate> availableTemplates;

    // 业务别名
    @NameInMap("bizAlias")
    public String bizAlias;

    // 套件的业务标识
    @NameInMap("bizType")
    public String bizType;

    // 联系人控件是否支持多选，1多选，0单选
    @NameInMap("choice")
    public String choice;

    // 自定义控件渲染标识
    @NameInMap("commonBizType")
    public String commonBizType;

    // 控件表单内唯一id
    @NameInMap("componentId")
    public String componentId;

    // 说明文字控件内容
    @NameInMap("content")
    public String content;

    // 关联数据源配置
    @NameInMap("dataSource")
    public FormDataSource dataSource;

    // 是否不可编辑
    @NameInMap("disabled")
    public Boolean disabled;

    // 是否自动计算时长
    @NameInMap("duration")
    public Boolean duration;

    // 时间格式
    @NameInMap("format")
    public String format;

    // 公式
    @NameInMap("formula")
    public String formula;

    // 是否隐藏字段
    @NameInMap("invisible")
    public Boolean invisible;

    // 控件标题
    @NameInMap("label")
    public String label;

    // 评分控件上限
    @NameInMap("limit")
    public Integer limit;

    // 说明文字控件链接地址
    @NameInMap("link")
    public String link;

    // 部门控件是否可多选
    @NameInMap("multiple")
    public Boolean multiple;

    // 单选多选控件选项列表
    @NameInMap("options")
    public java.util.List<SelectOption> options;

    // 输入提示
    @NameInMap("placeholder")
    public String placeholder;

    // 字段是否可打印，1打印，0不打印，默认打印
    @NameInMap("print")
    public String print;

    // 是否必填
    @NameInMap("required")
    public Boolean required;

    // 明细控件数据汇总统计
    @NameInMap("statField")
    public java.util.List<FormComponentPropsStatField> statField;

    // 明细填写方式，table（表格）、list（列表）
    @NameInMap("tableViewMode")
    public String tableViewMode;

    // 时间单位（天、小时）
    @NameInMap("unit")
    public String unit;

    // 金额控件是否需要大写，1不需要大写，其他需要大写
    @NameInMap("upper")
    public String upper;

    // 明细打印方式false横向，true纵向
    @NameInMap("verticalPrint")
    public Boolean verticalPrint;

    public static FormComponentProps build(java.util.Map<String, ?> map) throws Exception {
        FormComponentProps self = new FormComponentProps();
        return TeaModel.build(map, self);
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
        // 需要统计的明细控件内子控件id
        @NameInMap("componentId")
        public String componentId;

        // 子控件标题
        @NameInMap("label")
        public String label;

        // 金额控件是否需要大写，1不需要大写，其他需要大写
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
