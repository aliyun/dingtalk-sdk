// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class CreateRelationMetaRequest extends TeaModel {
    @NameInMap("tenant")
    public String tenant;

    @NameInMap("operatorUserId")
    public String operatorUserId;

    @NameInMap("relationMetaDTO")
    public CreateRelationMetaRequestRelationMetaDTO relationMetaDTO;

    public static CreateRelationMetaRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateRelationMetaRequest self = new CreateRelationMetaRequest();
        return TeaModel.build(map, self);
    }

    public CreateRelationMetaRequest setTenant(String tenant) {
        this.tenant = tenant;
        return this;
    }
    public String getTenant() {
        return this.tenant;
    }

    public CreateRelationMetaRequest setOperatorUserId(String operatorUserId) {
        this.operatorUserId = operatorUserId;
        return this;
    }
    public String getOperatorUserId() {
        return this.operatorUserId;
    }

    public CreateRelationMetaRequest setRelationMetaDTO(CreateRelationMetaRequestRelationMetaDTO relationMetaDTO) {
        this.relationMetaDTO = relationMetaDTO;
        return this;
    }
    public CreateRelationMetaRequestRelationMetaDTO getRelationMetaDTO() {
        return this.relationMetaDTO;
    }

    public static class CreateRelationMetaRequestRelationMetaDTOItemsPropsOptions extends TeaModel {
        @NameInMap("key")
        public String key;

        @NameInMap("value")
        public String value;

        public static CreateRelationMetaRequestRelationMetaDTOItemsPropsOptions build(java.util.Map<String, ?> map) throws Exception {
            CreateRelationMetaRequestRelationMetaDTOItemsPropsOptions self = new CreateRelationMetaRequestRelationMetaDTOItemsPropsOptions();
            return TeaModel.build(map, self);
        }

        public CreateRelationMetaRequestRelationMetaDTOItemsPropsOptions setKey(String key) {
            this.key = key;
            return this;
        }
        public String getKey() {
            return this.key;
        }

        public CreateRelationMetaRequestRelationMetaDTOItemsPropsOptions setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

    }

    public static class CreateRelationMetaRequestRelationMetaDTOItemsProps extends TeaModel {
        @NameInMap("fieldId")
        public String fieldId;

        @NameInMap("label")
        public String label;

        @NameInMap("sortable")
        public Boolean sortable;

        @NameInMap("needDetail")
        public String needDetail;

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
        public java.util.List<CreateRelationMetaRequestRelationMetaDTOItemsPropsOptions> options;

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

        @NameInMap("link")
        public String link;

        public static CreateRelationMetaRequestRelationMetaDTOItemsProps build(java.util.Map<String, ?> map) throws Exception {
            CreateRelationMetaRequestRelationMetaDTOItemsProps self = new CreateRelationMetaRequestRelationMetaDTOItemsProps();
            return TeaModel.build(map, self);
        }

        public CreateRelationMetaRequestRelationMetaDTOItemsProps setFieldId(String fieldId) {
            this.fieldId = fieldId;
            return this;
        }
        public String getFieldId() {
            return this.fieldId;
        }

        public CreateRelationMetaRequestRelationMetaDTOItemsProps setLabel(String label) {
            this.label = label;
            return this;
        }
        public String getLabel() {
            return this.label;
        }

        public CreateRelationMetaRequestRelationMetaDTOItemsProps setSortable(Boolean sortable) {
            this.sortable = sortable;
            return this;
        }
        public Boolean getSortable() {
            return this.sortable;
        }

        public CreateRelationMetaRequestRelationMetaDTOItemsProps setNeedDetail(String needDetail) {
            this.needDetail = needDetail;
            return this;
        }
        public String getNeedDetail() {
            return this.needDetail;
        }

        public CreateRelationMetaRequestRelationMetaDTOItemsProps setLabelEditableFreeze(Boolean labelEditableFreeze) {
            this.labelEditableFreeze = labelEditableFreeze;
            return this;
        }
        public Boolean getLabelEditableFreeze() {
            return this.labelEditableFreeze;
        }

        public CreateRelationMetaRequestRelationMetaDTOItemsProps setRequired(Boolean required) {
            this.required = required;
            return this;
        }
        public Boolean getRequired() {
            return this.required;
        }

        public CreateRelationMetaRequestRelationMetaDTOItemsProps setRequiredEditableFreeze(Boolean requiredEditableFreeze) {
            this.requiredEditableFreeze = requiredEditableFreeze;
            return this;
        }
        public Boolean getRequiredEditableFreeze() {
            return this.requiredEditableFreeze;
        }

        public CreateRelationMetaRequestRelationMetaDTOItemsProps setNotPrint(String notPrint) {
            this.notPrint = notPrint;
            return this;
        }
        public String getNotPrint() {
            return this.notPrint;
        }

        public CreateRelationMetaRequestRelationMetaDTOItemsProps setContent(String content) {
            this.content = content;
            return this;
        }
        public String getContent() {
            return this.content;
        }

        public CreateRelationMetaRequestRelationMetaDTOItemsProps setFormat(String format) {
            this.format = format;
            return this;
        }
        public String getFormat() {
            return this.format;
        }

        public CreateRelationMetaRequestRelationMetaDTOItemsProps setOptions(java.util.List<CreateRelationMetaRequestRelationMetaDTOItemsPropsOptions> options) {
            this.options = options;
            return this;
        }
        public java.util.List<CreateRelationMetaRequestRelationMetaDTOItemsPropsOptions> getOptions() {
            return this.options;
        }

        public CreateRelationMetaRequestRelationMetaDTOItemsProps setNotUpper(String notUpper) {
            this.notUpper = notUpper;
            return this;
        }
        public String getNotUpper() {
            return this.notUpper;
        }

        public CreateRelationMetaRequestRelationMetaDTOItemsProps setUnit(String unit) {
            this.unit = unit;
            return this;
        }
        public String getUnit() {
            return this.unit;
        }

        public CreateRelationMetaRequestRelationMetaDTOItemsProps setPlaceholder(String placeholder) {
            this.placeholder = placeholder;
            return this;
        }
        public String getPlaceholder() {
            return this.placeholder;
        }

        public CreateRelationMetaRequestRelationMetaDTOItemsProps setBizAlias(String bizAlias) {
            this.bizAlias = bizAlias;
            return this;
        }
        public String getBizAlias() {
            return this.bizAlias;
        }

        public CreateRelationMetaRequestRelationMetaDTOItemsProps setDuration(Boolean duration) {
            this.duration = duration;
            return this;
        }
        public Boolean getDuration() {
            return this.duration;
        }

        public CreateRelationMetaRequestRelationMetaDTOItemsProps setChoice(Long choice) {
            this.choice = choice;
            return this;
        }
        public Long getChoice() {
            return this.choice;
        }

        public CreateRelationMetaRequestRelationMetaDTOItemsProps setDisabled(Boolean disabled) {
            this.disabled = disabled;
            return this;
        }
        public Boolean getDisabled() {
            return this.disabled;
        }

        public CreateRelationMetaRequestRelationMetaDTOItemsProps setAlign(String align) {
            this.align = align;
            return this;
        }
        public String getAlign() {
            return this.align;
        }

        public CreateRelationMetaRequestRelationMetaDTOItemsProps setInvisible(Boolean invisible) {
            this.invisible = invisible;
            return this;
        }
        public Boolean getInvisible() {
            return this.invisible;
        }

        public CreateRelationMetaRequestRelationMetaDTOItemsProps setPayEnable(Boolean payEnable) {
            this.payEnable = payEnable;
            return this;
        }
        public Boolean getPayEnable() {
            return this.payEnable;
        }

        public CreateRelationMetaRequestRelationMetaDTOItemsProps setLink(String link) {
            this.link = link;
            return this;
        }
        public String getLink() {
            return this.link;
        }

    }

    public static class CreateRelationMetaRequestRelationMetaDTOItems extends TeaModel {
        @NameInMap("componentName")
        public String componentName;

        @NameInMap("props")
        public CreateRelationMetaRequestRelationMetaDTOItemsProps props;

        public static CreateRelationMetaRequestRelationMetaDTOItems build(java.util.Map<String, ?> map) throws Exception {
            CreateRelationMetaRequestRelationMetaDTOItems self = new CreateRelationMetaRequestRelationMetaDTOItems();
            return TeaModel.build(map, self);
        }

        public CreateRelationMetaRequestRelationMetaDTOItems setComponentName(String componentName) {
            this.componentName = componentName;
            return this;
        }
        public String getComponentName() {
            return this.componentName;
        }

        public CreateRelationMetaRequestRelationMetaDTOItems setProps(CreateRelationMetaRequestRelationMetaDTOItemsProps props) {
            this.props = props;
            return this;
        }
        public CreateRelationMetaRequestRelationMetaDTOItemsProps getProps() {
            return this.props;
        }

    }

    public static class CreateRelationMetaRequestRelationMetaDTO extends TeaModel {
        @NameInMap("relationType")
        public String relationType;

        @NameInMap("name")
        public String name;

        @NameInMap("desc")
        public String desc;

        @NameInMap("items")
        public java.util.List<CreateRelationMetaRequestRelationMetaDTOItems> items;

        public static CreateRelationMetaRequestRelationMetaDTO build(java.util.Map<String, ?> map) throws Exception {
            CreateRelationMetaRequestRelationMetaDTO self = new CreateRelationMetaRequestRelationMetaDTO();
            return TeaModel.build(map, self);
        }

        public CreateRelationMetaRequestRelationMetaDTO setRelationType(String relationType) {
            this.relationType = relationType;
            return this;
        }
        public String getRelationType() {
            return this.relationType;
        }

        public CreateRelationMetaRequestRelationMetaDTO setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public CreateRelationMetaRequestRelationMetaDTO setDesc(String desc) {
            this.desc = desc;
            return this;
        }
        public String getDesc() {
            return this.desc;
        }

        public CreateRelationMetaRequestRelationMetaDTO setItems(java.util.List<CreateRelationMetaRequestRelationMetaDTOItems> items) {
            this.items = items;
            return this;
        }
        public java.util.List<CreateRelationMetaRequestRelationMetaDTOItems> getItems() {
            return this.items;
        }

    }

}