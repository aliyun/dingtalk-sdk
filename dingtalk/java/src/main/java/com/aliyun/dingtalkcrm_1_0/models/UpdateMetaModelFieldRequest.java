// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class UpdateMetaModelFieldRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("bizType")
    public String bizType;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("fieldDTOList")
    public java.util.List<UpdateMetaModelFieldRequestFieldDTOList> fieldDTOList;

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

    public static UpdateMetaModelFieldRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateMetaModelFieldRequest self = new UpdateMetaModelFieldRequest();
        return TeaModel.build(map, self);
    }

    public UpdateMetaModelFieldRequest setBizType(String bizType) {
        this.bizType = bizType;
        return this;
    }
    public String getBizType() {
        return this.bizType;
    }

    public UpdateMetaModelFieldRequest setFieldDTOList(java.util.List<UpdateMetaModelFieldRequestFieldDTOList> fieldDTOList) {
        this.fieldDTOList = fieldDTOList;
        return this;
    }
    public java.util.List<UpdateMetaModelFieldRequestFieldDTOList> getFieldDTOList() {
        return this.fieldDTOList;
    }

    public UpdateMetaModelFieldRequest setOperatorUserId(String operatorUserId) {
        this.operatorUserId = operatorUserId;
        return this;
    }
    public String getOperatorUserId() {
        return this.operatorUserId;
    }

    public UpdateMetaModelFieldRequest setTenant(String tenant) {
        this.tenant = tenant;
        return this;
    }
    public String getTenant() {
        return this.tenant;
    }

    public static class UpdateMetaModelFieldRequestFieldDTOListPropsOptions extends TeaModel {
        @NameInMap("key")
        public String key;

        @NameInMap("value")
        public String value;

        public static UpdateMetaModelFieldRequestFieldDTOListPropsOptions build(java.util.Map<String, ?> map) throws Exception {
            UpdateMetaModelFieldRequestFieldDTOListPropsOptions self = new UpdateMetaModelFieldRequestFieldDTOListPropsOptions();
            return TeaModel.build(map, self);
        }

        public UpdateMetaModelFieldRequestFieldDTOListPropsOptions setKey(String key) {
            this.key = key;
            return this;
        }
        public String getKey() {
            return this.key;
        }

        public UpdateMetaModelFieldRequestFieldDTOListPropsOptions setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

    }

    public static class UpdateMetaModelFieldRequestFieldDTOListProps extends TeaModel {
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
        public java.util.List<UpdateMetaModelFieldRequestFieldDTOListPropsOptions> options;

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

        public static UpdateMetaModelFieldRequestFieldDTOListProps build(java.util.Map<String, ?> map) throws Exception {
            UpdateMetaModelFieldRequestFieldDTOListProps self = new UpdateMetaModelFieldRequestFieldDTOListProps();
            return TeaModel.build(map, self);
        }

        public UpdateMetaModelFieldRequestFieldDTOListProps setAlign(String align) {
            this.align = align;
            return this;
        }
        public String getAlign() {
            return this.align;
        }

        public UpdateMetaModelFieldRequestFieldDTOListProps setBizAlias(String bizAlias) {
            this.bizAlias = bizAlias;
            return this;
        }
        public String getBizAlias() {
            return this.bizAlias;
        }

        public UpdateMetaModelFieldRequestFieldDTOListProps setChoice(Long choice) {
            this.choice = choice;
            return this;
        }
        public Long getChoice() {
            return this.choice;
        }

        public UpdateMetaModelFieldRequestFieldDTOListProps setContent(String content) {
            this.content = content;
            return this;
        }
        public String getContent() {
            return this.content;
        }

        public UpdateMetaModelFieldRequestFieldDTOListProps setDisabled(Boolean disabled) {
            this.disabled = disabled;
            return this;
        }
        public Boolean getDisabled() {
            return this.disabled;
        }

        public UpdateMetaModelFieldRequestFieldDTOListProps setDuration(Boolean duration) {
            this.duration = duration;
            return this;
        }
        public Boolean getDuration() {
            return this.duration;
        }

        public UpdateMetaModelFieldRequestFieldDTOListProps setFieldId(String fieldId) {
            this.fieldId = fieldId;
            return this;
        }
        public String getFieldId() {
            return this.fieldId;
        }

        public UpdateMetaModelFieldRequestFieldDTOListProps setFormat(String format) {
            this.format = format;
            return this;
        }
        public String getFormat() {
            return this.format;
        }

        public UpdateMetaModelFieldRequestFieldDTOListProps setInvisible(Boolean invisible) {
            this.invisible = invisible;
            return this;
        }
        public Boolean getInvisible() {
            return this.invisible;
        }

        public UpdateMetaModelFieldRequestFieldDTOListProps setLabel(String label) {
            this.label = label;
            return this;
        }
        public String getLabel() {
            return this.label;
        }

        public UpdateMetaModelFieldRequestFieldDTOListProps setLabelEditableFreeze(Boolean labelEditableFreeze) {
            this.labelEditableFreeze = labelEditableFreeze;
            return this;
        }
        public Boolean getLabelEditableFreeze() {
            return this.labelEditableFreeze;
        }

        public UpdateMetaModelFieldRequestFieldDTOListProps setLink(String link) {
            this.link = link;
            return this;
        }
        public String getLink() {
            return this.link;
        }

        public UpdateMetaModelFieldRequestFieldDTOListProps setNeedDetail(String needDetail) {
            this.needDetail = needDetail;
            return this;
        }
        public String getNeedDetail() {
            return this.needDetail;
        }

        public UpdateMetaModelFieldRequestFieldDTOListProps setNotPrint(String notPrint) {
            this.notPrint = notPrint;
            return this;
        }
        public String getNotPrint() {
            return this.notPrint;
        }

        public UpdateMetaModelFieldRequestFieldDTOListProps setNotUpper(String notUpper) {
            this.notUpper = notUpper;
            return this;
        }
        public String getNotUpper() {
            return this.notUpper;
        }

        public UpdateMetaModelFieldRequestFieldDTOListProps setOptions(java.util.List<UpdateMetaModelFieldRequestFieldDTOListPropsOptions> options) {
            this.options = options;
            return this;
        }
        public java.util.List<UpdateMetaModelFieldRequestFieldDTOListPropsOptions> getOptions() {
            return this.options;
        }

        public UpdateMetaModelFieldRequestFieldDTOListProps setPayEnable(Boolean payEnable) {
            this.payEnable = payEnable;
            return this;
        }
        public Boolean getPayEnable() {
            return this.payEnable;
        }

        public UpdateMetaModelFieldRequestFieldDTOListProps setPlaceholder(String placeholder) {
            this.placeholder = placeholder;
            return this;
        }
        public String getPlaceholder() {
            return this.placeholder;
        }

        public UpdateMetaModelFieldRequestFieldDTOListProps setRequired(Boolean required) {
            this.required = required;
            return this;
        }
        public Boolean getRequired() {
            return this.required;
        }

        public UpdateMetaModelFieldRequestFieldDTOListProps setRequiredEditableFreeze(Boolean requiredEditableFreeze) {
            this.requiredEditableFreeze = requiredEditableFreeze;
            return this;
        }
        public Boolean getRequiredEditableFreeze() {
            return this.requiredEditableFreeze;
        }

        public UpdateMetaModelFieldRequestFieldDTOListProps setSortable(Boolean sortable) {
            this.sortable = sortable;
            return this;
        }
        public Boolean getSortable() {
            return this.sortable;
        }

        public UpdateMetaModelFieldRequestFieldDTOListProps setUnit(String unit) {
            this.unit = unit;
            return this;
        }
        public String getUnit() {
            return this.unit;
        }

    }

    public static class UpdateMetaModelFieldRequestFieldDTOList extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("componentName")
        public String componentName;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("props")
        public UpdateMetaModelFieldRequestFieldDTOListProps props;

        public static UpdateMetaModelFieldRequestFieldDTOList build(java.util.Map<String, ?> map) throws Exception {
            UpdateMetaModelFieldRequestFieldDTOList self = new UpdateMetaModelFieldRequestFieldDTOList();
            return TeaModel.build(map, self);
        }

        public UpdateMetaModelFieldRequestFieldDTOList setComponentName(String componentName) {
            this.componentName = componentName;
            return this;
        }
        public String getComponentName() {
            return this.componentName;
        }

        public UpdateMetaModelFieldRequestFieldDTOList setProps(UpdateMetaModelFieldRequestFieldDTOListProps props) {
            this.props = props;
            return this;
        }
        public UpdateMetaModelFieldRequestFieldDTOListProps getProps() {
            return this.props;
        }

    }

}
