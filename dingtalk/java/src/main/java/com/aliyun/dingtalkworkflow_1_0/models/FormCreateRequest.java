// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class FormCreateRequest extends TeaModel {
    @NameInMap("dingCorpId")
    public String dingCorpId;

    @NameInMap("dingOrgId")
    public Long dingOrgId;

    @NameInMap("dingIsvOrgId")
    public Long dingIsvOrgId;

    @NameInMap("dingSuiteKey")
    public String dingSuiteKey;

    @NameInMap("dingTokenGrantType")
    public Long dingTokenGrantType;

    @NameInMap("RequestId")
    public String requestId;

    @NameInMap("processCode")
    public String processCode;

    // 表单模板名称
    @NameInMap("name")
    public String name;

    // 表单模板描述
    @NameInMap("description")
    public String description;

    // 表单控件列表
    @NameInMap("formComponents")
    public java.util.List<FormCreateRequestFormComponents> formComponents;

    public static FormCreateRequest build(java.util.Map<String, ?> map) throws Exception {
        FormCreateRequest self = new FormCreateRequest();
        return TeaModel.build(map, self);
    }

    public FormCreateRequest setDingCorpId(String dingCorpId) {
        this.dingCorpId = dingCorpId;
        return this;
    }
    public String getDingCorpId() {
        return this.dingCorpId;
    }

    public FormCreateRequest setDingOrgId(Long dingOrgId) {
        this.dingOrgId = dingOrgId;
        return this;
    }
    public Long getDingOrgId() {
        return this.dingOrgId;
    }

    public FormCreateRequest setDingIsvOrgId(Long dingIsvOrgId) {
        this.dingIsvOrgId = dingIsvOrgId;
        return this;
    }
    public Long getDingIsvOrgId() {
        return this.dingIsvOrgId;
    }

    public FormCreateRequest setDingSuiteKey(String dingSuiteKey) {
        this.dingSuiteKey = dingSuiteKey;
        return this;
    }
    public String getDingSuiteKey() {
        return this.dingSuiteKey;
    }

    public FormCreateRequest setDingTokenGrantType(Long dingTokenGrantType) {
        this.dingTokenGrantType = dingTokenGrantType;
        return this;
    }
    public Long getDingTokenGrantType() {
        return this.dingTokenGrantType;
    }

    public FormCreateRequest setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public FormCreateRequest setProcessCode(String processCode) {
        this.processCode = processCode;
        return this;
    }
    public String getProcessCode() {
        return this.processCode;
    }

    public FormCreateRequest setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public FormCreateRequest setDescription(String description) {
        this.description = description;
        return this;
    }
    public String getDescription() {
        return this.description;
    }

    public FormCreateRequest setFormComponents(java.util.List<FormCreateRequestFormComponents> formComponents) {
        this.formComponents = formComponents;
        return this;
    }
    public java.util.List<FormCreateRequestFormComponents> getFormComponents() {
        return this.formComponents;
    }

    public static class FormCreateRequestFormComponentsPropsOptions extends TeaModel {
        // 选项的显示内容
        @NameInMap("value")
        public String value;

        // 选项的唯一主键
        @NameInMap("key")
        public String key;

        public static FormCreateRequestFormComponentsPropsOptions build(java.util.Map<String, ?> map) throws Exception {
            FormCreateRequestFormComponentsPropsOptions self = new FormCreateRequestFormComponentsPropsOptions();
            return TeaModel.build(map, self);
        }

        public FormCreateRequestFormComponentsPropsOptions setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

        public FormCreateRequestFormComponentsPropsOptions setKey(String key) {
            this.key = key;
            return this;
        }
        public String getKey() {
            return this.key;
        }

    }

    public static class FormCreateRequestFormComponentsPropsStatField extends TeaModel {
        // 需要统计的明细控件内子控件id
        @NameInMap("componentId")
        public String componentId;

        // 子控件标题
        @NameInMap("label")
        public String label;

        // 金额控件是否需要大写
        @NameInMap("upper")
        public Boolean upper;

        @NameInMap("payEnable")
        public String payEnable;

        public static FormCreateRequestFormComponentsPropsStatField build(java.util.Map<String, ?> map) throws Exception {
            FormCreateRequestFormComponentsPropsStatField self = new FormCreateRequestFormComponentsPropsStatField();
            return TeaModel.build(map, self);
        }

        public FormCreateRequestFormComponentsPropsStatField setComponentId(String componentId) {
            this.componentId = componentId;
            return this;
        }
        public String getComponentId() {
            return this.componentId;
        }

        public FormCreateRequestFormComponentsPropsStatField setLabel(String label) {
            this.label = label;
            return this;
        }
        public String getLabel() {
            return this.label;
        }

        public FormCreateRequestFormComponentsPropsStatField setUpper(Boolean upper) {
            this.upper = upper;
            return this;
        }
        public Boolean getUpper() {
            return this.upper;
        }

        public FormCreateRequestFormComponentsPropsStatField setPayEnable(String payEnable) {
            this.payEnable = payEnable;
            return this;
        }
        public String getPayEnable() {
            return this.payEnable;
        }

    }

    public static class FormCreateRequestFormComponentsPropsDataSourceTarget extends TeaModel {
        // 应用appUuid
        @NameInMap("appUuid")
        public String appUuid;

        // 表单类型，0流程表单
        @NameInMap("appType")
        public Integer appType;

        // 关联表单业务标识
        @NameInMap("bizType")
        public String bizType;

        // 关联表单的formCode
        @NameInMap("formCode")
        public String formCode;

        public static FormCreateRequestFormComponentsPropsDataSourceTarget build(java.util.Map<String, ?> map) throws Exception {
            FormCreateRequestFormComponentsPropsDataSourceTarget self = new FormCreateRequestFormComponentsPropsDataSourceTarget();
            return TeaModel.build(map, self);
        }

        public FormCreateRequestFormComponentsPropsDataSourceTarget setAppUuid(String appUuid) {
            this.appUuid = appUuid;
            return this;
        }
        public String getAppUuid() {
            return this.appUuid;
        }

        public FormCreateRequestFormComponentsPropsDataSourceTarget setAppType(Integer appType) {
            this.appType = appType;
            return this;
        }
        public Integer getAppType() {
            return this.appType;
        }

        public FormCreateRequestFormComponentsPropsDataSourceTarget setBizType(String bizType) {
            this.bizType = bizType;
            return this;
        }
        public String getBizType() {
            return this.bizType;
        }

        public FormCreateRequestFormComponentsPropsDataSourceTarget setFormCode(String formCode) {
            this.formCode = formCode;
            return this;
        }
        public String getFormCode() {
            return this.formCode;
        }

    }

    public static class FormCreateRequestFormComponentsPropsDataSource extends TeaModel {
        // 关联类型，form关联表单
        @NameInMap("type")
        public String type;

        // 关联表单信息
        @NameInMap("target")
        public FormCreateRequestFormComponentsPropsDataSourceTarget target;

        public static FormCreateRequestFormComponentsPropsDataSource build(java.util.Map<String, ?> map) throws Exception {
            FormCreateRequestFormComponentsPropsDataSource self = new FormCreateRequestFormComponentsPropsDataSource();
            return TeaModel.build(map, self);
        }

        public FormCreateRequestFormComponentsPropsDataSource setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

        public FormCreateRequestFormComponentsPropsDataSource setTarget(FormCreateRequestFormComponentsPropsDataSourceTarget target) {
            this.target = target;
            return this;
        }
        public FormCreateRequestFormComponentsPropsDataSourceTarget getTarget() {
            return this.target;
        }

    }

    public static class FormCreateRequestFormComponentsPropsFieldsPropsOptions extends TeaModel {
        // 每一个选项的唯一键
        @NameInMap("key")
        public String key;

        // 每一个选项的值
        @NameInMap("value")
        public String value;

        public static FormCreateRequestFormComponentsPropsFieldsPropsOptions build(java.util.Map<String, ?> map) throws Exception {
            FormCreateRequestFormComponentsPropsFieldsPropsOptions self = new FormCreateRequestFormComponentsPropsFieldsPropsOptions();
            return TeaModel.build(map, self);
        }

        public FormCreateRequestFormComponentsPropsFieldsPropsOptions setKey(String key) {
            this.key = key;
            return this;
        }
        public String getKey() {
            return this.key;
        }

        public FormCreateRequestFormComponentsPropsFieldsPropsOptions setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

    }

    public static class FormCreateRequestFormComponentsPropsFieldsProps extends TeaModel {
        // 表单中控件的唯一id
        @NameInMap("componentId")
        public String componentId;

        // 控件标题
        @NameInMap("label")
        public String label;

        // label是否禁用修改
        @NameInMap("labelEditableFreeze")
        public Boolean labelEditableFreeze;

        // 必填
        @NameInMap("required")
        public Boolean required;

        // 必填是否可修改
        @NameInMap("requiredEditableFreeze")
        public Boolean requiredEditableFreeze;

        // 是否可打印
        @NameInMap("print")
        public String print;

        // 说明文字控件内容
        @NameInMap("content")
        public String content;

        // 时间格式
        @NameInMap("format")
        public String format;

        // 选项内容
        @NameInMap("options")
        public java.util.List<FormCreateRequestFormComponentsPropsFieldsPropsOptions> options;

        // 是否需要大写，1需要大写，0不需要
        @NameInMap("upper")
        public String upper;

        // 时间单位（天、小时）
        @NameInMap("unit")
        public String unit;

        // 输入提示
        @NameInMap("placeholder")
        public String placeholder;

        // 业务别名
        @NameInMap("bizAlias")
        public String bizAlias;

        // 套件的业务标识
        @NameInMap("bizType")
        public String bizType;

        // 是否自动计算时长
        @NameInMap("duration")
        public Boolean duration;

        // 联系人控件是否支持多选，1多选，0单选
        @NameInMap("choice")
        public String choice;

        // 是否不可编辑
        @NameInMap("disabled")
        public Boolean disabled;

        // 文字提示控件显示方式（top|middle|bottom）
        @NameInMap("align")
        public String align;

        public static FormCreateRequestFormComponentsPropsFieldsProps build(java.util.Map<String, ?> map) throws Exception {
            FormCreateRequestFormComponentsPropsFieldsProps self = new FormCreateRequestFormComponentsPropsFieldsProps();
            return TeaModel.build(map, self);
        }

        public FormCreateRequestFormComponentsPropsFieldsProps setComponentId(String componentId) {
            this.componentId = componentId;
            return this;
        }
        public String getComponentId() {
            return this.componentId;
        }

        public FormCreateRequestFormComponentsPropsFieldsProps setLabel(String label) {
            this.label = label;
            return this;
        }
        public String getLabel() {
            return this.label;
        }

        public FormCreateRequestFormComponentsPropsFieldsProps setLabelEditableFreeze(Boolean labelEditableFreeze) {
            this.labelEditableFreeze = labelEditableFreeze;
            return this;
        }
        public Boolean getLabelEditableFreeze() {
            return this.labelEditableFreeze;
        }

        public FormCreateRequestFormComponentsPropsFieldsProps setRequired(Boolean required) {
            this.required = required;
            return this;
        }
        public Boolean getRequired() {
            return this.required;
        }

        public FormCreateRequestFormComponentsPropsFieldsProps setRequiredEditableFreeze(Boolean requiredEditableFreeze) {
            this.requiredEditableFreeze = requiredEditableFreeze;
            return this;
        }
        public Boolean getRequiredEditableFreeze() {
            return this.requiredEditableFreeze;
        }

        public FormCreateRequestFormComponentsPropsFieldsProps setPrint(String print) {
            this.print = print;
            return this;
        }
        public String getPrint() {
            return this.print;
        }

        public FormCreateRequestFormComponentsPropsFieldsProps setContent(String content) {
            this.content = content;
            return this;
        }
        public String getContent() {
            return this.content;
        }

        public FormCreateRequestFormComponentsPropsFieldsProps setFormat(String format) {
            this.format = format;
            return this;
        }
        public String getFormat() {
            return this.format;
        }

        public FormCreateRequestFormComponentsPropsFieldsProps setOptions(java.util.List<FormCreateRequestFormComponentsPropsFieldsPropsOptions> options) {
            this.options = options;
            return this;
        }
        public java.util.List<FormCreateRequestFormComponentsPropsFieldsPropsOptions> getOptions() {
            return this.options;
        }

        public FormCreateRequestFormComponentsPropsFieldsProps setUpper(String upper) {
            this.upper = upper;
            return this;
        }
        public String getUpper() {
            return this.upper;
        }

        public FormCreateRequestFormComponentsPropsFieldsProps setUnit(String unit) {
            this.unit = unit;
            return this;
        }
        public String getUnit() {
            return this.unit;
        }

        public FormCreateRequestFormComponentsPropsFieldsProps setPlaceholder(String placeholder) {
            this.placeholder = placeholder;
            return this;
        }
        public String getPlaceholder() {
            return this.placeholder;
        }

        public FormCreateRequestFormComponentsPropsFieldsProps setBizAlias(String bizAlias) {
            this.bizAlias = bizAlias;
            return this;
        }
        public String getBizAlias() {
            return this.bizAlias;
        }

        public FormCreateRequestFormComponentsPropsFieldsProps setBizType(String bizType) {
            this.bizType = bizType;
            return this;
        }
        public String getBizType() {
            return this.bizType;
        }

        public FormCreateRequestFormComponentsPropsFieldsProps setDuration(Boolean duration) {
            this.duration = duration;
            return this;
        }
        public Boolean getDuration() {
            return this.duration;
        }

        public FormCreateRequestFormComponentsPropsFieldsProps setChoice(String choice) {
            this.choice = choice;
            return this;
        }
        public String getChoice() {
            return this.choice;
        }

        public FormCreateRequestFormComponentsPropsFieldsProps setDisabled(Boolean disabled) {
            this.disabled = disabled;
            return this;
        }
        public Boolean getDisabled() {
            return this.disabled;
        }

        public FormCreateRequestFormComponentsPropsFieldsProps setAlign(String align) {
            this.align = align;
            return this;
        }
        public String getAlign() {
            return this.align;
        }

    }

    public static class FormCreateRequestFormComponentsPropsFields extends TeaModel {
        // 关联显示字段类型
        @NameInMap("componentType")
        public String componentType;

        // 关联显示字段属性
        @NameInMap("props")
        public FormCreateRequestFormComponentsPropsFieldsProps props;

        public static FormCreateRequestFormComponentsPropsFields build(java.util.Map<String, ?> map) throws Exception {
            FormCreateRequestFormComponentsPropsFields self = new FormCreateRequestFormComponentsPropsFields();
            return TeaModel.build(map, self);
        }

        public FormCreateRequestFormComponentsPropsFields setComponentType(String componentType) {
            this.componentType = componentType;
            return this;
        }
        public String getComponentType() {
            return this.componentType;
        }

        public FormCreateRequestFormComponentsPropsFields setProps(FormCreateRequestFormComponentsPropsFieldsProps props) {
            this.props = props;
            return this;
        }
        public FormCreateRequestFormComponentsPropsFieldsProps getProps() {
            return this.props;
        }

    }

    public static class FormCreateRequestFormComponentsPropsAvailableTemplates extends TeaModel {
        // 表单名称
        @NameInMap("name")
        public String name;

        // 表单模板processCode
        @NameInMap("processCode")
        public String processCode;

        public static FormCreateRequestFormComponentsPropsAvailableTemplates build(java.util.Map<String, ?> map) throws Exception {
            FormCreateRequestFormComponentsPropsAvailableTemplates self = new FormCreateRequestFormComponentsPropsAvailableTemplates();
            return TeaModel.build(map, self);
        }

        public FormCreateRequestFormComponentsPropsAvailableTemplates setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public FormCreateRequestFormComponentsPropsAvailableTemplates setProcessCode(String processCode) {
            this.processCode = processCode;
            return this;
        }
        public String getProcessCode() {
            return this.processCode;
        }

    }

    public static class FormCreateRequestFormComponentsProps extends TeaModel {
        // 控件表单内唯一id
        @NameInMap("componentId")
        public String componentId;

        // 控件标题
        @NameInMap("label")
        public String label;

        // 套件中控件是否可设置为分条件字段
        @NameInMap("asyncCondition")
        public Boolean asyncCondition;

        // 是否必填
        @NameInMap("required")
        public Boolean required;

        // 说明文字控件内容
        @NameInMap("content")
        public String content;

        // 时间格式
        @NameInMap("format")
        public String format;

        // 金额控件是否需要大写，1不需要大写，其他需要大写
        @NameInMap("upper")
        public String upper;

        // 时间单位（天、小时）
        @NameInMap("unit")
        public String unit;

        // 输入提示
        @NameInMap("placeholder")
        public String placeholder;

        // 业务别名
        @NameInMap("bizAlias")
        public String bizAlias;

        // 套件的业务标识
        @NameInMap("bizType")
        public String bizType;

        // 是否自动计算时长
        @NameInMap("duration")
        public Boolean duration;

        // 联系人控件是否支持多选，1多选，0单选
        @NameInMap("choice")
        public String choice;

        // 是否不可编辑
        @NameInMap("disabled")
        public Boolean disabled;

        // 文字提示控件显示方式:top|middle|bottom
        @NameInMap("align")
        public String align;

        // 是否隐藏字段
        @NameInMap("invisible")
        public Boolean invisible;

        // 说明文字控件链接地址
        @NameInMap("link")
        public String link;

        // 明细打印方式false横向，true纵向
        @NameInMap("verticalPrint")
        public Boolean verticalPrint;

        // 公式
        @NameInMap("formula")
        public String formula;

        // 自定义控件渲染标识
        @NameInMap("commonBizType")
        public String commonBizType;

        // 单选多选控件选项列表
        @NameInMap("options")
        public java.util.List<FormCreateRequestFormComponentsPropsOptions> options;

        // 字段是否可打印，1打印，0不打印，默认打印
        @NameInMap("print")
        public String print;

        // 明细控件数据汇总统计
        @NameInMap("statField")
        public java.util.List<FormCreateRequestFormComponentsPropsStatField> statField;

        // 关联审批单、关联表单数据源配置
        @NameInMap("dataSource")
        public FormCreateRequestFormComponentsPropsDataSource dataSource;

        // 关联显示字段
        @NameInMap("fields")
        public java.util.List<FormCreateRequestFormComponentsPropsFields> fields;

        // 地址控件模式city省市,district省市区,street省市区街道
        @NameInMap("addressModel")
        public String addressModel;

        // 部门控件是否可多选
        @NameInMap("multiple")
        public Boolean multiple;

        // 评分控件上限
        @NameInMap("limit")
        public Integer limit;

        // 关联审批单控件限定模板列表
        @NameInMap("availableTemplates")
        public java.util.List<FormCreateRequestFormComponentsPropsAvailableTemplates> availableTemplates;

        // 明细填写方式，table（表格）、list（列表）
        @NameInMap("tableViewMode")
        public String tableViewMode;

        public static FormCreateRequestFormComponentsProps build(java.util.Map<String, ?> map) throws Exception {
            FormCreateRequestFormComponentsProps self = new FormCreateRequestFormComponentsProps();
            return TeaModel.build(map, self);
        }

        public FormCreateRequestFormComponentsProps setComponentId(String componentId) {
            this.componentId = componentId;
            return this;
        }
        public String getComponentId() {
            return this.componentId;
        }

        public FormCreateRequestFormComponentsProps setLabel(String label) {
            this.label = label;
            return this;
        }
        public String getLabel() {
            return this.label;
        }

        public FormCreateRequestFormComponentsProps setAsyncCondition(Boolean asyncCondition) {
            this.asyncCondition = asyncCondition;
            return this;
        }
        public Boolean getAsyncCondition() {
            return this.asyncCondition;
        }

        public FormCreateRequestFormComponentsProps setRequired(Boolean required) {
            this.required = required;
            return this;
        }
        public Boolean getRequired() {
            return this.required;
        }

        public FormCreateRequestFormComponentsProps setContent(String content) {
            this.content = content;
            return this;
        }
        public String getContent() {
            return this.content;
        }

        public FormCreateRequestFormComponentsProps setFormat(String format) {
            this.format = format;
            return this;
        }
        public String getFormat() {
            return this.format;
        }

        public FormCreateRequestFormComponentsProps setUpper(String upper) {
            this.upper = upper;
            return this;
        }
        public String getUpper() {
            return this.upper;
        }

        public FormCreateRequestFormComponentsProps setUnit(String unit) {
            this.unit = unit;
            return this;
        }
        public String getUnit() {
            return this.unit;
        }

        public FormCreateRequestFormComponentsProps setPlaceholder(String placeholder) {
            this.placeholder = placeholder;
            return this;
        }
        public String getPlaceholder() {
            return this.placeholder;
        }

        public FormCreateRequestFormComponentsProps setBizAlias(String bizAlias) {
            this.bizAlias = bizAlias;
            return this;
        }
        public String getBizAlias() {
            return this.bizAlias;
        }

        public FormCreateRequestFormComponentsProps setBizType(String bizType) {
            this.bizType = bizType;
            return this;
        }
        public String getBizType() {
            return this.bizType;
        }

        public FormCreateRequestFormComponentsProps setDuration(Boolean duration) {
            this.duration = duration;
            return this;
        }
        public Boolean getDuration() {
            return this.duration;
        }

        public FormCreateRequestFormComponentsProps setChoice(String choice) {
            this.choice = choice;
            return this;
        }
        public String getChoice() {
            return this.choice;
        }

        public FormCreateRequestFormComponentsProps setDisabled(Boolean disabled) {
            this.disabled = disabled;
            return this;
        }
        public Boolean getDisabled() {
            return this.disabled;
        }

        public FormCreateRequestFormComponentsProps setAlign(String align) {
            this.align = align;
            return this;
        }
        public String getAlign() {
            return this.align;
        }

        public FormCreateRequestFormComponentsProps setInvisible(Boolean invisible) {
            this.invisible = invisible;
            return this;
        }
        public Boolean getInvisible() {
            return this.invisible;
        }

        public FormCreateRequestFormComponentsProps setLink(String link) {
            this.link = link;
            return this;
        }
        public String getLink() {
            return this.link;
        }

        public FormCreateRequestFormComponentsProps setVerticalPrint(Boolean verticalPrint) {
            this.verticalPrint = verticalPrint;
            return this;
        }
        public Boolean getVerticalPrint() {
            return this.verticalPrint;
        }

        public FormCreateRequestFormComponentsProps setFormula(String formula) {
            this.formula = formula;
            return this;
        }
        public String getFormula() {
            return this.formula;
        }

        public FormCreateRequestFormComponentsProps setCommonBizType(String commonBizType) {
            this.commonBizType = commonBizType;
            return this;
        }
        public String getCommonBizType() {
            return this.commonBizType;
        }

        public FormCreateRequestFormComponentsProps setOptions(java.util.List<FormCreateRequestFormComponentsPropsOptions> options) {
            this.options = options;
            return this;
        }
        public java.util.List<FormCreateRequestFormComponentsPropsOptions> getOptions() {
            return this.options;
        }

        public FormCreateRequestFormComponentsProps setPrint(String print) {
            this.print = print;
            return this;
        }
        public String getPrint() {
            return this.print;
        }

        public FormCreateRequestFormComponentsProps setStatField(java.util.List<FormCreateRequestFormComponentsPropsStatField> statField) {
            this.statField = statField;
            return this;
        }
        public java.util.List<FormCreateRequestFormComponentsPropsStatField> getStatField() {
            return this.statField;
        }

        public FormCreateRequestFormComponentsProps setDataSource(FormCreateRequestFormComponentsPropsDataSource dataSource) {
            this.dataSource = dataSource;
            return this;
        }
        public FormCreateRequestFormComponentsPropsDataSource getDataSource() {
            return this.dataSource;
        }

        public FormCreateRequestFormComponentsProps setFields(java.util.List<FormCreateRequestFormComponentsPropsFields> fields) {
            this.fields = fields;
            return this;
        }
        public java.util.List<FormCreateRequestFormComponentsPropsFields> getFields() {
            return this.fields;
        }

        public FormCreateRequestFormComponentsProps setAddressModel(String addressModel) {
            this.addressModel = addressModel;
            return this;
        }
        public String getAddressModel() {
            return this.addressModel;
        }

        public FormCreateRequestFormComponentsProps setMultiple(Boolean multiple) {
            this.multiple = multiple;
            return this;
        }
        public Boolean getMultiple() {
            return this.multiple;
        }

        public FormCreateRequestFormComponentsProps setLimit(Integer limit) {
            this.limit = limit;
            return this;
        }
        public Integer getLimit() {
            return this.limit;
        }

        public FormCreateRequestFormComponentsProps setAvailableTemplates(java.util.List<FormCreateRequestFormComponentsPropsAvailableTemplates> availableTemplates) {
            this.availableTemplates = availableTemplates;
            return this;
        }
        public java.util.List<FormCreateRequestFormComponentsPropsAvailableTemplates> getAvailableTemplates() {
            return this.availableTemplates;
        }

        public FormCreateRequestFormComponentsProps setTableViewMode(String tableViewMode) {
            this.tableViewMode = tableViewMode;
            return this;
        }
        public String getTableViewMode() {
            return this.tableViewMode;
        }

    }

    public static class FormCreateRequestFormComponentsChildrenPropsOptions extends TeaModel {
        // 选项的显示内容
        @NameInMap("value")
        public String value;

        // 选项的唯一主键
        @NameInMap("key")
        public String key;

        public static FormCreateRequestFormComponentsChildrenPropsOptions build(java.util.Map<String, ?> map) throws Exception {
            FormCreateRequestFormComponentsChildrenPropsOptions self = new FormCreateRequestFormComponentsChildrenPropsOptions();
            return TeaModel.build(map, self);
        }

        public FormCreateRequestFormComponentsChildrenPropsOptions setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

        public FormCreateRequestFormComponentsChildrenPropsOptions setKey(String key) {
            this.key = key;
            return this;
        }
        public String getKey() {
            return this.key;
        }

    }

    public static class FormCreateRequestFormComponentsChildrenPropsStatField extends TeaModel {
        @NameInMap("componentId")
        public String componentId;

        @NameInMap("label")
        public String label;

        @NameInMap("upper")
        public Boolean upper;

        @NameInMap("payEnable")
        public String payEnable;

        public static FormCreateRequestFormComponentsChildrenPropsStatField build(java.util.Map<String, ?> map) throws Exception {
            FormCreateRequestFormComponentsChildrenPropsStatField self = new FormCreateRequestFormComponentsChildrenPropsStatField();
            return TeaModel.build(map, self);
        }

        public FormCreateRequestFormComponentsChildrenPropsStatField setComponentId(String componentId) {
            this.componentId = componentId;
            return this;
        }
        public String getComponentId() {
            return this.componentId;
        }

        public FormCreateRequestFormComponentsChildrenPropsStatField setLabel(String label) {
            this.label = label;
            return this;
        }
        public String getLabel() {
            return this.label;
        }

        public FormCreateRequestFormComponentsChildrenPropsStatField setUpper(Boolean upper) {
            this.upper = upper;
            return this;
        }
        public Boolean getUpper() {
            return this.upper;
        }

        public FormCreateRequestFormComponentsChildrenPropsStatField setPayEnable(String payEnable) {
            this.payEnable = payEnable;
            return this;
        }
        public String getPayEnable() {
            return this.payEnable;
        }

    }

    public static class FormCreateRequestFormComponentsChildrenPropsDataSourceTarget extends TeaModel {
        @NameInMap("appUuid")
        public String appUuid;

        @NameInMap("appType")
        public Long appType;

        @NameInMap("bizType")
        public String bizType;

        @NameInMap("formCode")
        public String formCode;

        public static FormCreateRequestFormComponentsChildrenPropsDataSourceTarget build(java.util.Map<String, ?> map) throws Exception {
            FormCreateRequestFormComponentsChildrenPropsDataSourceTarget self = new FormCreateRequestFormComponentsChildrenPropsDataSourceTarget();
            return TeaModel.build(map, self);
        }

        public FormCreateRequestFormComponentsChildrenPropsDataSourceTarget setAppUuid(String appUuid) {
            this.appUuid = appUuid;
            return this;
        }
        public String getAppUuid() {
            return this.appUuid;
        }

        public FormCreateRequestFormComponentsChildrenPropsDataSourceTarget setAppType(Long appType) {
            this.appType = appType;
            return this;
        }
        public Long getAppType() {
            return this.appType;
        }

        public FormCreateRequestFormComponentsChildrenPropsDataSourceTarget setBizType(String bizType) {
            this.bizType = bizType;
            return this;
        }
        public String getBizType() {
            return this.bizType;
        }

        public FormCreateRequestFormComponentsChildrenPropsDataSourceTarget setFormCode(String formCode) {
            this.formCode = formCode;
            return this;
        }
        public String getFormCode() {
            return this.formCode;
        }

    }

    public static class FormCreateRequestFormComponentsChildrenPropsDataSource extends TeaModel {
        @NameInMap("type")
        public String type;

        @NameInMap("target")
        public FormCreateRequestFormComponentsChildrenPropsDataSourceTarget target;

        public static FormCreateRequestFormComponentsChildrenPropsDataSource build(java.util.Map<String, ?> map) throws Exception {
            FormCreateRequestFormComponentsChildrenPropsDataSource self = new FormCreateRequestFormComponentsChildrenPropsDataSource();
            return TeaModel.build(map, self);
        }

        public FormCreateRequestFormComponentsChildrenPropsDataSource setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

        public FormCreateRequestFormComponentsChildrenPropsDataSource setTarget(FormCreateRequestFormComponentsChildrenPropsDataSourceTarget target) {
            this.target = target;
            return this;
        }
        public FormCreateRequestFormComponentsChildrenPropsDataSourceTarget getTarget() {
            return this.target;
        }

    }

    public static class FormCreateRequestFormComponentsChildrenPropsFieldsPropsOptions extends TeaModel {
        // 每一个选项的唯一键
        @NameInMap("key")
        public String key;

        // 每一个选项的值
        @NameInMap("value")
        public String value;

        public static FormCreateRequestFormComponentsChildrenPropsFieldsPropsOptions build(java.util.Map<String, ?> map) throws Exception {
            FormCreateRequestFormComponentsChildrenPropsFieldsPropsOptions self = new FormCreateRequestFormComponentsChildrenPropsFieldsPropsOptions();
            return TeaModel.build(map, self);
        }

        public FormCreateRequestFormComponentsChildrenPropsFieldsPropsOptions setKey(String key) {
            this.key = key;
            return this;
        }
        public String getKey() {
            return this.key;
        }

        public FormCreateRequestFormComponentsChildrenPropsFieldsPropsOptions setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

    }

    public static class FormCreateRequestFormComponentsChildrenPropsFieldsProps extends TeaModel {
        // 表单中控件的唯一id
        @NameInMap("componentId")
        public String componentId;

        // 控件标题
        @NameInMap("label")
        public String label;

        // label是否禁用修改
        @NameInMap("labelEditableFreeze")
        public Boolean labelEditableFreeze;

        // 必填
        @NameInMap("required")
        public Boolean required;

        // 必填是否可修改
        @NameInMap("requiredEditableFreeze")
        public Boolean requiredEditableFreeze;

        @NameInMap("print")
        public String print;

        // 说明文字控件内容
        @NameInMap("content")
        public String content;

        // 时间格式
        @NameInMap("format")
        public String format;

        // 选项内容
        @NameInMap("options")
        public java.util.List<FormCreateRequestFormComponentsChildrenPropsFieldsPropsOptions> options;

        // 是否需要大写，1不需要大写，其他需要大写
        @NameInMap("notUpper")
        public String notUpper;

        // 时间单位（天、小时）
        @NameInMap("unit")
        public String unit;

        // 输入提示
        @NameInMap("placeholder")
        public String placeholder;

        // 业务别名
        @NameInMap("bizAlias")
        public String bizAlias;

        // 套件的业务标识
        @NameInMap("bizType")
        public String bizType;

        // 是否自动计算时长
        @NameInMap("duration")
        public Boolean duration;

        // 联系人控件是否支持多选，1多选，0单选
        @NameInMap("choice")
        public String choice;

        // 是否不可编辑
        @NameInMap("disabled")
        public Boolean disabled;

        // 文字提示控件显示方式（top|middle|bottom）
        @NameInMap("align")
        public String align;

        public static FormCreateRequestFormComponentsChildrenPropsFieldsProps build(java.util.Map<String, ?> map) throws Exception {
            FormCreateRequestFormComponentsChildrenPropsFieldsProps self = new FormCreateRequestFormComponentsChildrenPropsFieldsProps();
            return TeaModel.build(map, self);
        }

        public FormCreateRequestFormComponentsChildrenPropsFieldsProps setComponentId(String componentId) {
            this.componentId = componentId;
            return this;
        }
        public String getComponentId() {
            return this.componentId;
        }

        public FormCreateRequestFormComponentsChildrenPropsFieldsProps setLabel(String label) {
            this.label = label;
            return this;
        }
        public String getLabel() {
            return this.label;
        }

        public FormCreateRequestFormComponentsChildrenPropsFieldsProps setLabelEditableFreeze(Boolean labelEditableFreeze) {
            this.labelEditableFreeze = labelEditableFreeze;
            return this;
        }
        public Boolean getLabelEditableFreeze() {
            return this.labelEditableFreeze;
        }

        public FormCreateRequestFormComponentsChildrenPropsFieldsProps setRequired(Boolean required) {
            this.required = required;
            return this;
        }
        public Boolean getRequired() {
            return this.required;
        }

        public FormCreateRequestFormComponentsChildrenPropsFieldsProps setRequiredEditableFreeze(Boolean requiredEditableFreeze) {
            this.requiredEditableFreeze = requiredEditableFreeze;
            return this;
        }
        public Boolean getRequiredEditableFreeze() {
            return this.requiredEditableFreeze;
        }

        public FormCreateRequestFormComponentsChildrenPropsFieldsProps setPrint(String print) {
            this.print = print;
            return this;
        }
        public String getPrint() {
            return this.print;
        }

        public FormCreateRequestFormComponentsChildrenPropsFieldsProps setContent(String content) {
            this.content = content;
            return this;
        }
        public String getContent() {
            return this.content;
        }

        public FormCreateRequestFormComponentsChildrenPropsFieldsProps setFormat(String format) {
            this.format = format;
            return this;
        }
        public String getFormat() {
            return this.format;
        }

        public FormCreateRequestFormComponentsChildrenPropsFieldsProps setOptions(java.util.List<FormCreateRequestFormComponentsChildrenPropsFieldsPropsOptions> options) {
            this.options = options;
            return this;
        }
        public java.util.List<FormCreateRequestFormComponentsChildrenPropsFieldsPropsOptions> getOptions() {
            return this.options;
        }

        public FormCreateRequestFormComponentsChildrenPropsFieldsProps setNotUpper(String notUpper) {
            this.notUpper = notUpper;
            return this;
        }
        public String getNotUpper() {
            return this.notUpper;
        }

        public FormCreateRequestFormComponentsChildrenPropsFieldsProps setUnit(String unit) {
            this.unit = unit;
            return this;
        }
        public String getUnit() {
            return this.unit;
        }

        public FormCreateRequestFormComponentsChildrenPropsFieldsProps setPlaceholder(String placeholder) {
            this.placeholder = placeholder;
            return this;
        }
        public String getPlaceholder() {
            return this.placeholder;
        }

        public FormCreateRequestFormComponentsChildrenPropsFieldsProps setBizAlias(String bizAlias) {
            this.bizAlias = bizAlias;
            return this;
        }
        public String getBizAlias() {
            return this.bizAlias;
        }

        public FormCreateRequestFormComponentsChildrenPropsFieldsProps setBizType(String bizType) {
            this.bizType = bizType;
            return this;
        }
        public String getBizType() {
            return this.bizType;
        }

        public FormCreateRequestFormComponentsChildrenPropsFieldsProps setDuration(Boolean duration) {
            this.duration = duration;
            return this;
        }
        public Boolean getDuration() {
            return this.duration;
        }

        public FormCreateRequestFormComponentsChildrenPropsFieldsProps setChoice(String choice) {
            this.choice = choice;
            return this;
        }
        public String getChoice() {
            return this.choice;
        }

        public FormCreateRequestFormComponentsChildrenPropsFieldsProps setDisabled(Boolean disabled) {
            this.disabled = disabled;
            return this;
        }
        public Boolean getDisabled() {
            return this.disabled;
        }

        public FormCreateRequestFormComponentsChildrenPropsFieldsProps setAlign(String align) {
            this.align = align;
            return this;
        }
        public String getAlign() {
            return this.align;
        }

    }

    public static class FormCreateRequestFormComponentsChildrenPropsFields extends TeaModel {
        @NameInMap("componentType")
        public String componentType;

        @NameInMap("props")
        public FormCreateRequestFormComponentsChildrenPropsFieldsProps props;

        public static FormCreateRequestFormComponentsChildrenPropsFields build(java.util.Map<String, ?> map) throws Exception {
            FormCreateRequestFormComponentsChildrenPropsFields self = new FormCreateRequestFormComponentsChildrenPropsFields();
            return TeaModel.build(map, self);
        }

        public FormCreateRequestFormComponentsChildrenPropsFields setComponentType(String componentType) {
            this.componentType = componentType;
            return this;
        }
        public String getComponentType() {
            return this.componentType;
        }

        public FormCreateRequestFormComponentsChildrenPropsFields setProps(FormCreateRequestFormComponentsChildrenPropsFieldsProps props) {
            this.props = props;
            return this;
        }
        public FormCreateRequestFormComponentsChildrenPropsFieldsProps getProps() {
            return this.props;
        }

    }

    public static class FormCreateRequestFormComponentsChildrenPropsAvailableTemplates extends TeaModel {
        // 模板名称
        @NameInMap("name")
        public String name;

        // 模板processCode
        @NameInMap("processCode")
        public String processCode;

        public static FormCreateRequestFormComponentsChildrenPropsAvailableTemplates build(java.util.Map<String, ?> map) throws Exception {
            FormCreateRequestFormComponentsChildrenPropsAvailableTemplates self = new FormCreateRequestFormComponentsChildrenPropsAvailableTemplates();
            return TeaModel.build(map, self);
        }

        public FormCreateRequestFormComponentsChildrenPropsAvailableTemplates setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public FormCreateRequestFormComponentsChildrenPropsAvailableTemplates setProcessCode(String processCode) {
            this.processCode = processCode;
            return this;
        }
        public String getProcessCode() {
            return this.processCode;
        }

    }

    public static class FormCreateRequestFormComponentsChildrenProps extends TeaModel {
        @NameInMap("componentId")
        public String componentId;

        // 控件标题
        @NameInMap("label")
        public String label;

        // 套件中控件是否可设置为分条件字段
        @NameInMap("asyncCondition")
        public Boolean asyncCondition;

        // 必填
        @NameInMap("required")
        public Boolean required;

        // 说明文字控件内容
        @NameInMap("content")
        public String content;

        // 时间格式
        @NameInMap("format")
        public String format;

        // 金额是否需要大写，1不需要大写，其他需要大写
        @NameInMap("upper")
        public String upper;

        // 时间单位（天、小时）
        @NameInMap("unit")
        public String unit;

        // 输入提示
        @NameInMap("placeholder")
        public String placeholder;

        // 业务别名
        @NameInMap("bizAlias")
        public String bizAlias;

        // 套件的业务标识
        @NameInMap("bizType")
        public String bizType;

        // 是否自动计算时长
        @NameInMap("duration")
        public Boolean duration;

        // 联系人控件是否支持多选，1多选，0单选
        @NameInMap("choice")
        public String choice;

        // 是否不可编辑
        @NameInMap("disabled")
        public Boolean disabled;

        // 文字提示控件显示方式:top|middle|bottom
        @NameInMap("align")
        public String align;

        // 是否隐藏字段
        @NameInMap("invisible")
        public Boolean invisible;

        // 说明文字控件链接地址
        @NameInMap("link")
        public String link;

        // 明细打印方式false横向，true纵向
        @NameInMap("verticalPrint")
        public Boolean verticalPrint;

        // 公式
        @NameInMap("formula")
        public String formula;

        // 自定义控件渲染标识
        @NameInMap("commonBizType")
        public String commonBizType;

        // 单选多选控件选项列表
        @NameInMap("options")
        public java.util.List<FormCreateRequestFormComponentsChildrenPropsOptions> options;

        // 是否可被打印
        @NameInMap("print")
        public String print;

        // 明细汇总统计设置
        @NameInMap("statField")
        public java.util.List<FormCreateRequestFormComponentsChildrenPropsStatField> statField;

        // 数据源配置
        @NameInMap("dataSource")
        public FormCreateRequestFormComponentsChildrenPropsDataSource dataSource;

        // 关联显示字段配置
        @NameInMap("fields")
        public java.util.List<FormCreateRequestFormComponentsChildrenPropsFields> fields;

        // 地址控件模式
        @NameInMap("addressModel")
        public String addressModel;

        // 部门控件是否支持多选
        @NameInMap("multiple")
        public Boolean multiple;

        // 评分控件上限
        @NameInMap("limit")
        public Integer limit;

        // 关联审批单表单筛选列表
        @NameInMap("availableTemplates")
        public java.util.List<FormCreateRequestFormComponentsChildrenPropsAvailableTemplates> availableTemplates;

        // 明细填写方式，table（表格）、list（列表）
        @NameInMap("tableViewMode")
        public String tableViewMode;

        public static FormCreateRequestFormComponentsChildrenProps build(java.util.Map<String, ?> map) throws Exception {
            FormCreateRequestFormComponentsChildrenProps self = new FormCreateRequestFormComponentsChildrenProps();
            return TeaModel.build(map, self);
        }

        public FormCreateRequestFormComponentsChildrenProps setComponentId(String componentId) {
            this.componentId = componentId;
            return this;
        }
        public String getComponentId() {
            return this.componentId;
        }

        public FormCreateRequestFormComponentsChildrenProps setLabel(String label) {
            this.label = label;
            return this;
        }
        public String getLabel() {
            return this.label;
        }

        public FormCreateRequestFormComponentsChildrenProps setAsyncCondition(Boolean asyncCondition) {
            this.asyncCondition = asyncCondition;
            return this;
        }
        public Boolean getAsyncCondition() {
            return this.asyncCondition;
        }

        public FormCreateRequestFormComponentsChildrenProps setRequired(Boolean required) {
            this.required = required;
            return this;
        }
        public Boolean getRequired() {
            return this.required;
        }

        public FormCreateRequestFormComponentsChildrenProps setContent(String content) {
            this.content = content;
            return this;
        }
        public String getContent() {
            return this.content;
        }

        public FormCreateRequestFormComponentsChildrenProps setFormat(String format) {
            this.format = format;
            return this;
        }
        public String getFormat() {
            return this.format;
        }

        public FormCreateRequestFormComponentsChildrenProps setUpper(String upper) {
            this.upper = upper;
            return this;
        }
        public String getUpper() {
            return this.upper;
        }

        public FormCreateRequestFormComponentsChildrenProps setUnit(String unit) {
            this.unit = unit;
            return this;
        }
        public String getUnit() {
            return this.unit;
        }

        public FormCreateRequestFormComponentsChildrenProps setPlaceholder(String placeholder) {
            this.placeholder = placeholder;
            return this;
        }
        public String getPlaceholder() {
            return this.placeholder;
        }

        public FormCreateRequestFormComponentsChildrenProps setBizAlias(String bizAlias) {
            this.bizAlias = bizAlias;
            return this;
        }
        public String getBizAlias() {
            return this.bizAlias;
        }

        public FormCreateRequestFormComponentsChildrenProps setBizType(String bizType) {
            this.bizType = bizType;
            return this;
        }
        public String getBizType() {
            return this.bizType;
        }

        public FormCreateRequestFormComponentsChildrenProps setDuration(Boolean duration) {
            this.duration = duration;
            return this;
        }
        public Boolean getDuration() {
            return this.duration;
        }

        public FormCreateRequestFormComponentsChildrenProps setChoice(String choice) {
            this.choice = choice;
            return this;
        }
        public String getChoice() {
            return this.choice;
        }

        public FormCreateRequestFormComponentsChildrenProps setDisabled(Boolean disabled) {
            this.disabled = disabled;
            return this;
        }
        public Boolean getDisabled() {
            return this.disabled;
        }

        public FormCreateRequestFormComponentsChildrenProps setAlign(String align) {
            this.align = align;
            return this;
        }
        public String getAlign() {
            return this.align;
        }

        public FormCreateRequestFormComponentsChildrenProps setInvisible(Boolean invisible) {
            this.invisible = invisible;
            return this;
        }
        public Boolean getInvisible() {
            return this.invisible;
        }

        public FormCreateRequestFormComponentsChildrenProps setLink(String link) {
            this.link = link;
            return this;
        }
        public String getLink() {
            return this.link;
        }

        public FormCreateRequestFormComponentsChildrenProps setVerticalPrint(Boolean verticalPrint) {
            this.verticalPrint = verticalPrint;
            return this;
        }
        public Boolean getVerticalPrint() {
            return this.verticalPrint;
        }

        public FormCreateRequestFormComponentsChildrenProps setFormula(String formula) {
            this.formula = formula;
            return this;
        }
        public String getFormula() {
            return this.formula;
        }

        public FormCreateRequestFormComponentsChildrenProps setCommonBizType(String commonBizType) {
            this.commonBizType = commonBizType;
            return this;
        }
        public String getCommonBizType() {
            return this.commonBizType;
        }

        public FormCreateRequestFormComponentsChildrenProps setOptions(java.util.List<FormCreateRequestFormComponentsChildrenPropsOptions> options) {
            this.options = options;
            return this;
        }
        public java.util.List<FormCreateRequestFormComponentsChildrenPropsOptions> getOptions() {
            return this.options;
        }

        public FormCreateRequestFormComponentsChildrenProps setPrint(String print) {
            this.print = print;
            return this;
        }
        public String getPrint() {
            return this.print;
        }

        public FormCreateRequestFormComponentsChildrenProps setStatField(java.util.List<FormCreateRequestFormComponentsChildrenPropsStatField> statField) {
            this.statField = statField;
            return this;
        }
        public java.util.List<FormCreateRequestFormComponentsChildrenPropsStatField> getStatField() {
            return this.statField;
        }

        public FormCreateRequestFormComponentsChildrenProps setDataSource(FormCreateRequestFormComponentsChildrenPropsDataSource dataSource) {
            this.dataSource = dataSource;
            return this;
        }
        public FormCreateRequestFormComponentsChildrenPropsDataSource getDataSource() {
            return this.dataSource;
        }

        public FormCreateRequestFormComponentsChildrenProps setFields(java.util.List<FormCreateRequestFormComponentsChildrenPropsFields> fields) {
            this.fields = fields;
            return this;
        }
        public java.util.List<FormCreateRequestFormComponentsChildrenPropsFields> getFields() {
            return this.fields;
        }

        public FormCreateRequestFormComponentsChildrenProps setAddressModel(String addressModel) {
            this.addressModel = addressModel;
            return this;
        }
        public String getAddressModel() {
            return this.addressModel;
        }

        public FormCreateRequestFormComponentsChildrenProps setMultiple(Boolean multiple) {
            this.multiple = multiple;
            return this;
        }
        public Boolean getMultiple() {
            return this.multiple;
        }

        public FormCreateRequestFormComponentsChildrenProps setLimit(Integer limit) {
            this.limit = limit;
            return this;
        }
        public Integer getLimit() {
            return this.limit;
        }

        public FormCreateRequestFormComponentsChildrenProps setAvailableTemplates(java.util.List<FormCreateRequestFormComponentsChildrenPropsAvailableTemplates> availableTemplates) {
            this.availableTemplates = availableTemplates;
            return this;
        }
        public java.util.List<FormCreateRequestFormComponentsChildrenPropsAvailableTemplates> getAvailableTemplates() {
            return this.availableTemplates;
        }

        public FormCreateRequestFormComponentsChildrenProps setTableViewMode(String tableViewMode) {
            this.tableViewMode = tableViewMode;
            return this;
        }
        public String getTableViewMode() {
            return this.tableViewMode;
        }

    }

    public static class FormCreateRequestFormComponentsChildrenChildrenPropsOptions extends TeaModel {
        // 选项的显示内容
        @NameInMap("value")
        public String value;

        // 选项的唯一主键
        @NameInMap("key")
        public String key;

        public static FormCreateRequestFormComponentsChildrenChildrenPropsOptions build(java.util.Map<String, ?> map) throws Exception {
            FormCreateRequestFormComponentsChildrenChildrenPropsOptions self = new FormCreateRequestFormComponentsChildrenChildrenPropsOptions();
            return TeaModel.build(map, self);
        }

        public FormCreateRequestFormComponentsChildrenChildrenPropsOptions setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

        public FormCreateRequestFormComponentsChildrenChildrenPropsOptions setKey(String key) {
            this.key = key;
            return this;
        }
        public String getKey() {
            return this.key;
        }

    }

    public static class FormCreateRequestFormComponentsChildrenChildrenPropsStatField extends TeaModel {
        @NameInMap("componentId")
        public String componentId;

        @NameInMap("label")
        public String label;

        @NameInMap("upper")
        public Boolean upper;

        @NameInMap("payEnable")
        public String payEnable;

        public static FormCreateRequestFormComponentsChildrenChildrenPropsStatField build(java.util.Map<String, ?> map) throws Exception {
            FormCreateRequestFormComponentsChildrenChildrenPropsStatField self = new FormCreateRequestFormComponentsChildrenChildrenPropsStatField();
            return TeaModel.build(map, self);
        }

        public FormCreateRequestFormComponentsChildrenChildrenPropsStatField setComponentId(String componentId) {
            this.componentId = componentId;
            return this;
        }
        public String getComponentId() {
            return this.componentId;
        }

        public FormCreateRequestFormComponentsChildrenChildrenPropsStatField setLabel(String label) {
            this.label = label;
            return this;
        }
        public String getLabel() {
            return this.label;
        }

        public FormCreateRequestFormComponentsChildrenChildrenPropsStatField setUpper(Boolean upper) {
            this.upper = upper;
            return this;
        }
        public Boolean getUpper() {
            return this.upper;
        }

        public FormCreateRequestFormComponentsChildrenChildrenPropsStatField setPayEnable(String payEnable) {
            this.payEnable = payEnable;
            return this;
        }
        public String getPayEnable() {
            return this.payEnable;
        }

    }

    public static class FormCreateRequestFormComponentsChildrenChildrenPropsDataSourceTarget extends TeaModel {
        @NameInMap("appUuid")
        public String appUuid;

        @NameInMap("appType")
        public Long appType;

        @NameInMap("bizType")
        public String bizType;

        @NameInMap("formCode")
        public String formCode;

        public static FormCreateRequestFormComponentsChildrenChildrenPropsDataSourceTarget build(java.util.Map<String, ?> map) throws Exception {
            FormCreateRequestFormComponentsChildrenChildrenPropsDataSourceTarget self = new FormCreateRequestFormComponentsChildrenChildrenPropsDataSourceTarget();
            return TeaModel.build(map, self);
        }

        public FormCreateRequestFormComponentsChildrenChildrenPropsDataSourceTarget setAppUuid(String appUuid) {
            this.appUuid = appUuid;
            return this;
        }
        public String getAppUuid() {
            return this.appUuid;
        }

        public FormCreateRequestFormComponentsChildrenChildrenPropsDataSourceTarget setAppType(Long appType) {
            this.appType = appType;
            return this;
        }
        public Long getAppType() {
            return this.appType;
        }

        public FormCreateRequestFormComponentsChildrenChildrenPropsDataSourceTarget setBizType(String bizType) {
            this.bizType = bizType;
            return this;
        }
        public String getBizType() {
            return this.bizType;
        }

        public FormCreateRequestFormComponentsChildrenChildrenPropsDataSourceTarget setFormCode(String formCode) {
            this.formCode = formCode;
            return this;
        }
        public String getFormCode() {
            return this.formCode;
        }

    }

    public static class FormCreateRequestFormComponentsChildrenChildrenPropsDataSource extends TeaModel {
        @NameInMap("type")
        public String type;

        @NameInMap("target")
        public FormCreateRequestFormComponentsChildrenChildrenPropsDataSourceTarget target;

        public static FormCreateRequestFormComponentsChildrenChildrenPropsDataSource build(java.util.Map<String, ?> map) throws Exception {
            FormCreateRequestFormComponentsChildrenChildrenPropsDataSource self = new FormCreateRequestFormComponentsChildrenChildrenPropsDataSource();
            return TeaModel.build(map, self);
        }

        public FormCreateRequestFormComponentsChildrenChildrenPropsDataSource setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

        public FormCreateRequestFormComponentsChildrenChildrenPropsDataSource setTarget(FormCreateRequestFormComponentsChildrenChildrenPropsDataSourceTarget target) {
            this.target = target;
            return this;
        }
        public FormCreateRequestFormComponentsChildrenChildrenPropsDataSourceTarget getTarget() {
            return this.target;
        }

    }

    public static class FormCreateRequestFormComponentsChildrenChildrenPropsFieldsPropsOptions extends TeaModel {
        // 每一个选项的唯一键
        @NameInMap("key")
        public String key;

        // 每一个选项的值
        @NameInMap("value")
        public String value;

        public static FormCreateRequestFormComponentsChildrenChildrenPropsFieldsPropsOptions build(java.util.Map<String, ?> map) throws Exception {
            FormCreateRequestFormComponentsChildrenChildrenPropsFieldsPropsOptions self = new FormCreateRequestFormComponentsChildrenChildrenPropsFieldsPropsOptions();
            return TeaModel.build(map, self);
        }

        public FormCreateRequestFormComponentsChildrenChildrenPropsFieldsPropsOptions setKey(String key) {
            this.key = key;
            return this;
        }
        public String getKey() {
            return this.key;
        }

        public FormCreateRequestFormComponentsChildrenChildrenPropsFieldsPropsOptions setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

    }

    public static class FormCreateRequestFormComponentsChildrenChildrenPropsFieldsProps extends TeaModel {
        // 表单中控件的唯一id
        @NameInMap("componentId")
        public String componentId;

        // 控件标题
        @NameInMap("label")
        public String label;

        // 必填
        @NameInMap("required")
        public Boolean required;

        // 字段是否可被打印，1表示打印, 0表示打印，默认打印
        @NameInMap("print")
        public String print;

        // 说明文字控件内容
        @NameInMap("content")
        public String content;

        // 时间格式
        @NameInMap("format")
        public String format;

        // 选项内容
        @NameInMap("options")
        public java.util.List<FormCreateRequestFormComponentsChildrenChildrenPropsFieldsPropsOptions> options;

        // 是否需要大写，1需要大写，0不需要，默认1
        @NameInMap("upper")
        public String upper;

        // 时间单位（天、小时）
        @NameInMap("unit")
        public String unit;

        // 输入提示
        @NameInMap("placeholder")
        public String placeholder;

        // 业务别名
        @NameInMap("bizAlias")
        public String bizAlias;

        // 套件的业务标识
        @NameInMap("bizType")
        public String bizType;

        // 是否自动计算时长
        @NameInMap("duration")
        public Boolean duration;

        // 联系人控件是否支持多选，1多选，0单选
        @NameInMap("choice")
        public String choice;

        // 是否不可编辑
        @NameInMap("disabled")
        public Boolean disabled;

        // 文字提示控件显示方式（top|middle|bottom）
        @NameInMap("align")
        public String align;

        public static FormCreateRequestFormComponentsChildrenChildrenPropsFieldsProps build(java.util.Map<String, ?> map) throws Exception {
            FormCreateRequestFormComponentsChildrenChildrenPropsFieldsProps self = new FormCreateRequestFormComponentsChildrenChildrenPropsFieldsProps();
            return TeaModel.build(map, self);
        }

        public FormCreateRequestFormComponentsChildrenChildrenPropsFieldsProps setComponentId(String componentId) {
            this.componentId = componentId;
            return this;
        }
        public String getComponentId() {
            return this.componentId;
        }

        public FormCreateRequestFormComponentsChildrenChildrenPropsFieldsProps setLabel(String label) {
            this.label = label;
            return this;
        }
        public String getLabel() {
            return this.label;
        }

        public FormCreateRequestFormComponentsChildrenChildrenPropsFieldsProps setRequired(Boolean required) {
            this.required = required;
            return this;
        }
        public Boolean getRequired() {
            return this.required;
        }

        public FormCreateRequestFormComponentsChildrenChildrenPropsFieldsProps setPrint(String print) {
            this.print = print;
            return this;
        }
        public String getPrint() {
            return this.print;
        }

        public FormCreateRequestFormComponentsChildrenChildrenPropsFieldsProps setContent(String content) {
            this.content = content;
            return this;
        }
        public String getContent() {
            return this.content;
        }

        public FormCreateRequestFormComponentsChildrenChildrenPropsFieldsProps setFormat(String format) {
            this.format = format;
            return this;
        }
        public String getFormat() {
            return this.format;
        }

        public FormCreateRequestFormComponentsChildrenChildrenPropsFieldsProps setOptions(java.util.List<FormCreateRequestFormComponentsChildrenChildrenPropsFieldsPropsOptions> options) {
            this.options = options;
            return this;
        }
        public java.util.List<FormCreateRequestFormComponentsChildrenChildrenPropsFieldsPropsOptions> getOptions() {
            return this.options;
        }

        public FormCreateRequestFormComponentsChildrenChildrenPropsFieldsProps setUpper(String upper) {
            this.upper = upper;
            return this;
        }
        public String getUpper() {
            return this.upper;
        }

        public FormCreateRequestFormComponentsChildrenChildrenPropsFieldsProps setUnit(String unit) {
            this.unit = unit;
            return this;
        }
        public String getUnit() {
            return this.unit;
        }

        public FormCreateRequestFormComponentsChildrenChildrenPropsFieldsProps setPlaceholder(String placeholder) {
            this.placeholder = placeholder;
            return this;
        }
        public String getPlaceholder() {
            return this.placeholder;
        }

        public FormCreateRequestFormComponentsChildrenChildrenPropsFieldsProps setBizAlias(String bizAlias) {
            this.bizAlias = bizAlias;
            return this;
        }
        public String getBizAlias() {
            return this.bizAlias;
        }

        public FormCreateRequestFormComponentsChildrenChildrenPropsFieldsProps setBizType(String bizType) {
            this.bizType = bizType;
            return this;
        }
        public String getBizType() {
            return this.bizType;
        }

        public FormCreateRequestFormComponentsChildrenChildrenPropsFieldsProps setDuration(Boolean duration) {
            this.duration = duration;
            return this;
        }
        public Boolean getDuration() {
            return this.duration;
        }

        public FormCreateRequestFormComponentsChildrenChildrenPropsFieldsProps setChoice(String choice) {
            this.choice = choice;
            return this;
        }
        public String getChoice() {
            return this.choice;
        }

        public FormCreateRequestFormComponentsChildrenChildrenPropsFieldsProps setDisabled(Boolean disabled) {
            this.disabled = disabled;
            return this;
        }
        public Boolean getDisabled() {
            return this.disabled;
        }

        public FormCreateRequestFormComponentsChildrenChildrenPropsFieldsProps setAlign(String align) {
            this.align = align;
            return this;
        }
        public String getAlign() {
            return this.align;
        }

    }

    public static class FormCreateRequestFormComponentsChildrenChildrenPropsFields extends TeaModel {
        @NameInMap("componentType")
        public String componentType;

        @NameInMap("props")
        public FormCreateRequestFormComponentsChildrenChildrenPropsFieldsProps props;

        public static FormCreateRequestFormComponentsChildrenChildrenPropsFields build(java.util.Map<String, ?> map) throws Exception {
            FormCreateRequestFormComponentsChildrenChildrenPropsFields self = new FormCreateRequestFormComponentsChildrenChildrenPropsFields();
            return TeaModel.build(map, self);
        }

        public FormCreateRequestFormComponentsChildrenChildrenPropsFields setComponentType(String componentType) {
            this.componentType = componentType;
            return this;
        }
        public String getComponentType() {
            return this.componentType;
        }

        public FormCreateRequestFormComponentsChildrenChildrenPropsFields setProps(FormCreateRequestFormComponentsChildrenChildrenPropsFieldsProps props) {
            this.props = props;
            return this;
        }
        public FormCreateRequestFormComponentsChildrenChildrenPropsFieldsProps getProps() {
            return this.props;
        }

    }

    public static class FormCreateRequestFormComponentsChildrenChildrenProps extends TeaModel {
        @NameInMap("componentId")
        public String componentId;

        // 控件标题
        @NameInMap("label")
        public String label;

        // 套件中控件是否可设置为分条件字段
        @NameInMap("asyncCondition")
        public Boolean asyncCondition;

        // 必填
        @NameInMap("required")
        public Boolean required;

        // 说明文字控件内容
        @NameInMap("content")
        public String content;

        // 时间格式
        @NameInMap("format")
        public String format;

        // 是否需要大写，1需要大写，0不需要大写
        @NameInMap("upper")
        public String upper;

        // 时间单位（天、小时）
        @NameInMap("unit")
        public String unit;

        // 输入提示
        @NameInMap("placeholder")
        public String placeholder;

        // 业务别名
        @NameInMap("bizAlias")
        public String bizAlias;

        // 套件的业务标识
        @NameInMap("bizType")
        public String bizType;

        // 是否自动计算时长
        @NameInMap("duration")
        public Boolean duration;

        // 联系人控件是否支持多选，1多选，0单选
        @NameInMap("choice")
        public String choice;

        // 是否不可编辑
        @NameInMap("disabled")
        public Boolean disabled;

        // 文字提示控件显示方式:top|middle|bottom
        @NameInMap("align")
        public String align;

        // 是否隐藏字段
        @NameInMap("invisible")
        public Boolean invisible;

        // 说明文字控件链接地址
        @NameInMap("link")
        public String link;

        // 明细排版方式false横向，true纵向
        @NameInMap("verticalPrint")
        public Boolean verticalPrint;

        // 公式
        @NameInMap("formula")
        public String formula;

        // 自定义控件渲染标识
        @NameInMap("commonBizType")
        public String commonBizType;

        @NameInMap("options")
        public java.util.List<FormCreateRequestFormComponentsChildrenChildrenPropsOptions> options;

        @NameInMap("print")
        public String print;

        @NameInMap("statField")
        public java.util.List<FormCreateRequestFormComponentsChildrenChildrenPropsStatField> statField;

        @NameInMap("dataSource")
        public FormCreateRequestFormComponentsChildrenChildrenPropsDataSource dataSource;

        @NameInMap("fields")
        public java.util.List<FormCreateRequestFormComponentsChildrenChildrenPropsFields> fields;

        public static FormCreateRequestFormComponentsChildrenChildrenProps build(java.util.Map<String, ?> map) throws Exception {
            FormCreateRequestFormComponentsChildrenChildrenProps self = new FormCreateRequestFormComponentsChildrenChildrenProps();
            return TeaModel.build(map, self);
        }

        public FormCreateRequestFormComponentsChildrenChildrenProps setComponentId(String componentId) {
            this.componentId = componentId;
            return this;
        }
        public String getComponentId() {
            return this.componentId;
        }

        public FormCreateRequestFormComponentsChildrenChildrenProps setLabel(String label) {
            this.label = label;
            return this;
        }
        public String getLabel() {
            return this.label;
        }

        public FormCreateRequestFormComponentsChildrenChildrenProps setAsyncCondition(Boolean asyncCondition) {
            this.asyncCondition = asyncCondition;
            return this;
        }
        public Boolean getAsyncCondition() {
            return this.asyncCondition;
        }

        public FormCreateRequestFormComponentsChildrenChildrenProps setRequired(Boolean required) {
            this.required = required;
            return this;
        }
        public Boolean getRequired() {
            return this.required;
        }

        public FormCreateRequestFormComponentsChildrenChildrenProps setContent(String content) {
            this.content = content;
            return this;
        }
        public String getContent() {
            return this.content;
        }

        public FormCreateRequestFormComponentsChildrenChildrenProps setFormat(String format) {
            this.format = format;
            return this;
        }
        public String getFormat() {
            return this.format;
        }

        public FormCreateRequestFormComponentsChildrenChildrenProps setUpper(String upper) {
            this.upper = upper;
            return this;
        }
        public String getUpper() {
            return this.upper;
        }

        public FormCreateRequestFormComponentsChildrenChildrenProps setUnit(String unit) {
            this.unit = unit;
            return this;
        }
        public String getUnit() {
            return this.unit;
        }

        public FormCreateRequestFormComponentsChildrenChildrenProps setPlaceholder(String placeholder) {
            this.placeholder = placeholder;
            return this;
        }
        public String getPlaceholder() {
            return this.placeholder;
        }

        public FormCreateRequestFormComponentsChildrenChildrenProps setBizAlias(String bizAlias) {
            this.bizAlias = bizAlias;
            return this;
        }
        public String getBizAlias() {
            return this.bizAlias;
        }

        public FormCreateRequestFormComponentsChildrenChildrenProps setBizType(String bizType) {
            this.bizType = bizType;
            return this;
        }
        public String getBizType() {
            return this.bizType;
        }

        public FormCreateRequestFormComponentsChildrenChildrenProps setDuration(Boolean duration) {
            this.duration = duration;
            return this;
        }
        public Boolean getDuration() {
            return this.duration;
        }

        public FormCreateRequestFormComponentsChildrenChildrenProps setChoice(String choice) {
            this.choice = choice;
            return this;
        }
        public String getChoice() {
            return this.choice;
        }

        public FormCreateRequestFormComponentsChildrenChildrenProps setDisabled(Boolean disabled) {
            this.disabled = disabled;
            return this;
        }
        public Boolean getDisabled() {
            return this.disabled;
        }

        public FormCreateRequestFormComponentsChildrenChildrenProps setAlign(String align) {
            this.align = align;
            return this;
        }
        public String getAlign() {
            return this.align;
        }

        public FormCreateRequestFormComponentsChildrenChildrenProps setInvisible(Boolean invisible) {
            this.invisible = invisible;
            return this;
        }
        public Boolean getInvisible() {
            return this.invisible;
        }

        public FormCreateRequestFormComponentsChildrenChildrenProps setLink(String link) {
            this.link = link;
            return this;
        }
        public String getLink() {
            return this.link;
        }

        public FormCreateRequestFormComponentsChildrenChildrenProps setVerticalPrint(Boolean verticalPrint) {
            this.verticalPrint = verticalPrint;
            return this;
        }
        public Boolean getVerticalPrint() {
            return this.verticalPrint;
        }

        public FormCreateRequestFormComponentsChildrenChildrenProps setFormula(String formula) {
            this.formula = formula;
            return this;
        }
        public String getFormula() {
            return this.formula;
        }

        public FormCreateRequestFormComponentsChildrenChildrenProps setCommonBizType(String commonBizType) {
            this.commonBizType = commonBizType;
            return this;
        }
        public String getCommonBizType() {
            return this.commonBizType;
        }

        public FormCreateRequestFormComponentsChildrenChildrenProps setOptions(java.util.List<FormCreateRequestFormComponentsChildrenChildrenPropsOptions> options) {
            this.options = options;
            return this;
        }
        public java.util.List<FormCreateRequestFormComponentsChildrenChildrenPropsOptions> getOptions() {
            return this.options;
        }

        public FormCreateRequestFormComponentsChildrenChildrenProps setPrint(String print) {
            this.print = print;
            return this;
        }
        public String getPrint() {
            return this.print;
        }

        public FormCreateRequestFormComponentsChildrenChildrenProps setStatField(java.util.List<FormCreateRequestFormComponentsChildrenChildrenPropsStatField> statField) {
            this.statField = statField;
            return this;
        }
        public java.util.List<FormCreateRequestFormComponentsChildrenChildrenPropsStatField> getStatField() {
            return this.statField;
        }

        public FormCreateRequestFormComponentsChildrenChildrenProps setDataSource(FormCreateRequestFormComponentsChildrenChildrenPropsDataSource dataSource) {
            this.dataSource = dataSource;
            return this;
        }
        public FormCreateRequestFormComponentsChildrenChildrenPropsDataSource getDataSource() {
            return this.dataSource;
        }

        public FormCreateRequestFormComponentsChildrenChildrenProps setFields(java.util.List<FormCreateRequestFormComponentsChildrenChildrenPropsFields> fields) {
            this.fields = fields;
            return this;
        }
        public java.util.List<FormCreateRequestFormComponentsChildrenChildrenPropsFields> getFields() {
            return this.fields;
        }

    }

    public static class FormCreateRequestFormComponentsChildrenChildren extends TeaModel {
        @NameInMap("componentType")
        public String componentType;

        @NameInMap("props")
        public FormCreateRequestFormComponentsChildrenChildrenProps props;

        public static FormCreateRequestFormComponentsChildrenChildren build(java.util.Map<String, ?> map) throws Exception {
            FormCreateRequestFormComponentsChildrenChildren self = new FormCreateRequestFormComponentsChildrenChildren();
            return TeaModel.build(map, self);
        }

        public FormCreateRequestFormComponentsChildrenChildren setComponentType(String componentType) {
            this.componentType = componentType;
            return this;
        }
        public String getComponentType() {
            return this.componentType;
        }

        public FormCreateRequestFormComponentsChildrenChildren setProps(FormCreateRequestFormComponentsChildrenChildrenProps props) {
            this.props = props;
            return this;
        }
        public FormCreateRequestFormComponentsChildrenChildrenProps getProps() {
            return this.props;
        }

    }

    public static class FormCreateRequestFormComponentsChildren extends TeaModel {
        // 控件类型
        @NameInMap("componentType")
        public String componentType;

        // 控件属性
        @NameInMap("props")
        public FormCreateRequestFormComponentsChildrenProps props;

        // 子控件列表
        @NameInMap("children")
        public java.util.List<FormCreateRequestFormComponentsChildrenChildren> children;

        public static FormCreateRequestFormComponentsChildren build(java.util.Map<String, ?> map) throws Exception {
            FormCreateRequestFormComponentsChildren self = new FormCreateRequestFormComponentsChildren();
            return TeaModel.build(map, self);
        }

        public FormCreateRequestFormComponentsChildren setComponentType(String componentType) {
            this.componentType = componentType;
            return this;
        }
        public String getComponentType() {
            return this.componentType;
        }

        public FormCreateRequestFormComponentsChildren setProps(FormCreateRequestFormComponentsChildrenProps props) {
            this.props = props;
            return this;
        }
        public FormCreateRequestFormComponentsChildrenProps getProps() {
            return this.props;
        }

        public FormCreateRequestFormComponentsChildren setChildren(java.util.List<FormCreateRequestFormComponentsChildrenChildren> children) {
            this.children = children;
            return this;
        }
        public java.util.List<FormCreateRequestFormComponentsChildrenChildren> getChildren() {
            return this.children;
        }

    }

    public static class FormCreateRequestFormComponents extends TeaModel {
        // 控件类型
        @NameInMap("componentType")
        public String componentType;

        // 控件属性
        @NameInMap("props")
        public FormCreateRequestFormComponentsProps props;

        // 子控件列表
        @NameInMap("children")
        public java.util.List<FormCreateRequestFormComponentsChildren> children;

        public static FormCreateRequestFormComponents build(java.util.Map<String, ?> map) throws Exception {
            FormCreateRequestFormComponents self = new FormCreateRequestFormComponents();
            return TeaModel.build(map, self);
        }

        public FormCreateRequestFormComponents setComponentType(String componentType) {
            this.componentType = componentType;
            return this;
        }
        public String getComponentType() {
            return this.componentType;
        }

        public FormCreateRequestFormComponents setProps(FormCreateRequestFormComponentsProps props) {
            this.props = props;
            return this;
        }
        public FormCreateRequestFormComponentsProps getProps() {
            return this.props;
        }

        public FormCreateRequestFormComponents setChildren(java.util.List<FormCreateRequestFormComponentsChildren> children) {
            this.children = children;
            return this;
        }
        public java.util.List<FormCreateRequestFormComponentsChildren> getChildren() {
            return this.children;
        }

    }

}
