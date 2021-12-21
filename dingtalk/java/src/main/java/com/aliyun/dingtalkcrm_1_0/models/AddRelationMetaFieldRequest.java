// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class AddRelationMetaFieldRequest extends TeaModel {
    @NameInMap("tenant")
    public String tenant;

    @NameInMap("operatorUserId")
    public String operatorUserId;

    @NameInMap("relationType")
    public String relationType;

    @NameInMap("fieldDTOList")
    public java.util.List<AddRelationMetaFieldRequestFieldDTOList> fieldDTOList;

    public static AddRelationMetaFieldRequest build(java.util.Map<String, ?> map) throws Exception {
        AddRelationMetaFieldRequest self = new AddRelationMetaFieldRequest();
        return TeaModel.build(map, self);
    }

    public AddRelationMetaFieldRequest setTenant(String tenant) {
        this.tenant = tenant;
        return this;
    }
    public String getTenant() {
        return this.tenant;
    }

    public AddRelationMetaFieldRequest setOperatorUserId(String operatorUserId) {
        this.operatorUserId = operatorUserId;
        return this;
    }
    public String getOperatorUserId() {
        return this.operatorUserId;
    }

    public AddRelationMetaFieldRequest setRelationType(String relationType) {
        this.relationType = relationType;
        return this;
    }
    public String getRelationType() {
        return this.relationType;
    }

    public AddRelationMetaFieldRequest setFieldDTOList(java.util.List<AddRelationMetaFieldRequestFieldDTOList> fieldDTOList) {
        this.fieldDTOList = fieldDTOList;
        return this;
    }
    public java.util.List<AddRelationMetaFieldRequestFieldDTOList> getFieldDTOList() {
        return this.fieldDTOList;
    }

    public static class AddRelationMetaFieldRequestFieldDTOListPropsOptions extends TeaModel {
        @NameInMap("key")
        public String key;

        @NameInMap("value")
        public String value;

        public static AddRelationMetaFieldRequestFieldDTOListPropsOptions build(java.util.Map<String, ?> map) throws Exception {
            AddRelationMetaFieldRequestFieldDTOListPropsOptions self = new AddRelationMetaFieldRequestFieldDTOListPropsOptions();
            return TeaModel.build(map, self);
        }

        public AddRelationMetaFieldRequestFieldDTOListPropsOptions setKey(String key) {
            this.key = key;
            return this;
        }
        public String getKey() {
            return this.key;
        }

        public AddRelationMetaFieldRequestFieldDTOListPropsOptions setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

    }

    public static class AddRelationMetaFieldRequestFieldDTOListProps extends TeaModel {
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
        public java.util.List<AddRelationMetaFieldRequestFieldDTOListPropsOptions> options;

        @NameInMap("notUpper")
        public String notUpper;

        @NameInMap("unit")
        public String unit;

        @NameInMap("needDetail")
        public String needDetail;

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

        public static AddRelationMetaFieldRequestFieldDTOListProps build(java.util.Map<String, ?> map) throws Exception {
            AddRelationMetaFieldRequestFieldDTOListProps self = new AddRelationMetaFieldRequestFieldDTOListProps();
            return TeaModel.build(map, self);
        }

        public AddRelationMetaFieldRequestFieldDTOListProps setFieldId(String fieldId) {
            this.fieldId = fieldId;
            return this;
        }
        public String getFieldId() {
            return this.fieldId;
        }

        public AddRelationMetaFieldRequestFieldDTOListProps setLabel(String label) {
            this.label = label;
            return this;
        }
        public String getLabel() {
            return this.label;
        }

        public AddRelationMetaFieldRequestFieldDTOListProps setSortable(Boolean sortable) {
            this.sortable = sortable;
            return this;
        }
        public Boolean getSortable() {
            return this.sortable;
        }

        public AddRelationMetaFieldRequestFieldDTOListProps setLabelEditableFreeze(Boolean labelEditableFreeze) {
            this.labelEditableFreeze = labelEditableFreeze;
            return this;
        }
        public Boolean getLabelEditableFreeze() {
            return this.labelEditableFreeze;
        }

        public AddRelationMetaFieldRequestFieldDTOListProps setRequired(Boolean required) {
            this.required = required;
            return this;
        }
        public Boolean getRequired() {
            return this.required;
        }

        public AddRelationMetaFieldRequestFieldDTOListProps setRequiredEditableFreeze(Boolean requiredEditableFreeze) {
            this.requiredEditableFreeze = requiredEditableFreeze;
            return this;
        }
        public Boolean getRequiredEditableFreeze() {
            return this.requiredEditableFreeze;
        }

        public AddRelationMetaFieldRequestFieldDTOListProps setNotPrint(String notPrint) {
            this.notPrint = notPrint;
            return this;
        }
        public String getNotPrint() {
            return this.notPrint;
        }

        public AddRelationMetaFieldRequestFieldDTOListProps setContent(String content) {
            this.content = content;
            return this;
        }
        public String getContent() {
            return this.content;
        }

        public AddRelationMetaFieldRequestFieldDTOListProps setFormat(String format) {
            this.format = format;
            return this;
        }
        public String getFormat() {
            return this.format;
        }

        public AddRelationMetaFieldRequestFieldDTOListProps setOptions(java.util.List<AddRelationMetaFieldRequestFieldDTOListPropsOptions> options) {
            this.options = options;
            return this;
        }
        public java.util.List<AddRelationMetaFieldRequestFieldDTOListPropsOptions> getOptions() {
            return this.options;
        }

        public AddRelationMetaFieldRequestFieldDTOListProps setNotUpper(String notUpper) {
            this.notUpper = notUpper;
            return this;
        }
        public String getNotUpper() {
            return this.notUpper;
        }

        public AddRelationMetaFieldRequestFieldDTOListProps setUnit(String unit) {
            this.unit = unit;
            return this;
        }
        public String getUnit() {
            return this.unit;
        }

        public AddRelationMetaFieldRequestFieldDTOListProps setNeedDetail(String needDetail) {
            this.needDetail = needDetail;
            return this;
        }
        public String getNeedDetail() {
            return this.needDetail;
        }

        public AddRelationMetaFieldRequestFieldDTOListProps setPlaceholder(String placeholder) {
            this.placeholder = placeholder;
            return this;
        }
        public String getPlaceholder() {
            return this.placeholder;
        }

        public AddRelationMetaFieldRequestFieldDTOListProps setBizAlias(String bizAlias) {
            this.bizAlias = bizAlias;
            return this;
        }
        public String getBizAlias() {
            return this.bizAlias;
        }

        public AddRelationMetaFieldRequestFieldDTOListProps setDuration(Boolean duration) {
            this.duration = duration;
            return this;
        }
        public Boolean getDuration() {
            return this.duration;
        }

        public AddRelationMetaFieldRequestFieldDTOListProps setChoice(Long choice) {
            this.choice = choice;
            return this;
        }
        public Long getChoice() {
            return this.choice;
        }

        public AddRelationMetaFieldRequestFieldDTOListProps setDisabled(Boolean disabled) {
            this.disabled = disabled;
            return this;
        }
        public Boolean getDisabled() {
            return this.disabled;
        }

        public AddRelationMetaFieldRequestFieldDTOListProps setAlign(String align) {
            this.align = align;
            return this;
        }
        public String getAlign() {
            return this.align;
        }

        public AddRelationMetaFieldRequestFieldDTOListProps setInvisible(Boolean invisible) {
            this.invisible = invisible;
            return this;
        }
        public Boolean getInvisible() {
            return this.invisible;
        }

        public AddRelationMetaFieldRequestFieldDTOListProps setPayEnable(Boolean payEnable) {
            this.payEnable = payEnable;
            return this;
        }
        public Boolean getPayEnable() {
            return this.payEnable;
        }

        public AddRelationMetaFieldRequestFieldDTOListProps setLink(String link) {
            this.link = link;
            return this;
        }
        public String getLink() {
            return this.link;
        }

    }

    public static class AddRelationMetaFieldRequestFieldDTOList extends TeaModel {
        @NameInMap("componentName")
        public String componentName;

        @NameInMap("props")
        public AddRelationMetaFieldRequestFieldDTOListProps props;

        public static AddRelationMetaFieldRequestFieldDTOList build(java.util.Map<String, ?> map) throws Exception {
            AddRelationMetaFieldRequestFieldDTOList self = new AddRelationMetaFieldRequestFieldDTOList();
            return TeaModel.build(map, self);
        }

        public AddRelationMetaFieldRequestFieldDTOList setComponentName(String componentName) {
            this.componentName = componentName;
            return this;
        }
        public String getComponentName() {
            return this.componentName;
        }

        public AddRelationMetaFieldRequestFieldDTOList setProps(AddRelationMetaFieldRequestFieldDTOListProps props) {
            this.props = props;
            return this;
        }
        public AddRelationMetaFieldRequestFieldDTOListProps getProps() {
            return this.props;
        }

    }

}
