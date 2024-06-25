// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class DescribeMetaModelResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("metaModelDTOList")
    public java.util.List<DescribeMetaModelResponseBodyMetaModelDTOList> metaModelDTOList;

    public static DescribeMetaModelResponseBody build(java.util.Map<String, ?> map) throws Exception {
        DescribeMetaModelResponseBody self = new DescribeMetaModelResponseBody();
        return TeaModel.build(map, self);
    }

    public DescribeMetaModelResponseBody setMetaModelDTOList(java.util.List<DescribeMetaModelResponseBodyMetaModelDTOList> metaModelDTOList) {
        this.metaModelDTOList = metaModelDTOList;
        return this;
    }
    public java.util.List<DescribeMetaModelResponseBodyMetaModelDTOList> getMetaModelDTOList() {
        return this.metaModelDTOList;
    }

    public static class DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsAvailableTemplates extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>审批模板id</p>
         */
        @NameInMap("id")
        public String id;

        /**
         * <strong>example:</strong>
         * <p>审批模板名称</p>
         */
        @NameInMap("name")
        public String name;

        public static DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsAvailableTemplates build(java.util.Map<String, ?> map) throws Exception {
            DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsAvailableTemplates self = new DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsAvailableTemplates();
            return TeaModel.build(map, self);
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsAvailableTemplates setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsAvailableTemplates setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

    }

    public static class DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsDataSourceParamsFilters extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("fieldId")
        public String fieldId;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("filterType")
        public String filterType;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("value")
        public String value;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("valueType")
        public String valueType;

        public static DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsDataSourceParamsFilters build(java.util.Map<String, ?> map) throws Exception {
            DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsDataSourceParamsFilters self = new DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsDataSourceParamsFilters();
            return TeaModel.build(map, self);
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsDataSourceParamsFilters setFieldId(String fieldId) {
            this.fieldId = fieldId;
            return this;
        }
        public String getFieldId() {
            return this.fieldId;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsDataSourceParamsFilters setFilterType(String filterType) {
            this.filterType = filterType;
            return this;
        }
        public String getFilterType() {
            return this.filterType;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsDataSourceParamsFilters setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsDataSourceParamsFilters setValueType(String valueType) {
            this.valueType = valueType;
            return this;
        }
        public String getValueType() {
            return this.valueType;
        }

    }

    public static class DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsDataSourceParams extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("filters")
        public java.util.List<DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsDataSourceParamsFilters> filters;

        public static DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsDataSourceParams build(java.util.Map<String, ?> map) throws Exception {
            DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsDataSourceParams self = new DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsDataSourceParams();
            return TeaModel.build(map, self);
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsDataSourceParams setFilters(java.util.List<DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsDataSourceParamsFilters> filters) {
            this.filters = filters;
            return this;
        }
        public java.util.List<DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsDataSourceParamsFilters> getFilters() {
            return this.filters;
        }

    }

    public static class DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsDataSourceTarget extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("appType")
        public Long appType;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("appUuid")
        public String appUuid;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("bizType")
        public String bizType;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("formCode")
        public String formCode;

        public static DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsDataSourceTarget build(java.util.Map<String, ?> map) throws Exception {
            DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsDataSourceTarget self = new DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsDataSourceTarget();
            return TeaModel.build(map, self);
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsDataSourceTarget setAppType(Long appType) {
            this.appType = appType;
            return this;
        }
        public Long getAppType() {
            return this.appType;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsDataSourceTarget setAppUuid(String appUuid) {
            this.appUuid = appUuid;
            return this;
        }
        public String getAppUuid() {
            return this.appUuid;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsDataSourceTarget setBizType(String bizType) {
            this.bizType = bizType;
            return this;
        }
        public String getBizType() {
            return this.bizType;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsDataSourceTarget setFormCode(String formCode) {
            this.formCode = formCode;
            return this;
        }
        public String getFormCode() {
            return this.formCode;
        }

    }

    public static class DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsDataSource extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("params")
        public DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsDataSourceParams params;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("target")
        public DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsDataSourceTarget target;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("type")
        public String type;

        public static DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsDataSource build(java.util.Map<String, ?> map) throws Exception {
            DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsDataSource self = new DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsDataSource();
            return TeaModel.build(map, self);
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsDataSource setParams(DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsDataSourceParams params) {
            this.params = params;
            return this;
        }
        public DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsDataSourceParams getParams() {
            return this.params;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsDataSource setTarget(DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsDataSourceTarget target) {
            this.target = target;
            return this;
        }
        public DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsDataSourceTarget getTarget() {
            return this.target;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsDataSource setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

    }

    public static class DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsFieldsRelatePropsOptionsExtension extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("editFreeze")
        public Boolean editFreeze;

        public static DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsFieldsRelatePropsOptionsExtension build(java.util.Map<String, ?> map) throws Exception {
            DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsFieldsRelatePropsOptionsExtension self = new DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsFieldsRelatePropsOptionsExtension();
            return TeaModel.build(map, self);
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsFieldsRelatePropsOptionsExtension setEditFreeze(Boolean editFreeze) {
            this.editFreeze = editFreeze;
            return this;
        }
        public Boolean getEditFreeze() {
            return this.editFreeze;
        }

    }

    public static class DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsFieldsRelatePropsOptions extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("extension")
        public DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsFieldsRelatePropsOptionsExtension extension;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("key")
        public String key;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("value")
        public String value;

        public static DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsFieldsRelatePropsOptions build(java.util.Map<String, ?> map) throws Exception {
            DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsFieldsRelatePropsOptions self = new DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsFieldsRelatePropsOptions();
            return TeaModel.build(map, self);
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsFieldsRelatePropsOptions setExtension(DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsFieldsRelatePropsOptionsExtension extension) {
            this.extension = extension;
            return this;
        }
        public DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsFieldsRelatePropsOptionsExtension getExtension() {
            return this.extension;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsFieldsRelatePropsOptions setKey(String key) {
            this.key = key;
            return this;
        }
        public String getKey() {
            return this.key;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsFieldsRelatePropsOptions setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

    }

    public static class DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsFieldsRelatePropsStatField extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("fieldId")
        public String fieldId;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("label")
        public String label;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("unit")
        public String unit;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("upper")
        public Boolean upper;

        public static DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsFieldsRelatePropsStatField build(java.util.Map<String, ?> map) throws Exception {
            DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsFieldsRelatePropsStatField self = new DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsFieldsRelatePropsStatField();
            return TeaModel.build(map, self);
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsFieldsRelatePropsStatField setFieldId(String fieldId) {
            this.fieldId = fieldId;
            return this;
        }
        public String getFieldId() {
            return this.fieldId;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsFieldsRelatePropsStatField setLabel(String label) {
            this.label = label;
            return this;
        }
        public String getLabel() {
            return this.label;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsFieldsRelatePropsStatField setUnit(String unit) {
            this.unit = unit;
            return this;
        }
        public String getUnit() {
            return this.unit;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsFieldsRelatePropsStatField setUpper(Boolean upper) {
            this.upper = upper;
            return this;
        }
        public Boolean getUpper() {
            return this.upper;
        }

    }

    public static class DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsFieldsRelateProps extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("align")
        public String align;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("bizAlias")
        public String bizAlias;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("choice")
        public Long choice;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("content")
        public String content;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("disabled")
        public Boolean disabled;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("duration")
        public Boolean duration;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("durationLabel")
        public String durationLabel;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("fieldId")
        public String fieldId;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("format")
        public String format;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("formula")
        public String formula;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("invisible")
        public Boolean invisible;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("label")
        public String label;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("labelEditableFreeze")
        public Boolean labelEditableFreeze;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("limit")
        public Long limit;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("link")
        public String link;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("mode")
        public String mode;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("notUpper")
        public String notUpper;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("options")
        public java.util.List<DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsFieldsRelatePropsOptions> options;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("payEnable")
        public Boolean payEnable;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("placeholder")
        public String placeholder;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("ratio")
        public Long ratio;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("required")
        public Boolean required;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("requiredEditableFreeze")
        public Boolean requiredEditableFreeze;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("spread")
        public Boolean spread;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("statField")
        public java.util.List<DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsFieldsRelatePropsStatField> statField;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("unit")
        public String unit;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("verticalPrint")
        public Boolean verticalPrint;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("watermark")
        public Boolean watermark;

        public static DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsFieldsRelateProps build(java.util.Map<String, ?> map) throws Exception {
            DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsFieldsRelateProps self = new DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsFieldsRelateProps();
            return TeaModel.build(map, self);
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsFieldsRelateProps setAlign(String align) {
            this.align = align;
            return this;
        }
        public String getAlign() {
            return this.align;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsFieldsRelateProps setBizAlias(String bizAlias) {
            this.bizAlias = bizAlias;
            return this;
        }
        public String getBizAlias() {
            return this.bizAlias;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsFieldsRelateProps setChoice(Long choice) {
            this.choice = choice;
            return this;
        }
        public Long getChoice() {
            return this.choice;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsFieldsRelateProps setContent(String content) {
            this.content = content;
            return this;
        }
        public String getContent() {
            return this.content;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsFieldsRelateProps setDisabled(Boolean disabled) {
            this.disabled = disabled;
            return this;
        }
        public Boolean getDisabled() {
            return this.disabled;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsFieldsRelateProps setDuration(Boolean duration) {
            this.duration = duration;
            return this;
        }
        public Boolean getDuration() {
            return this.duration;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsFieldsRelateProps setDurationLabel(String durationLabel) {
            this.durationLabel = durationLabel;
            return this;
        }
        public String getDurationLabel() {
            return this.durationLabel;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsFieldsRelateProps setFieldId(String fieldId) {
            this.fieldId = fieldId;
            return this;
        }
        public String getFieldId() {
            return this.fieldId;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsFieldsRelateProps setFormat(String format) {
            this.format = format;
            return this;
        }
        public String getFormat() {
            return this.format;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsFieldsRelateProps setFormula(String formula) {
            this.formula = formula;
            return this;
        }
        public String getFormula() {
            return this.formula;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsFieldsRelateProps setInvisible(Boolean invisible) {
            this.invisible = invisible;
            return this;
        }
        public Boolean getInvisible() {
            return this.invisible;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsFieldsRelateProps setLabel(String label) {
            this.label = label;
            return this;
        }
        public String getLabel() {
            return this.label;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsFieldsRelateProps setLabelEditableFreeze(Boolean labelEditableFreeze) {
            this.labelEditableFreeze = labelEditableFreeze;
            return this;
        }
        public Boolean getLabelEditableFreeze() {
            return this.labelEditableFreeze;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsFieldsRelateProps setLimit(Long limit) {
            this.limit = limit;
            return this;
        }
        public Long getLimit() {
            return this.limit;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsFieldsRelateProps setLink(String link) {
            this.link = link;
            return this;
        }
        public String getLink() {
            return this.link;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsFieldsRelateProps setMode(String mode) {
            this.mode = mode;
            return this;
        }
        public String getMode() {
            return this.mode;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsFieldsRelateProps setNotUpper(String notUpper) {
            this.notUpper = notUpper;
            return this;
        }
        public String getNotUpper() {
            return this.notUpper;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsFieldsRelateProps setOptions(java.util.List<DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsFieldsRelatePropsOptions> options) {
            this.options = options;
            return this;
        }
        public java.util.List<DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsFieldsRelatePropsOptions> getOptions() {
            return this.options;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsFieldsRelateProps setPayEnable(Boolean payEnable) {
            this.payEnable = payEnable;
            return this;
        }
        public Boolean getPayEnable() {
            return this.payEnable;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsFieldsRelateProps setPlaceholder(String placeholder) {
            this.placeholder = placeholder;
            return this;
        }
        public String getPlaceholder() {
            return this.placeholder;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsFieldsRelateProps setRatio(Long ratio) {
            this.ratio = ratio;
            return this;
        }
        public Long getRatio() {
            return this.ratio;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsFieldsRelateProps setRequired(Boolean required) {
            this.required = required;
            return this;
        }
        public Boolean getRequired() {
            return this.required;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsFieldsRelateProps setRequiredEditableFreeze(Boolean requiredEditableFreeze) {
            this.requiredEditableFreeze = requiredEditableFreeze;
            return this;
        }
        public Boolean getRequiredEditableFreeze() {
            return this.requiredEditableFreeze;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsFieldsRelateProps setSpread(Boolean spread) {
            this.spread = spread;
            return this;
        }
        public Boolean getSpread() {
            return this.spread;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsFieldsRelateProps setStatField(java.util.List<DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsFieldsRelatePropsStatField> statField) {
            this.statField = statField;
            return this;
        }
        public java.util.List<DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsFieldsRelatePropsStatField> getStatField() {
            return this.statField;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsFieldsRelateProps setUnit(String unit) {
            this.unit = unit;
            return this;
        }
        public String getUnit() {
            return this.unit;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsFieldsRelateProps setVerticalPrint(Boolean verticalPrint) {
            this.verticalPrint = verticalPrint;
            return this;
        }
        public Boolean getVerticalPrint() {
            return this.verticalPrint;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsFieldsRelateProps setWatermark(Boolean watermark) {
            this.watermark = watermark;
            return this;
        }
        public Boolean getWatermark() {
            return this.watermark;
        }

    }

    public static class DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsFields extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("componentName")
        public String componentName;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("relateProps")
        public DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsFieldsRelateProps relateProps;

        public static DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsFields build(java.util.Map<String, ?> map) throws Exception {
            DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsFields self = new DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsFields();
            return TeaModel.build(map, self);
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsFields setComponentName(String componentName) {
            this.componentName = componentName;
            return this;
        }
        public String getComponentName() {
            return this.componentName;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsFields setRelateProps(DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsFieldsRelateProps relateProps) {
            this.relateProps = relateProps;
            return this;
        }
        public DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsFieldsRelateProps getRelateProps() {
            return this.relateProps;
        }

    }

    public static class DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsOptionsExtension extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("editFreeze")
        public Boolean editFreeze;

        public static DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsOptionsExtension build(java.util.Map<String, ?> map) throws Exception {
            DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsOptionsExtension self = new DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsOptionsExtension();
            return TeaModel.build(map, self);
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsOptionsExtension setEditFreeze(Boolean editFreeze) {
            this.editFreeze = editFreeze;
            return this;
        }
        public Boolean getEditFreeze() {
            return this.editFreeze;
        }

    }

    public static class DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsOptions extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("extension")
        public DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsOptionsExtension extension;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("key")
        public String key;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("value")
        public String value;

        public static DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsOptions build(java.util.Map<String, ?> map) throws Exception {
            DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsOptions self = new DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsOptions();
            return TeaModel.build(map, self);
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsOptions setExtension(DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsOptionsExtension extension) {
            this.extension = extension;
            return this;
        }
        public DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsOptionsExtension getExtension() {
            return this.extension;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsOptions setKey(String key) {
            this.key = key;
            return this;
        }
        public String getKey() {
            return this.key;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsOptions setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

    }

    public static class DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsRelateSourceDataSourceParamsFilters extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("fieldId")
        public String fieldId;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("filterType")
        public String filterType;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("value")
        public String value;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("valueType")
        public String valueType;

        public static DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsRelateSourceDataSourceParamsFilters build(java.util.Map<String, ?> map) throws Exception {
            DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsRelateSourceDataSourceParamsFilters self = new DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsRelateSourceDataSourceParamsFilters();
            return TeaModel.build(map, self);
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsRelateSourceDataSourceParamsFilters setFieldId(String fieldId) {
            this.fieldId = fieldId;
            return this;
        }
        public String getFieldId() {
            return this.fieldId;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsRelateSourceDataSourceParamsFilters setFilterType(String filterType) {
            this.filterType = filterType;
            return this;
        }
        public String getFilterType() {
            return this.filterType;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsRelateSourceDataSourceParamsFilters setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsRelateSourceDataSourceParamsFilters setValueType(String valueType) {
            this.valueType = valueType;
            return this;
        }
        public String getValueType() {
            return this.valueType;
        }

    }

    public static class DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsRelateSourceDataSourceParams extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("filters")
        public java.util.List<DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsRelateSourceDataSourceParamsFilters> filters;

        public static DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsRelateSourceDataSourceParams build(java.util.Map<String, ?> map) throws Exception {
            DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsRelateSourceDataSourceParams self = new DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsRelateSourceDataSourceParams();
            return TeaModel.build(map, self);
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsRelateSourceDataSourceParams setFilters(java.util.List<DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsRelateSourceDataSourceParamsFilters> filters) {
            this.filters = filters;
            return this;
        }
        public java.util.List<DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsRelateSourceDataSourceParamsFilters> getFilters() {
            return this.filters;
        }

    }

    public static class DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsRelateSourceDataSourceTarget extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("appType")
        public Long appType;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("appUuid")
        public String appUuid;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("bizType")
        public String bizType;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("formCode")
        public String formCode;

        public static DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsRelateSourceDataSourceTarget build(java.util.Map<String, ?> map) throws Exception {
            DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsRelateSourceDataSourceTarget self = new DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsRelateSourceDataSourceTarget();
            return TeaModel.build(map, self);
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsRelateSourceDataSourceTarget setAppType(Long appType) {
            this.appType = appType;
            return this;
        }
        public Long getAppType() {
            return this.appType;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsRelateSourceDataSourceTarget setAppUuid(String appUuid) {
            this.appUuid = appUuid;
            return this;
        }
        public String getAppUuid() {
            return this.appUuid;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsRelateSourceDataSourceTarget setBizType(String bizType) {
            this.bizType = bizType;
            return this;
        }
        public String getBizType() {
            return this.bizType;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsRelateSourceDataSourceTarget setFormCode(String formCode) {
            this.formCode = formCode;
            return this;
        }
        public String getFormCode() {
            return this.formCode;
        }

    }

    public static class DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsRelateSourceDataSource extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("params")
        public DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsRelateSourceDataSourceParams params;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("target")
        public DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsRelateSourceDataSourceTarget target;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("type")
        public String type;

        public static DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsRelateSourceDataSource build(java.util.Map<String, ?> map) throws Exception {
            DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsRelateSourceDataSource self = new DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsRelateSourceDataSource();
            return TeaModel.build(map, self);
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsRelateSourceDataSource setParams(DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsRelateSourceDataSourceParams params) {
            this.params = params;
            return this;
        }
        public DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsRelateSourceDataSourceParams getParams() {
            return this.params;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsRelateSourceDataSource setTarget(DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsRelateSourceDataSourceTarget target) {
            this.target = target;
            return this;
        }
        public DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsRelateSourceDataSourceTarget getTarget() {
            return this.target;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsRelateSourceDataSource setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

    }

    public static class DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsRelateSourceFieldsRelatePropsOptions extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("key")
        public String key;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("value")
        public String value;

        public static DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsRelateSourceFieldsRelatePropsOptions build(java.util.Map<String, ?> map) throws Exception {
            DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsRelateSourceFieldsRelatePropsOptions self = new DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsRelateSourceFieldsRelatePropsOptions();
            return TeaModel.build(map, self);
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsRelateSourceFieldsRelatePropsOptions setKey(String key) {
            this.key = key;
            return this;
        }
        public String getKey() {
            return this.key;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsRelateSourceFieldsRelatePropsOptions setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

    }

    public static class DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsRelateSourceFieldsRelatePropsStatField extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("fieldId")
        public String fieldId;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("label")
        public String label;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("unit")
        public String unit;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("upper")
        public Boolean upper;

        public static DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsRelateSourceFieldsRelatePropsStatField build(java.util.Map<String, ?> map) throws Exception {
            DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsRelateSourceFieldsRelatePropsStatField self = new DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsRelateSourceFieldsRelatePropsStatField();
            return TeaModel.build(map, self);
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsRelateSourceFieldsRelatePropsStatField setFieldId(String fieldId) {
            this.fieldId = fieldId;
            return this;
        }
        public String getFieldId() {
            return this.fieldId;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsRelateSourceFieldsRelatePropsStatField setLabel(String label) {
            this.label = label;
            return this;
        }
        public String getLabel() {
            return this.label;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsRelateSourceFieldsRelatePropsStatField setUnit(String unit) {
            this.unit = unit;
            return this;
        }
        public String getUnit() {
            return this.unit;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsRelateSourceFieldsRelatePropsStatField setUpper(Boolean upper) {
            this.upper = upper;
            return this;
        }
        public Boolean getUpper() {
            return this.upper;
        }

    }

    public static class DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsRelateSourceFieldsRelateProps extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("align")
        public String align;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("bizAlias")
        public String bizAlias;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>1：多选，0：单选</p>
         */
        @NameInMap("choice")
        public Long choice;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("content")
        public String content;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>true：可编辑</p>
         */
        @NameInMap("disabled")
        public Boolean disabled;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>true：自动</p>
         */
        @NameInMap("duration")
        public String duration;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("fieldId")
        public String fieldId;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>DDDateField和DDDateRangeField</p>
         */
        @NameInMap("format")
        public String format;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("formula")
        public String formula;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>true：隐藏</p>
         */
        @NameInMap("invisible")
        public Boolean invisible;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("label")
        public String label;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("labelEditableFreeze")
        public Boolean labelEditableFreeze;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("link")
        public String link;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("multi")
        public Long multi;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>1:不需要大写, 空或者0:需要大写</p>
         */
        @NameInMap("notUpper")
        public String notUpper;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("options")
        public java.util.List<DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsRelateSourceFieldsRelatePropsOptions> options;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>true：是</p>
         */
        @NameInMap("payEnable")
        public Boolean payEnable;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("placeholder")
        public String placeholder;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("quote")
        public Long quote;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>true：必填</p>
         */
        @NameInMap("required")
        public Boolean required;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("requiredEditableFreeze")
        public Boolean requiredEditableFreeze;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("statField")
        public java.util.List<DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsRelateSourceFieldsRelatePropsStatField> statField;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("unit")
        public String unit;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>true：纵向，false：横向</p>
         */
        @NameInMap("verticalPrint")
        public Boolean verticalPrint;

        public static DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsRelateSourceFieldsRelateProps build(java.util.Map<String, ?> map) throws Exception {
            DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsRelateSourceFieldsRelateProps self = new DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsRelateSourceFieldsRelateProps();
            return TeaModel.build(map, self);
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsRelateSourceFieldsRelateProps setAlign(String align) {
            this.align = align;
            return this;
        }
        public String getAlign() {
            return this.align;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsRelateSourceFieldsRelateProps setBizAlias(String bizAlias) {
            this.bizAlias = bizAlias;
            return this;
        }
        public String getBizAlias() {
            return this.bizAlias;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsRelateSourceFieldsRelateProps setChoice(Long choice) {
            this.choice = choice;
            return this;
        }
        public Long getChoice() {
            return this.choice;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsRelateSourceFieldsRelateProps setContent(String content) {
            this.content = content;
            return this;
        }
        public String getContent() {
            return this.content;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsRelateSourceFieldsRelateProps setDisabled(Boolean disabled) {
            this.disabled = disabled;
            return this;
        }
        public Boolean getDisabled() {
            return this.disabled;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsRelateSourceFieldsRelateProps setDuration(String duration) {
            this.duration = duration;
            return this;
        }
        public String getDuration() {
            return this.duration;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsRelateSourceFieldsRelateProps setFieldId(String fieldId) {
            this.fieldId = fieldId;
            return this;
        }
        public String getFieldId() {
            return this.fieldId;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsRelateSourceFieldsRelateProps setFormat(String format) {
            this.format = format;
            return this;
        }
        public String getFormat() {
            return this.format;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsRelateSourceFieldsRelateProps setFormula(String formula) {
            this.formula = formula;
            return this;
        }
        public String getFormula() {
            return this.formula;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsRelateSourceFieldsRelateProps setInvisible(Boolean invisible) {
            this.invisible = invisible;
            return this;
        }
        public Boolean getInvisible() {
            return this.invisible;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsRelateSourceFieldsRelateProps setLabel(String label) {
            this.label = label;
            return this;
        }
        public String getLabel() {
            return this.label;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsRelateSourceFieldsRelateProps setLabelEditableFreeze(Boolean labelEditableFreeze) {
            this.labelEditableFreeze = labelEditableFreeze;
            return this;
        }
        public Boolean getLabelEditableFreeze() {
            return this.labelEditableFreeze;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsRelateSourceFieldsRelateProps setLink(String link) {
            this.link = link;
            return this;
        }
        public String getLink() {
            return this.link;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsRelateSourceFieldsRelateProps setMulti(Long multi) {
            this.multi = multi;
            return this;
        }
        public Long getMulti() {
            return this.multi;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsRelateSourceFieldsRelateProps setNotUpper(String notUpper) {
            this.notUpper = notUpper;
            return this;
        }
        public String getNotUpper() {
            return this.notUpper;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsRelateSourceFieldsRelateProps setOptions(java.util.List<DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsRelateSourceFieldsRelatePropsOptions> options) {
            this.options = options;
            return this;
        }
        public java.util.List<DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsRelateSourceFieldsRelatePropsOptions> getOptions() {
            return this.options;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsRelateSourceFieldsRelateProps setPayEnable(Boolean payEnable) {
            this.payEnable = payEnable;
            return this;
        }
        public Boolean getPayEnable() {
            return this.payEnable;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsRelateSourceFieldsRelateProps setPlaceholder(String placeholder) {
            this.placeholder = placeholder;
            return this;
        }
        public String getPlaceholder() {
            return this.placeholder;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsRelateSourceFieldsRelateProps setQuote(Long quote) {
            this.quote = quote;
            return this;
        }
        public Long getQuote() {
            return this.quote;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsRelateSourceFieldsRelateProps setRequired(Boolean required) {
            this.required = required;
            return this;
        }
        public Boolean getRequired() {
            return this.required;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsRelateSourceFieldsRelateProps setRequiredEditableFreeze(Boolean requiredEditableFreeze) {
            this.requiredEditableFreeze = requiredEditableFreeze;
            return this;
        }
        public Boolean getRequiredEditableFreeze() {
            return this.requiredEditableFreeze;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsRelateSourceFieldsRelateProps setStatField(java.util.List<DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsRelateSourceFieldsRelatePropsStatField> statField) {
            this.statField = statField;
            return this;
        }
        public java.util.List<DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsRelateSourceFieldsRelatePropsStatField> getStatField() {
            return this.statField;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsRelateSourceFieldsRelateProps setUnit(String unit) {
            this.unit = unit;
            return this;
        }
        public String getUnit() {
            return this.unit;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsRelateSourceFieldsRelateProps setVerticalPrint(Boolean verticalPrint) {
            this.verticalPrint = verticalPrint;
            return this;
        }
        public Boolean getVerticalPrint() {
            return this.verticalPrint;
        }

    }

    public static class DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsRelateSourceFields extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("componentName")
        public String componentName;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("relateProps")
        public DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsRelateSourceFieldsRelateProps relateProps;

        public static DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsRelateSourceFields build(java.util.Map<String, ?> map) throws Exception {
            DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsRelateSourceFields self = new DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsRelateSourceFields();
            return TeaModel.build(map, self);
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsRelateSourceFields setComponentName(String componentName) {
            this.componentName = componentName;
            return this;
        }
        public String getComponentName() {
            return this.componentName;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsRelateSourceFields setRelateProps(DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsRelateSourceFieldsRelateProps relateProps) {
            this.relateProps = relateProps;
            return this;
        }
        public DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsRelateSourceFieldsRelateProps getRelateProps() {
            return this.relateProps;
        }

    }

    public static class DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsRelateSource extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("bizType")
        public String bizType;

        @NameInMap("dataSource")
        public DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsRelateSourceDataSource dataSource;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("fields")
        public java.util.List<DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsRelateSourceFields> fields;

        public static DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsRelateSource build(java.util.Map<String, ?> map) throws Exception {
            DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsRelateSource self = new DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsRelateSource();
            return TeaModel.build(map, self);
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsRelateSource setBizType(String bizType) {
            this.bizType = bizType;
            return this;
        }
        public String getBizType() {
            return this.bizType;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsRelateSource setDataSource(DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsRelateSourceDataSource dataSource) {
            this.dataSource = dataSource;
            return this;
        }
        public DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsRelateSourceDataSource getDataSource() {
            return this.dataSource;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsRelateSource setFields(java.util.List<DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsRelateSourceFields> fields) {
            this.fields = fields;
            return this;
        }
        public java.util.List<DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsRelateSourceFields> getFields() {
            return this.fields;
        }

    }

    public static class DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsRule extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("type")
        public String type;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("value")
        public String value;

        public static DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsRule build(java.util.Map<String, ?> map) throws Exception {
            DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsRule self = new DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsRule();
            return TeaModel.build(map, self);
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsRule setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsRule setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

    }

    public static class DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsStatField extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("fieldId")
        public String fieldId;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("label")
        public String label;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("unit")
        public String unit;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("upper")
        public Boolean upper;

        public static DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsStatField build(java.util.Map<String, ?> map) throws Exception {
            DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsStatField self = new DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsStatField();
            return TeaModel.build(map, self);
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsStatField setFieldId(String fieldId) {
            this.fieldId = fieldId;
            return this;
        }
        public String getFieldId() {
            return this.fieldId;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsStatField setLabel(String label) {
            this.label = label;
            return this;
        }
        public String getLabel() {
            return this.label;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsStatField setUnit(String unit) {
            this.unit = unit;
            return this;
        }
        public String getUnit() {
            return this.unit;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsStatField setUpper(Boolean upper) {
            this.upper = upper;
            return this;
        }
        public Boolean getUpper() {
            return this.upper;
        }

    }

    public static class DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenProps extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("actionName")
        public String actionName;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("align")
        public String align;

        @NameInMap("availableTemplates")
        public java.util.List<DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsAvailableTemplates> availableTemplates;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("bizAlias")
        public String bizAlias;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("choice")
        public Long choice;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("content")
        public String content;

        @NameInMap("dataSource")
        public DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsDataSource dataSource;

        /**
         * <strong>example:</strong>
         * <p>标签字段 颜色属性，格式：#0089FF</p>
         */
        @NameInMap("defaultColor")
        public String defaultColor;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("disabled")
        public Boolean disabled;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("duration")
        public Boolean duration;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("durationLabel")
        public String durationLabel;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("fieldId")
        public String fieldId;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("fields")
        public java.util.List<DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsFields> fields;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("format")
        public String format;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("formula")
        public String formula;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("invisible")
        public Boolean invisible;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("label")
        public String label;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("labelEditableFreeze")
        public Boolean labelEditableFreeze;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("limit")
        public Long limit;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("link")
        public String link;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("mode")
        public String mode;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>true：支持多选，false：单选</p>
         */
        @NameInMap("multiple")
        public Boolean multiple;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("notPrint")
        public String notPrint;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("notUpper")
        public String notUpper;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("options")
        public java.util.List<DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsOptions> options;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("payEnable")
        public Boolean payEnable;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("placeholder")
        public String placeholder;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("quote")
        public Long quote;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("ratio")
        public Long ratio;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("relateSource")
        public java.util.List<DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsRelateSource> relateSource;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("required")
        public Boolean required;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("requiredEditableFreeze")
        public Boolean requiredEditableFreeze;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("rule")
        public java.util.List<DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsRule> rule;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("sortable")
        public Boolean sortable;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("spread")
        public Boolean spread;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("statField")
        public java.util.List<DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsStatField> statField;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("tableViewMode")
        public String tableViewMode;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("unit")
        public String unit;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("verticalPrint")
        public Boolean verticalPrint;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("watermark")
        public Boolean watermark;

        public static DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenProps build(java.util.Map<String, ?> map) throws Exception {
            DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenProps self = new DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenProps();
            return TeaModel.build(map, self);
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenProps setActionName(String actionName) {
            this.actionName = actionName;
            return this;
        }
        public String getActionName() {
            return this.actionName;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenProps setAlign(String align) {
            this.align = align;
            return this;
        }
        public String getAlign() {
            return this.align;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenProps setAvailableTemplates(java.util.List<DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsAvailableTemplates> availableTemplates) {
            this.availableTemplates = availableTemplates;
            return this;
        }
        public java.util.List<DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsAvailableTemplates> getAvailableTemplates() {
            return this.availableTemplates;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenProps setBizAlias(String bizAlias) {
            this.bizAlias = bizAlias;
            return this;
        }
        public String getBizAlias() {
            return this.bizAlias;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenProps setChoice(Long choice) {
            this.choice = choice;
            return this;
        }
        public Long getChoice() {
            return this.choice;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenProps setContent(String content) {
            this.content = content;
            return this;
        }
        public String getContent() {
            return this.content;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenProps setDataSource(DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsDataSource dataSource) {
            this.dataSource = dataSource;
            return this;
        }
        public DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsDataSource getDataSource() {
            return this.dataSource;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenProps setDefaultColor(String defaultColor) {
            this.defaultColor = defaultColor;
            return this;
        }
        public String getDefaultColor() {
            return this.defaultColor;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenProps setDisabled(Boolean disabled) {
            this.disabled = disabled;
            return this;
        }
        public Boolean getDisabled() {
            return this.disabled;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenProps setDuration(Boolean duration) {
            this.duration = duration;
            return this;
        }
        public Boolean getDuration() {
            return this.duration;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenProps setDurationLabel(String durationLabel) {
            this.durationLabel = durationLabel;
            return this;
        }
        public String getDurationLabel() {
            return this.durationLabel;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenProps setFieldId(String fieldId) {
            this.fieldId = fieldId;
            return this;
        }
        public String getFieldId() {
            return this.fieldId;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenProps setFields(java.util.List<DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsFields> fields) {
            this.fields = fields;
            return this;
        }
        public java.util.List<DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsFields> getFields() {
            return this.fields;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenProps setFormat(String format) {
            this.format = format;
            return this;
        }
        public String getFormat() {
            return this.format;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenProps setFormula(String formula) {
            this.formula = formula;
            return this;
        }
        public String getFormula() {
            return this.formula;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenProps setInvisible(Boolean invisible) {
            this.invisible = invisible;
            return this;
        }
        public Boolean getInvisible() {
            return this.invisible;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenProps setLabel(String label) {
            this.label = label;
            return this;
        }
        public String getLabel() {
            return this.label;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenProps setLabelEditableFreeze(Boolean labelEditableFreeze) {
            this.labelEditableFreeze = labelEditableFreeze;
            return this;
        }
        public Boolean getLabelEditableFreeze() {
            return this.labelEditableFreeze;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenProps setLimit(Long limit) {
            this.limit = limit;
            return this;
        }
        public Long getLimit() {
            return this.limit;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenProps setLink(String link) {
            this.link = link;
            return this;
        }
        public String getLink() {
            return this.link;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenProps setMode(String mode) {
            this.mode = mode;
            return this;
        }
        public String getMode() {
            return this.mode;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenProps setMultiple(Boolean multiple) {
            this.multiple = multiple;
            return this;
        }
        public Boolean getMultiple() {
            return this.multiple;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenProps setNotPrint(String notPrint) {
            this.notPrint = notPrint;
            return this;
        }
        public String getNotPrint() {
            return this.notPrint;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenProps setNotUpper(String notUpper) {
            this.notUpper = notUpper;
            return this;
        }
        public String getNotUpper() {
            return this.notUpper;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenProps setOptions(java.util.List<DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsOptions> options) {
            this.options = options;
            return this;
        }
        public java.util.List<DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsOptions> getOptions() {
            return this.options;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenProps setPayEnable(Boolean payEnable) {
            this.payEnable = payEnable;
            return this;
        }
        public Boolean getPayEnable() {
            return this.payEnable;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenProps setPlaceholder(String placeholder) {
            this.placeholder = placeholder;
            return this;
        }
        public String getPlaceholder() {
            return this.placeholder;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenProps setQuote(Long quote) {
            this.quote = quote;
            return this;
        }
        public Long getQuote() {
            return this.quote;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenProps setRatio(Long ratio) {
            this.ratio = ratio;
            return this;
        }
        public Long getRatio() {
            return this.ratio;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenProps setRelateSource(java.util.List<DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsRelateSource> relateSource) {
            this.relateSource = relateSource;
            return this;
        }
        public java.util.List<DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsRelateSource> getRelateSource() {
            return this.relateSource;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenProps setRequired(Boolean required) {
            this.required = required;
            return this;
        }
        public Boolean getRequired() {
            return this.required;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenProps setRequiredEditableFreeze(Boolean requiredEditableFreeze) {
            this.requiredEditableFreeze = requiredEditableFreeze;
            return this;
        }
        public Boolean getRequiredEditableFreeze() {
            return this.requiredEditableFreeze;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenProps setRule(java.util.List<DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsRule> rule) {
            this.rule = rule;
            return this;
        }
        public java.util.List<DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsRule> getRule() {
            return this.rule;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenProps setSortable(Boolean sortable) {
            this.sortable = sortable;
            return this;
        }
        public Boolean getSortable() {
            return this.sortable;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenProps setSpread(Boolean spread) {
            this.spread = spread;
            return this;
        }
        public Boolean getSpread() {
            return this.spread;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenProps setStatField(java.util.List<DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsStatField> statField) {
            this.statField = statField;
            return this;
        }
        public java.util.List<DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenPropsStatField> getStatField() {
            return this.statField;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenProps setTableViewMode(String tableViewMode) {
            this.tableViewMode = tableViewMode;
            return this;
        }
        public String getTableViewMode() {
            return this.tableViewMode;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenProps setUnit(String unit) {
            this.unit = unit;
            return this;
        }
        public String getUnit() {
            return this.unit;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenProps setVerticalPrint(Boolean verticalPrint) {
            this.verticalPrint = verticalPrint;
            return this;
        }
        public Boolean getVerticalPrint() {
            return this.verticalPrint;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenProps setWatermark(Boolean watermark) {
            this.watermark = watermark;
            return this;
        }
        public Boolean getWatermark() {
            return this.watermark;
        }

    }

    public static class DescribeMetaModelResponseBodyMetaModelDTOListItemsChildren extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("componentName")
        public String componentName;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("props")
        public DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenProps props;

        public static DescribeMetaModelResponseBodyMetaModelDTOListItemsChildren build(java.util.Map<String, ?> map) throws Exception {
            DescribeMetaModelResponseBodyMetaModelDTOListItemsChildren self = new DescribeMetaModelResponseBodyMetaModelDTOListItemsChildren();
            return TeaModel.build(map, self);
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsChildren setComponentName(String componentName) {
            this.componentName = componentName;
            return this;
        }
        public String getComponentName() {
            return this.componentName;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsChildren setProps(DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenProps props) {
            this.props = props;
            return this;
        }
        public DescribeMetaModelResponseBodyMetaModelDTOListItemsChildrenProps getProps() {
            return this.props;
        }

    }

    public static class DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsAvailableTemplates extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>审批模板id</p>
         */
        @NameInMap("id")
        public String id;

        /**
         * <strong>example:</strong>
         * <p>审批模板名称</p>
         */
        @NameInMap("name")
        public String name;

        public static DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsAvailableTemplates build(java.util.Map<String, ?> map) throws Exception {
            DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsAvailableTemplates self = new DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsAvailableTemplates();
            return TeaModel.build(map, self);
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsAvailableTemplates setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsAvailableTemplates setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

    }

    public static class DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsDataSourceParamsFilters extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("fieldId")
        public String fieldId;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("filterType")
        public String filterType;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("value")
        public String value;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("valueType")
        public String valueType;

        public static DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsDataSourceParamsFilters build(java.util.Map<String, ?> map) throws Exception {
            DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsDataSourceParamsFilters self = new DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsDataSourceParamsFilters();
            return TeaModel.build(map, self);
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsDataSourceParamsFilters setFieldId(String fieldId) {
            this.fieldId = fieldId;
            return this;
        }
        public String getFieldId() {
            return this.fieldId;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsDataSourceParamsFilters setFilterType(String filterType) {
            this.filterType = filterType;
            return this;
        }
        public String getFilterType() {
            return this.filterType;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsDataSourceParamsFilters setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsDataSourceParamsFilters setValueType(String valueType) {
            this.valueType = valueType;
            return this;
        }
        public String getValueType() {
            return this.valueType;
        }

    }

    public static class DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsDataSourceParams extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("filters")
        public java.util.List<DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsDataSourceParamsFilters> filters;

        public static DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsDataSourceParams build(java.util.Map<String, ?> map) throws Exception {
            DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsDataSourceParams self = new DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsDataSourceParams();
            return TeaModel.build(map, self);
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsDataSourceParams setFilters(java.util.List<DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsDataSourceParamsFilters> filters) {
            this.filters = filters;
            return this;
        }
        public java.util.List<DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsDataSourceParamsFilters> getFilters() {
            return this.filters;
        }

    }

    public static class DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsDataSourceTarget extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>0：流程表单，1：纯表单</p>
         */
        @NameInMap("appType")
        public Long appType;

        @NameInMap("appUuid")
        public String appUuid;

        @NameInMap("bizType")
        public String bizType;

        @NameInMap("formCode")
        public String formCode;

        public static DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsDataSourceTarget build(java.util.Map<String, ?> map) throws Exception {
            DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsDataSourceTarget self = new DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsDataSourceTarget();
            return TeaModel.build(map, self);
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsDataSourceTarget setAppType(Long appType) {
            this.appType = appType;
            return this;
        }
        public Long getAppType() {
            return this.appType;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsDataSourceTarget setAppUuid(String appUuid) {
            this.appUuid = appUuid;
            return this;
        }
        public String getAppUuid() {
            return this.appUuid;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsDataSourceTarget setBizType(String bizType) {
            this.bizType = bizType;
            return this;
        }
        public String getBizType() {
            return this.bizType;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsDataSourceTarget setFormCode(String formCode) {
            this.formCode = formCode;
            return this;
        }
        public String getFormCode() {
            return this.formCode;
        }

    }

    public static class DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsDataSource extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("params")
        public DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsDataSourceParams params;

        @NameInMap("target")
        public DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsDataSourceTarget target;

        @NameInMap("type")
        public String type;

        public static DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsDataSource build(java.util.Map<String, ?> map) throws Exception {
            DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsDataSource self = new DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsDataSource();
            return TeaModel.build(map, self);
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsDataSource setParams(DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsDataSourceParams params) {
            this.params = params;
            return this;
        }
        public DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsDataSourceParams getParams() {
            return this.params;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsDataSource setTarget(DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsDataSourceTarget target) {
            this.target = target;
            return this;
        }
        public DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsDataSourceTarget getTarget() {
            return this.target;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsDataSource setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

    }

    public static class DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsFieldsRelatePropsOptionsExtension extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("editFreeze")
        public Boolean editFreeze;

        public static DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsFieldsRelatePropsOptionsExtension build(java.util.Map<String, ?> map) throws Exception {
            DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsFieldsRelatePropsOptionsExtension self = new DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsFieldsRelatePropsOptionsExtension();
            return TeaModel.build(map, self);
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsFieldsRelatePropsOptionsExtension setEditFreeze(Boolean editFreeze) {
            this.editFreeze = editFreeze;
            return this;
        }
        public Boolean getEditFreeze() {
            return this.editFreeze;
        }

    }

    public static class DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsFieldsRelatePropsOptions extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("extension")
        public DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsFieldsRelatePropsOptionsExtension extension;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("key")
        public String key;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("value")
        public String value;

        public static DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsFieldsRelatePropsOptions build(java.util.Map<String, ?> map) throws Exception {
            DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsFieldsRelatePropsOptions self = new DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsFieldsRelatePropsOptions();
            return TeaModel.build(map, self);
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsFieldsRelatePropsOptions setExtension(DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsFieldsRelatePropsOptionsExtension extension) {
            this.extension = extension;
            return this;
        }
        public DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsFieldsRelatePropsOptionsExtension getExtension() {
            return this.extension;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsFieldsRelatePropsOptions setKey(String key) {
            this.key = key;
            return this;
        }
        public String getKey() {
            return this.key;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsFieldsRelatePropsOptions setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

    }

    public static class DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsFieldsRelatePropsStatField extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("fieldId")
        public String fieldId;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("label")
        public String label;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("unit")
        public String unit;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("upper")
        public Boolean upper;

        public static DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsFieldsRelatePropsStatField build(java.util.Map<String, ?> map) throws Exception {
            DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsFieldsRelatePropsStatField self = new DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsFieldsRelatePropsStatField();
            return TeaModel.build(map, self);
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsFieldsRelatePropsStatField setFieldId(String fieldId) {
            this.fieldId = fieldId;
            return this;
        }
        public String getFieldId() {
            return this.fieldId;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsFieldsRelatePropsStatField setLabel(String label) {
            this.label = label;
            return this;
        }
        public String getLabel() {
            return this.label;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsFieldsRelatePropsStatField setUnit(String unit) {
            this.unit = unit;
            return this;
        }
        public String getUnit() {
            return this.unit;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsFieldsRelatePropsStatField setUpper(Boolean upper) {
            this.upper = upper;
            return this;
        }
        public Boolean getUpper() {
            return this.upper;
        }

    }

    public static class DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsFieldsRelateProps extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("align")
        public String align;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("bizAlias")
        public String bizAlias;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>1：多选，0：单选</p>
         */
        @NameInMap("choice")
        public Long choice;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("content")
        public String content;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>true：可编辑</p>
         */
        @NameInMap("disabled")
        public Boolean disabled;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>true：自动</p>
         */
        @NameInMap("duration")
        public String duration;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("durationLabel")
        public String durationLabel;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("fieldId")
        public String fieldId;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>DDDateField和DDDateRangeField</p>
         */
        @NameInMap("format")
        public String format;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("formula")
        public String formula;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>true：隐藏</p>
         */
        @NameInMap("invisible")
        public Boolean invisible;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("label")
        public String label;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("labelEditableFreeze")
        public Boolean labelEditableFreeze;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("limit")
        public Long limit;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("link")
        public String link;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("mode")
        public String mode;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>1:不需要大写, 空或者0:需要大写</p>
         */
        @NameInMap("notUpper")
        public String notUpper;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("options")
        public java.util.List<DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsFieldsRelatePropsOptions> options;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>true：是</p>
         */
        @NameInMap("payEnable")
        public Boolean payEnable;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("placeholder")
        public String placeholder;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("ratio")
        public Long ratio;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>true：必填</p>
         */
        @NameInMap("required")
        public Boolean required;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("requiredEditableFreeze")
        public Boolean requiredEditableFreeze;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("spread")
        public Boolean spread;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("statField")
        public java.util.List<DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsFieldsRelatePropsStatField> statField;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("unit")
        public String unit;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>true：纵向，false：横向</p>
         */
        @NameInMap("verticalPrint")
        public Boolean verticalPrint;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("watermark")
        public Boolean watermark;

        public static DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsFieldsRelateProps build(java.util.Map<String, ?> map) throws Exception {
            DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsFieldsRelateProps self = new DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsFieldsRelateProps();
            return TeaModel.build(map, self);
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsFieldsRelateProps setAlign(String align) {
            this.align = align;
            return this;
        }
        public String getAlign() {
            return this.align;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsFieldsRelateProps setBizAlias(String bizAlias) {
            this.bizAlias = bizAlias;
            return this;
        }
        public String getBizAlias() {
            return this.bizAlias;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsFieldsRelateProps setChoice(Long choice) {
            this.choice = choice;
            return this;
        }
        public Long getChoice() {
            return this.choice;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsFieldsRelateProps setContent(String content) {
            this.content = content;
            return this;
        }
        public String getContent() {
            return this.content;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsFieldsRelateProps setDisabled(Boolean disabled) {
            this.disabled = disabled;
            return this;
        }
        public Boolean getDisabled() {
            return this.disabled;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsFieldsRelateProps setDuration(String duration) {
            this.duration = duration;
            return this;
        }
        public String getDuration() {
            return this.duration;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsFieldsRelateProps setDurationLabel(String durationLabel) {
            this.durationLabel = durationLabel;
            return this;
        }
        public String getDurationLabel() {
            return this.durationLabel;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsFieldsRelateProps setFieldId(String fieldId) {
            this.fieldId = fieldId;
            return this;
        }
        public String getFieldId() {
            return this.fieldId;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsFieldsRelateProps setFormat(String format) {
            this.format = format;
            return this;
        }
        public String getFormat() {
            return this.format;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsFieldsRelateProps setFormula(String formula) {
            this.formula = formula;
            return this;
        }
        public String getFormula() {
            return this.formula;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsFieldsRelateProps setInvisible(Boolean invisible) {
            this.invisible = invisible;
            return this;
        }
        public Boolean getInvisible() {
            return this.invisible;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsFieldsRelateProps setLabel(String label) {
            this.label = label;
            return this;
        }
        public String getLabel() {
            return this.label;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsFieldsRelateProps setLabelEditableFreeze(Boolean labelEditableFreeze) {
            this.labelEditableFreeze = labelEditableFreeze;
            return this;
        }
        public Boolean getLabelEditableFreeze() {
            return this.labelEditableFreeze;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsFieldsRelateProps setLimit(Long limit) {
            this.limit = limit;
            return this;
        }
        public Long getLimit() {
            return this.limit;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsFieldsRelateProps setLink(String link) {
            this.link = link;
            return this;
        }
        public String getLink() {
            return this.link;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsFieldsRelateProps setMode(String mode) {
            this.mode = mode;
            return this;
        }
        public String getMode() {
            return this.mode;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsFieldsRelateProps setNotUpper(String notUpper) {
            this.notUpper = notUpper;
            return this;
        }
        public String getNotUpper() {
            return this.notUpper;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsFieldsRelateProps setOptions(java.util.List<DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsFieldsRelatePropsOptions> options) {
            this.options = options;
            return this;
        }
        public java.util.List<DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsFieldsRelatePropsOptions> getOptions() {
            return this.options;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsFieldsRelateProps setPayEnable(Boolean payEnable) {
            this.payEnable = payEnable;
            return this;
        }
        public Boolean getPayEnable() {
            return this.payEnable;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsFieldsRelateProps setPlaceholder(String placeholder) {
            this.placeholder = placeholder;
            return this;
        }
        public String getPlaceholder() {
            return this.placeholder;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsFieldsRelateProps setRatio(Long ratio) {
            this.ratio = ratio;
            return this;
        }
        public Long getRatio() {
            return this.ratio;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsFieldsRelateProps setRequired(Boolean required) {
            this.required = required;
            return this;
        }
        public Boolean getRequired() {
            return this.required;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsFieldsRelateProps setRequiredEditableFreeze(Boolean requiredEditableFreeze) {
            this.requiredEditableFreeze = requiredEditableFreeze;
            return this;
        }
        public Boolean getRequiredEditableFreeze() {
            return this.requiredEditableFreeze;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsFieldsRelateProps setSpread(Boolean spread) {
            this.spread = spread;
            return this;
        }
        public Boolean getSpread() {
            return this.spread;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsFieldsRelateProps setStatField(java.util.List<DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsFieldsRelatePropsStatField> statField) {
            this.statField = statField;
            return this;
        }
        public java.util.List<DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsFieldsRelatePropsStatField> getStatField() {
            return this.statField;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsFieldsRelateProps setUnit(String unit) {
            this.unit = unit;
            return this;
        }
        public String getUnit() {
            return this.unit;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsFieldsRelateProps setVerticalPrint(Boolean verticalPrint) {
            this.verticalPrint = verticalPrint;
            return this;
        }
        public Boolean getVerticalPrint() {
            return this.verticalPrint;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsFieldsRelateProps setWatermark(Boolean watermark) {
            this.watermark = watermark;
            return this;
        }
        public Boolean getWatermark() {
            return this.watermark;
        }

    }

    public static class DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsFields extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("componentName")
        public String componentName;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("relateProps")
        public DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsFieldsRelateProps relateProps;

        public static DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsFields build(java.util.Map<String, ?> map) throws Exception {
            DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsFields self = new DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsFields();
            return TeaModel.build(map, self);
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsFields setComponentName(String componentName) {
            this.componentName = componentName;
            return this;
        }
        public String getComponentName() {
            return this.componentName;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsFields setRelateProps(DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsFieldsRelateProps relateProps) {
            this.relateProps = relateProps;
            return this;
        }
        public DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsFieldsRelateProps getRelateProps() {
            return this.relateProps;
        }

    }

    public static class DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsOptionsExtension extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("editFreeze")
        public Boolean editFreeze;

        public static DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsOptionsExtension build(java.util.Map<String, ?> map) throws Exception {
            DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsOptionsExtension self = new DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsOptionsExtension();
            return TeaModel.build(map, self);
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsOptionsExtension setEditFreeze(Boolean editFreeze) {
            this.editFreeze = editFreeze;
            return this;
        }
        public Boolean getEditFreeze() {
            return this.editFreeze;
        }

    }

    public static class DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsOptions extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("extension")
        public DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsOptionsExtension extension;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("key")
        public String key;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("value")
        public String value;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("warn")
        public Boolean warn;

        public static DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsOptions build(java.util.Map<String, ?> map) throws Exception {
            DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsOptions self = new DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsOptions();
            return TeaModel.build(map, self);
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsOptions setExtension(DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsOptionsExtension extension) {
            this.extension = extension;
            return this;
        }
        public DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsOptionsExtension getExtension() {
            return this.extension;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsOptions setKey(String key) {
            this.key = key;
            return this;
        }
        public String getKey() {
            return this.key;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsOptions setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsOptions setWarn(Boolean warn) {
            this.warn = warn;
            return this;
        }
        public Boolean getWarn() {
            return this.warn;
        }

    }

    public static class DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsRelateSourceDataSourceParamsFilters extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("fieldId")
        public String fieldId;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("filterType")
        public String filterType;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("value")
        public String value;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("valueType")
        public String valueType;

        public static DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsRelateSourceDataSourceParamsFilters build(java.util.Map<String, ?> map) throws Exception {
            DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsRelateSourceDataSourceParamsFilters self = new DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsRelateSourceDataSourceParamsFilters();
            return TeaModel.build(map, self);
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsRelateSourceDataSourceParamsFilters setFieldId(String fieldId) {
            this.fieldId = fieldId;
            return this;
        }
        public String getFieldId() {
            return this.fieldId;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsRelateSourceDataSourceParamsFilters setFilterType(String filterType) {
            this.filterType = filterType;
            return this;
        }
        public String getFilterType() {
            return this.filterType;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsRelateSourceDataSourceParamsFilters setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsRelateSourceDataSourceParamsFilters setValueType(String valueType) {
            this.valueType = valueType;
            return this;
        }
        public String getValueType() {
            return this.valueType;
        }

    }

    public static class DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsRelateSourceDataSourceParams extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("filters")
        public java.util.List<DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsRelateSourceDataSourceParamsFilters> filters;

        public static DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsRelateSourceDataSourceParams build(java.util.Map<String, ?> map) throws Exception {
            DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsRelateSourceDataSourceParams self = new DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsRelateSourceDataSourceParams();
            return TeaModel.build(map, self);
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsRelateSourceDataSourceParams setFilters(java.util.List<DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsRelateSourceDataSourceParamsFilters> filters) {
            this.filters = filters;
            return this;
        }
        public java.util.List<DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsRelateSourceDataSourceParamsFilters> getFilters() {
            return this.filters;
        }

    }

    public static class DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsRelateSourceDataSourceTarget extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("appType")
        public Long appType;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("appUuid")
        public String appUuid;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("bizType")
        public String bizType;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("formCode")
        public String formCode;

        public static DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsRelateSourceDataSourceTarget build(java.util.Map<String, ?> map) throws Exception {
            DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsRelateSourceDataSourceTarget self = new DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsRelateSourceDataSourceTarget();
            return TeaModel.build(map, self);
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsRelateSourceDataSourceTarget setAppType(Long appType) {
            this.appType = appType;
            return this;
        }
        public Long getAppType() {
            return this.appType;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsRelateSourceDataSourceTarget setAppUuid(String appUuid) {
            this.appUuid = appUuid;
            return this;
        }
        public String getAppUuid() {
            return this.appUuid;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsRelateSourceDataSourceTarget setBizType(String bizType) {
            this.bizType = bizType;
            return this;
        }
        public String getBizType() {
            return this.bizType;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsRelateSourceDataSourceTarget setFormCode(String formCode) {
            this.formCode = formCode;
            return this;
        }
        public String getFormCode() {
            return this.formCode;
        }

    }

    public static class DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsRelateSourceDataSource extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("params")
        public DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsRelateSourceDataSourceParams params;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("target")
        public DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsRelateSourceDataSourceTarget target;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("type")
        public String type;

        public static DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsRelateSourceDataSource build(java.util.Map<String, ?> map) throws Exception {
            DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsRelateSourceDataSource self = new DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsRelateSourceDataSource();
            return TeaModel.build(map, self);
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsRelateSourceDataSource setParams(DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsRelateSourceDataSourceParams params) {
            this.params = params;
            return this;
        }
        public DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsRelateSourceDataSourceParams getParams() {
            return this.params;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsRelateSourceDataSource setTarget(DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsRelateSourceDataSourceTarget target) {
            this.target = target;
            return this;
        }
        public DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsRelateSourceDataSourceTarget getTarget() {
            return this.target;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsRelateSourceDataSource setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

    }

    public static class DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsRelateSourceFieldsRelatePropsOptionsExtension extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("editFreeze")
        public Boolean editFreeze;

        public static DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsRelateSourceFieldsRelatePropsOptionsExtension build(java.util.Map<String, ?> map) throws Exception {
            DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsRelateSourceFieldsRelatePropsOptionsExtension self = new DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsRelateSourceFieldsRelatePropsOptionsExtension();
            return TeaModel.build(map, self);
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsRelateSourceFieldsRelatePropsOptionsExtension setEditFreeze(Boolean editFreeze) {
            this.editFreeze = editFreeze;
            return this;
        }
        public Boolean getEditFreeze() {
            return this.editFreeze;
        }

    }

    public static class DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsRelateSourceFieldsRelatePropsOptions extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("extension")
        public DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsRelateSourceFieldsRelatePropsOptionsExtension extension;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("key")
        public String key;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("value")
        public String value;

        public static DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsRelateSourceFieldsRelatePropsOptions build(java.util.Map<String, ?> map) throws Exception {
            DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsRelateSourceFieldsRelatePropsOptions self = new DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsRelateSourceFieldsRelatePropsOptions();
            return TeaModel.build(map, self);
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsRelateSourceFieldsRelatePropsOptions setExtension(DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsRelateSourceFieldsRelatePropsOptionsExtension extension) {
            this.extension = extension;
            return this;
        }
        public DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsRelateSourceFieldsRelatePropsOptionsExtension getExtension() {
            return this.extension;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsRelateSourceFieldsRelatePropsOptions setKey(String key) {
            this.key = key;
            return this;
        }
        public String getKey() {
            return this.key;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsRelateSourceFieldsRelatePropsOptions setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

    }

    public static class DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsRelateSourceFieldsRelatePropsStatField extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("fieldId")
        public String fieldId;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("label")
        public String label;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("unit")
        public String unit;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("upper")
        public Boolean upper;

        public static DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsRelateSourceFieldsRelatePropsStatField build(java.util.Map<String, ?> map) throws Exception {
            DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsRelateSourceFieldsRelatePropsStatField self = new DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsRelateSourceFieldsRelatePropsStatField();
            return TeaModel.build(map, self);
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsRelateSourceFieldsRelatePropsStatField setFieldId(String fieldId) {
            this.fieldId = fieldId;
            return this;
        }
        public String getFieldId() {
            return this.fieldId;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsRelateSourceFieldsRelatePropsStatField setLabel(String label) {
            this.label = label;
            return this;
        }
        public String getLabel() {
            return this.label;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsRelateSourceFieldsRelatePropsStatField setUnit(String unit) {
            this.unit = unit;
            return this;
        }
        public String getUnit() {
            return this.unit;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsRelateSourceFieldsRelatePropsStatField setUpper(Boolean upper) {
            this.upper = upper;
            return this;
        }
        public Boolean getUpper() {
            return this.upper;
        }

    }

    public static class DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsRelateSourceFieldsRelateProps extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("align")
        public String align;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("bizAlias")
        public String bizAlias;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>1：多选，0：单选</p>
         */
        @NameInMap("choice")
        public Long choice;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("content")
        public String content;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>true：可编辑</p>
         */
        @NameInMap("disabled")
        public Boolean disabled;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>true：自动</p>
         */
        @NameInMap("duration")
        public String duration;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("fieldId")
        public String fieldId;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>DDDateField和DDDateRangeField</p>
         */
        @NameInMap("format")
        public String format;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("formula")
        public String formula;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>true：隐藏</p>
         */
        @NameInMap("invisible")
        public Boolean invisible;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("label")
        public String label;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("labelEditableFreeze")
        public Boolean labelEditableFreeze;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("link")
        public String link;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("multi")
        public Long multi;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>1:不需要大写, 空或者0:需要大写</p>
         */
        @NameInMap("notUpper")
        public String notUpper;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("options")
        public java.util.List<DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsRelateSourceFieldsRelatePropsOptions> options;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>true：是</p>
         */
        @NameInMap("payEnable")
        public Boolean payEnable;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("placeholder")
        public String placeholder;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("quote")
        public Long quote;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>true：必填</p>
         */
        @NameInMap("required")
        public Boolean required;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("requiredEditableFreeze")
        public Boolean requiredEditableFreeze;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("statField")
        public java.util.List<DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsRelateSourceFieldsRelatePropsStatField> statField;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("unit")
        public String unit;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>true：纵向，false：横向</p>
         */
        @NameInMap("verticalPrint")
        public Boolean verticalPrint;

        public static DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsRelateSourceFieldsRelateProps build(java.util.Map<String, ?> map) throws Exception {
            DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsRelateSourceFieldsRelateProps self = new DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsRelateSourceFieldsRelateProps();
            return TeaModel.build(map, self);
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsRelateSourceFieldsRelateProps setAlign(String align) {
            this.align = align;
            return this;
        }
        public String getAlign() {
            return this.align;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsRelateSourceFieldsRelateProps setBizAlias(String bizAlias) {
            this.bizAlias = bizAlias;
            return this;
        }
        public String getBizAlias() {
            return this.bizAlias;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsRelateSourceFieldsRelateProps setChoice(Long choice) {
            this.choice = choice;
            return this;
        }
        public Long getChoice() {
            return this.choice;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsRelateSourceFieldsRelateProps setContent(String content) {
            this.content = content;
            return this;
        }
        public String getContent() {
            return this.content;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsRelateSourceFieldsRelateProps setDisabled(Boolean disabled) {
            this.disabled = disabled;
            return this;
        }
        public Boolean getDisabled() {
            return this.disabled;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsRelateSourceFieldsRelateProps setDuration(String duration) {
            this.duration = duration;
            return this;
        }
        public String getDuration() {
            return this.duration;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsRelateSourceFieldsRelateProps setFieldId(String fieldId) {
            this.fieldId = fieldId;
            return this;
        }
        public String getFieldId() {
            return this.fieldId;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsRelateSourceFieldsRelateProps setFormat(String format) {
            this.format = format;
            return this;
        }
        public String getFormat() {
            return this.format;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsRelateSourceFieldsRelateProps setFormula(String formula) {
            this.formula = formula;
            return this;
        }
        public String getFormula() {
            return this.formula;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsRelateSourceFieldsRelateProps setInvisible(Boolean invisible) {
            this.invisible = invisible;
            return this;
        }
        public Boolean getInvisible() {
            return this.invisible;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsRelateSourceFieldsRelateProps setLabel(String label) {
            this.label = label;
            return this;
        }
        public String getLabel() {
            return this.label;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsRelateSourceFieldsRelateProps setLabelEditableFreeze(Boolean labelEditableFreeze) {
            this.labelEditableFreeze = labelEditableFreeze;
            return this;
        }
        public Boolean getLabelEditableFreeze() {
            return this.labelEditableFreeze;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsRelateSourceFieldsRelateProps setLink(String link) {
            this.link = link;
            return this;
        }
        public String getLink() {
            return this.link;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsRelateSourceFieldsRelateProps setMulti(Long multi) {
            this.multi = multi;
            return this;
        }
        public Long getMulti() {
            return this.multi;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsRelateSourceFieldsRelateProps setNotUpper(String notUpper) {
            this.notUpper = notUpper;
            return this;
        }
        public String getNotUpper() {
            return this.notUpper;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsRelateSourceFieldsRelateProps setOptions(java.util.List<DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsRelateSourceFieldsRelatePropsOptions> options) {
            this.options = options;
            return this;
        }
        public java.util.List<DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsRelateSourceFieldsRelatePropsOptions> getOptions() {
            return this.options;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsRelateSourceFieldsRelateProps setPayEnable(Boolean payEnable) {
            this.payEnable = payEnable;
            return this;
        }
        public Boolean getPayEnable() {
            return this.payEnable;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsRelateSourceFieldsRelateProps setPlaceholder(String placeholder) {
            this.placeholder = placeholder;
            return this;
        }
        public String getPlaceholder() {
            return this.placeholder;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsRelateSourceFieldsRelateProps setQuote(Long quote) {
            this.quote = quote;
            return this;
        }
        public Long getQuote() {
            return this.quote;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsRelateSourceFieldsRelateProps setRequired(Boolean required) {
            this.required = required;
            return this;
        }
        public Boolean getRequired() {
            return this.required;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsRelateSourceFieldsRelateProps setRequiredEditableFreeze(Boolean requiredEditableFreeze) {
            this.requiredEditableFreeze = requiredEditableFreeze;
            return this;
        }
        public Boolean getRequiredEditableFreeze() {
            return this.requiredEditableFreeze;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsRelateSourceFieldsRelateProps setStatField(java.util.List<DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsRelateSourceFieldsRelatePropsStatField> statField) {
            this.statField = statField;
            return this;
        }
        public java.util.List<DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsRelateSourceFieldsRelatePropsStatField> getStatField() {
            return this.statField;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsRelateSourceFieldsRelateProps setUnit(String unit) {
            this.unit = unit;
            return this;
        }
        public String getUnit() {
            return this.unit;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsRelateSourceFieldsRelateProps setVerticalPrint(Boolean verticalPrint) {
            this.verticalPrint = verticalPrint;
            return this;
        }
        public Boolean getVerticalPrint() {
            return this.verticalPrint;
        }

    }

    public static class DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsRelateSourceFields extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("componentName")
        public String componentName;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("relateProps")
        public DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsRelateSourceFieldsRelateProps relateProps;

        public static DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsRelateSourceFields build(java.util.Map<String, ?> map) throws Exception {
            DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsRelateSourceFields self = new DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsRelateSourceFields();
            return TeaModel.build(map, self);
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsRelateSourceFields setComponentName(String componentName) {
            this.componentName = componentName;
            return this;
        }
        public String getComponentName() {
            return this.componentName;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsRelateSourceFields setRelateProps(DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsRelateSourceFieldsRelateProps relateProps) {
            this.relateProps = relateProps;
            return this;
        }
        public DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsRelateSourceFieldsRelateProps getRelateProps() {
            return this.relateProps;
        }

    }

    public static class DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsRelateSource extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("bizType")
        public String bizType;

        @NameInMap("dataSource")
        public DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsRelateSourceDataSource dataSource;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("fields")
        public java.util.List<DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsRelateSourceFields> fields;

        public static DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsRelateSource build(java.util.Map<String, ?> map) throws Exception {
            DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsRelateSource self = new DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsRelateSource();
            return TeaModel.build(map, self);
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsRelateSource setBizType(String bizType) {
            this.bizType = bizType;
            return this;
        }
        public String getBizType() {
            return this.bizType;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsRelateSource setDataSource(DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsRelateSourceDataSource dataSource) {
            this.dataSource = dataSource;
            return this;
        }
        public DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsRelateSourceDataSource getDataSource() {
            return this.dataSource;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsRelateSource setFields(java.util.List<DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsRelateSourceFields> fields) {
            this.fields = fields;
            return this;
        }
        public java.util.List<DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsRelateSourceFields> getFields() {
            return this.fields;
        }

    }

    public static class DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsRule extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("type")
        public String type;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("value")
        public String value;

        public static DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsRule build(java.util.Map<String, ?> map) throws Exception {
            DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsRule self = new DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsRule();
            return TeaModel.build(map, self);
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsRule setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsRule setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

    }

    public static class DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsStatField extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("fieldId")
        public String fieldId;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("label")
        public String label;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("unit")
        public String unit;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("upper")
        public Boolean upper;

        public static DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsStatField build(java.util.Map<String, ?> map) throws Exception {
            DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsStatField self = new DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsStatField();
            return TeaModel.build(map, self);
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsStatField setFieldId(String fieldId) {
            this.fieldId = fieldId;
            return this;
        }
        public String getFieldId() {
            return this.fieldId;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsStatField setLabel(String label) {
            this.label = label;
            return this;
        }
        public String getLabel() {
            return this.label;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsStatField setUnit(String unit) {
            this.unit = unit;
            return this;
        }
        public String getUnit() {
            return this.unit;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsStatField setUpper(Boolean upper) {
            this.upper = upper;
            return this;
        }
        public Boolean getUpper() {
            return this.upper;
        }

    }

    public static class DescribeMetaModelResponseBodyMetaModelDTOListItemsProps extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>明细动作名称</p>
         */
        @NameInMap("actionName")
        public String actionName;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>top|middle|bottom</p>
         */
        @NameInMap("align")
        public String align;

        @NameInMap("availableTemplates")
        public java.util.List<DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsAvailableTemplates> availableTemplates;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("bizAlias")
        public String bizAlias;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>1：多选，0：单选</p>
         */
        @NameInMap("choice")
        public Long choice;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("content")
        public String content;

        @NameInMap("dataSource")
        public DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsDataSource dataSource;

        /**
         * <strong>example:</strong>
         * <p>标签字段 颜色属性，格式：#0089FF</p>
         */
        @NameInMap("defaultColor")
        public String defaultColor;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>true：可编辑</p>
         */
        @NameInMap("disabled")
        public Boolean disabled;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>true：自动</p>
         */
        @NameInMap("duration")
        public Boolean duration;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>日期区间控件，自动计算时长的标题</p>
         */
        @NameInMap("durationLabel")
        public String durationLabel;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("fieldId")
        public String fieldId;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("fields")
        public java.util.List<DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsFields> fields;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>DDDateField和DDDateRangeField</p>
         */
        @NameInMap("format")
        public String format;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("formula")
        public String formula;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>true：隐藏</p>
         */
        @NameInMap("invisible")
        public Boolean invisible;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("label")
        public String label;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>true：不可修改</p>
         */
        @NameInMap("labelEditableFreeze")
        public Boolean labelEditableFreeze;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>评分组件限制</p>
         */
        @NameInMap("limit")
        public Long limit;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("link")
        public String link;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>电话控件模式 phone：仅手机，phone_tel： 手机和固话，tel：仅固话</p>
         */
        @NameInMap("mode")
        public String mode;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("multi")
        public Long multi;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>true：支持多选，false：单选</p>
         */
        @NameInMap("multiple")
        public Boolean multiple;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("needDetail")
        public String needDetail;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>1：不打印，0：打印</p>
         */
        @NameInMap("notPrint")
        public String notPrint;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>1:不需要大写, 空或者0:需要大写</p>
         */
        @NameInMap("notUpper")
        public String notUpper;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("options")
        public java.util.List<DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsOptions> options;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>true：是</p>
         */
        @NameInMap("payEnable")
        public Boolean payEnable;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("placeholder")
        public String placeholder;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>关联表单 1：引用，0：拷贝</p>
         */
        @NameInMap("quote")
        public Long quote;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>文本控件、选项控件等限制文本字数ratio</p>
         */
        @NameInMap("ratio")
        public Long ratio;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("relateSource")
        public java.util.List<DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsRelateSource> relateSource;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>true：必填</p>
         */
        @NameInMap("required")
        public Boolean required;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>true：不可修改</p>
         */
        @NameInMap("requiredEditableFreeze")
        public Boolean requiredEditableFreeze;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("rule")
        public java.util.List<DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsRule> rule;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("sortable")
        public Boolean sortable;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>选项控件spread</p>
         */
        @NameInMap("spread")
        public Boolean spread;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("statField")
        public java.util.List<DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsStatField> statField;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>明细填写方式 table：表格，list：列表</p>
         */
        @NameInMap("tableViewMode")
        public String tableViewMode;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("unit")
        public String unit;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>true：纵向，false：横向</p>
         */
        @NameInMap("verticalPrint")
        public Boolean verticalPrint;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>是否水印照片 true：是，false：否</p>
         */
        @NameInMap("watermark")
        public Boolean watermark;

        public static DescribeMetaModelResponseBodyMetaModelDTOListItemsProps build(java.util.Map<String, ?> map) throws Exception {
            DescribeMetaModelResponseBodyMetaModelDTOListItemsProps self = new DescribeMetaModelResponseBodyMetaModelDTOListItemsProps();
            return TeaModel.build(map, self);
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsProps setActionName(String actionName) {
            this.actionName = actionName;
            return this;
        }
        public String getActionName() {
            return this.actionName;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsProps setAlign(String align) {
            this.align = align;
            return this;
        }
        public String getAlign() {
            return this.align;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsProps setAvailableTemplates(java.util.List<DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsAvailableTemplates> availableTemplates) {
            this.availableTemplates = availableTemplates;
            return this;
        }
        public java.util.List<DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsAvailableTemplates> getAvailableTemplates() {
            return this.availableTemplates;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsProps setBizAlias(String bizAlias) {
            this.bizAlias = bizAlias;
            return this;
        }
        public String getBizAlias() {
            return this.bizAlias;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsProps setChoice(Long choice) {
            this.choice = choice;
            return this;
        }
        public Long getChoice() {
            return this.choice;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsProps setContent(String content) {
            this.content = content;
            return this;
        }
        public String getContent() {
            return this.content;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsProps setDataSource(DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsDataSource dataSource) {
            this.dataSource = dataSource;
            return this;
        }
        public DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsDataSource getDataSource() {
            return this.dataSource;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsProps setDefaultColor(String defaultColor) {
            this.defaultColor = defaultColor;
            return this;
        }
        public String getDefaultColor() {
            return this.defaultColor;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsProps setDisabled(Boolean disabled) {
            this.disabled = disabled;
            return this;
        }
        public Boolean getDisabled() {
            return this.disabled;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsProps setDuration(Boolean duration) {
            this.duration = duration;
            return this;
        }
        public Boolean getDuration() {
            return this.duration;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsProps setDurationLabel(String durationLabel) {
            this.durationLabel = durationLabel;
            return this;
        }
        public String getDurationLabel() {
            return this.durationLabel;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsProps setFieldId(String fieldId) {
            this.fieldId = fieldId;
            return this;
        }
        public String getFieldId() {
            return this.fieldId;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsProps setFields(java.util.List<DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsFields> fields) {
            this.fields = fields;
            return this;
        }
        public java.util.List<DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsFields> getFields() {
            return this.fields;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsProps setFormat(String format) {
            this.format = format;
            return this;
        }
        public String getFormat() {
            return this.format;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsProps setFormula(String formula) {
            this.formula = formula;
            return this;
        }
        public String getFormula() {
            return this.formula;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsProps setInvisible(Boolean invisible) {
            this.invisible = invisible;
            return this;
        }
        public Boolean getInvisible() {
            return this.invisible;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsProps setLabel(String label) {
            this.label = label;
            return this;
        }
        public String getLabel() {
            return this.label;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsProps setLabelEditableFreeze(Boolean labelEditableFreeze) {
            this.labelEditableFreeze = labelEditableFreeze;
            return this;
        }
        public Boolean getLabelEditableFreeze() {
            return this.labelEditableFreeze;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsProps setLimit(Long limit) {
            this.limit = limit;
            return this;
        }
        public Long getLimit() {
            return this.limit;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsProps setLink(String link) {
            this.link = link;
            return this;
        }
        public String getLink() {
            return this.link;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsProps setMode(String mode) {
            this.mode = mode;
            return this;
        }
        public String getMode() {
            return this.mode;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsProps setMulti(Long multi) {
            this.multi = multi;
            return this;
        }
        public Long getMulti() {
            return this.multi;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsProps setMultiple(Boolean multiple) {
            this.multiple = multiple;
            return this;
        }
        public Boolean getMultiple() {
            return this.multiple;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsProps setNeedDetail(String needDetail) {
            this.needDetail = needDetail;
            return this;
        }
        public String getNeedDetail() {
            return this.needDetail;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsProps setNotPrint(String notPrint) {
            this.notPrint = notPrint;
            return this;
        }
        public String getNotPrint() {
            return this.notPrint;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsProps setNotUpper(String notUpper) {
            this.notUpper = notUpper;
            return this;
        }
        public String getNotUpper() {
            return this.notUpper;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsProps setOptions(java.util.List<DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsOptions> options) {
            this.options = options;
            return this;
        }
        public java.util.List<DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsOptions> getOptions() {
            return this.options;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsProps setPayEnable(Boolean payEnable) {
            this.payEnable = payEnable;
            return this;
        }
        public Boolean getPayEnable() {
            return this.payEnable;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsProps setPlaceholder(String placeholder) {
            this.placeholder = placeholder;
            return this;
        }
        public String getPlaceholder() {
            return this.placeholder;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsProps setQuote(Long quote) {
            this.quote = quote;
            return this;
        }
        public Long getQuote() {
            return this.quote;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsProps setRatio(Long ratio) {
            this.ratio = ratio;
            return this;
        }
        public Long getRatio() {
            return this.ratio;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsProps setRelateSource(java.util.List<DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsRelateSource> relateSource) {
            this.relateSource = relateSource;
            return this;
        }
        public java.util.List<DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsRelateSource> getRelateSource() {
            return this.relateSource;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsProps setRequired(Boolean required) {
            this.required = required;
            return this;
        }
        public Boolean getRequired() {
            return this.required;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsProps setRequiredEditableFreeze(Boolean requiredEditableFreeze) {
            this.requiredEditableFreeze = requiredEditableFreeze;
            return this;
        }
        public Boolean getRequiredEditableFreeze() {
            return this.requiredEditableFreeze;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsProps setRule(java.util.List<DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsRule> rule) {
            this.rule = rule;
            return this;
        }
        public java.util.List<DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsRule> getRule() {
            return this.rule;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsProps setSortable(Boolean sortable) {
            this.sortable = sortable;
            return this;
        }
        public Boolean getSortable() {
            return this.sortable;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsProps setSpread(Boolean spread) {
            this.spread = spread;
            return this;
        }
        public Boolean getSpread() {
            return this.spread;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsProps setStatField(java.util.List<DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsStatField> statField) {
            this.statField = statField;
            return this;
        }
        public java.util.List<DescribeMetaModelResponseBodyMetaModelDTOListItemsPropsStatField> getStatField() {
            return this.statField;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsProps setTableViewMode(String tableViewMode) {
            this.tableViewMode = tableViewMode;
            return this;
        }
        public String getTableViewMode() {
            return this.tableViewMode;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsProps setUnit(String unit) {
            this.unit = unit;
            return this;
        }
        public String getUnit() {
            return this.unit;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsProps setVerticalPrint(Boolean verticalPrint) {
            this.verticalPrint = verticalPrint;
            return this;
        }
        public Boolean getVerticalPrint() {
            return this.verticalPrint;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItemsProps setWatermark(Boolean watermark) {
            this.watermark = watermark;
            return this;
        }
        public Boolean getWatermark() {
            return this.watermark;
        }

    }

    public static class DescribeMetaModelResponseBodyMetaModelDTOListItems extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("children")
        public java.util.List<DescribeMetaModelResponseBodyMetaModelDTOListItemsChildren> children;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("componentName")
        public String componentName;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("props")
        public DescribeMetaModelResponseBodyMetaModelDTOListItemsProps props;

        public static DescribeMetaModelResponseBodyMetaModelDTOListItems build(java.util.Map<String, ?> map) throws Exception {
            DescribeMetaModelResponseBodyMetaModelDTOListItems self = new DescribeMetaModelResponseBodyMetaModelDTOListItems();
            return TeaModel.build(map, self);
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItems setChildren(java.util.List<DescribeMetaModelResponseBodyMetaModelDTOListItemsChildren> children) {
            this.children = children;
            return this;
        }
        public java.util.List<DescribeMetaModelResponseBodyMetaModelDTOListItemsChildren> getChildren() {
            return this.children;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItems setComponentName(String componentName) {
            this.componentName = componentName;
            return this;
        }
        public String getComponentName() {
            return this.componentName;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOListItems setProps(DescribeMetaModelResponseBodyMetaModelDTOListItemsProps props) {
            this.props = props;
            return this;
        }
        public DescribeMetaModelResponseBodyMetaModelDTOListItemsProps getProps() {
            return this.props;
        }

    }

    public static class DescribeMetaModelResponseBodyMetaModelDTOList extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("creatorUserId")
        public String creatorUserId;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>企业客户表</p>
         */
        @NameInMap("desc")
        public String desc;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("gmtCreate")
        public String gmtCreate;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("gmtModified")
        public String gmtModified;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("items")
        public java.util.List<DescribeMetaModelResponseBodyMetaModelDTOListItems> items;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>企业客户</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("relationMetaCode")
        public String relationMetaCode;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("relationMetaStatus")
        public String relationMetaStatus;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>crm_customer</p>
         */
        @NameInMap("relationType")
        public String relationType;

        public static DescribeMetaModelResponseBodyMetaModelDTOList build(java.util.Map<String, ?> map) throws Exception {
            DescribeMetaModelResponseBodyMetaModelDTOList self = new DescribeMetaModelResponseBodyMetaModelDTOList();
            return TeaModel.build(map, self);
        }

        public DescribeMetaModelResponseBodyMetaModelDTOList setCreatorUserId(String creatorUserId) {
            this.creatorUserId = creatorUserId;
            return this;
        }
        public String getCreatorUserId() {
            return this.creatorUserId;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOList setDesc(String desc) {
            this.desc = desc;
            return this;
        }
        public String getDesc() {
            return this.desc;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOList setGmtCreate(String gmtCreate) {
            this.gmtCreate = gmtCreate;
            return this;
        }
        public String getGmtCreate() {
            return this.gmtCreate;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOList setGmtModified(String gmtModified) {
            this.gmtModified = gmtModified;
            return this;
        }
        public String getGmtModified() {
            return this.gmtModified;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOList setItems(java.util.List<DescribeMetaModelResponseBodyMetaModelDTOListItems> items) {
            this.items = items;
            return this;
        }
        public java.util.List<DescribeMetaModelResponseBodyMetaModelDTOListItems> getItems() {
            return this.items;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOList setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOList setRelationMetaCode(String relationMetaCode) {
            this.relationMetaCode = relationMetaCode;
            return this;
        }
        public String getRelationMetaCode() {
            return this.relationMetaCode;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOList setRelationMetaStatus(String relationMetaStatus) {
            this.relationMetaStatus = relationMetaStatus;
            return this;
        }
        public String getRelationMetaStatus() {
            return this.relationMetaStatus;
        }

        public DescribeMetaModelResponseBodyMetaModelDTOList setRelationType(String relationType) {
            this.relationType = relationType;
            return this;
        }
        public String getRelationType() {
            return this.relationType;
        }

    }

}
