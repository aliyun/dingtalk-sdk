// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class AddMetaModelFieldRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("bizType")
    public String bizType;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("fieldDTOList")
    public java.util.List<AddMetaModelFieldRequestFieldDTOList> fieldDTOList;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("operatorUserId")
    public String operatorUserId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("tenant")
    public String tenant;

    public static AddMetaModelFieldRequest build(java.util.Map<String, ?> map) throws Exception {
        AddMetaModelFieldRequest self = new AddMetaModelFieldRequest();
        return TeaModel.build(map, self);
    }

    public AddMetaModelFieldRequest setBizType(String bizType) {
        this.bizType = bizType;
        return this;
    }
    public String getBizType() {
        return this.bizType;
    }

    public AddMetaModelFieldRequest setFieldDTOList(java.util.List<AddMetaModelFieldRequestFieldDTOList> fieldDTOList) {
        this.fieldDTOList = fieldDTOList;
        return this;
    }
    public java.util.List<AddMetaModelFieldRequestFieldDTOList> getFieldDTOList() {
        return this.fieldDTOList;
    }

    public AddMetaModelFieldRequest setOperatorUserId(String operatorUserId) {
        this.operatorUserId = operatorUserId;
        return this;
    }
    public String getOperatorUserId() {
        return this.operatorUserId;
    }

    public AddMetaModelFieldRequest setTenant(String tenant) {
        this.tenant = tenant;
        return this;
    }
    public String getTenant() {
        return this.tenant;
    }

    public static class AddMetaModelFieldRequestFieldDTOListPropsOptions extends TeaModel {
        @NameInMap("key")
        public String key;

        @NameInMap("value")
        public String value;

        public static AddMetaModelFieldRequestFieldDTOListPropsOptions build(java.util.Map<String, ?> map) throws Exception {
            AddMetaModelFieldRequestFieldDTOListPropsOptions self = new AddMetaModelFieldRequestFieldDTOListPropsOptions();
            return TeaModel.build(map, self);
        }

        public AddMetaModelFieldRequestFieldDTOListPropsOptions setKey(String key) {
            this.key = key;
            return this;
        }
        public String getKey() {
            return this.key;
        }

        public AddMetaModelFieldRequestFieldDTOListPropsOptions setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

    }

    public static class AddMetaModelFieldRequestFieldDTOListProps extends TeaModel {
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
        public java.util.List<AddMetaModelFieldRequestFieldDTOListPropsOptions> options;

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

        public static AddMetaModelFieldRequestFieldDTOListProps build(java.util.Map<String, ?> map) throws Exception {
            AddMetaModelFieldRequestFieldDTOListProps self = new AddMetaModelFieldRequestFieldDTOListProps();
            return TeaModel.build(map, self);
        }

        public AddMetaModelFieldRequestFieldDTOListProps setAlign(String align) {
            this.align = align;
            return this;
        }
        public String getAlign() {
            return this.align;
        }

        public AddMetaModelFieldRequestFieldDTOListProps setBizAlias(String bizAlias) {
            this.bizAlias = bizAlias;
            return this;
        }
        public String getBizAlias() {
            return this.bizAlias;
        }

        public AddMetaModelFieldRequestFieldDTOListProps setChoice(Long choice) {
            this.choice = choice;
            return this;
        }
        public Long getChoice() {
            return this.choice;
        }

        public AddMetaModelFieldRequestFieldDTOListProps setContent(String content) {
            this.content = content;
            return this;
        }
        public String getContent() {
            return this.content;
        }

        public AddMetaModelFieldRequestFieldDTOListProps setDisabled(Boolean disabled) {
            this.disabled = disabled;
            return this;
        }
        public Boolean getDisabled() {
            return this.disabled;
        }

        public AddMetaModelFieldRequestFieldDTOListProps setDuration(Boolean duration) {
            this.duration = duration;
            return this;
        }
        public Boolean getDuration() {
            return this.duration;
        }

        public AddMetaModelFieldRequestFieldDTOListProps setFieldId(String fieldId) {
            this.fieldId = fieldId;
            return this;
        }
        public String getFieldId() {
            return this.fieldId;
        }

        public AddMetaModelFieldRequestFieldDTOListProps setFormat(String format) {
            this.format = format;
            return this;
        }
        public String getFormat() {
            return this.format;
        }

        public AddMetaModelFieldRequestFieldDTOListProps setInvisible(Boolean invisible) {
            this.invisible = invisible;
            return this;
        }
        public Boolean getInvisible() {
            return this.invisible;
        }

        public AddMetaModelFieldRequestFieldDTOListProps setLabel(String label) {
            this.label = label;
            return this;
        }
        public String getLabel() {
            return this.label;
        }

        public AddMetaModelFieldRequestFieldDTOListProps setLabelEditableFreeze(Boolean labelEditableFreeze) {
            this.labelEditableFreeze = labelEditableFreeze;
            return this;
        }
        public Boolean getLabelEditableFreeze() {
            return this.labelEditableFreeze;
        }

        public AddMetaModelFieldRequestFieldDTOListProps setLink(String link) {
            this.link = link;
            return this;
        }
        public String getLink() {
            return this.link;
        }

        public AddMetaModelFieldRequestFieldDTOListProps setNeedDetail(String needDetail) {
            this.needDetail = needDetail;
            return this;
        }
        public String getNeedDetail() {
            return this.needDetail;
        }

        public AddMetaModelFieldRequestFieldDTOListProps setNotPrint(String notPrint) {
            this.notPrint = notPrint;
            return this;
        }
        public String getNotPrint() {
            return this.notPrint;
        }

        public AddMetaModelFieldRequestFieldDTOListProps setNotUpper(String notUpper) {
            this.notUpper = notUpper;
            return this;
        }
        public String getNotUpper() {
            return this.notUpper;
        }

        public AddMetaModelFieldRequestFieldDTOListProps setOptions(java.util.List<AddMetaModelFieldRequestFieldDTOListPropsOptions> options) {
            this.options = options;
            return this;
        }
        public java.util.List<AddMetaModelFieldRequestFieldDTOListPropsOptions> getOptions() {
            return this.options;
        }

        public AddMetaModelFieldRequestFieldDTOListProps setPayEnable(Boolean payEnable) {
            this.payEnable = payEnable;
            return this;
        }
        public Boolean getPayEnable() {
            return this.payEnable;
        }

        public AddMetaModelFieldRequestFieldDTOListProps setPlaceholder(String placeholder) {
            this.placeholder = placeholder;
            return this;
        }
        public String getPlaceholder() {
            return this.placeholder;
        }

        public AddMetaModelFieldRequestFieldDTOListProps setRequired(Boolean required) {
            this.required = required;
            return this;
        }
        public Boolean getRequired() {
            return this.required;
        }

        public AddMetaModelFieldRequestFieldDTOListProps setRequiredEditableFreeze(Boolean requiredEditableFreeze) {
            this.requiredEditableFreeze = requiredEditableFreeze;
            return this;
        }
        public Boolean getRequiredEditableFreeze() {
            return this.requiredEditableFreeze;
        }

        public AddMetaModelFieldRequestFieldDTOListProps setSortable(Boolean sortable) {
            this.sortable = sortable;
            return this;
        }
        public Boolean getSortable() {
            return this.sortable;
        }

        public AddMetaModelFieldRequestFieldDTOListProps setUnit(String unit) {
            this.unit = unit;
            return this;
        }
        public String getUnit() {
            return this.unit;
        }

    }

    public static class AddMetaModelFieldRequestFieldDTOList extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("componentName")
        public String componentName;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("props")
        public AddMetaModelFieldRequestFieldDTOListProps props;

        public static AddMetaModelFieldRequestFieldDTOList build(java.util.Map<String, ?> map) throws Exception {
            AddMetaModelFieldRequestFieldDTOList self = new AddMetaModelFieldRequestFieldDTOList();
            return TeaModel.build(map, self);
        }

        public AddMetaModelFieldRequestFieldDTOList setComponentName(String componentName) {
            this.componentName = componentName;
            return this;
        }
        public String getComponentName() {
            return this.componentName;
        }

        public AddMetaModelFieldRequestFieldDTOList setProps(AddMetaModelFieldRequestFieldDTOListProps props) {
            this.props = props;
            return this;
        }
        public AddMetaModelFieldRequestFieldDTOListProps getProps() {
            return this.props;
        }

    }

}
