// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class AISaleSchemaGetResponseBody extends TeaModel {
    @NameInMap("errorCode")
    public String errorCode;

    @NameInMap("errorMsg")
    public String errorMsg;

    @NameInMap("result")
    public AISaleSchemaGetResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static AISaleSchemaGetResponseBody build(java.util.Map<String, ?> map) throws Exception {
        AISaleSchemaGetResponseBody self = new AISaleSchemaGetResponseBody();
        return TeaModel.build(map, self);
    }

    public AISaleSchemaGetResponseBody setErrorCode(String errorCode) {
        this.errorCode = errorCode;
        return this;
    }
    public String getErrorCode() {
        return this.errorCode;
    }

    public AISaleSchemaGetResponseBody setErrorMsg(String errorMsg) {
        this.errorMsg = errorMsg;
        return this;
    }
    public String getErrorMsg() {
        return this.errorMsg;
    }

    public AISaleSchemaGetResponseBody setResult(AISaleSchemaGetResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public AISaleSchemaGetResponseBodyResult getResult() {
        return this.result;
    }

    public AISaleSchemaGetResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class AISaleSchemaGetResponseBodyResultFieldsOptions extends TeaModel {
        @NameInMap("label")
        public String label;

        @NameInMap("value")
        public String value;

        public static AISaleSchemaGetResponseBodyResultFieldsOptions build(java.util.Map<String, ?> map) throws Exception {
            AISaleSchemaGetResponseBodyResultFieldsOptions self = new AISaleSchemaGetResponseBodyResultFieldsOptions();
            return TeaModel.build(map, self);
        }

        public AISaleSchemaGetResponseBodyResultFieldsOptions setLabel(String label) {
            this.label = label;
            return this;
        }
        public String getLabel() {
            return this.label;
        }

        public AISaleSchemaGetResponseBodyResultFieldsOptions setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

    }

    public static class AISaleSchemaGetResponseBodyResultFieldsSubFieldsOptions extends TeaModel {
        @NameInMap("label")
        public String label;

        @NameInMap("value")
        public String value;

        public static AISaleSchemaGetResponseBodyResultFieldsSubFieldsOptions build(java.util.Map<String, ?> map) throws Exception {
            AISaleSchemaGetResponseBodyResultFieldsSubFieldsOptions self = new AISaleSchemaGetResponseBodyResultFieldsSubFieldsOptions();
            return TeaModel.build(map, self);
        }

        public AISaleSchemaGetResponseBodyResultFieldsSubFieldsOptions setLabel(String label) {
            this.label = label;
            return this;
        }
        public String getLabel() {
            return this.label;
        }

        public AISaleSchemaGetResponseBodyResultFieldsSubFieldsOptions setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

    }

    public static class AISaleSchemaGetResponseBodyResultFieldsSubFields extends TeaModel {
        @NameInMap("fieldKey")
        public String fieldKey;

        @NameInMap("fieldLabel")
        public String fieldLabel;

        @NameInMap("options")
        public java.util.List<AISaleSchemaGetResponseBodyResultFieldsSubFieldsOptions> options;

        @NameInMap("placeholder")
        public String placeholder;

        @NameInMap("required")
        public Boolean required;

        public static AISaleSchemaGetResponseBodyResultFieldsSubFields build(java.util.Map<String, ?> map) throws Exception {
            AISaleSchemaGetResponseBodyResultFieldsSubFields self = new AISaleSchemaGetResponseBodyResultFieldsSubFields();
            return TeaModel.build(map, self);
        }

        public AISaleSchemaGetResponseBodyResultFieldsSubFields setFieldKey(String fieldKey) {
            this.fieldKey = fieldKey;
            return this;
        }
        public String getFieldKey() {
            return this.fieldKey;
        }

        public AISaleSchemaGetResponseBodyResultFieldsSubFields setFieldLabel(String fieldLabel) {
            this.fieldLabel = fieldLabel;
            return this;
        }
        public String getFieldLabel() {
            return this.fieldLabel;
        }

        public AISaleSchemaGetResponseBodyResultFieldsSubFields setOptions(java.util.List<AISaleSchemaGetResponseBodyResultFieldsSubFieldsOptions> options) {
            this.options = options;
            return this;
        }
        public java.util.List<AISaleSchemaGetResponseBodyResultFieldsSubFieldsOptions> getOptions() {
            return this.options;
        }

        public AISaleSchemaGetResponseBodyResultFieldsSubFields setPlaceholder(String placeholder) {
            this.placeholder = placeholder;
            return this;
        }
        public String getPlaceholder() {
            return this.placeholder;
        }

        public AISaleSchemaGetResponseBodyResultFieldsSubFields setRequired(Boolean required) {
            this.required = required;
            return this;
        }
        public Boolean getRequired() {
            return this.required;
        }

    }

    public static class AISaleSchemaGetResponseBodyResultFields extends TeaModel {
        @NameInMap("defaultValue")
        public String defaultValue;

        @NameInMap("description")
        public String description;

        @NameInMap("entityType")
        public String entityType;

        @NameInMap("fieldKey")
        public String fieldKey;

        @NameInMap("fieldLabel")
        public String fieldLabel;

        @NameInMap("fieldType")
        public String fieldType;

        @NameInMap("groupName")
        public String groupName;

        @NameInMap("itemType")
        public String itemType;

        @NameInMap("options")
        public java.util.List<AISaleSchemaGetResponseBodyResultFieldsOptions> options;

        @NameInMap("placeholder")
        public String placeholder;

        @NameInMap("required")
        public Boolean required;

        @NameInMap("sortOrder")
        public Integer sortOrder;

        @NameInMap("source")
        public String source;

        @NameInMap("subFields")
        public java.util.List<AISaleSchemaGetResponseBodyResultFieldsSubFields> subFields;

        public static AISaleSchemaGetResponseBodyResultFields build(java.util.Map<String, ?> map) throws Exception {
            AISaleSchemaGetResponseBodyResultFields self = new AISaleSchemaGetResponseBodyResultFields();
            return TeaModel.build(map, self);
        }

        public AISaleSchemaGetResponseBodyResultFields setDefaultValue(String defaultValue) {
            this.defaultValue = defaultValue;
            return this;
        }
        public String getDefaultValue() {
            return this.defaultValue;
        }

        public AISaleSchemaGetResponseBodyResultFields setDescription(String description) {
            this.description = description;
            return this;
        }
        public String getDescription() {
            return this.description;
        }

        public AISaleSchemaGetResponseBodyResultFields setEntityType(String entityType) {
            this.entityType = entityType;
            return this;
        }
        public String getEntityType() {
            return this.entityType;
        }

        public AISaleSchemaGetResponseBodyResultFields setFieldKey(String fieldKey) {
            this.fieldKey = fieldKey;
            return this;
        }
        public String getFieldKey() {
            return this.fieldKey;
        }

        public AISaleSchemaGetResponseBodyResultFields setFieldLabel(String fieldLabel) {
            this.fieldLabel = fieldLabel;
            return this;
        }
        public String getFieldLabel() {
            return this.fieldLabel;
        }

        public AISaleSchemaGetResponseBodyResultFields setFieldType(String fieldType) {
            this.fieldType = fieldType;
            return this;
        }
        public String getFieldType() {
            return this.fieldType;
        }

        public AISaleSchemaGetResponseBodyResultFields setGroupName(String groupName) {
            this.groupName = groupName;
            return this;
        }
        public String getGroupName() {
            return this.groupName;
        }

        public AISaleSchemaGetResponseBodyResultFields setItemType(String itemType) {
            this.itemType = itemType;
            return this;
        }
        public String getItemType() {
            return this.itemType;
        }

        public AISaleSchemaGetResponseBodyResultFields setOptions(java.util.List<AISaleSchemaGetResponseBodyResultFieldsOptions> options) {
            this.options = options;
            return this;
        }
        public java.util.List<AISaleSchemaGetResponseBodyResultFieldsOptions> getOptions() {
            return this.options;
        }

        public AISaleSchemaGetResponseBodyResultFields setPlaceholder(String placeholder) {
            this.placeholder = placeholder;
            return this;
        }
        public String getPlaceholder() {
            return this.placeholder;
        }

        public AISaleSchemaGetResponseBodyResultFields setRequired(Boolean required) {
            this.required = required;
            return this;
        }
        public Boolean getRequired() {
            return this.required;
        }

        public AISaleSchemaGetResponseBodyResultFields setSortOrder(Integer sortOrder) {
            this.sortOrder = sortOrder;
            return this;
        }
        public Integer getSortOrder() {
            return this.sortOrder;
        }

        public AISaleSchemaGetResponseBodyResultFields setSource(String source) {
            this.source = source;
            return this;
        }
        public String getSource() {
            return this.source;
        }

        public AISaleSchemaGetResponseBodyResultFields setSubFields(java.util.List<AISaleSchemaGetResponseBodyResultFieldsSubFields> subFields) {
            this.subFields = subFields;
            return this;
        }
        public java.util.List<AISaleSchemaGetResponseBodyResultFieldsSubFields> getSubFields() {
            return this.subFields;
        }

    }

    public static class AISaleSchemaGetResponseBodyResult extends TeaModel {
        @NameInMap("entityType")
        public String entityType;

        @NameInMap("fields")
        public java.util.List<AISaleSchemaGetResponseBodyResultFields> fields;

        public static AISaleSchemaGetResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            AISaleSchemaGetResponseBodyResult self = new AISaleSchemaGetResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public AISaleSchemaGetResponseBodyResult setEntityType(String entityType) {
            this.entityType = entityType;
            return this;
        }
        public String getEntityType() {
            return this.entityType;
        }

        public AISaleSchemaGetResponseBodyResult setFields(java.util.List<AISaleSchemaGetResponseBodyResultFields> fields) {
            this.fields = fields;
            return this;
        }
        public java.util.List<AISaleSchemaGetResponseBodyResultFields> getFields() {
            return this.fields;
        }

    }

}
