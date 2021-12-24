// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class DescribeRelationMetaResponseBody extends TeaModel {
    @NameInMap("relationMetaDTOList")
    public java.util.List<DescribeRelationMetaResponseBodyRelationMetaDTOList> relationMetaDTOList;

    public static DescribeRelationMetaResponseBody build(java.util.Map<String, ?> map) throws Exception {
        DescribeRelationMetaResponseBody self = new DescribeRelationMetaResponseBody();
        return TeaModel.build(map, self);
    }

    public DescribeRelationMetaResponseBody setRelationMetaDTOList(java.util.List<DescribeRelationMetaResponseBodyRelationMetaDTOList> relationMetaDTOList) {
        this.relationMetaDTOList = relationMetaDTOList;
        return this;
    }
    public java.util.List<DescribeRelationMetaResponseBodyRelationMetaDTOList> getRelationMetaDTOList() {
        return this.relationMetaDTOList;
    }

    public static class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsOptionsExtension extends TeaModel {
        // true
        @NameInMap("editFreeze")
        public Boolean editFreeze;

        public static DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsOptionsExtension build(java.util.Map<String, ?> map) throws Exception {
            DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsOptionsExtension self = new DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsOptionsExtension();
            return TeaModel.build(map, self);
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsOptionsExtension setEditFreeze(Boolean editFreeze) {
            this.editFreeze = editFreeze;
            return this;
        }
        public Boolean getEditFreeze() {
            return this.editFreeze;
        }

    }

    public static class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsOptions extends TeaModel {
        // 选项数据主键
        @NameInMap("key")
        public String key;

        // 选项显示内容
        @NameInMap("value")
        public String value;

        // false
        @NameInMap("warn")
        public Boolean warn;

        @NameInMap("extension")
        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsOptionsExtension extension;

        public static DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsOptions build(java.util.Map<String, ?> map) throws Exception {
            DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsOptions self = new DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsOptions();
            return TeaModel.build(map, self);
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsOptions setKey(String key) {
            this.key = key;
            return this;
        }
        public String getKey() {
            return this.key;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsOptions setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsOptions setWarn(Boolean warn) {
            this.warn = warn;
            return this;
        }
        public Boolean getWarn() {
            return this.warn;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsOptions setExtension(DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsOptionsExtension extension) {
            this.extension = extension;
            return this;
        }
        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsOptionsExtension getExtension() {
            return this.extension;
        }

    }

    public static class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceFieldsRelatePropsOptionsExtension extends TeaModel {
        @NameInMap("editFreeze")
        public Boolean editFreeze;

        public static DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceFieldsRelatePropsOptionsExtension build(java.util.Map<String, ?> map) throws Exception {
            DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceFieldsRelatePropsOptionsExtension self = new DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceFieldsRelatePropsOptionsExtension();
            return TeaModel.build(map, self);
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceFieldsRelatePropsOptionsExtension setEditFreeze(Boolean editFreeze) {
            this.editFreeze = editFreeze;
            return this;
        }
        public Boolean getEditFreeze() {
            return this.editFreeze;
        }

    }

    public static class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceFieldsRelatePropsOptions extends TeaModel {
        // 选项数据主键
        @NameInMap("key")
        public String key;

        // 选项显示内容
        @NameInMap("value")
        public String value;

        @NameInMap("extension")
        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceFieldsRelatePropsOptionsExtension extension;

        public static DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceFieldsRelatePropsOptions build(java.util.Map<String, ?> map) throws Exception {
            DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceFieldsRelatePropsOptions self = new DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceFieldsRelatePropsOptions();
            return TeaModel.build(map, self);
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceFieldsRelatePropsOptions setKey(String key) {
            this.key = key;
            return this;
        }
        public String getKey() {
            return this.key;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceFieldsRelatePropsOptions setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceFieldsRelatePropsOptions setExtension(DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceFieldsRelatePropsOptionsExtension extension) {
            this.extension = extension;
            return this;
        }
        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceFieldsRelatePropsOptionsExtension getExtension() {
            return this.extension;
        }

    }

    public static class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceFieldsRelatePropsStatField extends TeaModel {
        @NameInMap("fieldId")
        public String fieldId;

        @NameInMap("label")
        public String label;

        @NameInMap("upper")
        public Boolean upper;

        @NameInMap("unit")
        public String unit;

        public static DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceFieldsRelatePropsStatField build(java.util.Map<String, ?> map) throws Exception {
            DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceFieldsRelatePropsStatField self = new DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceFieldsRelatePropsStatField();
            return TeaModel.build(map, self);
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceFieldsRelatePropsStatField setFieldId(String fieldId) {
            this.fieldId = fieldId;
            return this;
        }
        public String getFieldId() {
            return this.fieldId;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceFieldsRelatePropsStatField setLabel(String label) {
            this.label = label;
            return this;
        }
        public String getLabel() {
            return this.label;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceFieldsRelatePropsStatField setUpper(Boolean upper) {
            this.upper = upper;
            return this;
        }
        public Boolean getUpper() {
            return this.upper;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceFieldsRelatePropsStatField setUnit(String unit) {
            this.unit = unit;
            return this;
        }
        public String getUnit() {
            return this.unit;
        }

    }

    public static class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceFieldsRelateProps extends TeaModel {
        // 字段id
        @NameInMap("fieldId")
        public String fieldId;

        // 字段标题
        @NameInMap("label")
        public String label;

        // 字段是否必填
        @NameInMap("required")
        public Boolean required;

        @NameInMap("requiredEditableFreeze")
        public Boolean requiredEditableFreeze;

        @NameInMap("labelEditableFreeze")
        public Boolean labelEditableFreeze;

        // 说明文字内容
        @NameInMap("content")
        public String content;

        // 时间格式
        @NameInMap("format")
        public String format;

        // 选项内容列表
        @NameInMap("options")
        public java.util.List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceFieldsRelatePropsOptions> options;

        // 是否需要大写 默认是需要
        @NameInMap("notUpper")
        public String notUpper;

        // 数字组件/日期区间组件单位属性
        @NameInMap("unit")
        public String unit;

        // 界面空值提示占位符 前后端统一用placeholder
        @NameInMap("placeholder")
        public String placeholder;

        // 字段别名
        @NameInMap("bizAlias")
        public String bizAlias;

        // 是否自动计算时长
        @NameInMap("duration")
        public String duration;

        // 内部联系人choice
        @NameInMap("choice")
        public Long choice;

        // 是否可编辑
        @NameInMap("disabled")
        public Boolean disabled;

        // textnote的样式
        @NameInMap("align")
        public String align;

        // 隐藏字段
        @NameInMap("invisible")
        public Boolean invisible;

        // 是否有支付属性
        @NameInMap("payEnable")
        public Boolean payEnable;

        // 需要计算总和的明细组件
        @NameInMap("statField")
        public java.util.List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceFieldsRelatePropsStatField> statField;

        // 说明文案的链接地址
        @NameInMap("link")
        public String link;

        // 明细打印排版方式
        @NameInMap("verticalPrint")
        public Boolean verticalPrint;

        // 公式
        @NameInMap("formula")
        public String formula;

        @NameInMap("quote")
        public Long quote;

        @NameInMap("multi")
        public Long multi;

        public static DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceFieldsRelateProps build(java.util.Map<String, ?> map) throws Exception {
            DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceFieldsRelateProps self = new DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceFieldsRelateProps();
            return TeaModel.build(map, self);
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceFieldsRelateProps setFieldId(String fieldId) {
            this.fieldId = fieldId;
            return this;
        }
        public String getFieldId() {
            return this.fieldId;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceFieldsRelateProps setLabel(String label) {
            this.label = label;
            return this;
        }
        public String getLabel() {
            return this.label;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceFieldsRelateProps setRequired(Boolean required) {
            this.required = required;
            return this;
        }
        public Boolean getRequired() {
            return this.required;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceFieldsRelateProps setRequiredEditableFreeze(Boolean requiredEditableFreeze) {
            this.requiredEditableFreeze = requiredEditableFreeze;
            return this;
        }
        public Boolean getRequiredEditableFreeze() {
            return this.requiredEditableFreeze;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceFieldsRelateProps setLabelEditableFreeze(Boolean labelEditableFreeze) {
            this.labelEditableFreeze = labelEditableFreeze;
            return this;
        }
        public Boolean getLabelEditableFreeze() {
            return this.labelEditableFreeze;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceFieldsRelateProps setContent(String content) {
            this.content = content;
            return this;
        }
        public String getContent() {
            return this.content;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceFieldsRelateProps setFormat(String format) {
            this.format = format;
            return this;
        }
        public String getFormat() {
            return this.format;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceFieldsRelateProps setOptions(java.util.List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceFieldsRelatePropsOptions> options) {
            this.options = options;
            return this;
        }
        public java.util.List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceFieldsRelatePropsOptions> getOptions() {
            return this.options;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceFieldsRelateProps setNotUpper(String notUpper) {
            this.notUpper = notUpper;
            return this;
        }
        public String getNotUpper() {
            return this.notUpper;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceFieldsRelateProps setUnit(String unit) {
            this.unit = unit;
            return this;
        }
        public String getUnit() {
            return this.unit;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceFieldsRelateProps setPlaceholder(String placeholder) {
            this.placeholder = placeholder;
            return this;
        }
        public String getPlaceholder() {
            return this.placeholder;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceFieldsRelateProps setBizAlias(String bizAlias) {
            this.bizAlias = bizAlias;
            return this;
        }
        public String getBizAlias() {
            return this.bizAlias;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceFieldsRelateProps setDuration(String duration) {
            this.duration = duration;
            return this;
        }
        public String getDuration() {
            return this.duration;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceFieldsRelateProps setChoice(Long choice) {
            this.choice = choice;
            return this;
        }
        public Long getChoice() {
            return this.choice;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceFieldsRelateProps setDisabled(Boolean disabled) {
            this.disabled = disabled;
            return this;
        }
        public Boolean getDisabled() {
            return this.disabled;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceFieldsRelateProps setAlign(String align) {
            this.align = align;
            return this;
        }
        public String getAlign() {
            return this.align;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceFieldsRelateProps setInvisible(Boolean invisible) {
            this.invisible = invisible;
            return this;
        }
        public Boolean getInvisible() {
            return this.invisible;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceFieldsRelateProps setPayEnable(Boolean payEnable) {
            this.payEnable = payEnable;
            return this;
        }
        public Boolean getPayEnable() {
            return this.payEnable;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceFieldsRelateProps setStatField(java.util.List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceFieldsRelatePropsStatField> statField) {
            this.statField = statField;
            return this;
        }
        public java.util.List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceFieldsRelatePropsStatField> getStatField() {
            return this.statField;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceFieldsRelateProps setLink(String link) {
            this.link = link;
            return this;
        }
        public String getLink() {
            return this.link;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceFieldsRelateProps setVerticalPrint(Boolean verticalPrint) {
            this.verticalPrint = verticalPrint;
            return this;
        }
        public Boolean getVerticalPrint() {
            return this.verticalPrint;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceFieldsRelateProps setFormula(String formula) {
            this.formula = formula;
            return this;
        }
        public String getFormula() {
            return this.formula;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceFieldsRelateProps setQuote(Long quote) {
            this.quote = quote;
            return this;
        }
        public Long getQuote() {
            return this.quote;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceFieldsRelateProps setMulti(Long multi) {
            this.multi = multi;
            return this;
        }
        public Long getMulti() {
            return this.multi;
        }

    }

    public static class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceFields extends TeaModel {
        // 字段类型
        @NameInMap("componentName")
        public String componentName;

        // 字段属性
        @NameInMap("relateProps")
        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceFieldsRelateProps relateProps;

        public static DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceFields build(java.util.Map<String, ?> map) throws Exception {
            DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceFields self = new DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceFields();
            return TeaModel.build(map, self);
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceFields setComponentName(String componentName) {
            this.componentName = componentName;
            return this;
        }
        public String getComponentName() {
            return this.componentName;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceFields setRelateProps(DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceFieldsRelateProps relateProps) {
            this.relateProps = relateProps;
            return this;
        }
        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceFieldsRelateProps getRelateProps() {
            return this.relateProps;
        }

    }

    public static class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceDataSourceParamsFilters extends TeaModel {
        @NameInMap("valueType")
        public String valueType;

        @NameInMap("filterType")
        public String filterType;

        @NameInMap("value")
        public String value;

        @NameInMap("fieldId")
        public String fieldId;

        public static DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceDataSourceParamsFilters build(java.util.Map<String, ?> map) throws Exception {
            DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceDataSourceParamsFilters self = new DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceDataSourceParamsFilters();
            return TeaModel.build(map, self);
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceDataSourceParamsFilters setValueType(String valueType) {
            this.valueType = valueType;
            return this;
        }
        public String getValueType() {
            return this.valueType;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceDataSourceParamsFilters setFilterType(String filterType) {
            this.filterType = filterType;
            return this;
        }
        public String getFilterType() {
            return this.filterType;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceDataSourceParamsFilters setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceDataSourceParamsFilters setFieldId(String fieldId) {
            this.fieldId = fieldId;
            return this;
        }
        public String getFieldId() {
            return this.fieldId;
        }

    }

    public static class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceDataSourceParams extends TeaModel {
        @NameInMap("filters")
        public java.util.List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceDataSourceParamsFilters> filters;

        public static DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceDataSourceParams build(java.util.Map<String, ?> map) throws Exception {
            DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceDataSourceParams self = new DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceDataSourceParams();
            return TeaModel.build(map, self);
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceDataSourceParams setFilters(java.util.List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceDataSourceParamsFilters> filters) {
            this.filters = filters;
            return this;
        }
        public java.util.List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceDataSourceParamsFilters> getFilters() {
            return this.filters;
        }

    }

    public static class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceDataSourceTarget extends TeaModel {
        @NameInMap("appUuid")
        public String appUuid;

        @NameInMap("appType")
        public Long appType;

        @NameInMap("bizType")
        public String bizType;

        @NameInMap("formCode")
        public String formCode;

        public static DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceDataSourceTarget build(java.util.Map<String, ?> map) throws Exception {
            DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceDataSourceTarget self = new DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceDataSourceTarget();
            return TeaModel.build(map, self);
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceDataSourceTarget setAppUuid(String appUuid) {
            this.appUuid = appUuid;
            return this;
        }
        public String getAppUuid() {
            return this.appUuid;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceDataSourceTarget setAppType(Long appType) {
            this.appType = appType;
            return this;
        }
        public Long getAppType() {
            return this.appType;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceDataSourceTarget setBizType(String bizType) {
            this.bizType = bizType;
            return this;
        }
        public String getBizType() {
            return this.bizType;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceDataSourceTarget setFormCode(String formCode) {
            this.formCode = formCode;
            return this;
        }
        public String getFormCode() {
            return this.formCode;
        }

    }

    public static class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceDataSource extends TeaModel {
        @NameInMap("type")
        public String type;

        @NameInMap("params")
        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceDataSourceParams params;

        @NameInMap("target")
        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceDataSourceTarget target;

        public static DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceDataSource build(java.util.Map<String, ?> map) throws Exception {
            DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceDataSource self = new DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceDataSource();
            return TeaModel.build(map, self);
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceDataSource setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceDataSource setParams(DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceDataSourceParams params) {
            this.params = params;
            return this;
        }
        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceDataSourceParams getParams() {
            return this.params;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceDataSource setTarget(DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceDataSourceTarget target) {
            this.target = target;
            return this;
        }
        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceDataSourceTarget getTarget() {
            return this.target;
        }

    }

    public static class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSource extends TeaModel {
        @NameInMap("bizType")
        public String bizType;

        // 关联表单的关联控件显示
        @NameInMap("fields")
        public java.util.List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceFields> fields;

        @NameInMap("dataSource")
        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceDataSource dataSource;

        public static DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSource build(java.util.Map<String, ?> map) throws Exception {
            DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSource self = new DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSource();
            return TeaModel.build(map, self);
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSource setBizType(String bizType) {
            this.bizType = bizType;
            return this;
        }
        public String getBizType() {
            return this.bizType;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSource setFields(java.util.List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceFields> fields) {
            this.fields = fields;
            return this;
        }
        public java.util.List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceFields> getFields() {
            return this.fields;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSource setDataSource(DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceDataSource dataSource) {
            this.dataSource = dataSource;
            return this;
        }
        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceDataSource getDataSource() {
            return this.dataSource;
        }

    }

    public static class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelatePropsOptionsExtension extends TeaModel {
        @NameInMap("editFreeze")
        public Boolean editFreeze;

        public static DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelatePropsOptionsExtension build(java.util.Map<String, ?> map) throws Exception {
            DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelatePropsOptionsExtension self = new DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelatePropsOptionsExtension();
            return TeaModel.build(map, self);
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelatePropsOptionsExtension setEditFreeze(Boolean editFreeze) {
            this.editFreeze = editFreeze;
            return this;
        }
        public Boolean getEditFreeze() {
            return this.editFreeze;
        }

    }

    public static class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelatePropsOptions extends TeaModel {
        // 选项数据主键
        @NameInMap("key")
        public String key;

        // 选项显示内容
        @NameInMap("value")
        public String value;

        @NameInMap("extension")
        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelatePropsOptionsExtension extension;

        public static DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelatePropsOptions build(java.util.Map<String, ?> map) throws Exception {
            DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelatePropsOptions self = new DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelatePropsOptions();
            return TeaModel.build(map, self);
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelatePropsOptions setKey(String key) {
            this.key = key;
            return this;
        }
        public String getKey() {
            return this.key;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelatePropsOptions setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelatePropsOptions setExtension(DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelatePropsOptionsExtension extension) {
            this.extension = extension;
            return this;
        }
        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelatePropsOptionsExtension getExtension() {
            return this.extension;
        }

    }

    public static class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelatePropsStatField extends TeaModel {
        @NameInMap("fieldId")
        public String fieldId;

        @NameInMap("label")
        public String label;

        @NameInMap("upper")
        public Boolean upper;

        @NameInMap("unit")
        public String unit;

        public static DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelatePropsStatField build(java.util.Map<String, ?> map) throws Exception {
            DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelatePropsStatField self = new DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelatePropsStatField();
            return TeaModel.build(map, self);
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelatePropsStatField setFieldId(String fieldId) {
            this.fieldId = fieldId;
            return this;
        }
        public String getFieldId() {
            return this.fieldId;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelatePropsStatField setLabel(String label) {
            this.label = label;
            return this;
        }
        public String getLabel() {
            return this.label;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelatePropsStatField setUpper(Boolean upper) {
            this.upper = upper;
            return this;
        }
        public Boolean getUpper() {
            return this.upper;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelatePropsStatField setUnit(String unit) {
            this.unit = unit;
            return this;
        }
        public String getUnit() {
            return this.unit;
        }

    }

    public static class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelateProps extends TeaModel {
        // 字段id
        @NameInMap("fieldId")
        public String fieldId;

        // 字段标题
        @NameInMap("label")
        public String label;

        // 字段是否必填
        @NameInMap("required")
        public Boolean required;

        @NameInMap("requiredEditableFreeze")
        public Boolean requiredEditableFreeze;

        @NameInMap("labelEditableFreeze")
        public Boolean labelEditableFreeze;

        // 说明文字内容
        @NameInMap("content")
        public String content;

        // 时间格式
        @NameInMap("format")
        public String format;

        // 选项内容列表
        @NameInMap("options")
        public java.util.List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelatePropsOptions> options;

        // 是否需要大写 默认是需要
        @NameInMap("notUpper")
        public String notUpper;

        // 数字组件/日期区间组件单位属性
        @NameInMap("unit")
        public String unit;

        // 界面空值提示占位符 前后端统一用placeholder
        @NameInMap("placeholder")
        public String placeholder;

        // 字段别名
        @NameInMap("bizAlias")
        public String bizAlias;

        // 是否自动计算时长
        @NameInMap("duration")
        public String duration;

        // 内部联系人choice
        @NameInMap("choice")
        public Long choice;

        // 是否可编辑
        @NameInMap("disabled")
        public Boolean disabled;

        // textnote的样式
        @NameInMap("align")
        public String align;

        // 隐藏字段
        @NameInMap("invisible")
        public Boolean invisible;

        // 是否有支付属性
        @NameInMap("payEnable")
        public Boolean payEnable;

        // 需要计算总和的明细组件
        @NameInMap("statField")
        public java.util.List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelatePropsStatField> statField;

        // 说明文案的链接地址
        @NameInMap("link")
        public String link;

        // 明细打印排版方式
        @NameInMap("verticalPrint")
        public Boolean verticalPrint;

        // 公式
        @NameInMap("formula")
        public String formula;

        @NameInMap("watermark")
        public Boolean watermark;

        @NameInMap("limit")
        public Long limit;

        @NameInMap("spread")
        public Boolean spread;

        @NameInMap("ratio")
        public Long ratio;

        @NameInMap("durationLabel")
        public String durationLabel;

        @NameInMap("mode")
        public String mode;

        public static DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelateProps build(java.util.Map<String, ?> map) throws Exception {
            DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelateProps self = new DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelateProps();
            return TeaModel.build(map, self);
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelateProps setFieldId(String fieldId) {
            this.fieldId = fieldId;
            return this;
        }
        public String getFieldId() {
            return this.fieldId;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelateProps setLabel(String label) {
            this.label = label;
            return this;
        }
        public String getLabel() {
            return this.label;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelateProps setRequired(Boolean required) {
            this.required = required;
            return this;
        }
        public Boolean getRequired() {
            return this.required;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelateProps setRequiredEditableFreeze(Boolean requiredEditableFreeze) {
            this.requiredEditableFreeze = requiredEditableFreeze;
            return this;
        }
        public Boolean getRequiredEditableFreeze() {
            return this.requiredEditableFreeze;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelateProps setLabelEditableFreeze(Boolean labelEditableFreeze) {
            this.labelEditableFreeze = labelEditableFreeze;
            return this;
        }
        public Boolean getLabelEditableFreeze() {
            return this.labelEditableFreeze;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelateProps setContent(String content) {
            this.content = content;
            return this;
        }
        public String getContent() {
            return this.content;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelateProps setFormat(String format) {
            this.format = format;
            return this;
        }
        public String getFormat() {
            return this.format;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelateProps setOptions(java.util.List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelatePropsOptions> options) {
            this.options = options;
            return this;
        }
        public java.util.List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelatePropsOptions> getOptions() {
            return this.options;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelateProps setNotUpper(String notUpper) {
            this.notUpper = notUpper;
            return this;
        }
        public String getNotUpper() {
            return this.notUpper;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelateProps setUnit(String unit) {
            this.unit = unit;
            return this;
        }
        public String getUnit() {
            return this.unit;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelateProps setPlaceholder(String placeholder) {
            this.placeholder = placeholder;
            return this;
        }
        public String getPlaceholder() {
            return this.placeholder;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelateProps setBizAlias(String bizAlias) {
            this.bizAlias = bizAlias;
            return this;
        }
        public String getBizAlias() {
            return this.bizAlias;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelateProps setDuration(String duration) {
            this.duration = duration;
            return this;
        }
        public String getDuration() {
            return this.duration;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelateProps setChoice(Long choice) {
            this.choice = choice;
            return this;
        }
        public Long getChoice() {
            return this.choice;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelateProps setDisabled(Boolean disabled) {
            this.disabled = disabled;
            return this;
        }
        public Boolean getDisabled() {
            return this.disabled;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelateProps setAlign(String align) {
            this.align = align;
            return this;
        }
        public String getAlign() {
            return this.align;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelateProps setInvisible(Boolean invisible) {
            this.invisible = invisible;
            return this;
        }
        public Boolean getInvisible() {
            return this.invisible;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelateProps setPayEnable(Boolean payEnable) {
            this.payEnable = payEnable;
            return this;
        }
        public Boolean getPayEnable() {
            return this.payEnable;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelateProps setStatField(java.util.List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelatePropsStatField> statField) {
            this.statField = statField;
            return this;
        }
        public java.util.List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelatePropsStatField> getStatField() {
            return this.statField;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelateProps setLink(String link) {
            this.link = link;
            return this;
        }
        public String getLink() {
            return this.link;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelateProps setVerticalPrint(Boolean verticalPrint) {
            this.verticalPrint = verticalPrint;
            return this;
        }
        public Boolean getVerticalPrint() {
            return this.verticalPrint;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelateProps setFormula(String formula) {
            this.formula = formula;
            return this;
        }
        public String getFormula() {
            return this.formula;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelateProps setWatermark(Boolean watermark) {
            this.watermark = watermark;
            return this;
        }
        public Boolean getWatermark() {
            return this.watermark;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelateProps setLimit(Long limit) {
            this.limit = limit;
            return this;
        }
        public Long getLimit() {
            return this.limit;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelateProps setSpread(Boolean spread) {
            this.spread = spread;
            return this;
        }
        public Boolean getSpread() {
            return this.spread;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelateProps setRatio(Long ratio) {
            this.ratio = ratio;
            return this;
        }
        public Long getRatio() {
            return this.ratio;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelateProps setDurationLabel(String durationLabel) {
            this.durationLabel = durationLabel;
            return this;
        }
        public String getDurationLabel() {
            return this.durationLabel;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelateProps setMode(String mode) {
            this.mode = mode;
            return this;
        }
        public String getMode() {
            return this.mode;
        }

    }

    public static class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFields extends TeaModel {
        // 字段类型
        @NameInMap("componentName")
        public String componentName;

        // 字段属性
        @NameInMap("relateProps")
        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelateProps relateProps;

        public static DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFields build(java.util.Map<String, ?> map) throws Exception {
            DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFields self = new DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFields();
            return TeaModel.build(map, self);
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFields setComponentName(String componentName) {
            this.componentName = componentName;
            return this;
        }
        public String getComponentName() {
            return this.componentName;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFields setRelateProps(DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelateProps relateProps) {
            this.relateProps = relateProps;
            return this;
        }
        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelateProps getRelateProps() {
            return this.relateProps;
        }

    }

    public static class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsDataSourceParamsFilters extends TeaModel {
        @NameInMap("valueType")
        public String valueType;

        @NameInMap("filterType")
        public String filterType;

        @NameInMap("value")
        public String value;

        @NameInMap("fieldId")
        public String fieldId;

        public static DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsDataSourceParamsFilters build(java.util.Map<String, ?> map) throws Exception {
            DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsDataSourceParamsFilters self = new DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsDataSourceParamsFilters();
            return TeaModel.build(map, self);
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsDataSourceParamsFilters setValueType(String valueType) {
            this.valueType = valueType;
            return this;
        }
        public String getValueType() {
            return this.valueType;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsDataSourceParamsFilters setFilterType(String filterType) {
            this.filterType = filterType;
            return this;
        }
        public String getFilterType() {
            return this.filterType;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsDataSourceParamsFilters setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsDataSourceParamsFilters setFieldId(String fieldId) {
            this.fieldId = fieldId;
            return this;
        }
        public String getFieldId() {
            return this.fieldId;
        }

    }

    public static class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsDataSourceParams extends TeaModel {
        @NameInMap("filters")
        public java.util.List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsDataSourceParamsFilters> filters;

        public static DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsDataSourceParams build(java.util.Map<String, ?> map) throws Exception {
            DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsDataSourceParams self = new DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsDataSourceParams();
            return TeaModel.build(map, self);
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsDataSourceParams setFilters(java.util.List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsDataSourceParamsFilters> filters) {
            this.filters = filters;
            return this;
        }
        public java.util.List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsDataSourceParamsFilters> getFilters() {
            return this.filters;
        }

    }

    public static class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsDataSourceTarget extends TeaModel {
        // 应用搭建id
        @NameInMap("appUuid")
        public String appUuid;

        // 应用类型
        @NameInMap("appType")
        public Long appType;

        // 表单业务标识
        @NameInMap("bizType")
        public String bizType;

        // 被关联表单的formCode
        @NameInMap("formCode")
        public String formCode;

        public static DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsDataSourceTarget build(java.util.Map<String, ?> map) throws Exception {
            DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsDataSourceTarget self = new DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsDataSourceTarget();
            return TeaModel.build(map, self);
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsDataSourceTarget setAppUuid(String appUuid) {
            this.appUuid = appUuid;
            return this;
        }
        public String getAppUuid() {
            return this.appUuid;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsDataSourceTarget setAppType(Long appType) {
            this.appType = appType;
            return this;
        }
        public Long getAppType() {
            return this.appType;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsDataSourceTarget setBizType(String bizType) {
            this.bizType = bizType;
            return this;
        }
        public String getBizType() {
            return this.bizType;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsDataSourceTarget setFormCode(String formCode) {
            this.formCode = formCode;
            return this;
        }
        public String getFormCode() {
            return this.formCode;
        }

    }

    public static class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsDataSource extends TeaModel {
        // 关联类型{ "form": 关联表单 }
        @NameInMap("type")
        public String type;

        @NameInMap("params")
        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsDataSourceParams params;

        // 关联表单的业务标识
        @NameInMap("target")
        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsDataSourceTarget target;

        public static DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsDataSource build(java.util.Map<String, ?> map) throws Exception {
            DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsDataSource self = new DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsDataSource();
            return TeaModel.build(map, self);
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsDataSource setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsDataSource setParams(DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsDataSourceParams params) {
            this.params = params;
            return this;
        }
        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsDataSourceParams getParams() {
            return this.params;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsDataSource setTarget(DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsDataSourceTarget target) {
            this.target = target;
            return this;
        }
        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsDataSourceTarget getTarget() {
            return this.target;
        }

    }

    public static class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsStatField extends TeaModel {
        @NameInMap("fieldId")
        public String fieldId;

        @NameInMap("label")
        public String label;

        @NameInMap("upper")
        public Boolean upper;

        @NameInMap("unit")
        public String unit;

        public static DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsStatField build(java.util.Map<String, ?> map) throws Exception {
            DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsStatField self = new DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsStatField();
            return TeaModel.build(map, self);
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsStatField setFieldId(String fieldId) {
            this.fieldId = fieldId;
            return this;
        }
        public String getFieldId() {
            return this.fieldId;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsStatField setLabel(String label) {
            this.label = label;
            return this;
        }
        public String getLabel() {
            return this.label;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsStatField setUpper(Boolean upper) {
            this.upper = upper;
            return this;
        }
        public Boolean getUpper() {
            return this.upper;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsStatField setUnit(String unit) {
            this.unit = unit;
            return this;
        }
        public String getUnit() {
            return this.unit;
        }

    }

    public static class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRule extends TeaModel {
        @NameInMap("type")
        public String type;

        @NameInMap("value")
        public String value;

        public static DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRule build(java.util.Map<String, ?> map) throws Exception {
            DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRule self = new DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRule();
            return TeaModel.build(map, self);
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRule setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRule setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

    }

    public static class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsProps extends TeaModel {
        // 字段id
        @NameInMap("fieldId")
        public String fieldId;

        // 字段标题
        @NameInMap("label")
        public String label;

        @NameInMap("sortable")
        public Boolean sortable;

        // 字段标题是否可修改
        @NameInMap("labelEditableFreeze")
        public Boolean labelEditableFreeze;

        // 字段是否必填
        @NameInMap("required")
        public Boolean required;

        // 字段必填是否修改
        @NameInMap("requiredEditableFreeze")
        public Boolean requiredEditableFreeze;

        // 是否参与打印
        @NameInMap("notPrint")
        public String notPrint;

        // 说明文字内容
        @NameInMap("content")
        public String content;

        // 时间格式
        @NameInMap("format")
        public String format;

        // 选项内容列表
        @NameInMap("options")
        public java.util.List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsOptions> options;

        // 是否需要大写 默认是需要
        @NameInMap("notUpper")
        public String notUpper;

        // 数字组件/日期区间组件单位属性
        @NameInMap("unit")
        public String unit;

        // 界面空值提示占位符 前后端统一用placeholder
        @NameInMap("placeholder")
        public String placeholder;

        // 字段别名
        @NameInMap("bizAlias")
        public String bizAlias;

        // 是否自动计算时长
        @NameInMap("duration")
        public Boolean duration;

        // 内部联系人choice
        @NameInMap("choice")
        public Long choice;

        // 是否可编辑
        @NameInMap("disabled")
        public Boolean disabled;

        // textnote的样式
        @NameInMap("align")
        public String align;

        @NameInMap("relateSource")
        public java.util.List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSource> relateSource;

        // 关联表单的关联控件显示
        @NameInMap("fields")
        public java.util.List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFields> fields;

        // 关联表单的数据源配置
        @NameInMap("dataSource")
        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsDataSource dataSource;

        // 隐藏字段
        @NameInMap("invisible")
        public Boolean invisible;

        // 是否有支付属性
        @NameInMap("payEnable")
        public Boolean payEnable;

        // 需要计算总和的明细组件
        @NameInMap("statField")
        public java.util.List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsStatField> statField;

        // 说明文案的链接地址
        @NameInMap("link")
        public String link;

        // 明细打印排版方式
        @NameInMap("verticalPrint")
        public Boolean verticalPrint;

        // 公式
        @NameInMap("formula")
        public String formula;

        @NameInMap("needDetail")
        public String needDetail;

        // 1
        @NameInMap("quote")
        public Long quote;

        @NameInMap("multi")
        public Long multi;

        // 流水号控件规则
        @NameInMap("rule")
        public java.util.List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRule> rule;

        // table
        @NameInMap("tableViewMode")
        public String tableViewMode;

        @NameInMap("actionName")
        public String actionName;

        // true
        @NameInMap("watermark")
        public Boolean watermark;

        // 5
        @NameInMap("limit")
        public Long limit;

        // true
        @NameInMap("spread")
        public Boolean spread;

        // 50
        @NameInMap("ratio")
        public Long ratio;

        @NameInMap("durationLabel")
        public String durationLabel;

        // phone
        @NameInMap("mode")
        public String mode;

        public static DescribeRelationMetaResponseBodyRelationMetaDTOListItemsProps build(java.util.Map<String, ?> map) throws Exception {
            DescribeRelationMetaResponseBodyRelationMetaDTOListItemsProps self = new DescribeRelationMetaResponseBodyRelationMetaDTOListItemsProps();
            return TeaModel.build(map, self);
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsProps setFieldId(String fieldId) {
            this.fieldId = fieldId;
            return this;
        }
        public String getFieldId() {
            return this.fieldId;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsProps setLabel(String label) {
            this.label = label;
            return this;
        }
        public String getLabel() {
            return this.label;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsProps setSortable(Boolean sortable) {
            this.sortable = sortable;
            return this;
        }
        public Boolean getSortable() {
            return this.sortable;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsProps setLabelEditableFreeze(Boolean labelEditableFreeze) {
            this.labelEditableFreeze = labelEditableFreeze;
            return this;
        }
        public Boolean getLabelEditableFreeze() {
            return this.labelEditableFreeze;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsProps setRequired(Boolean required) {
            this.required = required;
            return this;
        }
        public Boolean getRequired() {
            return this.required;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsProps setRequiredEditableFreeze(Boolean requiredEditableFreeze) {
            this.requiredEditableFreeze = requiredEditableFreeze;
            return this;
        }
        public Boolean getRequiredEditableFreeze() {
            return this.requiredEditableFreeze;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsProps setNotPrint(String notPrint) {
            this.notPrint = notPrint;
            return this;
        }
        public String getNotPrint() {
            return this.notPrint;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsProps setContent(String content) {
            this.content = content;
            return this;
        }
        public String getContent() {
            return this.content;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsProps setFormat(String format) {
            this.format = format;
            return this;
        }
        public String getFormat() {
            return this.format;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsProps setOptions(java.util.List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsOptions> options) {
            this.options = options;
            return this;
        }
        public java.util.List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsOptions> getOptions() {
            return this.options;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsProps setNotUpper(String notUpper) {
            this.notUpper = notUpper;
            return this;
        }
        public String getNotUpper() {
            return this.notUpper;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsProps setUnit(String unit) {
            this.unit = unit;
            return this;
        }
        public String getUnit() {
            return this.unit;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsProps setPlaceholder(String placeholder) {
            this.placeholder = placeholder;
            return this;
        }
        public String getPlaceholder() {
            return this.placeholder;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsProps setBizAlias(String bizAlias) {
            this.bizAlias = bizAlias;
            return this;
        }
        public String getBizAlias() {
            return this.bizAlias;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsProps setDuration(Boolean duration) {
            this.duration = duration;
            return this;
        }
        public Boolean getDuration() {
            return this.duration;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsProps setChoice(Long choice) {
            this.choice = choice;
            return this;
        }
        public Long getChoice() {
            return this.choice;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsProps setDisabled(Boolean disabled) {
            this.disabled = disabled;
            return this;
        }
        public Boolean getDisabled() {
            return this.disabled;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsProps setAlign(String align) {
            this.align = align;
            return this;
        }
        public String getAlign() {
            return this.align;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsProps setRelateSource(java.util.List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSource> relateSource) {
            this.relateSource = relateSource;
            return this;
        }
        public java.util.List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSource> getRelateSource() {
            return this.relateSource;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsProps setFields(java.util.List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFields> fields) {
            this.fields = fields;
            return this;
        }
        public java.util.List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFields> getFields() {
            return this.fields;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsProps setDataSource(DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsDataSource dataSource) {
            this.dataSource = dataSource;
            return this;
        }
        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsDataSource getDataSource() {
            return this.dataSource;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsProps setInvisible(Boolean invisible) {
            this.invisible = invisible;
            return this;
        }
        public Boolean getInvisible() {
            return this.invisible;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsProps setPayEnable(Boolean payEnable) {
            this.payEnable = payEnable;
            return this;
        }
        public Boolean getPayEnable() {
            return this.payEnable;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsProps setStatField(java.util.List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsStatField> statField) {
            this.statField = statField;
            return this;
        }
        public java.util.List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsStatField> getStatField() {
            return this.statField;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsProps setLink(String link) {
            this.link = link;
            return this;
        }
        public String getLink() {
            return this.link;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsProps setVerticalPrint(Boolean verticalPrint) {
            this.verticalPrint = verticalPrint;
            return this;
        }
        public Boolean getVerticalPrint() {
            return this.verticalPrint;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsProps setFormula(String formula) {
            this.formula = formula;
            return this;
        }
        public String getFormula() {
            return this.formula;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsProps setNeedDetail(String needDetail) {
            this.needDetail = needDetail;
            return this;
        }
        public String getNeedDetail() {
            return this.needDetail;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsProps setQuote(Long quote) {
            this.quote = quote;
            return this;
        }
        public Long getQuote() {
            return this.quote;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsProps setMulti(Long multi) {
            this.multi = multi;
            return this;
        }
        public Long getMulti() {
            return this.multi;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsProps setRule(java.util.List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRule> rule) {
            this.rule = rule;
            return this;
        }
        public java.util.List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRule> getRule() {
            return this.rule;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsProps setTableViewMode(String tableViewMode) {
            this.tableViewMode = tableViewMode;
            return this;
        }
        public String getTableViewMode() {
            return this.tableViewMode;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsProps setActionName(String actionName) {
            this.actionName = actionName;
            return this;
        }
        public String getActionName() {
            return this.actionName;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsProps setWatermark(Boolean watermark) {
            this.watermark = watermark;
            return this;
        }
        public Boolean getWatermark() {
            return this.watermark;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsProps setLimit(Long limit) {
            this.limit = limit;
            return this;
        }
        public Long getLimit() {
            return this.limit;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsProps setSpread(Boolean spread) {
            this.spread = spread;
            return this;
        }
        public Boolean getSpread() {
            return this.spread;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsProps setRatio(Long ratio) {
            this.ratio = ratio;
            return this;
        }
        public Long getRatio() {
            return this.ratio;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsProps setDurationLabel(String durationLabel) {
            this.durationLabel = durationLabel;
            return this;
        }
        public String getDurationLabel() {
            return this.durationLabel;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsProps setMode(String mode) {
            this.mode = mode;
            return this;
        }
        public String getMode() {
            return this.mode;
        }

    }

    public static class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsOptionsExtension extends TeaModel {
        @NameInMap("editFreeze")
        public Boolean editFreeze;

        public static DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsOptionsExtension build(java.util.Map<String, ?> map) throws Exception {
            DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsOptionsExtension self = new DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsOptionsExtension();
            return TeaModel.build(map, self);
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsOptionsExtension setEditFreeze(Boolean editFreeze) {
            this.editFreeze = editFreeze;
            return this;
        }
        public Boolean getEditFreeze() {
            return this.editFreeze;
        }

    }

    public static class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsOptions extends TeaModel {
        @NameInMap("key")
        public String key;

        @NameInMap("value")
        public String value;

        @NameInMap("extension")
        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsOptionsExtension extension;

        public static DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsOptions build(java.util.Map<String, ?> map) throws Exception {
            DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsOptions self = new DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsOptions();
            return TeaModel.build(map, self);
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsOptions setKey(String key) {
            this.key = key;
            return this;
        }
        public String getKey() {
            return this.key;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsOptions setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsOptions setExtension(DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsOptionsExtension extension) {
            this.extension = extension;
            return this;
        }
        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsOptionsExtension getExtension() {
            return this.extension;
        }

    }

    public static class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceFieldsRelatePropsOptions extends TeaModel {
        // 选项数据主键
        @NameInMap("key")
        public String key;

        // 选项显示内容
        @NameInMap("value")
        public String value;

        public static DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceFieldsRelatePropsOptions build(java.util.Map<String, ?> map) throws Exception {
            DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceFieldsRelatePropsOptions self = new DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceFieldsRelatePropsOptions();
            return TeaModel.build(map, self);
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceFieldsRelatePropsOptions setKey(String key) {
            this.key = key;
            return this;
        }
        public String getKey() {
            return this.key;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceFieldsRelatePropsOptions setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

    }

    public static class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceFieldsRelatePropsStatField extends TeaModel {
        @NameInMap("fieldId")
        public String fieldId;

        @NameInMap("label")
        public String label;

        @NameInMap("upper")
        public Boolean upper;

        @NameInMap("unit")
        public String unit;

        public static DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceFieldsRelatePropsStatField build(java.util.Map<String, ?> map) throws Exception {
            DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceFieldsRelatePropsStatField self = new DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceFieldsRelatePropsStatField();
            return TeaModel.build(map, self);
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceFieldsRelatePropsStatField setFieldId(String fieldId) {
            this.fieldId = fieldId;
            return this;
        }
        public String getFieldId() {
            return this.fieldId;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceFieldsRelatePropsStatField setLabel(String label) {
            this.label = label;
            return this;
        }
        public String getLabel() {
            return this.label;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceFieldsRelatePropsStatField setUpper(Boolean upper) {
            this.upper = upper;
            return this;
        }
        public Boolean getUpper() {
            return this.upper;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceFieldsRelatePropsStatField setUnit(String unit) {
            this.unit = unit;
            return this;
        }
        public String getUnit() {
            return this.unit;
        }

    }

    public static class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceFieldsRelateProps extends TeaModel {
        // 字段id
        @NameInMap("fieldId")
        public String fieldId;

        // 字段标题
        @NameInMap("label")
        public String label;

        // 字段是否必填
        @NameInMap("required")
        public Boolean required;

        @NameInMap("requiredEditableFreeze")
        public Boolean requiredEditableFreeze;

        @NameInMap("labelEditableFreeze")
        public Boolean labelEditableFreeze;

        // 说明文字内容
        @NameInMap("content")
        public String content;

        // 时间格式
        @NameInMap("format")
        public String format;

        // 选项内容列表
        @NameInMap("options")
        public java.util.List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceFieldsRelatePropsOptions> options;

        // 是否需要大写 默认是需要
        @NameInMap("notUpper")
        public String notUpper;

        // 数字组件/日期区间组件单位属性
        @NameInMap("unit")
        public String unit;

        // 界面空值提示占位符 前后端统一用placeholder
        @NameInMap("placeholder")
        public String placeholder;

        // 字段别名
        @NameInMap("bizAlias")
        public String bizAlias;

        // 是否自动计算时长
        @NameInMap("duration")
        public String duration;

        // 内部联系人choice
        @NameInMap("choice")
        public Long choice;

        // 是否可编辑
        @NameInMap("disabled")
        public Boolean disabled;

        // textnote的样式
        @NameInMap("align")
        public String align;

        // 隐藏字段
        @NameInMap("invisible")
        public Boolean invisible;

        // 是否有支付属性
        @NameInMap("payEnable")
        public Boolean payEnable;

        // 需要计算总和的明细组件
        @NameInMap("statField")
        public java.util.List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceFieldsRelatePropsStatField> statField;

        // 说明文案的链接地址
        @NameInMap("link")
        public String link;

        // 明细打印排版方式
        @NameInMap("verticalPrint")
        public Boolean verticalPrint;

        // 公式
        @NameInMap("formula")
        public String formula;

        @NameInMap("quote")
        public Long quote;

        @NameInMap("multi")
        public Long multi;

        public static DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceFieldsRelateProps build(java.util.Map<String, ?> map) throws Exception {
            DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceFieldsRelateProps self = new DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceFieldsRelateProps();
            return TeaModel.build(map, self);
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceFieldsRelateProps setFieldId(String fieldId) {
            this.fieldId = fieldId;
            return this;
        }
        public String getFieldId() {
            return this.fieldId;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceFieldsRelateProps setLabel(String label) {
            this.label = label;
            return this;
        }
        public String getLabel() {
            return this.label;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceFieldsRelateProps setRequired(Boolean required) {
            this.required = required;
            return this;
        }
        public Boolean getRequired() {
            return this.required;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceFieldsRelateProps setRequiredEditableFreeze(Boolean requiredEditableFreeze) {
            this.requiredEditableFreeze = requiredEditableFreeze;
            return this;
        }
        public Boolean getRequiredEditableFreeze() {
            return this.requiredEditableFreeze;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceFieldsRelateProps setLabelEditableFreeze(Boolean labelEditableFreeze) {
            this.labelEditableFreeze = labelEditableFreeze;
            return this;
        }
        public Boolean getLabelEditableFreeze() {
            return this.labelEditableFreeze;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceFieldsRelateProps setContent(String content) {
            this.content = content;
            return this;
        }
        public String getContent() {
            return this.content;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceFieldsRelateProps setFormat(String format) {
            this.format = format;
            return this;
        }
        public String getFormat() {
            return this.format;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceFieldsRelateProps setOptions(java.util.List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceFieldsRelatePropsOptions> options) {
            this.options = options;
            return this;
        }
        public java.util.List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceFieldsRelatePropsOptions> getOptions() {
            return this.options;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceFieldsRelateProps setNotUpper(String notUpper) {
            this.notUpper = notUpper;
            return this;
        }
        public String getNotUpper() {
            return this.notUpper;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceFieldsRelateProps setUnit(String unit) {
            this.unit = unit;
            return this;
        }
        public String getUnit() {
            return this.unit;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceFieldsRelateProps setPlaceholder(String placeholder) {
            this.placeholder = placeholder;
            return this;
        }
        public String getPlaceholder() {
            return this.placeholder;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceFieldsRelateProps setBizAlias(String bizAlias) {
            this.bizAlias = bizAlias;
            return this;
        }
        public String getBizAlias() {
            return this.bizAlias;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceFieldsRelateProps setDuration(String duration) {
            this.duration = duration;
            return this;
        }
        public String getDuration() {
            return this.duration;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceFieldsRelateProps setChoice(Long choice) {
            this.choice = choice;
            return this;
        }
        public Long getChoice() {
            return this.choice;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceFieldsRelateProps setDisabled(Boolean disabled) {
            this.disabled = disabled;
            return this;
        }
        public Boolean getDisabled() {
            return this.disabled;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceFieldsRelateProps setAlign(String align) {
            this.align = align;
            return this;
        }
        public String getAlign() {
            return this.align;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceFieldsRelateProps setInvisible(Boolean invisible) {
            this.invisible = invisible;
            return this;
        }
        public Boolean getInvisible() {
            return this.invisible;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceFieldsRelateProps setPayEnable(Boolean payEnable) {
            this.payEnable = payEnable;
            return this;
        }
        public Boolean getPayEnable() {
            return this.payEnable;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceFieldsRelateProps setStatField(java.util.List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceFieldsRelatePropsStatField> statField) {
            this.statField = statField;
            return this;
        }
        public java.util.List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceFieldsRelatePropsStatField> getStatField() {
            return this.statField;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceFieldsRelateProps setLink(String link) {
            this.link = link;
            return this;
        }
        public String getLink() {
            return this.link;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceFieldsRelateProps setVerticalPrint(Boolean verticalPrint) {
            this.verticalPrint = verticalPrint;
            return this;
        }
        public Boolean getVerticalPrint() {
            return this.verticalPrint;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceFieldsRelateProps setFormula(String formula) {
            this.formula = formula;
            return this;
        }
        public String getFormula() {
            return this.formula;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceFieldsRelateProps setQuote(Long quote) {
            this.quote = quote;
            return this;
        }
        public Long getQuote() {
            return this.quote;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceFieldsRelateProps setMulti(Long multi) {
            this.multi = multi;
            return this;
        }
        public Long getMulti() {
            return this.multi;
        }

    }

    public static class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceFields extends TeaModel {
        // 字段类型
        @NameInMap("componentName")
        public String componentName;

        // 字段属性
        @NameInMap("relateProps")
        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceFieldsRelateProps relateProps;

        public static DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceFields build(java.util.Map<String, ?> map) throws Exception {
            DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceFields self = new DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceFields();
            return TeaModel.build(map, self);
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceFields setComponentName(String componentName) {
            this.componentName = componentName;
            return this;
        }
        public String getComponentName() {
            return this.componentName;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceFields setRelateProps(DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceFieldsRelateProps relateProps) {
            this.relateProps = relateProps;
            return this;
        }
        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceFieldsRelateProps getRelateProps() {
            return this.relateProps;
        }

    }

    public static class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceDataSourceParamsFilters extends TeaModel {
        @NameInMap("valueType")
        public String valueType;

        @NameInMap("filterType")
        public String filterType;

        @NameInMap("value")
        public String value;

        @NameInMap("fieldId")
        public String fieldId;

        public static DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceDataSourceParamsFilters build(java.util.Map<String, ?> map) throws Exception {
            DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceDataSourceParamsFilters self = new DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceDataSourceParamsFilters();
            return TeaModel.build(map, self);
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceDataSourceParamsFilters setValueType(String valueType) {
            this.valueType = valueType;
            return this;
        }
        public String getValueType() {
            return this.valueType;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceDataSourceParamsFilters setFilterType(String filterType) {
            this.filterType = filterType;
            return this;
        }
        public String getFilterType() {
            return this.filterType;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceDataSourceParamsFilters setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceDataSourceParamsFilters setFieldId(String fieldId) {
            this.fieldId = fieldId;
            return this;
        }
        public String getFieldId() {
            return this.fieldId;
        }

    }

    public static class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceDataSourceParams extends TeaModel {
        @NameInMap("filters")
        public java.util.List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceDataSourceParamsFilters> filters;

        public static DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceDataSourceParams build(java.util.Map<String, ?> map) throws Exception {
            DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceDataSourceParams self = new DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceDataSourceParams();
            return TeaModel.build(map, self);
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceDataSourceParams setFilters(java.util.List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceDataSourceParamsFilters> filters) {
            this.filters = filters;
            return this;
        }
        public java.util.List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceDataSourceParamsFilters> getFilters() {
            return this.filters;
        }

    }

    public static class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceDataSourceTarget extends TeaModel {
        @NameInMap("appUuid")
        public String appUuid;

        @NameInMap("appType")
        public Long appType;

        @NameInMap("bizType")
        public String bizType;

        @NameInMap("formCode")
        public String formCode;

        public static DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceDataSourceTarget build(java.util.Map<String, ?> map) throws Exception {
            DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceDataSourceTarget self = new DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceDataSourceTarget();
            return TeaModel.build(map, self);
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceDataSourceTarget setAppUuid(String appUuid) {
            this.appUuid = appUuid;
            return this;
        }
        public String getAppUuid() {
            return this.appUuid;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceDataSourceTarget setAppType(Long appType) {
            this.appType = appType;
            return this;
        }
        public Long getAppType() {
            return this.appType;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceDataSourceTarget setBizType(String bizType) {
            this.bizType = bizType;
            return this;
        }
        public String getBizType() {
            return this.bizType;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceDataSourceTarget setFormCode(String formCode) {
            this.formCode = formCode;
            return this;
        }
        public String getFormCode() {
            return this.formCode;
        }

    }

    public static class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceDataSource extends TeaModel {
        @NameInMap("type")
        public String type;

        @NameInMap("params")
        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceDataSourceParams params;

        @NameInMap("target")
        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceDataSourceTarget target;

        public static DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceDataSource build(java.util.Map<String, ?> map) throws Exception {
            DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceDataSource self = new DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceDataSource();
            return TeaModel.build(map, self);
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceDataSource setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceDataSource setParams(DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceDataSourceParams params) {
            this.params = params;
            return this;
        }
        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceDataSourceParams getParams() {
            return this.params;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceDataSource setTarget(DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceDataSourceTarget target) {
            this.target = target;
            return this;
        }
        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceDataSourceTarget getTarget() {
            return this.target;
        }

    }

    public static class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSource extends TeaModel {
        @NameInMap("bizType")
        public String bizType;

        // 关联表单的关联控件显示
        @NameInMap("fields")
        public java.util.List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceFields> fields;

        @NameInMap("dataSource")
        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceDataSource dataSource;

        public static DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSource build(java.util.Map<String, ?> map) throws Exception {
            DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSource self = new DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSource();
            return TeaModel.build(map, self);
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSource setBizType(String bizType) {
            this.bizType = bizType;
            return this;
        }
        public String getBizType() {
            return this.bizType;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSource setFields(java.util.List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceFields> fields) {
            this.fields = fields;
            return this;
        }
        public java.util.List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceFields> getFields() {
            return this.fields;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSource setDataSource(DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceDataSource dataSource) {
            this.dataSource = dataSource;
            return this;
        }
        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceDataSource getDataSource() {
            return this.dataSource;
        }

    }

    public static class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelatePropsOptionsExtension extends TeaModel {
        @NameInMap("editFreeze")
        public Boolean editFreeze;

        public static DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelatePropsOptionsExtension build(java.util.Map<String, ?> map) throws Exception {
            DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelatePropsOptionsExtension self = new DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelatePropsOptionsExtension();
            return TeaModel.build(map, self);
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelatePropsOptionsExtension setEditFreeze(Boolean editFreeze) {
            this.editFreeze = editFreeze;
            return this;
        }
        public Boolean getEditFreeze() {
            return this.editFreeze;
        }

    }

    public static class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelatePropsOptions extends TeaModel {
        @NameInMap("key")
        public String key;

        @NameInMap("value")
        public String value;

        @NameInMap("extension")
        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelatePropsOptionsExtension extension;

        public static DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelatePropsOptions build(java.util.Map<String, ?> map) throws Exception {
            DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelatePropsOptions self = new DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelatePropsOptions();
            return TeaModel.build(map, self);
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelatePropsOptions setKey(String key) {
            this.key = key;
            return this;
        }
        public String getKey() {
            return this.key;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelatePropsOptions setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelatePropsOptions setExtension(DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelatePropsOptionsExtension extension) {
            this.extension = extension;
            return this;
        }
        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelatePropsOptionsExtension getExtension() {
            return this.extension;
        }

    }

    public static class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelatePropsStatField extends TeaModel {
        @NameInMap("fieldId")
        public String fieldId;

        @NameInMap("label")
        public String label;

        @NameInMap("upper")
        public Boolean upper;

        @NameInMap("unit")
        public String unit;

        public static DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelatePropsStatField build(java.util.Map<String, ?> map) throws Exception {
            DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelatePropsStatField self = new DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelatePropsStatField();
            return TeaModel.build(map, self);
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelatePropsStatField setFieldId(String fieldId) {
            this.fieldId = fieldId;
            return this;
        }
        public String getFieldId() {
            return this.fieldId;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelatePropsStatField setLabel(String label) {
            this.label = label;
            return this;
        }
        public String getLabel() {
            return this.label;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelatePropsStatField setUpper(Boolean upper) {
            this.upper = upper;
            return this;
        }
        public Boolean getUpper() {
            return this.upper;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelatePropsStatField setUnit(String unit) {
            this.unit = unit;
            return this;
        }
        public String getUnit() {
            return this.unit;
        }

    }

    public static class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelateProps extends TeaModel {
        @NameInMap("fieldId")
        public String fieldId;

        @NameInMap("label")
        public String label;

        @NameInMap("required")
        public Boolean required;

        @NameInMap("requiredEditableFreeze")
        public Boolean requiredEditableFreeze;

        @NameInMap("labelEditableFreeze")
        public Boolean labelEditableFreeze;

        @NameInMap("content")
        public String content;

        @NameInMap("format")
        public String format;

        @NameInMap("options")
        public java.util.List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelatePropsOptions> options;

        @NameInMap("notUpper")
        public String notUpper;

        @NameInMap("unit")
        public String unit;

        @NameInMap("placeholder")
        public String placeholder;

        @NameInMap("bizAlias")
        public String bizAlias;

        @NameInMap("duration")
        public Boolean duration;

        @NameInMap("choice")
        public Long choice;

        @NameInMap("disabled")
        public Boolean disabled;

        @NameInMap("align")
        public String align;

        @NameInMap("invisible")
        public Boolean invisible;

        @NameInMap("payEnable")
        public Boolean payEnable;

        @NameInMap("statField")
        public java.util.List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelatePropsStatField> statField;

        @NameInMap("link")
        public String link;

        @NameInMap("verticalPrint")
        public Boolean verticalPrint;

        @NameInMap("formula")
        public String formula;

        @NameInMap("watermark")
        public Boolean watermark;

        @NameInMap("limit")
        public Long limit;

        @NameInMap("spread")
        public Boolean spread;

        @NameInMap("ratio")
        public Long ratio;

        @NameInMap("durationLabel")
        public String durationLabel;

        @NameInMap("mode")
        public String mode;

        public static DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelateProps build(java.util.Map<String, ?> map) throws Exception {
            DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelateProps self = new DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelateProps();
            return TeaModel.build(map, self);
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelateProps setFieldId(String fieldId) {
            this.fieldId = fieldId;
            return this;
        }
        public String getFieldId() {
            return this.fieldId;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelateProps setLabel(String label) {
            this.label = label;
            return this;
        }
        public String getLabel() {
            return this.label;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelateProps setRequired(Boolean required) {
            this.required = required;
            return this;
        }
        public Boolean getRequired() {
            return this.required;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelateProps setRequiredEditableFreeze(Boolean requiredEditableFreeze) {
            this.requiredEditableFreeze = requiredEditableFreeze;
            return this;
        }
        public Boolean getRequiredEditableFreeze() {
            return this.requiredEditableFreeze;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelateProps setLabelEditableFreeze(Boolean labelEditableFreeze) {
            this.labelEditableFreeze = labelEditableFreeze;
            return this;
        }
        public Boolean getLabelEditableFreeze() {
            return this.labelEditableFreeze;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelateProps setContent(String content) {
            this.content = content;
            return this;
        }
        public String getContent() {
            return this.content;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelateProps setFormat(String format) {
            this.format = format;
            return this;
        }
        public String getFormat() {
            return this.format;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelateProps setOptions(java.util.List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelatePropsOptions> options) {
            this.options = options;
            return this;
        }
        public java.util.List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelatePropsOptions> getOptions() {
            return this.options;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelateProps setNotUpper(String notUpper) {
            this.notUpper = notUpper;
            return this;
        }
        public String getNotUpper() {
            return this.notUpper;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelateProps setUnit(String unit) {
            this.unit = unit;
            return this;
        }
        public String getUnit() {
            return this.unit;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelateProps setPlaceholder(String placeholder) {
            this.placeholder = placeholder;
            return this;
        }
        public String getPlaceholder() {
            return this.placeholder;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelateProps setBizAlias(String bizAlias) {
            this.bizAlias = bizAlias;
            return this;
        }
        public String getBizAlias() {
            return this.bizAlias;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelateProps setDuration(Boolean duration) {
            this.duration = duration;
            return this;
        }
        public Boolean getDuration() {
            return this.duration;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelateProps setChoice(Long choice) {
            this.choice = choice;
            return this;
        }
        public Long getChoice() {
            return this.choice;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelateProps setDisabled(Boolean disabled) {
            this.disabled = disabled;
            return this;
        }
        public Boolean getDisabled() {
            return this.disabled;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelateProps setAlign(String align) {
            this.align = align;
            return this;
        }
        public String getAlign() {
            return this.align;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelateProps setInvisible(Boolean invisible) {
            this.invisible = invisible;
            return this;
        }
        public Boolean getInvisible() {
            return this.invisible;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelateProps setPayEnable(Boolean payEnable) {
            this.payEnable = payEnable;
            return this;
        }
        public Boolean getPayEnable() {
            return this.payEnable;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelateProps setStatField(java.util.List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelatePropsStatField> statField) {
            this.statField = statField;
            return this;
        }
        public java.util.List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelatePropsStatField> getStatField() {
            return this.statField;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelateProps setLink(String link) {
            this.link = link;
            return this;
        }
        public String getLink() {
            return this.link;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelateProps setVerticalPrint(Boolean verticalPrint) {
            this.verticalPrint = verticalPrint;
            return this;
        }
        public Boolean getVerticalPrint() {
            return this.verticalPrint;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelateProps setFormula(String formula) {
            this.formula = formula;
            return this;
        }
        public String getFormula() {
            return this.formula;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelateProps setWatermark(Boolean watermark) {
            this.watermark = watermark;
            return this;
        }
        public Boolean getWatermark() {
            return this.watermark;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelateProps setLimit(Long limit) {
            this.limit = limit;
            return this;
        }
        public Long getLimit() {
            return this.limit;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelateProps setSpread(Boolean spread) {
            this.spread = spread;
            return this;
        }
        public Boolean getSpread() {
            return this.spread;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelateProps setRatio(Long ratio) {
            this.ratio = ratio;
            return this;
        }
        public Long getRatio() {
            return this.ratio;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelateProps setDurationLabel(String durationLabel) {
            this.durationLabel = durationLabel;
            return this;
        }
        public String getDurationLabel() {
            return this.durationLabel;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelateProps setMode(String mode) {
            this.mode = mode;
            return this;
        }
        public String getMode() {
            return this.mode;
        }

    }

    public static class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFields extends TeaModel {
        @NameInMap("componentName")
        public String componentName;

        @NameInMap("relateProps")
        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelateProps relateProps;

        public static DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFields build(java.util.Map<String, ?> map) throws Exception {
            DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFields self = new DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFields();
            return TeaModel.build(map, self);
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFields setComponentName(String componentName) {
            this.componentName = componentName;
            return this;
        }
        public String getComponentName() {
            return this.componentName;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFields setRelateProps(DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelateProps relateProps) {
            this.relateProps = relateProps;
            return this;
        }
        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelateProps getRelateProps() {
            return this.relateProps;
        }

    }

    public static class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsDataSourceParamsFilters extends TeaModel {
        @NameInMap("valueType")
        public String valueType;

        @NameInMap("filterType")
        public String filterType;

        @NameInMap("value")
        public String value;

        @NameInMap("fieldId")
        public String fieldId;

        public static DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsDataSourceParamsFilters build(java.util.Map<String, ?> map) throws Exception {
            DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsDataSourceParamsFilters self = new DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsDataSourceParamsFilters();
            return TeaModel.build(map, self);
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsDataSourceParamsFilters setValueType(String valueType) {
            this.valueType = valueType;
            return this;
        }
        public String getValueType() {
            return this.valueType;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsDataSourceParamsFilters setFilterType(String filterType) {
            this.filterType = filterType;
            return this;
        }
        public String getFilterType() {
            return this.filterType;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsDataSourceParamsFilters setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsDataSourceParamsFilters setFieldId(String fieldId) {
            this.fieldId = fieldId;
            return this;
        }
        public String getFieldId() {
            return this.fieldId;
        }

    }

    public static class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsDataSourceParams extends TeaModel {
        @NameInMap("filters")
        public java.util.List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsDataSourceParamsFilters> filters;

        public static DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsDataSourceParams build(java.util.Map<String, ?> map) throws Exception {
            DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsDataSourceParams self = new DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsDataSourceParams();
            return TeaModel.build(map, self);
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsDataSourceParams setFilters(java.util.List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsDataSourceParamsFilters> filters) {
            this.filters = filters;
            return this;
        }
        public java.util.List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsDataSourceParamsFilters> getFilters() {
            return this.filters;
        }

    }

    public static class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsDataSourceTarget extends TeaModel {
        @NameInMap("appUuid")
        public String appUuid;

        @NameInMap("appType")
        public Long appType;

        @NameInMap("bizType")
        public String bizType;

        @NameInMap("formCode")
        public String formCode;

        public static DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsDataSourceTarget build(java.util.Map<String, ?> map) throws Exception {
            DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsDataSourceTarget self = new DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsDataSourceTarget();
            return TeaModel.build(map, self);
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsDataSourceTarget setAppUuid(String appUuid) {
            this.appUuid = appUuid;
            return this;
        }
        public String getAppUuid() {
            return this.appUuid;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsDataSourceTarget setAppType(Long appType) {
            this.appType = appType;
            return this;
        }
        public Long getAppType() {
            return this.appType;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsDataSourceTarget setBizType(String bizType) {
            this.bizType = bizType;
            return this;
        }
        public String getBizType() {
            return this.bizType;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsDataSourceTarget setFormCode(String formCode) {
            this.formCode = formCode;
            return this;
        }
        public String getFormCode() {
            return this.formCode;
        }

    }

    public static class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsDataSource extends TeaModel {
        @NameInMap("type")
        public String type;

        @NameInMap("params")
        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsDataSourceParams params;

        @NameInMap("target")
        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsDataSourceTarget target;

        public static DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsDataSource build(java.util.Map<String, ?> map) throws Exception {
            DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsDataSource self = new DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsDataSource();
            return TeaModel.build(map, self);
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsDataSource setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsDataSource setParams(DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsDataSourceParams params) {
            this.params = params;
            return this;
        }
        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsDataSourceParams getParams() {
            return this.params;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsDataSource setTarget(DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsDataSourceTarget target) {
            this.target = target;
            return this;
        }
        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsDataSourceTarget getTarget() {
            return this.target;
        }

    }

    public static class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsStatField extends TeaModel {
        @NameInMap("fieldId")
        public String fieldId;

        @NameInMap("label")
        public String label;

        @NameInMap("upper")
        public Boolean upper;

        @NameInMap("unit")
        public String unit;

        public static DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsStatField build(java.util.Map<String, ?> map) throws Exception {
            DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsStatField self = new DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsStatField();
            return TeaModel.build(map, self);
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsStatField setFieldId(String fieldId) {
            this.fieldId = fieldId;
            return this;
        }
        public String getFieldId() {
            return this.fieldId;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsStatField setLabel(String label) {
            this.label = label;
            return this;
        }
        public String getLabel() {
            return this.label;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsStatField setUpper(Boolean upper) {
            this.upper = upper;
            return this;
        }
        public Boolean getUpper() {
            return this.upper;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsStatField setUnit(String unit) {
            this.unit = unit;
            return this;
        }
        public String getUnit() {
            return this.unit;
        }

    }

    public static class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRule extends TeaModel {
        @NameInMap("type")
        public String type;

        @NameInMap("value")
        public String value;

        public static DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRule build(java.util.Map<String, ?> map) throws Exception {
            DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRule self = new DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRule();
            return TeaModel.build(map, self);
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRule setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRule setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

    }

    public static class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenProps extends TeaModel {
        @NameInMap("fieldId")
        public String fieldId;

        @NameInMap("label")
        public String label;

        @NameInMap("sortable")
        public Boolean sortable;

        @NameInMap("labelEditableFreeze")
        public Boolean labelEditableFreeze;

        @NameInMap("required")
        public Boolean required;

        @NameInMap("requiredEditableFreeze")
        public Boolean requiredEditableFreeze;

        @NameInMap("notPrint")
        public String notPrint;

        @NameInMap("content")
        public String content;

        @NameInMap("format")
        public String format;

        @NameInMap("options")
        public java.util.List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsOptions> options;

        @NameInMap("notUpper")
        public String notUpper;

        @NameInMap("unit")
        public String unit;

        @NameInMap("placeholder")
        public String placeholder;

        @NameInMap("bizAlias")
        public String bizAlias;

        @NameInMap("duration")
        public Boolean duration;

        @NameInMap("choice")
        public Long choice;

        @NameInMap("disabled")
        public Boolean disabled;

        @NameInMap("align")
        public String align;

        @NameInMap("relateSource")
        public java.util.List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSource> relateSource;

        @NameInMap("fields")
        public java.util.List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFields> fields;

        @NameInMap("dataSource")
        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsDataSource dataSource;

        @NameInMap("invisible")
        public Boolean invisible;

        @NameInMap("payEnable")
        public Boolean payEnable;

        @NameInMap("statField")
        public java.util.List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsStatField> statField;

        @NameInMap("link")
        public String link;

        @NameInMap("verticalPrint")
        public Boolean verticalPrint;

        @NameInMap("formula")
        public String formula;

        @NameInMap("quote")
        public Long quote;

        @NameInMap("rule")
        public java.util.List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRule> rule;

        @NameInMap("tableViewMode")
        public String tableViewMode;

        @NameInMap("actionName")
        public String actionName;

        @NameInMap("watermark")
        public Boolean watermark;

        @NameInMap("limit")
        public Long limit;

        @NameInMap("spread")
        public Boolean spread;

        @NameInMap("ratio")
        public Long ratio;

        @NameInMap("durationLabel")
        public String durationLabel;

        @NameInMap("mode")
        public String mode;

        public static DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenProps build(java.util.Map<String, ?> map) throws Exception {
            DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenProps self = new DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenProps();
            return TeaModel.build(map, self);
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenProps setFieldId(String fieldId) {
            this.fieldId = fieldId;
            return this;
        }
        public String getFieldId() {
            return this.fieldId;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenProps setLabel(String label) {
            this.label = label;
            return this;
        }
        public String getLabel() {
            return this.label;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenProps setSortable(Boolean sortable) {
            this.sortable = sortable;
            return this;
        }
        public Boolean getSortable() {
            return this.sortable;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenProps setLabelEditableFreeze(Boolean labelEditableFreeze) {
            this.labelEditableFreeze = labelEditableFreeze;
            return this;
        }
        public Boolean getLabelEditableFreeze() {
            return this.labelEditableFreeze;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenProps setRequired(Boolean required) {
            this.required = required;
            return this;
        }
        public Boolean getRequired() {
            return this.required;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenProps setRequiredEditableFreeze(Boolean requiredEditableFreeze) {
            this.requiredEditableFreeze = requiredEditableFreeze;
            return this;
        }
        public Boolean getRequiredEditableFreeze() {
            return this.requiredEditableFreeze;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenProps setNotPrint(String notPrint) {
            this.notPrint = notPrint;
            return this;
        }
        public String getNotPrint() {
            return this.notPrint;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenProps setContent(String content) {
            this.content = content;
            return this;
        }
        public String getContent() {
            return this.content;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenProps setFormat(String format) {
            this.format = format;
            return this;
        }
        public String getFormat() {
            return this.format;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenProps setOptions(java.util.List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsOptions> options) {
            this.options = options;
            return this;
        }
        public java.util.List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsOptions> getOptions() {
            return this.options;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenProps setNotUpper(String notUpper) {
            this.notUpper = notUpper;
            return this;
        }
        public String getNotUpper() {
            return this.notUpper;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenProps setUnit(String unit) {
            this.unit = unit;
            return this;
        }
        public String getUnit() {
            return this.unit;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenProps setPlaceholder(String placeholder) {
            this.placeholder = placeholder;
            return this;
        }
        public String getPlaceholder() {
            return this.placeholder;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenProps setBizAlias(String bizAlias) {
            this.bizAlias = bizAlias;
            return this;
        }
        public String getBizAlias() {
            return this.bizAlias;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenProps setDuration(Boolean duration) {
            this.duration = duration;
            return this;
        }
        public Boolean getDuration() {
            return this.duration;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenProps setChoice(Long choice) {
            this.choice = choice;
            return this;
        }
        public Long getChoice() {
            return this.choice;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenProps setDisabled(Boolean disabled) {
            this.disabled = disabled;
            return this;
        }
        public Boolean getDisabled() {
            return this.disabled;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenProps setAlign(String align) {
            this.align = align;
            return this;
        }
        public String getAlign() {
            return this.align;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenProps setRelateSource(java.util.List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSource> relateSource) {
            this.relateSource = relateSource;
            return this;
        }
        public java.util.List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSource> getRelateSource() {
            return this.relateSource;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenProps setFields(java.util.List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFields> fields) {
            this.fields = fields;
            return this;
        }
        public java.util.List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFields> getFields() {
            return this.fields;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenProps setDataSource(DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsDataSource dataSource) {
            this.dataSource = dataSource;
            return this;
        }
        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsDataSource getDataSource() {
            return this.dataSource;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenProps setInvisible(Boolean invisible) {
            this.invisible = invisible;
            return this;
        }
        public Boolean getInvisible() {
            return this.invisible;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenProps setPayEnable(Boolean payEnable) {
            this.payEnable = payEnable;
            return this;
        }
        public Boolean getPayEnable() {
            return this.payEnable;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenProps setStatField(java.util.List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsStatField> statField) {
            this.statField = statField;
            return this;
        }
        public java.util.List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsStatField> getStatField() {
            return this.statField;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenProps setLink(String link) {
            this.link = link;
            return this;
        }
        public String getLink() {
            return this.link;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenProps setVerticalPrint(Boolean verticalPrint) {
            this.verticalPrint = verticalPrint;
            return this;
        }
        public Boolean getVerticalPrint() {
            return this.verticalPrint;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenProps setFormula(String formula) {
            this.formula = formula;
            return this;
        }
        public String getFormula() {
            return this.formula;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenProps setQuote(Long quote) {
            this.quote = quote;
            return this;
        }
        public Long getQuote() {
            return this.quote;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenProps setRule(java.util.List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRule> rule) {
            this.rule = rule;
            return this;
        }
        public java.util.List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRule> getRule() {
            return this.rule;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenProps setTableViewMode(String tableViewMode) {
            this.tableViewMode = tableViewMode;
            return this;
        }
        public String getTableViewMode() {
            return this.tableViewMode;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenProps setActionName(String actionName) {
            this.actionName = actionName;
            return this;
        }
        public String getActionName() {
            return this.actionName;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenProps setWatermark(Boolean watermark) {
            this.watermark = watermark;
            return this;
        }
        public Boolean getWatermark() {
            return this.watermark;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenProps setLimit(Long limit) {
            this.limit = limit;
            return this;
        }
        public Long getLimit() {
            return this.limit;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenProps setSpread(Boolean spread) {
            this.spread = spread;
            return this;
        }
        public Boolean getSpread() {
            return this.spread;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenProps setRatio(Long ratio) {
            this.ratio = ratio;
            return this;
        }
        public Long getRatio() {
            return this.ratio;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenProps setDurationLabel(String durationLabel) {
            this.durationLabel = durationLabel;
            return this;
        }
        public String getDurationLabel() {
            return this.durationLabel;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenProps setMode(String mode) {
            this.mode = mode;
            return this;
        }
        public String getMode() {
            return this.mode;
        }

    }

    public static class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildren extends TeaModel {
        @NameInMap("componentName")
        public String componentName;

        @NameInMap("props")
        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenProps props;

        public static DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildren build(java.util.Map<String, ?> map) throws Exception {
            DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildren self = new DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildren();
            return TeaModel.build(map, self);
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildren setComponentName(String componentName) {
            this.componentName = componentName;
            return this;
        }
        public String getComponentName() {
            return this.componentName;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildren setProps(DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenProps props) {
            this.props = props;
            return this;
        }
        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenProps getProps() {
            return this.props;
        }

    }

    public static class DescribeRelationMetaResponseBodyRelationMetaDTOListItems extends TeaModel {
        // 字段类型
        @NameInMap("componentName")
        public String componentName;

        // 字段属性
        @NameInMap("props")
        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsProps props;

        // 子字段列表
        @NameInMap("children")
        public java.util.List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildren> children;

        public static DescribeRelationMetaResponseBodyRelationMetaDTOListItems build(java.util.Map<String, ?> map) throws Exception {
            DescribeRelationMetaResponseBodyRelationMetaDTOListItems self = new DescribeRelationMetaResponseBodyRelationMetaDTOListItems();
            return TeaModel.build(map, self);
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItems setComponentName(String componentName) {
            this.componentName = componentName;
            return this;
        }
        public String getComponentName() {
            return this.componentName;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItems setProps(DescribeRelationMetaResponseBodyRelationMetaDTOListItemsProps props) {
            this.props = props;
            return this;
        }
        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsProps getProps() {
            return this.props;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItems setChildren(java.util.List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildren> children) {
            this.children = children;
            return this;
        }
        public java.util.List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildren> getChildren() {
            return this.children;
        }

    }

    public static class DescribeRelationMetaResponseBodyRelationMetaDTOList extends TeaModel {
        // 关系类型
        @NameInMap("relationType")
        public String relationType;

        // 模型结构名称
        @NameInMap("name")
        public String name;

        // 模型结构描述
        @NameInMap("desc")
        public String desc;

        // 模型结构code
        @NameInMap("relationMetaCode")
        public String relationMetaCode;

        // 模型结构状态
        @NameInMap("relationMetaStatus")
        public String relationMetaStatus;

        // 创建者userId
        @NameInMap("creatorUserId")
        public String creatorUserId;

        // 创建时间
        @NameInMap("gmtCreate")
        public String gmtCreate;

        // 修改时间
        @NameInMap("gmtModified")
        public String gmtModified;

        // 模型结构字段集合
        @NameInMap("items")
        public java.util.List<DescribeRelationMetaResponseBodyRelationMetaDTOListItems> items;

        public static DescribeRelationMetaResponseBodyRelationMetaDTOList build(java.util.Map<String, ?> map) throws Exception {
            DescribeRelationMetaResponseBodyRelationMetaDTOList self = new DescribeRelationMetaResponseBodyRelationMetaDTOList();
            return TeaModel.build(map, self);
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOList setRelationType(String relationType) {
            this.relationType = relationType;
            return this;
        }
        public String getRelationType() {
            return this.relationType;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOList setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOList setDesc(String desc) {
            this.desc = desc;
            return this;
        }
        public String getDesc() {
            return this.desc;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOList setRelationMetaCode(String relationMetaCode) {
            this.relationMetaCode = relationMetaCode;
            return this;
        }
        public String getRelationMetaCode() {
            return this.relationMetaCode;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOList setRelationMetaStatus(String relationMetaStatus) {
            this.relationMetaStatus = relationMetaStatus;
            return this;
        }
        public String getRelationMetaStatus() {
            return this.relationMetaStatus;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOList setCreatorUserId(String creatorUserId) {
            this.creatorUserId = creatorUserId;
            return this;
        }
        public String getCreatorUserId() {
            return this.creatorUserId;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOList setGmtCreate(String gmtCreate) {
            this.gmtCreate = gmtCreate;
            return this;
        }
        public String getGmtCreate() {
            return this.gmtCreate;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOList setGmtModified(String gmtModified) {
            this.gmtModified = gmtModified;
            return this;
        }
        public String getGmtModified() {
            return this.gmtModified;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOList setItems(java.util.List<DescribeRelationMetaResponseBodyRelationMetaDTOListItems> items) {
            this.items = items;
            return this;
        }
        public java.util.List<DescribeRelationMetaResponseBodyRelationMetaDTOListItems> getItems() {
            return this.items;
        }

    }

}
