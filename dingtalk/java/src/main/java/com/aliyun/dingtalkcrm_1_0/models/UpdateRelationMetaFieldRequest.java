// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class UpdateRelationMetaFieldRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("fieldDTOList")
    public java.util.List<UpdateRelationMetaFieldRequestFieldDTOList> fieldDTOList;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("operatorUserId")
    public String operatorUserId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("relationType")
    public String relationType;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("tenant")
    public String tenant;

    public static UpdateRelationMetaFieldRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateRelationMetaFieldRequest self = new UpdateRelationMetaFieldRequest();
        return TeaModel.build(map, self);
    }

    public UpdateRelationMetaFieldRequest setFieldDTOList(java.util.List<UpdateRelationMetaFieldRequestFieldDTOList> fieldDTOList) {
        this.fieldDTOList = fieldDTOList;
        return this;
    }
    public java.util.List<UpdateRelationMetaFieldRequestFieldDTOList> getFieldDTOList() {
        return this.fieldDTOList;
    }

    public UpdateRelationMetaFieldRequest setOperatorUserId(String operatorUserId) {
        this.operatorUserId = operatorUserId;
        return this;
    }
    public String getOperatorUserId() {
        return this.operatorUserId;
    }

    public UpdateRelationMetaFieldRequest setRelationType(String relationType) {
        this.relationType = relationType;
        return this;
    }
    public String getRelationType() {
        return this.relationType;
    }

    public UpdateRelationMetaFieldRequest setTenant(String tenant) {
        this.tenant = tenant;
        return this;
    }
    public String getTenant() {
        return this.tenant;
    }

    public static class UpdateRelationMetaFieldRequestFieldDTOListPropsOptions extends TeaModel {
        @NameInMap("key")
        public String key;

        @NameInMap("value")
        public String value;

        public static UpdateRelationMetaFieldRequestFieldDTOListPropsOptions build(java.util.Map<String, ?> map) throws Exception {
            UpdateRelationMetaFieldRequestFieldDTOListPropsOptions self = new UpdateRelationMetaFieldRequestFieldDTOListPropsOptions();
            return TeaModel.build(map, self);
        }

        public UpdateRelationMetaFieldRequestFieldDTOListPropsOptions setKey(String key) {
            this.key = key;
            return this;
        }
        public String getKey() {
            return this.key;
        }

        public UpdateRelationMetaFieldRequestFieldDTOListPropsOptions setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

    }

    public static class UpdateRelationMetaFieldRequestFieldDTOListProps extends TeaModel {
        @NameInMap("align")
        public String align;

        /**
         * <p>This parameter is required.</p>
         */
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

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("fieldId")
        public String fieldId;

        @NameInMap("format")
        public String format;

        @NameInMap("invisible")
        public Boolean invisible;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("label")
        public String label;

        @NameInMap("labelEditableFreeze")
        public Boolean labelEditableFreeze;

        @NameInMap("link")
        public String link;

        @NameInMap("needDetail")
        public String needDetail;

        @NameInMap("notPrint")
        public String notPrint;

        @NameInMap("notUpper")
        public String notUpper;

        @NameInMap("options")
        public java.util.List<UpdateRelationMetaFieldRequestFieldDTOListPropsOptions> options;

        @NameInMap("payEnable")
        public Boolean payEnable;

        @NameInMap("placeholder")
        public String placeholder;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("required")
        public Boolean required;

        @NameInMap("requiredEditableFreeze")
        public Boolean requiredEditableFreeze;

        @NameInMap("sortable")
        public Boolean sortable;

        @NameInMap("unit")
        public String unit;

        public static UpdateRelationMetaFieldRequestFieldDTOListProps build(java.util.Map<String, ?> map) throws Exception {
            UpdateRelationMetaFieldRequestFieldDTOListProps self = new UpdateRelationMetaFieldRequestFieldDTOListProps();
            return TeaModel.build(map, self);
        }

        public UpdateRelationMetaFieldRequestFieldDTOListProps setAlign(String align) {
            this.align = align;
            return this;
        }
        public String getAlign() {
            return this.align;
        }

        public UpdateRelationMetaFieldRequestFieldDTOListProps setBizAlias(String bizAlias) {
            this.bizAlias = bizAlias;
            return this;
        }
        public String getBizAlias() {
            return this.bizAlias;
        }

        public UpdateRelationMetaFieldRequestFieldDTOListProps setChoice(Long choice) {
            this.choice = choice;
            return this;
        }
        public Long getChoice() {
            return this.choice;
        }

        public UpdateRelationMetaFieldRequestFieldDTOListProps setContent(String content) {
            this.content = content;
            return this;
        }
        public String getContent() {
            return this.content;
        }

        public UpdateRelationMetaFieldRequestFieldDTOListProps setDisabled(Boolean disabled) {
            this.disabled = disabled;
            return this;
        }
        public Boolean getDisabled() {
            return this.disabled;
        }

        public UpdateRelationMetaFieldRequestFieldDTOListProps setDuration(Boolean duration) {
            this.duration = duration;
            return this;
        }
        public Boolean getDuration() {
            return this.duration;
        }

        public UpdateRelationMetaFieldRequestFieldDTOListProps setFieldId(String fieldId) {
            this.fieldId = fieldId;
            return this;
        }
        public String getFieldId() {
            return this.fieldId;
        }

        public UpdateRelationMetaFieldRequestFieldDTOListProps setFormat(String format) {
            this.format = format;
            return this;
        }
        public String getFormat() {
            return this.format;
        }

        public UpdateRelationMetaFieldRequestFieldDTOListProps setInvisible(Boolean invisible) {
            this.invisible = invisible;
            return this;
        }
        public Boolean getInvisible() {
            return this.invisible;
        }

        public UpdateRelationMetaFieldRequestFieldDTOListProps setLabel(String label) {
            this.label = label;
            return this;
        }
        public String getLabel() {
            return this.label;
        }

        public UpdateRelationMetaFieldRequestFieldDTOListProps setLabelEditableFreeze(Boolean labelEditableFreeze) {
            this.labelEditableFreeze = labelEditableFreeze;
            return this;
        }
        public Boolean getLabelEditableFreeze() {
            return this.labelEditableFreeze;
        }

        public UpdateRelationMetaFieldRequestFieldDTOListProps setLink(String link) {
            this.link = link;
            return this;
        }
        public String getLink() {
            return this.link;
        }

        public UpdateRelationMetaFieldRequestFieldDTOListProps setNeedDetail(String needDetail) {
            this.needDetail = needDetail;
            return this;
        }
        public String getNeedDetail() {
            return this.needDetail;
        }

        public UpdateRelationMetaFieldRequestFieldDTOListProps setNotPrint(String notPrint) {
            this.notPrint = notPrint;
            return this;
        }
        public String getNotPrint() {
            return this.notPrint;
        }

        public UpdateRelationMetaFieldRequestFieldDTOListProps setNotUpper(String notUpper) {
            this.notUpper = notUpper;
            return this;
        }
        public String getNotUpper() {
            return this.notUpper;
        }

        public UpdateRelationMetaFieldRequestFieldDTOListProps setOptions(java.util.List<UpdateRelationMetaFieldRequestFieldDTOListPropsOptions> options) {
            this.options = options;
            return this;
        }
        public java.util.List<UpdateRelationMetaFieldRequestFieldDTOListPropsOptions> getOptions() {
            return this.options;
        }

        public UpdateRelationMetaFieldRequestFieldDTOListProps setPayEnable(Boolean payEnable) {
            this.payEnable = payEnable;
            return this;
        }
        public Boolean getPayEnable() {
            return this.payEnable;
        }

        public UpdateRelationMetaFieldRequestFieldDTOListProps setPlaceholder(String placeholder) {
            this.placeholder = placeholder;
            return this;
        }
        public String getPlaceholder() {
            return this.placeholder;
        }

        public UpdateRelationMetaFieldRequestFieldDTOListProps setRequired(Boolean required) {
            this.required = required;
            return this;
        }
        public Boolean getRequired() {
            return this.required;
        }

        public UpdateRelationMetaFieldRequestFieldDTOListProps setRequiredEditableFreeze(Boolean requiredEditableFreeze) {
            this.requiredEditableFreeze = requiredEditableFreeze;
            return this;
        }
        public Boolean getRequiredEditableFreeze() {
            return this.requiredEditableFreeze;
        }

        public UpdateRelationMetaFieldRequestFieldDTOListProps setSortable(Boolean sortable) {
            this.sortable = sortable;
            return this;
        }
        public Boolean getSortable() {
            return this.sortable;
        }

        public UpdateRelationMetaFieldRequestFieldDTOListProps setUnit(String unit) {
            this.unit = unit;
            return this;
        }
        public String getUnit() {
            return this.unit;
        }

    }

    public static class UpdateRelationMetaFieldRequestFieldDTOList extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("componentName")
        public String componentName;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("props")
        public UpdateRelationMetaFieldRequestFieldDTOListProps props;

        public static UpdateRelationMetaFieldRequestFieldDTOList build(java.util.Map<String, ?> map) throws Exception {
            UpdateRelationMetaFieldRequestFieldDTOList self = new UpdateRelationMetaFieldRequestFieldDTOList();
            return TeaModel.build(map, self);
        }

        public UpdateRelationMetaFieldRequestFieldDTOList setComponentName(String componentName) {
            this.componentName = componentName;
            return this;
        }
        public String getComponentName() {
            return this.componentName;
        }

        public UpdateRelationMetaFieldRequestFieldDTOList setProps(UpdateRelationMetaFieldRequestFieldDTOListProps props) {
            this.props = props;
            return this;
        }
        public UpdateRelationMetaFieldRequestFieldDTOListProps getProps() {
            return this.props;
        }

    }

}
