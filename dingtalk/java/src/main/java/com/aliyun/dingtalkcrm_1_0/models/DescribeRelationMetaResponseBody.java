// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class DescribeRelationMetaResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
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

    public static class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsAvailableTemplates extends TeaModel {
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

        public static DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsAvailableTemplates build(java.util.Map<String, ?> map) throws Exception {
            DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsAvailableTemplates self = new DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsAvailableTemplates();
            return TeaModel.build(map, self);
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsAvailableTemplates setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsAvailableTemplates setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

    }

    public static class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsDataSourceParamsFilters extends TeaModel {
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

        public static DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsDataSourceParamsFilters build(java.util.Map<String, ?> map) throws Exception {
            DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsDataSourceParamsFilters self = new DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsDataSourceParamsFilters();
            return TeaModel.build(map, self);
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsDataSourceParamsFilters setFieldId(String fieldId) {
            this.fieldId = fieldId;
            return this;
        }
        public String getFieldId() {
            return this.fieldId;
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

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsDataSourceParamsFilters setValueType(String valueType) {
            this.valueType = valueType;
            return this;
        }
        public String getValueType() {
            return this.valueType;
        }

    }

    public static class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsDataSourceParams extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
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

        public static DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsDataSourceTarget build(java.util.Map<String, ?> map) throws Exception {
            DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsDataSourceTarget self = new DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsDataSourceTarget();
            return TeaModel.build(map, self);
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsDataSourceTarget setAppType(Long appType) {
            this.appType = appType;
            return this;
        }
        public Long getAppType() {
            return this.appType;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsDataSourceTarget setAppUuid(String appUuid) {
            this.appUuid = appUuid;
            return this;
        }
        public String getAppUuid() {
            return this.appUuid;
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
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("params")
        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsDataSourceParams params;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("target")
        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsDataSourceTarget target;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("type")
        public String type;

        public static DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsDataSource build(java.util.Map<String, ?> map) throws Exception {
            DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsDataSource self = new DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsDataSource();
            return TeaModel.build(map, self);
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

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsDataSource setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

    }

    public static class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelatePropsOptionsExtension extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
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
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("extension")
        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelatePropsOptionsExtension extension;

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

        public static DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelatePropsOptions build(java.util.Map<String, ?> map) throws Exception {
            DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelatePropsOptions self = new DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelatePropsOptions();
            return TeaModel.build(map, self);
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelatePropsOptions setExtension(DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelatePropsOptionsExtension extension) {
            this.extension = extension;
            return this;
        }
        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelatePropsOptionsExtension getExtension() {
            return this.extension;
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

    }

    public static class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelatePropsStatField extends TeaModel {
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

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelatePropsStatField setUnit(String unit) {
            this.unit = unit;
            return this;
        }
        public String getUnit() {
            return this.unit;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelatePropsStatField setUpper(Boolean upper) {
            this.upper = upper;
            return this;
        }
        public Boolean getUpper() {
            return this.upper;
        }

    }

    public static class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelateProps extends TeaModel {
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
        public java.util.List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelatePropsOptions> options;

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
        public java.util.List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelatePropsStatField> statField;

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

        public static DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelateProps build(java.util.Map<String, ?> map) throws Exception {
            DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelateProps self = new DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelateProps();
            return TeaModel.build(map, self);
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelateProps setAlign(String align) {
            this.align = align;
            return this;
        }
        public String getAlign() {
            return this.align;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelateProps setBizAlias(String bizAlias) {
            this.bizAlias = bizAlias;
            return this;
        }
        public String getBizAlias() {
            return this.bizAlias;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelateProps setChoice(Long choice) {
            this.choice = choice;
            return this;
        }
        public Long getChoice() {
            return this.choice;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelateProps setContent(String content) {
            this.content = content;
            return this;
        }
        public String getContent() {
            return this.content;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelateProps setDisabled(Boolean disabled) {
            this.disabled = disabled;
            return this;
        }
        public Boolean getDisabled() {
            return this.disabled;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelateProps setDuration(Boolean duration) {
            this.duration = duration;
            return this;
        }
        public Boolean getDuration() {
            return this.duration;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelateProps setDurationLabel(String durationLabel) {
            this.durationLabel = durationLabel;
            return this;
        }
        public String getDurationLabel() {
            return this.durationLabel;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelateProps setFieldId(String fieldId) {
            this.fieldId = fieldId;
            return this;
        }
        public String getFieldId() {
            return this.fieldId;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelateProps setFormat(String format) {
            this.format = format;
            return this;
        }
        public String getFormat() {
            return this.format;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelateProps setFormula(String formula) {
            this.formula = formula;
            return this;
        }
        public String getFormula() {
            return this.formula;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelateProps setInvisible(Boolean invisible) {
            this.invisible = invisible;
            return this;
        }
        public Boolean getInvisible() {
            return this.invisible;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelateProps setLabel(String label) {
            this.label = label;
            return this;
        }
        public String getLabel() {
            return this.label;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelateProps setLabelEditableFreeze(Boolean labelEditableFreeze) {
            this.labelEditableFreeze = labelEditableFreeze;
            return this;
        }
        public Boolean getLabelEditableFreeze() {
            return this.labelEditableFreeze;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelateProps setLimit(Long limit) {
            this.limit = limit;
            return this;
        }
        public Long getLimit() {
            return this.limit;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelateProps setLink(String link) {
            this.link = link;
            return this;
        }
        public String getLink() {
            return this.link;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelateProps setMode(String mode) {
            this.mode = mode;
            return this;
        }
        public String getMode() {
            return this.mode;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelateProps setNotUpper(String notUpper) {
            this.notUpper = notUpper;
            return this;
        }
        public String getNotUpper() {
            return this.notUpper;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelateProps setOptions(java.util.List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelatePropsOptions> options) {
            this.options = options;
            return this;
        }
        public java.util.List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelatePropsOptions> getOptions() {
            return this.options;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelateProps setPayEnable(Boolean payEnable) {
            this.payEnable = payEnable;
            return this;
        }
        public Boolean getPayEnable() {
            return this.payEnable;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelateProps setPlaceholder(String placeholder) {
            this.placeholder = placeholder;
            return this;
        }
        public String getPlaceholder() {
            return this.placeholder;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelateProps setRatio(Long ratio) {
            this.ratio = ratio;
            return this;
        }
        public Long getRatio() {
            return this.ratio;
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

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelateProps setSpread(Boolean spread) {
            this.spread = spread;
            return this;
        }
        public Boolean getSpread() {
            return this.spread;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelateProps setStatField(java.util.List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelatePropsStatField> statField) {
            this.statField = statField;
            return this;
        }
        public java.util.List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelatePropsStatField> getStatField() {
            return this.statField;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelateProps setUnit(String unit) {
            this.unit = unit;
            return this;
        }
        public String getUnit() {
            return this.unit;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelateProps setVerticalPrint(Boolean verticalPrint) {
            this.verticalPrint = verticalPrint;
            return this;
        }
        public Boolean getVerticalPrint() {
            return this.verticalPrint;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelateProps setWatermark(Boolean watermark) {
            this.watermark = watermark;
            return this;
        }
        public Boolean getWatermark() {
            return this.watermark;
        }

    }

    public static class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFields extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("componentName")
        public String componentName;

        /**
         * <p>This parameter is required.</p>
         */
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

    public static class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsOptionsExtension extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
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
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("extension")
        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsOptionsExtension extension;

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

        public static DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsOptions build(java.util.Map<String, ?> map) throws Exception {
            DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsOptions self = new DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsOptions();
            return TeaModel.build(map, self);
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsOptions setExtension(DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsOptionsExtension extension) {
            this.extension = extension;
            return this;
        }
        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsOptionsExtension getExtension() {
            return this.extension;
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

    }

    public static class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceDataSourceParamsFilters extends TeaModel {
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

        public static DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceDataSourceParamsFilters build(java.util.Map<String, ?> map) throws Exception {
            DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceDataSourceParamsFilters self = new DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceDataSourceParamsFilters();
            return TeaModel.build(map, self);
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceDataSourceParamsFilters setFieldId(String fieldId) {
            this.fieldId = fieldId;
            return this;
        }
        public String getFieldId() {
            return this.fieldId;
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

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceDataSourceParamsFilters setValueType(String valueType) {
            this.valueType = valueType;
            return this;
        }
        public String getValueType() {
            return this.valueType;
        }

    }

    public static class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceDataSourceParams extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
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

        public static DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceDataSourceTarget build(java.util.Map<String, ?> map) throws Exception {
            DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceDataSourceTarget self = new DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceDataSourceTarget();
            return TeaModel.build(map, self);
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceDataSourceTarget setAppType(Long appType) {
            this.appType = appType;
            return this;
        }
        public Long getAppType() {
            return this.appType;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceDataSourceTarget setAppUuid(String appUuid) {
            this.appUuid = appUuid;
            return this;
        }
        public String getAppUuid() {
            return this.appUuid;
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
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("params")
        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceDataSourceParams params;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("target")
        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceDataSourceTarget target;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("type")
        public String type;

        public static DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceDataSource build(java.util.Map<String, ?> map) throws Exception {
            DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceDataSource self = new DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceDataSource();
            return TeaModel.build(map, self);
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

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceDataSource setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

    }

    public static class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceFieldsRelatePropsOptions extends TeaModel {
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

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceFieldsRelatePropsStatField setUnit(String unit) {
            this.unit = unit;
            return this;
        }
        public String getUnit() {
            return this.unit;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceFieldsRelatePropsStatField setUpper(Boolean upper) {
            this.upper = upper;
            return this;
        }
        public Boolean getUpper() {
            return this.upper;
        }

    }

    public static class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceFieldsRelateProps extends TeaModel {
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
        public java.util.List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceFieldsRelatePropsOptions> options;

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
        public java.util.List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceFieldsRelatePropsStatField> statField;

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

        public static DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceFieldsRelateProps build(java.util.Map<String, ?> map) throws Exception {
            DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceFieldsRelateProps self = new DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceFieldsRelateProps();
            return TeaModel.build(map, self);
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceFieldsRelateProps setAlign(String align) {
            this.align = align;
            return this;
        }
        public String getAlign() {
            return this.align;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceFieldsRelateProps setBizAlias(String bizAlias) {
            this.bizAlias = bizAlias;
            return this;
        }
        public String getBizAlias() {
            return this.bizAlias;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceFieldsRelateProps setChoice(Long choice) {
            this.choice = choice;
            return this;
        }
        public Long getChoice() {
            return this.choice;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceFieldsRelateProps setContent(String content) {
            this.content = content;
            return this;
        }
        public String getContent() {
            return this.content;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceFieldsRelateProps setDisabled(Boolean disabled) {
            this.disabled = disabled;
            return this;
        }
        public Boolean getDisabled() {
            return this.disabled;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceFieldsRelateProps setDuration(String duration) {
            this.duration = duration;
            return this;
        }
        public String getDuration() {
            return this.duration;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceFieldsRelateProps setFieldId(String fieldId) {
            this.fieldId = fieldId;
            return this;
        }
        public String getFieldId() {
            return this.fieldId;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceFieldsRelateProps setFormat(String format) {
            this.format = format;
            return this;
        }
        public String getFormat() {
            return this.format;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceFieldsRelateProps setFormula(String formula) {
            this.formula = formula;
            return this;
        }
        public String getFormula() {
            return this.formula;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceFieldsRelateProps setInvisible(Boolean invisible) {
            this.invisible = invisible;
            return this;
        }
        public Boolean getInvisible() {
            return this.invisible;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceFieldsRelateProps setLabel(String label) {
            this.label = label;
            return this;
        }
        public String getLabel() {
            return this.label;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceFieldsRelateProps setLabelEditableFreeze(Boolean labelEditableFreeze) {
            this.labelEditableFreeze = labelEditableFreeze;
            return this;
        }
        public Boolean getLabelEditableFreeze() {
            return this.labelEditableFreeze;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceFieldsRelateProps setLink(String link) {
            this.link = link;
            return this;
        }
        public String getLink() {
            return this.link;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceFieldsRelateProps setMulti(Long multi) {
            this.multi = multi;
            return this;
        }
        public Long getMulti() {
            return this.multi;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceFieldsRelateProps setNotUpper(String notUpper) {
            this.notUpper = notUpper;
            return this;
        }
        public String getNotUpper() {
            return this.notUpper;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceFieldsRelateProps setOptions(java.util.List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceFieldsRelatePropsOptions> options) {
            this.options = options;
            return this;
        }
        public java.util.List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceFieldsRelatePropsOptions> getOptions() {
            return this.options;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceFieldsRelateProps setPayEnable(Boolean payEnable) {
            this.payEnable = payEnable;
            return this;
        }
        public Boolean getPayEnable() {
            return this.payEnable;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceFieldsRelateProps setPlaceholder(String placeholder) {
            this.placeholder = placeholder;
            return this;
        }
        public String getPlaceholder() {
            return this.placeholder;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceFieldsRelateProps setQuote(Long quote) {
            this.quote = quote;
            return this;
        }
        public Long getQuote() {
            return this.quote;
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

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceFieldsRelateProps setStatField(java.util.List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceFieldsRelatePropsStatField> statField) {
            this.statField = statField;
            return this;
        }
        public java.util.List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceFieldsRelatePropsStatField> getStatField() {
            return this.statField;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceFieldsRelateProps setUnit(String unit) {
            this.unit = unit;
            return this;
        }
        public String getUnit() {
            return this.unit;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceFieldsRelateProps setVerticalPrint(Boolean verticalPrint) {
            this.verticalPrint = verticalPrint;
            return this;
        }
        public Boolean getVerticalPrint() {
            return this.verticalPrint;
        }

    }

    public static class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceFields extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("componentName")
        public String componentName;

        /**
         * <p>This parameter is required.</p>
         */
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

    public static class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSource extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("bizType")
        public String bizType;

        @NameInMap("dataSource")
        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceDataSource dataSource;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("fields")
        public java.util.List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceFields> fields;

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

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSource setDataSource(DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceDataSource dataSource) {
            this.dataSource = dataSource;
            return this;
        }
        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceDataSource getDataSource() {
            return this.dataSource;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSource setFields(java.util.List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceFields> fields) {
            this.fields = fields;
            return this;
        }
        public java.util.List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSourceFields> getFields() {
            return this.fields;
        }

    }

    public static class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRule extends TeaModel {
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

    public static class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsStatField extends TeaModel {
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

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsStatField setUnit(String unit) {
            this.unit = unit;
            return this;
        }
        public String getUnit() {
            return this.unit;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsStatField setUpper(Boolean upper) {
            this.upper = upper;
            return this;
        }
        public Boolean getUpper() {
            return this.upper;
        }

    }

    public static class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenProps extends TeaModel {
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
        public java.util.List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsAvailableTemplates> availableTemplates;

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
        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsDataSource dataSource;

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
        public java.util.List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFields> fields;

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
        public java.util.List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsOptions> options;

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
        public java.util.List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSource> relateSource;

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
        public java.util.List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRule> rule;

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
        public java.util.List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsStatField> statField;

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

        public static DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenProps build(java.util.Map<String, ?> map) throws Exception {
            DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenProps self = new DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenProps();
            return TeaModel.build(map, self);
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenProps setActionName(String actionName) {
            this.actionName = actionName;
            return this;
        }
        public String getActionName() {
            return this.actionName;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenProps setAlign(String align) {
            this.align = align;
            return this;
        }
        public String getAlign() {
            return this.align;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenProps setAvailableTemplates(java.util.List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsAvailableTemplates> availableTemplates) {
            this.availableTemplates = availableTemplates;
            return this;
        }
        public java.util.List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsAvailableTemplates> getAvailableTemplates() {
            return this.availableTemplates;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenProps setBizAlias(String bizAlias) {
            this.bizAlias = bizAlias;
            return this;
        }
        public String getBizAlias() {
            return this.bizAlias;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenProps setChoice(Long choice) {
            this.choice = choice;
            return this;
        }
        public Long getChoice() {
            return this.choice;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenProps setContent(String content) {
            this.content = content;
            return this;
        }
        public String getContent() {
            return this.content;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenProps setDataSource(DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsDataSource dataSource) {
            this.dataSource = dataSource;
            return this;
        }
        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsDataSource getDataSource() {
            return this.dataSource;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenProps setDefaultColor(String defaultColor) {
            this.defaultColor = defaultColor;
            return this;
        }
        public String getDefaultColor() {
            return this.defaultColor;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenProps setDisabled(Boolean disabled) {
            this.disabled = disabled;
            return this;
        }
        public Boolean getDisabled() {
            return this.disabled;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenProps setDuration(Boolean duration) {
            this.duration = duration;
            return this;
        }
        public Boolean getDuration() {
            return this.duration;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenProps setDurationLabel(String durationLabel) {
            this.durationLabel = durationLabel;
            return this;
        }
        public String getDurationLabel() {
            return this.durationLabel;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenProps setFieldId(String fieldId) {
            this.fieldId = fieldId;
            return this;
        }
        public String getFieldId() {
            return this.fieldId;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenProps setFields(java.util.List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFields> fields) {
            this.fields = fields;
            return this;
        }
        public java.util.List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFields> getFields() {
            return this.fields;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenProps setFormat(String format) {
            this.format = format;
            return this;
        }
        public String getFormat() {
            return this.format;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenProps setFormula(String formula) {
            this.formula = formula;
            return this;
        }
        public String getFormula() {
            return this.formula;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenProps setInvisible(Boolean invisible) {
            this.invisible = invisible;
            return this;
        }
        public Boolean getInvisible() {
            return this.invisible;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenProps setLabel(String label) {
            this.label = label;
            return this;
        }
        public String getLabel() {
            return this.label;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenProps setLabelEditableFreeze(Boolean labelEditableFreeze) {
            this.labelEditableFreeze = labelEditableFreeze;
            return this;
        }
        public Boolean getLabelEditableFreeze() {
            return this.labelEditableFreeze;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenProps setLimit(Long limit) {
            this.limit = limit;
            return this;
        }
        public Long getLimit() {
            return this.limit;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenProps setLink(String link) {
            this.link = link;
            return this;
        }
        public String getLink() {
            return this.link;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenProps setMode(String mode) {
            this.mode = mode;
            return this;
        }
        public String getMode() {
            return this.mode;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenProps setMultiple(Boolean multiple) {
            this.multiple = multiple;
            return this;
        }
        public Boolean getMultiple() {
            return this.multiple;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenProps setNotPrint(String notPrint) {
            this.notPrint = notPrint;
            return this;
        }
        public String getNotPrint() {
            return this.notPrint;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenProps setNotUpper(String notUpper) {
            this.notUpper = notUpper;
            return this;
        }
        public String getNotUpper() {
            return this.notUpper;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenProps setOptions(java.util.List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsOptions> options) {
            this.options = options;
            return this;
        }
        public java.util.List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsOptions> getOptions() {
            return this.options;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenProps setPayEnable(Boolean payEnable) {
            this.payEnable = payEnable;
            return this;
        }
        public Boolean getPayEnable() {
            return this.payEnable;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenProps setPlaceholder(String placeholder) {
            this.placeholder = placeholder;
            return this;
        }
        public String getPlaceholder() {
            return this.placeholder;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenProps setQuote(Long quote) {
            this.quote = quote;
            return this;
        }
        public Long getQuote() {
            return this.quote;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenProps setRatio(Long ratio) {
            this.ratio = ratio;
            return this;
        }
        public Long getRatio() {
            return this.ratio;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenProps setRelateSource(java.util.List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSource> relateSource) {
            this.relateSource = relateSource;
            return this;
        }
        public java.util.List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRelateSource> getRelateSource() {
            return this.relateSource;
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

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenProps setRule(java.util.List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRule> rule) {
            this.rule = rule;
            return this;
        }
        public java.util.List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsRule> getRule() {
            return this.rule;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenProps setSortable(Boolean sortable) {
            this.sortable = sortable;
            return this;
        }
        public Boolean getSortable() {
            return this.sortable;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenProps setSpread(Boolean spread) {
            this.spread = spread;
            return this;
        }
        public Boolean getSpread() {
            return this.spread;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenProps setStatField(java.util.List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsStatField> statField) {
            this.statField = statField;
            return this;
        }
        public java.util.List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsStatField> getStatField() {
            return this.statField;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenProps setTableViewMode(String tableViewMode) {
            this.tableViewMode = tableViewMode;
            return this;
        }
        public String getTableViewMode() {
            return this.tableViewMode;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenProps setUnit(String unit) {
            this.unit = unit;
            return this;
        }
        public String getUnit() {
            return this.unit;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenProps setVerticalPrint(Boolean verticalPrint) {
            this.verticalPrint = verticalPrint;
            return this;
        }
        public Boolean getVerticalPrint() {
            return this.verticalPrint;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenProps setWatermark(Boolean watermark) {
            this.watermark = watermark;
            return this;
        }
        public Boolean getWatermark() {
            return this.watermark;
        }

    }

    public static class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildren extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("componentName")
        public String componentName;

        /**
         * <p>This parameter is required.</p>
         */
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

    public static class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsAvailableTemplates extends TeaModel {
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

        public static DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsAvailableTemplates build(java.util.Map<String, ?> map) throws Exception {
            DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsAvailableTemplates self = new DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsAvailableTemplates();
            return TeaModel.build(map, self);
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsAvailableTemplates setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsAvailableTemplates setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

    }

    public static class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsDataSourceParamsFilters extends TeaModel {
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

        public static DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsDataSourceParamsFilters build(java.util.Map<String, ?> map) throws Exception {
            DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsDataSourceParamsFilters self = new DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsDataSourceParamsFilters();
            return TeaModel.build(map, self);
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsDataSourceParamsFilters setFieldId(String fieldId) {
            this.fieldId = fieldId;
            return this;
        }
        public String getFieldId() {
            return this.fieldId;
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

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsDataSourceParamsFilters setValueType(String valueType) {
            this.valueType = valueType;
            return this;
        }
        public String getValueType() {
            return this.valueType;
        }

    }

    public static class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsDataSourceParams extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
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

        public static DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsDataSourceTarget build(java.util.Map<String, ?> map) throws Exception {
            DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsDataSourceTarget self = new DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsDataSourceTarget();
            return TeaModel.build(map, self);
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsDataSourceTarget setAppType(Long appType) {
            this.appType = appType;
            return this;
        }
        public Long getAppType() {
            return this.appType;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsDataSourceTarget setAppUuid(String appUuid) {
            this.appUuid = appUuid;
            return this;
        }
        public String getAppUuid() {
            return this.appUuid;
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
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("params")
        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsDataSourceParams params;

        @NameInMap("target")
        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsDataSourceTarget target;

        @NameInMap("type")
        public String type;

        public static DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsDataSource build(java.util.Map<String, ?> map) throws Exception {
            DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsDataSource self = new DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsDataSource();
            return TeaModel.build(map, self);
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

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsDataSource setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

    }

    public static class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelatePropsOptionsExtension extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
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
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("extension")
        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelatePropsOptionsExtension extension;

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

        public static DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelatePropsOptions build(java.util.Map<String, ?> map) throws Exception {
            DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelatePropsOptions self = new DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelatePropsOptions();
            return TeaModel.build(map, self);
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelatePropsOptions setExtension(DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelatePropsOptionsExtension extension) {
            this.extension = extension;
            return this;
        }
        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelatePropsOptionsExtension getExtension() {
            return this.extension;
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

    }

    public static class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelatePropsStatField extends TeaModel {
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

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelatePropsStatField setUnit(String unit) {
            this.unit = unit;
            return this;
        }
        public String getUnit() {
            return this.unit;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelatePropsStatField setUpper(Boolean upper) {
            this.upper = upper;
            return this;
        }
        public Boolean getUpper() {
            return this.upper;
        }

    }

    public static class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelateProps extends TeaModel {
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
        public java.util.List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelatePropsOptions> options;

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
        public java.util.List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelatePropsStatField> statField;

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

        public static DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelateProps build(java.util.Map<String, ?> map) throws Exception {
            DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelateProps self = new DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelateProps();
            return TeaModel.build(map, self);
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelateProps setAlign(String align) {
            this.align = align;
            return this;
        }
        public String getAlign() {
            return this.align;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelateProps setBizAlias(String bizAlias) {
            this.bizAlias = bizAlias;
            return this;
        }
        public String getBizAlias() {
            return this.bizAlias;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelateProps setChoice(Long choice) {
            this.choice = choice;
            return this;
        }
        public Long getChoice() {
            return this.choice;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelateProps setContent(String content) {
            this.content = content;
            return this;
        }
        public String getContent() {
            return this.content;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelateProps setDisabled(Boolean disabled) {
            this.disabled = disabled;
            return this;
        }
        public Boolean getDisabled() {
            return this.disabled;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelateProps setDuration(String duration) {
            this.duration = duration;
            return this;
        }
        public String getDuration() {
            return this.duration;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelateProps setDurationLabel(String durationLabel) {
            this.durationLabel = durationLabel;
            return this;
        }
        public String getDurationLabel() {
            return this.durationLabel;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelateProps setFieldId(String fieldId) {
            this.fieldId = fieldId;
            return this;
        }
        public String getFieldId() {
            return this.fieldId;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelateProps setFormat(String format) {
            this.format = format;
            return this;
        }
        public String getFormat() {
            return this.format;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelateProps setFormula(String formula) {
            this.formula = formula;
            return this;
        }
        public String getFormula() {
            return this.formula;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelateProps setInvisible(Boolean invisible) {
            this.invisible = invisible;
            return this;
        }
        public Boolean getInvisible() {
            return this.invisible;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelateProps setLabel(String label) {
            this.label = label;
            return this;
        }
        public String getLabel() {
            return this.label;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelateProps setLabelEditableFreeze(Boolean labelEditableFreeze) {
            this.labelEditableFreeze = labelEditableFreeze;
            return this;
        }
        public Boolean getLabelEditableFreeze() {
            return this.labelEditableFreeze;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelateProps setLimit(Long limit) {
            this.limit = limit;
            return this;
        }
        public Long getLimit() {
            return this.limit;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelateProps setLink(String link) {
            this.link = link;
            return this;
        }
        public String getLink() {
            return this.link;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelateProps setMode(String mode) {
            this.mode = mode;
            return this;
        }
        public String getMode() {
            return this.mode;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelateProps setNotUpper(String notUpper) {
            this.notUpper = notUpper;
            return this;
        }
        public String getNotUpper() {
            return this.notUpper;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelateProps setOptions(java.util.List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelatePropsOptions> options) {
            this.options = options;
            return this;
        }
        public java.util.List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelatePropsOptions> getOptions() {
            return this.options;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelateProps setPayEnable(Boolean payEnable) {
            this.payEnable = payEnable;
            return this;
        }
        public Boolean getPayEnable() {
            return this.payEnable;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelateProps setPlaceholder(String placeholder) {
            this.placeholder = placeholder;
            return this;
        }
        public String getPlaceholder() {
            return this.placeholder;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelateProps setRatio(Long ratio) {
            this.ratio = ratio;
            return this;
        }
        public Long getRatio() {
            return this.ratio;
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

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelateProps setSpread(Boolean spread) {
            this.spread = spread;
            return this;
        }
        public Boolean getSpread() {
            return this.spread;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelateProps setStatField(java.util.List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelatePropsStatField> statField) {
            this.statField = statField;
            return this;
        }
        public java.util.List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelatePropsStatField> getStatField() {
            return this.statField;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelateProps setUnit(String unit) {
            this.unit = unit;
            return this;
        }
        public String getUnit() {
            return this.unit;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelateProps setVerticalPrint(Boolean verticalPrint) {
            this.verticalPrint = verticalPrint;
            return this;
        }
        public Boolean getVerticalPrint() {
            return this.verticalPrint;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelateProps setWatermark(Boolean watermark) {
            this.watermark = watermark;
            return this;
        }
        public Boolean getWatermark() {
            return this.watermark;
        }

    }

    public static class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFields extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("componentName")
        public String componentName;

        /**
         * <p>This parameter is required.</p>
         */
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

    public static class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsOptionsExtension extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
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
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("extension")
        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsOptionsExtension extension;

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

        public static DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsOptions build(java.util.Map<String, ?> map) throws Exception {
            DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsOptions self = new DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsOptions();
            return TeaModel.build(map, self);
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsOptions setExtension(DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsOptionsExtension extension) {
            this.extension = extension;
            return this;
        }
        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsOptionsExtension getExtension() {
            return this.extension;
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

    }

    public static class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceDataSourceParamsFilters extends TeaModel {
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

        public static DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceDataSourceParamsFilters build(java.util.Map<String, ?> map) throws Exception {
            DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceDataSourceParamsFilters self = new DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceDataSourceParamsFilters();
            return TeaModel.build(map, self);
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceDataSourceParamsFilters setFieldId(String fieldId) {
            this.fieldId = fieldId;
            return this;
        }
        public String getFieldId() {
            return this.fieldId;
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

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceDataSourceParamsFilters setValueType(String valueType) {
            this.valueType = valueType;
            return this;
        }
        public String getValueType() {
            return this.valueType;
        }

    }

    public static class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceDataSourceParams extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
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

        public static DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceDataSourceTarget build(java.util.Map<String, ?> map) throws Exception {
            DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceDataSourceTarget self = new DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceDataSourceTarget();
            return TeaModel.build(map, self);
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceDataSourceTarget setAppType(Long appType) {
            this.appType = appType;
            return this;
        }
        public Long getAppType() {
            return this.appType;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceDataSourceTarget setAppUuid(String appUuid) {
            this.appUuid = appUuid;
            return this;
        }
        public String getAppUuid() {
            return this.appUuid;
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
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("params")
        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceDataSourceParams params;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("target")
        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceDataSourceTarget target;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("type")
        public String type;

        public static DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceDataSource build(java.util.Map<String, ?> map) throws Exception {
            DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceDataSource self = new DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceDataSource();
            return TeaModel.build(map, self);
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

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceDataSource setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

    }

    public static class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceFieldsRelatePropsOptionsExtension extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
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
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("extension")
        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceFieldsRelatePropsOptionsExtension extension;

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

        public static DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceFieldsRelatePropsOptions build(java.util.Map<String, ?> map) throws Exception {
            DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceFieldsRelatePropsOptions self = new DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceFieldsRelatePropsOptions();
            return TeaModel.build(map, self);
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceFieldsRelatePropsOptions setExtension(DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceFieldsRelatePropsOptionsExtension extension) {
            this.extension = extension;
            return this;
        }
        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceFieldsRelatePropsOptionsExtension getExtension() {
            return this.extension;
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

    }

    public static class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceFieldsRelatePropsStatField extends TeaModel {
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

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceFieldsRelatePropsStatField setUnit(String unit) {
            this.unit = unit;
            return this;
        }
        public String getUnit() {
            return this.unit;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceFieldsRelatePropsStatField setUpper(Boolean upper) {
            this.upper = upper;
            return this;
        }
        public Boolean getUpper() {
            return this.upper;
        }

    }

    public static class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceFieldsRelateProps extends TeaModel {
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
        public java.util.List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceFieldsRelatePropsOptions> options;

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
        public java.util.List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceFieldsRelatePropsStatField> statField;

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

        public static DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceFieldsRelateProps build(java.util.Map<String, ?> map) throws Exception {
            DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceFieldsRelateProps self = new DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceFieldsRelateProps();
            return TeaModel.build(map, self);
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceFieldsRelateProps setAlign(String align) {
            this.align = align;
            return this;
        }
        public String getAlign() {
            return this.align;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceFieldsRelateProps setBizAlias(String bizAlias) {
            this.bizAlias = bizAlias;
            return this;
        }
        public String getBizAlias() {
            return this.bizAlias;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceFieldsRelateProps setChoice(Long choice) {
            this.choice = choice;
            return this;
        }
        public Long getChoice() {
            return this.choice;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceFieldsRelateProps setContent(String content) {
            this.content = content;
            return this;
        }
        public String getContent() {
            return this.content;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceFieldsRelateProps setDisabled(Boolean disabled) {
            this.disabled = disabled;
            return this;
        }
        public Boolean getDisabled() {
            return this.disabled;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceFieldsRelateProps setDuration(String duration) {
            this.duration = duration;
            return this;
        }
        public String getDuration() {
            return this.duration;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceFieldsRelateProps setFieldId(String fieldId) {
            this.fieldId = fieldId;
            return this;
        }
        public String getFieldId() {
            return this.fieldId;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceFieldsRelateProps setFormat(String format) {
            this.format = format;
            return this;
        }
        public String getFormat() {
            return this.format;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceFieldsRelateProps setFormula(String formula) {
            this.formula = formula;
            return this;
        }
        public String getFormula() {
            return this.formula;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceFieldsRelateProps setInvisible(Boolean invisible) {
            this.invisible = invisible;
            return this;
        }
        public Boolean getInvisible() {
            return this.invisible;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceFieldsRelateProps setLabel(String label) {
            this.label = label;
            return this;
        }
        public String getLabel() {
            return this.label;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceFieldsRelateProps setLabelEditableFreeze(Boolean labelEditableFreeze) {
            this.labelEditableFreeze = labelEditableFreeze;
            return this;
        }
        public Boolean getLabelEditableFreeze() {
            return this.labelEditableFreeze;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceFieldsRelateProps setLink(String link) {
            this.link = link;
            return this;
        }
        public String getLink() {
            return this.link;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceFieldsRelateProps setMulti(Long multi) {
            this.multi = multi;
            return this;
        }
        public Long getMulti() {
            return this.multi;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceFieldsRelateProps setNotUpper(String notUpper) {
            this.notUpper = notUpper;
            return this;
        }
        public String getNotUpper() {
            return this.notUpper;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceFieldsRelateProps setOptions(java.util.List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceFieldsRelatePropsOptions> options) {
            this.options = options;
            return this;
        }
        public java.util.List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceFieldsRelatePropsOptions> getOptions() {
            return this.options;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceFieldsRelateProps setPayEnable(Boolean payEnable) {
            this.payEnable = payEnable;
            return this;
        }
        public Boolean getPayEnable() {
            return this.payEnable;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceFieldsRelateProps setPlaceholder(String placeholder) {
            this.placeholder = placeholder;
            return this;
        }
        public String getPlaceholder() {
            return this.placeholder;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceFieldsRelateProps setQuote(Long quote) {
            this.quote = quote;
            return this;
        }
        public Long getQuote() {
            return this.quote;
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

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceFieldsRelateProps setStatField(java.util.List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceFieldsRelatePropsStatField> statField) {
            this.statField = statField;
            return this;
        }
        public java.util.List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceFieldsRelatePropsStatField> getStatField() {
            return this.statField;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceFieldsRelateProps setUnit(String unit) {
            this.unit = unit;
            return this;
        }
        public String getUnit() {
            return this.unit;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceFieldsRelateProps setVerticalPrint(Boolean verticalPrint) {
            this.verticalPrint = verticalPrint;
            return this;
        }
        public Boolean getVerticalPrint() {
            return this.verticalPrint;
        }

    }

    public static class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceFields extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("componentName")
        public String componentName;

        /**
         * <p>This parameter is required.</p>
         */
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

    public static class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSource extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("bizType")
        public String bizType;

        @NameInMap("dataSource")
        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceDataSource dataSource;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("fields")
        public java.util.List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceFields> fields;

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

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSource setDataSource(DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceDataSource dataSource) {
            this.dataSource = dataSource;
            return this;
        }
        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceDataSource getDataSource() {
            return this.dataSource;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSource setFields(java.util.List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceFields> fields) {
            this.fields = fields;
            return this;
        }
        public java.util.List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSourceFields> getFields() {
            return this.fields;
        }

    }

    public static class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRule extends TeaModel {
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

    public static class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsStatField extends TeaModel {
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

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsStatField setUnit(String unit) {
            this.unit = unit;
            return this;
        }
        public String getUnit() {
            return this.unit;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsStatField setUpper(Boolean upper) {
            this.upper = upper;
            return this;
        }
        public Boolean getUpper() {
            return this.upper;
        }

    }

    public static class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsProps extends TeaModel {
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
        public java.util.List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsAvailableTemplates> availableTemplates;

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
        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsDataSource dataSource;

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
        public java.util.List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFields> fields;

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
        public java.util.List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsOptions> options;

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
        public java.util.List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSource> relateSource;

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
        public java.util.List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRule> rule;

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
        public java.util.List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsStatField> statField;

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

        public static DescribeRelationMetaResponseBodyRelationMetaDTOListItemsProps build(java.util.Map<String, ?> map) throws Exception {
            DescribeRelationMetaResponseBodyRelationMetaDTOListItemsProps self = new DescribeRelationMetaResponseBodyRelationMetaDTOListItemsProps();
            return TeaModel.build(map, self);
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsProps setActionName(String actionName) {
            this.actionName = actionName;
            return this;
        }
        public String getActionName() {
            return this.actionName;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsProps setAlign(String align) {
            this.align = align;
            return this;
        }
        public String getAlign() {
            return this.align;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsProps setAvailableTemplates(java.util.List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsAvailableTemplates> availableTemplates) {
            this.availableTemplates = availableTemplates;
            return this;
        }
        public java.util.List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsAvailableTemplates> getAvailableTemplates() {
            return this.availableTemplates;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsProps setBizAlias(String bizAlias) {
            this.bizAlias = bizAlias;
            return this;
        }
        public String getBizAlias() {
            return this.bizAlias;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsProps setChoice(Long choice) {
            this.choice = choice;
            return this;
        }
        public Long getChoice() {
            return this.choice;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsProps setContent(String content) {
            this.content = content;
            return this;
        }
        public String getContent() {
            return this.content;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsProps setDataSource(DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsDataSource dataSource) {
            this.dataSource = dataSource;
            return this;
        }
        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsDataSource getDataSource() {
            return this.dataSource;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsProps setDefaultColor(String defaultColor) {
            this.defaultColor = defaultColor;
            return this;
        }
        public String getDefaultColor() {
            return this.defaultColor;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsProps setDisabled(Boolean disabled) {
            this.disabled = disabled;
            return this;
        }
        public Boolean getDisabled() {
            return this.disabled;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsProps setDuration(Boolean duration) {
            this.duration = duration;
            return this;
        }
        public Boolean getDuration() {
            return this.duration;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsProps setDurationLabel(String durationLabel) {
            this.durationLabel = durationLabel;
            return this;
        }
        public String getDurationLabel() {
            return this.durationLabel;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsProps setFieldId(String fieldId) {
            this.fieldId = fieldId;
            return this;
        }
        public String getFieldId() {
            return this.fieldId;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsProps setFields(java.util.List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFields> fields) {
            this.fields = fields;
            return this;
        }
        public java.util.List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFields> getFields() {
            return this.fields;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsProps setFormat(String format) {
            this.format = format;
            return this;
        }
        public String getFormat() {
            return this.format;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsProps setFormula(String formula) {
            this.formula = formula;
            return this;
        }
        public String getFormula() {
            return this.formula;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsProps setInvisible(Boolean invisible) {
            this.invisible = invisible;
            return this;
        }
        public Boolean getInvisible() {
            return this.invisible;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsProps setLabel(String label) {
            this.label = label;
            return this;
        }
        public String getLabel() {
            return this.label;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsProps setLabelEditableFreeze(Boolean labelEditableFreeze) {
            this.labelEditableFreeze = labelEditableFreeze;
            return this;
        }
        public Boolean getLabelEditableFreeze() {
            return this.labelEditableFreeze;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsProps setLimit(Long limit) {
            this.limit = limit;
            return this;
        }
        public Long getLimit() {
            return this.limit;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsProps setLink(String link) {
            this.link = link;
            return this;
        }
        public String getLink() {
            return this.link;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsProps setMode(String mode) {
            this.mode = mode;
            return this;
        }
        public String getMode() {
            return this.mode;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsProps setMulti(Long multi) {
            this.multi = multi;
            return this;
        }
        public Long getMulti() {
            return this.multi;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsProps setMultiple(Boolean multiple) {
            this.multiple = multiple;
            return this;
        }
        public Boolean getMultiple() {
            return this.multiple;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsProps setNeedDetail(String needDetail) {
            this.needDetail = needDetail;
            return this;
        }
        public String getNeedDetail() {
            return this.needDetail;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsProps setNotPrint(String notPrint) {
            this.notPrint = notPrint;
            return this;
        }
        public String getNotPrint() {
            return this.notPrint;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsProps setNotUpper(String notUpper) {
            this.notUpper = notUpper;
            return this;
        }
        public String getNotUpper() {
            return this.notUpper;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsProps setOptions(java.util.List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsOptions> options) {
            this.options = options;
            return this;
        }
        public java.util.List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsOptions> getOptions() {
            return this.options;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsProps setPayEnable(Boolean payEnable) {
            this.payEnable = payEnable;
            return this;
        }
        public Boolean getPayEnable() {
            return this.payEnable;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsProps setPlaceholder(String placeholder) {
            this.placeholder = placeholder;
            return this;
        }
        public String getPlaceholder() {
            return this.placeholder;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsProps setQuote(Long quote) {
            this.quote = quote;
            return this;
        }
        public Long getQuote() {
            return this.quote;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsProps setRatio(Long ratio) {
            this.ratio = ratio;
            return this;
        }
        public Long getRatio() {
            return this.ratio;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsProps setRelateSource(java.util.List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSource> relateSource) {
            this.relateSource = relateSource;
            return this;
        }
        public java.util.List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRelateSource> getRelateSource() {
            return this.relateSource;
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

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsProps setRule(java.util.List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRule> rule) {
            this.rule = rule;
            return this;
        }
        public java.util.List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsRule> getRule() {
            return this.rule;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsProps setSortable(Boolean sortable) {
            this.sortable = sortable;
            return this;
        }
        public Boolean getSortable() {
            return this.sortable;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsProps setSpread(Boolean spread) {
            this.spread = spread;
            return this;
        }
        public Boolean getSpread() {
            return this.spread;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsProps setStatField(java.util.List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsStatField> statField) {
            this.statField = statField;
            return this;
        }
        public java.util.List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsStatField> getStatField() {
            return this.statField;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsProps setTableViewMode(String tableViewMode) {
            this.tableViewMode = tableViewMode;
            return this;
        }
        public String getTableViewMode() {
            return this.tableViewMode;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsProps setUnit(String unit) {
            this.unit = unit;
            return this;
        }
        public String getUnit() {
            return this.unit;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsProps setVerticalPrint(Boolean verticalPrint) {
            this.verticalPrint = verticalPrint;
            return this;
        }
        public Boolean getVerticalPrint() {
            return this.verticalPrint;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsProps setWatermark(Boolean watermark) {
            this.watermark = watermark;
            return this;
        }
        public Boolean getWatermark() {
            return this.watermark;
        }

    }

    public static class DescribeRelationMetaResponseBodyRelationMetaDTOListItems extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("children")
        public java.util.List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildren> children;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("componentName")
        public String componentName;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("props")
        public DescribeRelationMetaResponseBodyRelationMetaDTOListItemsProps props;

        public static DescribeRelationMetaResponseBodyRelationMetaDTOListItems build(java.util.Map<String, ?> map) throws Exception {
            DescribeRelationMetaResponseBodyRelationMetaDTOListItems self = new DescribeRelationMetaResponseBodyRelationMetaDTOListItems();
            return TeaModel.build(map, self);
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOListItems setChildren(java.util.List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildren> children) {
            this.children = children;
            return this;
        }
        public java.util.List<DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildren> getChildren() {
            return this.children;
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

    }

    public static class DescribeRelationMetaResponseBodyRelationMetaDTOList extends TeaModel {
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
        public java.util.List<DescribeRelationMetaResponseBodyRelationMetaDTOListItems> items;

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

        public static DescribeRelationMetaResponseBodyRelationMetaDTOList build(java.util.Map<String, ?> map) throws Exception {
            DescribeRelationMetaResponseBodyRelationMetaDTOList self = new DescribeRelationMetaResponseBodyRelationMetaDTOList();
            return TeaModel.build(map, self);
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOList setCreatorUserId(String creatorUserId) {
            this.creatorUserId = creatorUserId;
            return this;
        }
        public String getCreatorUserId() {
            return this.creatorUserId;
        }

        public DescribeRelationMetaResponseBodyRelationMetaDTOList setDesc(String desc) {
            this.desc = desc;
            return this;
        }
        public String getDesc() {
            return this.desc;
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

        public DescribeRelationMetaResponseBodyRelationMetaDTOList setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
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

        public DescribeRelationMetaResponseBodyRelationMetaDTOList setRelationType(String relationType) {
            this.relationType = relationType;
            return this;
        }
        public String getRelationType() {
            return this.relationType;
        }

    }

}
