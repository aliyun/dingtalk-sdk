// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class UpdateRelationMetaFieldResponseBody extends TeaModel {
    @NameInMap("relationMetaDTO")
    public UpdateRelationMetaFieldResponseBodyRelationMetaDTO relationMetaDTO;

    public static UpdateRelationMetaFieldResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdateRelationMetaFieldResponseBody self = new UpdateRelationMetaFieldResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdateRelationMetaFieldResponseBody setRelationMetaDTO(UpdateRelationMetaFieldResponseBodyRelationMetaDTO relationMetaDTO) {
        this.relationMetaDTO = relationMetaDTO;
        return this;
    }
    public UpdateRelationMetaFieldResponseBodyRelationMetaDTO getRelationMetaDTO() {
        return this.relationMetaDTO;
    }

    public static class UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsDataSourceTarget extends TeaModel {
        @NameInMap("appType")
        public Long appType;

        @NameInMap("appUuid")
        public String appUuid;

        @NameInMap("bizType")
        public String bizType;

        @NameInMap("formCode")
        public String formCode;

        public static UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsDataSourceTarget build(java.util.Map<String, ?> map) throws Exception {
            UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsDataSourceTarget self = new UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsDataSourceTarget();
            return TeaModel.build(map, self);
        }

        public UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsDataSourceTarget setAppType(Long appType) {
            this.appType = appType;
            return this;
        }
        public Long getAppType() {
            return this.appType;
        }

        public UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsDataSourceTarget setAppUuid(String appUuid) {
            this.appUuid = appUuid;
            return this;
        }
        public String getAppUuid() {
            return this.appUuid;
        }

        public UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsDataSourceTarget setBizType(String bizType) {
            this.bizType = bizType;
            return this;
        }
        public String getBizType() {
            return this.bizType;
        }

        public UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsDataSourceTarget setFormCode(String formCode) {
            this.formCode = formCode;
            return this;
        }
        public String getFormCode() {
            return this.formCode;
        }

    }

    public static class UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsDataSource extends TeaModel {
        @NameInMap("target")
        public UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsDataSourceTarget target;

        @NameInMap("type")
        public String type;

        public static UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsDataSource build(java.util.Map<String, ?> map) throws Exception {
            UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsDataSource self = new UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsDataSource();
            return TeaModel.build(map, self);
        }

        public UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsDataSource setTarget(UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsDataSourceTarget target) {
            this.target = target;
            return this;
        }
        public UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsDataSourceTarget getTarget() {
            return this.target;
        }

        public UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsDataSource setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

    }

    public static class UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsFieldsRelatePropsOptions extends TeaModel {
        @NameInMap("key")
        public String key;

        @NameInMap("value")
        public String value;

        public static UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsFieldsRelatePropsOptions build(java.util.Map<String, ?> map) throws Exception {
            UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsFieldsRelatePropsOptions self = new UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsFieldsRelatePropsOptions();
            return TeaModel.build(map, self);
        }

        public UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsFieldsRelatePropsOptions setKey(String key) {
            this.key = key;
            return this;
        }
        public String getKey() {
            return this.key;
        }

        public UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsFieldsRelatePropsOptions setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

    }

    public static class UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsFieldsRelatePropsStatField extends TeaModel {
        @NameInMap("fieldId")
        public String fieldId;

        @NameInMap("label")
        public String label;

        @NameInMap("unit")
        public String unit;

        @NameInMap("upper")
        public Boolean upper;

        public static UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsFieldsRelatePropsStatField build(java.util.Map<String, ?> map) throws Exception {
            UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsFieldsRelatePropsStatField self = new UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsFieldsRelatePropsStatField();
            return TeaModel.build(map, self);
        }

        public UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsFieldsRelatePropsStatField setFieldId(String fieldId) {
            this.fieldId = fieldId;
            return this;
        }
        public String getFieldId() {
            return this.fieldId;
        }

        public UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsFieldsRelatePropsStatField setLabel(String label) {
            this.label = label;
            return this;
        }
        public String getLabel() {
            return this.label;
        }

        public UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsFieldsRelatePropsStatField setUnit(String unit) {
            this.unit = unit;
            return this;
        }
        public String getUnit() {
            return this.unit;
        }

        public UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsFieldsRelatePropsStatField setUpper(Boolean upper) {
            this.upper = upper;
            return this;
        }
        public Boolean getUpper() {
            return this.upper;
        }

    }

    public static class UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsFieldsRelateProps extends TeaModel {
        @NameInMap("align")
        public String align;

        @NameInMap("bizAlias")
        public String bizAlias;

        @NameInMap("choice")
        public Long choice;

        @NameInMap("content")
        public String content;

        @NameInMap("disabled")
        public Boolean disabled;

        @NameInMap("duration")
        public Boolean duration;

        @NameInMap("format")
        public String format;

        @NameInMap("formula")
        public String formula;

        @NameInMap("fieldId")
        public String fieldId;

        @NameInMap("invisible")
        public Boolean invisible;

        @NameInMap("label")
        public String label;

        @NameInMap("link")
        public String link;

        @NameInMap("notUpper")
        public String notUpper;

        @NameInMap("options")
        public java.util.List<UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsFieldsRelatePropsOptions> options;

        @NameInMap("payEnable")
        public Boolean payEnable;

        @NameInMap("placeholder")
        public String placeholder;

        @NameInMap("required")
        public Boolean required;

        @NameInMap("statField")
        public java.util.List<UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsFieldsRelatePropsStatField> statField;

        @NameInMap("unit")
        public String unit;

        @NameInMap("verticalPrint")
        public Boolean verticalPrint;

        public static UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsFieldsRelateProps build(java.util.Map<String, ?> map) throws Exception {
            UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsFieldsRelateProps self = new UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsFieldsRelateProps();
            return TeaModel.build(map, self);
        }

        public UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsFieldsRelateProps setAlign(String align) {
            this.align = align;
            return this;
        }
        public String getAlign() {
            return this.align;
        }

        public UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsFieldsRelateProps setBizAlias(String bizAlias) {
            this.bizAlias = bizAlias;
            return this;
        }
        public String getBizAlias() {
            return this.bizAlias;
        }

        public UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsFieldsRelateProps setChoice(Long choice) {
            this.choice = choice;
            return this;
        }
        public Long getChoice() {
            return this.choice;
        }

        public UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsFieldsRelateProps setContent(String content) {
            this.content = content;
            return this;
        }
        public String getContent() {
            return this.content;
        }

        public UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsFieldsRelateProps setDisabled(Boolean disabled) {
            this.disabled = disabled;
            return this;
        }
        public Boolean getDisabled() {
            return this.disabled;
        }

        public UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsFieldsRelateProps setDuration(Boolean duration) {
            this.duration = duration;
            return this;
        }
        public Boolean getDuration() {
            return this.duration;
        }

        public UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsFieldsRelateProps setFormat(String format) {
            this.format = format;
            return this;
        }
        public String getFormat() {
            return this.format;
        }

        public UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsFieldsRelateProps setFormula(String formula) {
            this.formula = formula;
            return this;
        }
        public String getFormula() {
            return this.formula;
        }

        public UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsFieldsRelateProps setFieldId(String fieldId) {
            this.fieldId = fieldId;
            return this;
        }
        public String getFieldId() {
            return this.fieldId;
        }

        public UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsFieldsRelateProps setInvisible(Boolean invisible) {
            this.invisible = invisible;
            return this;
        }
        public Boolean getInvisible() {
            return this.invisible;
        }

        public UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsFieldsRelateProps setLabel(String label) {
            this.label = label;
            return this;
        }
        public String getLabel() {
            return this.label;
        }

        public UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsFieldsRelateProps setLink(String link) {
            this.link = link;
            return this;
        }
        public String getLink() {
            return this.link;
        }

        public UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsFieldsRelateProps setNotUpper(String notUpper) {
            this.notUpper = notUpper;
            return this;
        }
        public String getNotUpper() {
            return this.notUpper;
        }

        public UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsFieldsRelateProps setOptions(java.util.List<UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsFieldsRelatePropsOptions> options) {
            this.options = options;
            return this;
        }
        public java.util.List<UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsFieldsRelatePropsOptions> getOptions() {
            return this.options;
        }

        public UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsFieldsRelateProps setPayEnable(Boolean payEnable) {
            this.payEnable = payEnable;
            return this;
        }
        public Boolean getPayEnable() {
            return this.payEnable;
        }

        public UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsFieldsRelateProps setPlaceholder(String placeholder) {
            this.placeholder = placeholder;
            return this;
        }
        public String getPlaceholder() {
            return this.placeholder;
        }

        public UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsFieldsRelateProps setRequired(Boolean required) {
            this.required = required;
            return this;
        }
        public Boolean getRequired() {
            return this.required;
        }

        public UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsFieldsRelateProps setStatField(java.util.List<UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsFieldsRelatePropsStatField> statField) {
            this.statField = statField;
            return this;
        }
        public java.util.List<UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsFieldsRelatePropsStatField> getStatField() {
            return this.statField;
        }

        public UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsFieldsRelateProps setUnit(String unit) {
            this.unit = unit;
            return this;
        }
        public String getUnit() {
            return this.unit;
        }

        public UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsFieldsRelateProps setVerticalPrint(Boolean verticalPrint) {
            this.verticalPrint = verticalPrint;
            return this;
        }
        public Boolean getVerticalPrint() {
            return this.verticalPrint;
        }

    }

    public static class UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsFields extends TeaModel {
        @NameInMap("componentName")
        public String componentName;

        @NameInMap("relateProps")
        public UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsFieldsRelateProps relateProps;

        public static UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsFields build(java.util.Map<String, ?> map) throws Exception {
            UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsFields self = new UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsFields();
            return TeaModel.build(map, self);
        }

        public UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsFields setComponentName(String componentName) {
            this.componentName = componentName;
            return this;
        }
        public String getComponentName() {
            return this.componentName;
        }

        public UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsFields setRelateProps(UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsFieldsRelateProps relateProps) {
            this.relateProps = relateProps;
            return this;
        }
        public UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsFieldsRelateProps getRelateProps() {
            return this.relateProps;
        }

    }

    public static class UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsOptions extends TeaModel {
        @NameInMap("key")
        public String key;

        @NameInMap("value")
        public String value;

        public static UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsOptions build(java.util.Map<String, ?> map) throws Exception {
            UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsOptions self = new UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsOptions();
            return TeaModel.build(map, self);
        }

        public UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsOptions setKey(String key) {
            this.key = key;
            return this;
        }
        public String getKey() {
            return this.key;
        }

        public UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsOptions setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

    }

    public static class UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsStatField extends TeaModel {
        @NameInMap("fieldId")
        public String fieldId;

        @NameInMap("label")
        public String label;

        @NameInMap("unit")
        public String unit;

        @NameInMap("upper")
        public Boolean upper;

        public static UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsStatField build(java.util.Map<String, ?> map) throws Exception {
            UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsStatField self = new UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsStatField();
            return TeaModel.build(map, self);
        }

        public UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsStatField setFieldId(String fieldId) {
            this.fieldId = fieldId;
            return this;
        }
        public String getFieldId() {
            return this.fieldId;
        }

        public UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsStatField setLabel(String label) {
            this.label = label;
            return this;
        }
        public String getLabel() {
            return this.label;
        }

        public UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsStatField setUnit(String unit) {
            this.unit = unit;
            return this;
        }
        public String getUnit() {
            return this.unit;
        }

        public UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsStatField setUpper(Boolean upper) {
            this.upper = upper;
            return this;
        }
        public Boolean getUpper() {
            return this.upper;
        }

    }

    public static class UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenProps extends TeaModel {
        @NameInMap("align")
        public String align;

        @NameInMap("bizAlias")
        public String bizAlias;

        @NameInMap("choice")
        public Long choice;

        @NameInMap("content")
        public String content;

        @NameInMap("dataSource")
        public UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsDataSource dataSource;

        @NameInMap("disabled")
        public Boolean disabled;

        @NameInMap("duration")
        public Boolean duration;

        @NameInMap("fields")
        public java.util.List<UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsFields> fields;

        @NameInMap("format")
        public String format;

        @NameInMap("formula")
        public String formula;

        @NameInMap("fieldId")
        public String fieldId;

        @NameInMap("invisible")
        public Boolean invisible;

        @NameInMap("label")
        public String label;

        @NameInMap("labelEditableFreeze")
        public Boolean labelEditableFreeze;

        @NameInMap("link")
        public String link;

        @NameInMap("notPrint")
        public String notPrint;

        @NameInMap("notUpper")
        public String notUpper;

        @NameInMap("options")
        public java.util.List<UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsOptions> options;

        @NameInMap("payEnable")
        public Boolean payEnable;

        @NameInMap("placeholder")
        public String placeholder;

        @NameInMap("required")
        public Boolean required;

        @NameInMap("requiredEditableFreeze")
        public Boolean requiredEditableFreeze;

        @NameInMap("statField")
        public java.util.List<UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsStatField> statField;

        @NameInMap("unit")
        public String unit;

        @NameInMap("verticalPrint")
        public Boolean verticalPrint;

        public static UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenProps build(java.util.Map<String, ?> map) throws Exception {
            UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenProps self = new UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenProps();
            return TeaModel.build(map, self);
        }

        public UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenProps setAlign(String align) {
            this.align = align;
            return this;
        }
        public String getAlign() {
            return this.align;
        }

        public UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenProps setBizAlias(String bizAlias) {
            this.bizAlias = bizAlias;
            return this;
        }
        public String getBizAlias() {
            return this.bizAlias;
        }

        public UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenProps setChoice(Long choice) {
            this.choice = choice;
            return this;
        }
        public Long getChoice() {
            return this.choice;
        }

        public UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenProps setContent(String content) {
            this.content = content;
            return this;
        }
        public String getContent() {
            return this.content;
        }

        public UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenProps setDataSource(UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsDataSource dataSource) {
            this.dataSource = dataSource;
            return this;
        }
        public UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsDataSource getDataSource() {
            return this.dataSource;
        }

        public UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenProps setDisabled(Boolean disabled) {
            this.disabled = disabled;
            return this;
        }
        public Boolean getDisabled() {
            return this.disabled;
        }

        public UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenProps setDuration(Boolean duration) {
            this.duration = duration;
            return this;
        }
        public Boolean getDuration() {
            return this.duration;
        }

        public UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenProps setFields(java.util.List<UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsFields> fields) {
            this.fields = fields;
            return this;
        }
        public java.util.List<UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsFields> getFields() {
            return this.fields;
        }

        public UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenProps setFormat(String format) {
            this.format = format;
            return this;
        }
        public String getFormat() {
            return this.format;
        }

        public UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenProps setFormula(String formula) {
            this.formula = formula;
            return this;
        }
        public String getFormula() {
            return this.formula;
        }

        public UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenProps setFieldId(String fieldId) {
            this.fieldId = fieldId;
            return this;
        }
        public String getFieldId() {
            return this.fieldId;
        }

        public UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenProps setInvisible(Boolean invisible) {
            this.invisible = invisible;
            return this;
        }
        public Boolean getInvisible() {
            return this.invisible;
        }

        public UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenProps setLabel(String label) {
            this.label = label;
            return this;
        }
        public String getLabel() {
            return this.label;
        }

        public UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenProps setLabelEditableFreeze(Boolean labelEditableFreeze) {
            this.labelEditableFreeze = labelEditableFreeze;
            return this;
        }
        public Boolean getLabelEditableFreeze() {
            return this.labelEditableFreeze;
        }

        public UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenProps setLink(String link) {
            this.link = link;
            return this;
        }
        public String getLink() {
            return this.link;
        }

        public UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenProps setNotPrint(String notPrint) {
            this.notPrint = notPrint;
            return this;
        }
        public String getNotPrint() {
            return this.notPrint;
        }

        public UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenProps setNotUpper(String notUpper) {
            this.notUpper = notUpper;
            return this;
        }
        public String getNotUpper() {
            return this.notUpper;
        }

        public UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenProps setOptions(java.util.List<UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsOptions> options) {
            this.options = options;
            return this;
        }
        public java.util.List<UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsOptions> getOptions() {
            return this.options;
        }

        public UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenProps setPayEnable(Boolean payEnable) {
            this.payEnable = payEnable;
            return this;
        }
        public Boolean getPayEnable() {
            return this.payEnable;
        }

        public UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenProps setPlaceholder(String placeholder) {
            this.placeholder = placeholder;
            return this;
        }
        public String getPlaceholder() {
            return this.placeholder;
        }

        public UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenProps setRequired(Boolean required) {
            this.required = required;
            return this;
        }
        public Boolean getRequired() {
            return this.required;
        }

        public UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenProps setRequiredEditableFreeze(Boolean requiredEditableFreeze) {
            this.requiredEditableFreeze = requiredEditableFreeze;
            return this;
        }
        public Boolean getRequiredEditableFreeze() {
            return this.requiredEditableFreeze;
        }

        public UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenProps setStatField(java.util.List<UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsStatField> statField) {
            this.statField = statField;
            return this;
        }
        public java.util.List<UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsStatField> getStatField() {
            return this.statField;
        }

        public UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenProps setUnit(String unit) {
            this.unit = unit;
            return this;
        }
        public String getUnit() {
            return this.unit;
        }

        public UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenProps setVerticalPrint(Boolean verticalPrint) {
            this.verticalPrint = verticalPrint;
            return this;
        }
        public Boolean getVerticalPrint() {
            return this.verticalPrint;
        }

    }

    public static class UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildren extends TeaModel {
        @NameInMap("componentName")
        public String componentName;

        @NameInMap("props")
        public UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenProps props;

        public static UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildren build(java.util.Map<String, ?> map) throws Exception {
            UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildren self = new UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildren();
            return TeaModel.build(map, self);
        }

        public UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildren setComponentName(String componentName) {
            this.componentName = componentName;
            return this;
        }
        public String getComponentName() {
            return this.componentName;
        }

        public UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildren setProps(UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenProps props) {
            this.props = props;
            return this;
        }
        public UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenProps getProps() {
            return this.props;
        }

    }

    public static class UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsDataSourceTarget extends TeaModel {
        @NameInMap("appType")
        public Long appType;

        @NameInMap("appUuid")
        public String appUuid;

        @NameInMap("bizType")
        public String bizType;

        @NameInMap("formCode")
        public String formCode;

        public static UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsDataSourceTarget build(java.util.Map<String, ?> map) throws Exception {
            UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsDataSourceTarget self = new UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsDataSourceTarget();
            return TeaModel.build(map, self);
        }

        public UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsDataSourceTarget setAppType(Long appType) {
            this.appType = appType;
            return this;
        }
        public Long getAppType() {
            return this.appType;
        }

        public UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsDataSourceTarget setAppUuid(String appUuid) {
            this.appUuid = appUuid;
            return this;
        }
        public String getAppUuid() {
            return this.appUuid;
        }

        public UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsDataSourceTarget setBizType(String bizType) {
            this.bizType = bizType;
            return this;
        }
        public String getBizType() {
            return this.bizType;
        }

        public UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsDataSourceTarget setFormCode(String formCode) {
            this.formCode = formCode;
            return this;
        }
        public String getFormCode() {
            return this.formCode;
        }

    }

    public static class UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsDataSource extends TeaModel {
        @NameInMap("target")
        public UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsDataSourceTarget target;

        @NameInMap("type")
        public String type;

        public static UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsDataSource build(java.util.Map<String, ?> map) throws Exception {
            UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsDataSource self = new UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsDataSource();
            return TeaModel.build(map, self);
        }

        public UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsDataSource setTarget(UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsDataSourceTarget target) {
            this.target = target;
            return this;
        }
        public UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsDataSourceTarget getTarget() {
            return this.target;
        }

        public UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsDataSource setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

    }

    public static class UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsFieldsRelatePropsOptions extends TeaModel {
        @NameInMap("key")
        public String key;

        @NameInMap("value")
        public String value;

        public static UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsFieldsRelatePropsOptions build(java.util.Map<String, ?> map) throws Exception {
            UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsFieldsRelatePropsOptions self = new UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsFieldsRelatePropsOptions();
            return TeaModel.build(map, self);
        }

        public UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsFieldsRelatePropsOptions setKey(String key) {
            this.key = key;
            return this;
        }
        public String getKey() {
            return this.key;
        }

        public UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsFieldsRelatePropsOptions setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

    }

    public static class UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsFieldsRelatePropsStatField extends TeaModel {
        @NameInMap("fieldId")
        public String fieldId;

        @NameInMap("label")
        public String label;

        @NameInMap("unit")
        public String unit;

        @NameInMap("upper")
        public Boolean upper;

        public static UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsFieldsRelatePropsStatField build(java.util.Map<String, ?> map) throws Exception {
            UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsFieldsRelatePropsStatField self = new UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsFieldsRelatePropsStatField();
            return TeaModel.build(map, self);
        }

        public UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsFieldsRelatePropsStatField setFieldId(String fieldId) {
            this.fieldId = fieldId;
            return this;
        }
        public String getFieldId() {
            return this.fieldId;
        }

        public UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsFieldsRelatePropsStatField setLabel(String label) {
            this.label = label;
            return this;
        }
        public String getLabel() {
            return this.label;
        }

        public UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsFieldsRelatePropsStatField setUnit(String unit) {
            this.unit = unit;
            return this;
        }
        public String getUnit() {
            return this.unit;
        }

        public UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsFieldsRelatePropsStatField setUpper(Boolean upper) {
            this.upper = upper;
            return this;
        }
        public Boolean getUpper() {
            return this.upper;
        }

    }

    public static class UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsFieldsRelateProps extends TeaModel {
        @NameInMap("align")
        public String align;

        @NameInMap("bizAlias")
        public String bizAlias;

        @NameInMap("choice")
        public Long choice;

        @NameInMap("content")
        public String content;

        @NameInMap("disabled")
        public Boolean disabled;

        @NameInMap("duration")
        public String duration;

        @NameInMap("format")
        public String format;

        @NameInMap("formula")
        public String formula;

        @NameInMap("fieldId")
        public String fieldId;

        @NameInMap("invisible")
        public Boolean invisible;

        @NameInMap("label")
        public String label;

        @NameInMap("link")
        public String link;

        @NameInMap("notUpper")
        public String notUpper;

        @NameInMap("options")
        public java.util.List<UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsFieldsRelatePropsOptions> options;

        @NameInMap("payEnable")
        public Boolean payEnable;

        @NameInMap("placeholder")
        public String placeholder;

        @NameInMap("required")
        public Boolean required;

        @NameInMap("statField")
        public java.util.List<UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsFieldsRelatePropsStatField> statField;

        @NameInMap("unit")
        public String unit;

        @NameInMap("verticalPrint")
        public Boolean verticalPrint;

        public static UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsFieldsRelateProps build(java.util.Map<String, ?> map) throws Exception {
            UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsFieldsRelateProps self = new UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsFieldsRelateProps();
            return TeaModel.build(map, self);
        }

        public UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsFieldsRelateProps setAlign(String align) {
            this.align = align;
            return this;
        }
        public String getAlign() {
            return this.align;
        }

        public UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsFieldsRelateProps setBizAlias(String bizAlias) {
            this.bizAlias = bizAlias;
            return this;
        }
        public String getBizAlias() {
            return this.bizAlias;
        }

        public UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsFieldsRelateProps setChoice(Long choice) {
            this.choice = choice;
            return this;
        }
        public Long getChoice() {
            return this.choice;
        }

        public UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsFieldsRelateProps setContent(String content) {
            this.content = content;
            return this;
        }
        public String getContent() {
            return this.content;
        }

        public UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsFieldsRelateProps setDisabled(Boolean disabled) {
            this.disabled = disabled;
            return this;
        }
        public Boolean getDisabled() {
            return this.disabled;
        }

        public UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsFieldsRelateProps setDuration(String duration) {
            this.duration = duration;
            return this;
        }
        public String getDuration() {
            return this.duration;
        }

        public UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsFieldsRelateProps setFormat(String format) {
            this.format = format;
            return this;
        }
        public String getFormat() {
            return this.format;
        }

        public UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsFieldsRelateProps setFormula(String formula) {
            this.formula = formula;
            return this;
        }
        public String getFormula() {
            return this.formula;
        }

        public UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsFieldsRelateProps setFieldId(String fieldId) {
            this.fieldId = fieldId;
            return this;
        }
        public String getFieldId() {
            return this.fieldId;
        }

        public UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsFieldsRelateProps setInvisible(Boolean invisible) {
            this.invisible = invisible;
            return this;
        }
        public Boolean getInvisible() {
            return this.invisible;
        }

        public UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsFieldsRelateProps setLabel(String label) {
            this.label = label;
            return this;
        }
        public String getLabel() {
            return this.label;
        }

        public UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsFieldsRelateProps setLink(String link) {
            this.link = link;
            return this;
        }
        public String getLink() {
            return this.link;
        }

        public UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsFieldsRelateProps setNotUpper(String notUpper) {
            this.notUpper = notUpper;
            return this;
        }
        public String getNotUpper() {
            return this.notUpper;
        }

        public UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsFieldsRelateProps setOptions(java.util.List<UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsFieldsRelatePropsOptions> options) {
            this.options = options;
            return this;
        }
        public java.util.List<UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsFieldsRelatePropsOptions> getOptions() {
            return this.options;
        }

        public UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsFieldsRelateProps setPayEnable(Boolean payEnable) {
            this.payEnable = payEnable;
            return this;
        }
        public Boolean getPayEnable() {
            return this.payEnable;
        }

        public UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsFieldsRelateProps setPlaceholder(String placeholder) {
            this.placeholder = placeholder;
            return this;
        }
        public String getPlaceholder() {
            return this.placeholder;
        }

        public UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsFieldsRelateProps setRequired(Boolean required) {
            this.required = required;
            return this;
        }
        public Boolean getRequired() {
            return this.required;
        }

        public UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsFieldsRelateProps setStatField(java.util.List<UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsFieldsRelatePropsStatField> statField) {
            this.statField = statField;
            return this;
        }
        public java.util.List<UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsFieldsRelatePropsStatField> getStatField() {
            return this.statField;
        }

        public UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsFieldsRelateProps setUnit(String unit) {
            this.unit = unit;
            return this;
        }
        public String getUnit() {
            return this.unit;
        }

        public UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsFieldsRelateProps setVerticalPrint(Boolean verticalPrint) {
            this.verticalPrint = verticalPrint;
            return this;
        }
        public Boolean getVerticalPrint() {
            return this.verticalPrint;
        }

    }

    public static class UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsFields extends TeaModel {
        @NameInMap("componentName")
        public String componentName;

        @NameInMap("relateProps")
        public UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsFieldsRelateProps relateProps;

        public static UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsFields build(java.util.Map<String, ?> map) throws Exception {
            UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsFields self = new UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsFields();
            return TeaModel.build(map, self);
        }

        public UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsFields setComponentName(String componentName) {
            this.componentName = componentName;
            return this;
        }
        public String getComponentName() {
            return this.componentName;
        }

        public UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsFields setRelateProps(UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsFieldsRelateProps relateProps) {
            this.relateProps = relateProps;
            return this;
        }
        public UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsFieldsRelateProps getRelateProps() {
            return this.relateProps;
        }

    }

    public static class UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsOptions extends TeaModel {
        @NameInMap("key")
        public String key;

        @NameInMap("value")
        public String value;

        public static UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsOptions build(java.util.Map<String, ?> map) throws Exception {
            UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsOptions self = new UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsOptions();
            return TeaModel.build(map, self);
        }

        public UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsOptions setKey(String key) {
            this.key = key;
            return this;
        }
        public String getKey() {
            return this.key;
        }

        public UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsOptions setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

    }

    public static class UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsStatField extends TeaModel {
        @NameInMap("fieldId")
        public String fieldId;

        @NameInMap("label")
        public String label;

        @NameInMap("unit")
        public String unit;

        @NameInMap("upper")
        public Boolean upper;

        public static UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsStatField build(java.util.Map<String, ?> map) throws Exception {
            UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsStatField self = new UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsStatField();
            return TeaModel.build(map, self);
        }

        public UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsStatField setFieldId(String fieldId) {
            this.fieldId = fieldId;
            return this;
        }
        public String getFieldId() {
            return this.fieldId;
        }

        public UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsStatField setLabel(String label) {
            this.label = label;
            return this;
        }
        public String getLabel() {
            return this.label;
        }

        public UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsStatField setUnit(String unit) {
            this.unit = unit;
            return this;
        }
        public String getUnit() {
            return this.unit;
        }

        public UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsStatField setUpper(Boolean upper) {
            this.upper = upper;
            return this;
        }
        public Boolean getUpper() {
            return this.upper;
        }

    }

    public static class UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsProps extends TeaModel {
        @NameInMap("align")
        public String align;

        @NameInMap("bizAlias")
        public String bizAlias;

        @NameInMap("choice")
        public Long choice;

        @NameInMap("content")
        public String content;

        @NameInMap("dataSource")
        public UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsDataSource dataSource;

        @NameInMap("disabled")
        public Boolean disabled;

        @NameInMap("duration")
        public Boolean duration;

        @NameInMap("fields")
        public java.util.List<UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsFields> fields;

        @NameInMap("format")
        public String format;

        @NameInMap("formula")
        public String formula;

        @NameInMap("fieldId")
        public String fieldId;

        @NameInMap("invisible")
        public Boolean invisible;

        @NameInMap("label")
        public String label;

        @NameInMap("labelEditableFreeze")
        public Boolean labelEditableFreeze;

        @NameInMap("link")
        public String link;

        @NameInMap("notPrint")
        public String notPrint;

        @NameInMap("notUpper")
        public String notUpper;

        @NameInMap("options")
        public java.util.List<UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsOptions> options;

        @NameInMap("payEnable")
        public Boolean payEnable;

        @NameInMap("placeholder")
        public String placeholder;

        @NameInMap("required")
        public Boolean required;

        @NameInMap("requiredEditableFreeze")
        public Boolean requiredEditableFreeze;

        @NameInMap("statField")
        public java.util.List<UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsStatField> statField;

        @NameInMap("unit")
        public String unit;

        @NameInMap("verticalPrint")
        public Boolean verticalPrint;

        public static UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsProps build(java.util.Map<String, ?> map) throws Exception {
            UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsProps self = new UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsProps();
            return TeaModel.build(map, self);
        }

        public UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsProps setAlign(String align) {
            this.align = align;
            return this;
        }
        public String getAlign() {
            return this.align;
        }

        public UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsProps setBizAlias(String bizAlias) {
            this.bizAlias = bizAlias;
            return this;
        }
        public String getBizAlias() {
            return this.bizAlias;
        }

        public UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsProps setChoice(Long choice) {
            this.choice = choice;
            return this;
        }
        public Long getChoice() {
            return this.choice;
        }

        public UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsProps setContent(String content) {
            this.content = content;
            return this;
        }
        public String getContent() {
            return this.content;
        }

        public UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsProps setDataSource(UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsDataSource dataSource) {
            this.dataSource = dataSource;
            return this;
        }
        public UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsDataSource getDataSource() {
            return this.dataSource;
        }

        public UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsProps setDisabled(Boolean disabled) {
            this.disabled = disabled;
            return this;
        }
        public Boolean getDisabled() {
            return this.disabled;
        }

        public UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsProps setDuration(Boolean duration) {
            this.duration = duration;
            return this;
        }
        public Boolean getDuration() {
            return this.duration;
        }

        public UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsProps setFields(java.util.List<UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsFields> fields) {
            this.fields = fields;
            return this;
        }
        public java.util.List<UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsFields> getFields() {
            return this.fields;
        }

        public UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsProps setFormat(String format) {
            this.format = format;
            return this;
        }
        public String getFormat() {
            return this.format;
        }

        public UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsProps setFormula(String formula) {
            this.formula = formula;
            return this;
        }
        public String getFormula() {
            return this.formula;
        }

        public UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsProps setFieldId(String fieldId) {
            this.fieldId = fieldId;
            return this;
        }
        public String getFieldId() {
            return this.fieldId;
        }

        public UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsProps setInvisible(Boolean invisible) {
            this.invisible = invisible;
            return this;
        }
        public Boolean getInvisible() {
            return this.invisible;
        }

        public UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsProps setLabel(String label) {
            this.label = label;
            return this;
        }
        public String getLabel() {
            return this.label;
        }

        public UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsProps setLabelEditableFreeze(Boolean labelEditableFreeze) {
            this.labelEditableFreeze = labelEditableFreeze;
            return this;
        }
        public Boolean getLabelEditableFreeze() {
            return this.labelEditableFreeze;
        }

        public UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsProps setLink(String link) {
            this.link = link;
            return this;
        }
        public String getLink() {
            return this.link;
        }

        public UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsProps setNotPrint(String notPrint) {
            this.notPrint = notPrint;
            return this;
        }
        public String getNotPrint() {
            return this.notPrint;
        }

        public UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsProps setNotUpper(String notUpper) {
            this.notUpper = notUpper;
            return this;
        }
        public String getNotUpper() {
            return this.notUpper;
        }

        public UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsProps setOptions(java.util.List<UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsOptions> options) {
            this.options = options;
            return this;
        }
        public java.util.List<UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsOptions> getOptions() {
            return this.options;
        }

        public UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsProps setPayEnable(Boolean payEnable) {
            this.payEnable = payEnable;
            return this;
        }
        public Boolean getPayEnable() {
            return this.payEnable;
        }

        public UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsProps setPlaceholder(String placeholder) {
            this.placeholder = placeholder;
            return this;
        }
        public String getPlaceholder() {
            return this.placeholder;
        }

        public UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsProps setRequired(Boolean required) {
            this.required = required;
            return this;
        }
        public Boolean getRequired() {
            return this.required;
        }

        public UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsProps setRequiredEditableFreeze(Boolean requiredEditableFreeze) {
            this.requiredEditableFreeze = requiredEditableFreeze;
            return this;
        }
        public Boolean getRequiredEditableFreeze() {
            return this.requiredEditableFreeze;
        }

        public UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsProps setStatField(java.util.List<UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsStatField> statField) {
            this.statField = statField;
            return this;
        }
        public java.util.List<UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsStatField> getStatField() {
            return this.statField;
        }

        public UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsProps setUnit(String unit) {
            this.unit = unit;
            return this;
        }
        public String getUnit() {
            return this.unit;
        }

        public UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsProps setVerticalPrint(Boolean verticalPrint) {
            this.verticalPrint = verticalPrint;
            return this;
        }
        public Boolean getVerticalPrint() {
            return this.verticalPrint;
        }

    }

    public static class UpdateRelationMetaFieldResponseBodyRelationMetaDTOItems extends TeaModel {
        @NameInMap("children")
        public java.util.List<UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildren> children;

        @NameInMap("componentName")
        public String componentName;

        @NameInMap("props")
        public java.util.List<UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsProps> props;

        public static UpdateRelationMetaFieldResponseBodyRelationMetaDTOItems build(java.util.Map<String, ?> map) throws Exception {
            UpdateRelationMetaFieldResponseBodyRelationMetaDTOItems self = new UpdateRelationMetaFieldResponseBodyRelationMetaDTOItems();
            return TeaModel.build(map, self);
        }

        public UpdateRelationMetaFieldResponseBodyRelationMetaDTOItems setChildren(java.util.List<UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildren> children) {
            this.children = children;
            return this;
        }
        public java.util.List<UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildren> getChildren() {
            return this.children;
        }

        public UpdateRelationMetaFieldResponseBodyRelationMetaDTOItems setComponentName(String componentName) {
            this.componentName = componentName;
            return this;
        }
        public String getComponentName() {
            return this.componentName;
        }

        public UpdateRelationMetaFieldResponseBodyRelationMetaDTOItems setProps(java.util.List<UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsProps> props) {
            this.props = props;
            return this;
        }
        public java.util.List<UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsProps> getProps() {
            return this.props;
        }

    }

    public static class UpdateRelationMetaFieldResponseBodyRelationMetaDTO extends TeaModel {
        @NameInMap("desc")
        public String desc;

        @NameInMap("items")
        public java.util.List<UpdateRelationMetaFieldResponseBodyRelationMetaDTOItems> items;

        @NameInMap("name")
        public String name;

        @NameInMap("relationType")
        public String relationType;

        public static UpdateRelationMetaFieldResponseBodyRelationMetaDTO build(java.util.Map<String, ?> map) throws Exception {
            UpdateRelationMetaFieldResponseBodyRelationMetaDTO self = new UpdateRelationMetaFieldResponseBodyRelationMetaDTO();
            return TeaModel.build(map, self);
        }

        public UpdateRelationMetaFieldResponseBodyRelationMetaDTO setDesc(String desc) {
            this.desc = desc;
            return this;
        }
        public String getDesc() {
            return this.desc;
        }

        public UpdateRelationMetaFieldResponseBodyRelationMetaDTO setItems(java.util.List<UpdateRelationMetaFieldResponseBodyRelationMetaDTOItems> items) {
            this.items = items;
            return this;
        }
        public java.util.List<UpdateRelationMetaFieldResponseBodyRelationMetaDTOItems> getItems() {
            return this.items;
        }

        public UpdateRelationMetaFieldResponseBodyRelationMetaDTO setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public UpdateRelationMetaFieldResponseBodyRelationMetaDTO setRelationType(String relationType) {
            this.relationType = relationType;
            return this;
        }
        public String getRelationType() {
            return this.relationType;
        }

    }

}
