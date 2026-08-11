// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class AISaleEntityDetailResponseBody extends TeaModel {
    @NameInMap("errorCode")
    public String errorCode;

    @NameInMap("errorMsg")
    public String errorMsg;

    @NameInMap("result")
    public AISaleEntityDetailResponseBodyResult result;

    @NameInMap("success")
    public String success;

    public static AISaleEntityDetailResponseBody build(java.util.Map<String, ?> map) throws Exception {
        AISaleEntityDetailResponseBody self = new AISaleEntityDetailResponseBody();
        return TeaModel.build(map, self);
    }

    public AISaleEntityDetailResponseBody setErrorCode(String errorCode) {
        this.errorCode = errorCode;
        return this;
    }
    public String getErrorCode() {
        return this.errorCode;
    }

    public AISaleEntityDetailResponseBody setErrorMsg(String errorMsg) {
        this.errorMsg = errorMsg;
        return this;
    }
    public String getErrorMsg() {
        return this.errorMsg;
    }

    public AISaleEntityDetailResponseBody setResult(AISaleEntityDetailResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public AISaleEntityDetailResponseBodyResult getResult() {
        return this.result;
    }

    public AISaleEntityDetailResponseBody setSuccess(String success) {
        this.success = success;
        return this;
    }
    public String getSuccess() {
        return this.success;
    }

    public static class AISaleEntityDetailResponseBodyResultFieldInstancesOptions extends TeaModel {
        @NameInMap("label")
        public String label;

        @NameInMap("value")
        public String value;

        public static AISaleEntityDetailResponseBodyResultFieldInstancesOptions build(java.util.Map<String, ?> map) throws Exception {
            AISaleEntityDetailResponseBodyResultFieldInstancesOptions self = new AISaleEntityDetailResponseBodyResultFieldInstancesOptions();
            return TeaModel.build(map, self);
        }

        public AISaleEntityDetailResponseBodyResultFieldInstancesOptions setLabel(String label) {
            this.label = label;
            return this;
        }
        public String getLabel() {
            return this.label;
        }

        public AISaleEntityDetailResponseBodyResultFieldInstancesOptions setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

    }

    public static class AISaleEntityDetailResponseBodyResultFieldInstancesSubFieldsOptions extends TeaModel {
        @NameInMap("label")
        public String label;

        @NameInMap("value")
        public String value;

        public static AISaleEntityDetailResponseBodyResultFieldInstancesSubFieldsOptions build(java.util.Map<String, ?> map) throws Exception {
            AISaleEntityDetailResponseBodyResultFieldInstancesSubFieldsOptions self = new AISaleEntityDetailResponseBodyResultFieldInstancesSubFieldsOptions();
            return TeaModel.build(map, self);
        }

        public AISaleEntityDetailResponseBodyResultFieldInstancesSubFieldsOptions setLabel(String label) {
            this.label = label;
            return this;
        }
        public String getLabel() {
            return this.label;
        }

        public AISaleEntityDetailResponseBodyResultFieldInstancesSubFieldsOptions setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

    }

    public static class AISaleEntityDetailResponseBodyResultFieldInstancesSubFields extends TeaModel {
        @NameInMap("fieldKey")
        public String fieldKey;

        @NameInMap("fieldLabel")
        public String fieldLabel;

        @NameInMap("fieldValue")
        public String fieldValue;

        @NameInMap("itemType")
        public String itemType;

        @NameInMap("options")
        public java.util.List<AISaleEntityDetailResponseBodyResultFieldInstancesSubFieldsOptions> options;

        @NameInMap("placeholder")
        public String placeholder;

        @NameInMap("required")
        public Boolean required;

        @NameInMap("source")
        public String source;

        public static AISaleEntityDetailResponseBodyResultFieldInstancesSubFields build(java.util.Map<String, ?> map) throws Exception {
            AISaleEntityDetailResponseBodyResultFieldInstancesSubFields self = new AISaleEntityDetailResponseBodyResultFieldInstancesSubFields();
            return TeaModel.build(map, self);
        }

        public AISaleEntityDetailResponseBodyResultFieldInstancesSubFields setFieldKey(String fieldKey) {
            this.fieldKey = fieldKey;
            return this;
        }
        public String getFieldKey() {
            return this.fieldKey;
        }

        public AISaleEntityDetailResponseBodyResultFieldInstancesSubFields setFieldLabel(String fieldLabel) {
            this.fieldLabel = fieldLabel;
            return this;
        }
        public String getFieldLabel() {
            return this.fieldLabel;
        }

        public AISaleEntityDetailResponseBodyResultFieldInstancesSubFields setFieldValue(String fieldValue) {
            this.fieldValue = fieldValue;
            return this;
        }
        public String getFieldValue() {
            return this.fieldValue;
        }

        public AISaleEntityDetailResponseBodyResultFieldInstancesSubFields setItemType(String itemType) {
            this.itemType = itemType;
            return this;
        }
        public String getItemType() {
            return this.itemType;
        }

        public AISaleEntityDetailResponseBodyResultFieldInstancesSubFields setOptions(java.util.List<AISaleEntityDetailResponseBodyResultFieldInstancesSubFieldsOptions> options) {
            this.options = options;
            return this;
        }
        public java.util.List<AISaleEntityDetailResponseBodyResultFieldInstancesSubFieldsOptions> getOptions() {
            return this.options;
        }

        public AISaleEntityDetailResponseBodyResultFieldInstancesSubFields setPlaceholder(String placeholder) {
            this.placeholder = placeholder;
            return this;
        }
        public String getPlaceholder() {
            return this.placeholder;
        }

        public AISaleEntityDetailResponseBodyResultFieldInstancesSubFields setRequired(Boolean required) {
            this.required = required;
            return this;
        }
        public Boolean getRequired() {
            return this.required;
        }

        public AISaleEntityDetailResponseBodyResultFieldInstancesSubFields setSource(String source) {
            this.source = source;
            return this;
        }
        public String getSource() {
            return this.source;
        }

    }

    public static class AISaleEntityDetailResponseBodyResultFieldInstances extends TeaModel {
        @NameInMap("fieldKey")
        public String fieldKey;

        @NameInMap("fieldLabel")
        public String fieldLabel;

        @NameInMap("fieldType")
        public String fieldType;

        @NameInMap("fieldValue")
        public String fieldValue;

        @NameInMap("itemType")
        public String itemType;

        @NameInMap("options")
        public java.util.List<AISaleEntityDetailResponseBodyResultFieldInstancesOptions> options;

        @NameInMap("placeholder")
        public String placeholder;

        @NameInMap("required")
        public Boolean required;

        @NameInMap("source")
        public String source;

        @NameInMap("subFields")
        public java.util.List<AISaleEntityDetailResponseBodyResultFieldInstancesSubFields> subFields;

        public static AISaleEntityDetailResponseBodyResultFieldInstances build(java.util.Map<String, ?> map) throws Exception {
            AISaleEntityDetailResponseBodyResultFieldInstances self = new AISaleEntityDetailResponseBodyResultFieldInstances();
            return TeaModel.build(map, self);
        }

        public AISaleEntityDetailResponseBodyResultFieldInstances setFieldKey(String fieldKey) {
            this.fieldKey = fieldKey;
            return this;
        }
        public String getFieldKey() {
            return this.fieldKey;
        }

        public AISaleEntityDetailResponseBodyResultFieldInstances setFieldLabel(String fieldLabel) {
            this.fieldLabel = fieldLabel;
            return this;
        }
        public String getFieldLabel() {
            return this.fieldLabel;
        }

        public AISaleEntityDetailResponseBodyResultFieldInstances setFieldType(String fieldType) {
            this.fieldType = fieldType;
            return this;
        }
        public String getFieldType() {
            return this.fieldType;
        }

        public AISaleEntityDetailResponseBodyResultFieldInstances setFieldValue(String fieldValue) {
            this.fieldValue = fieldValue;
            return this;
        }
        public String getFieldValue() {
            return this.fieldValue;
        }

        public AISaleEntityDetailResponseBodyResultFieldInstances setItemType(String itemType) {
            this.itemType = itemType;
            return this;
        }
        public String getItemType() {
            return this.itemType;
        }

        public AISaleEntityDetailResponseBodyResultFieldInstances setOptions(java.util.List<AISaleEntityDetailResponseBodyResultFieldInstancesOptions> options) {
            this.options = options;
            return this;
        }
        public java.util.List<AISaleEntityDetailResponseBodyResultFieldInstancesOptions> getOptions() {
            return this.options;
        }

        public AISaleEntityDetailResponseBodyResultFieldInstances setPlaceholder(String placeholder) {
            this.placeholder = placeholder;
            return this;
        }
        public String getPlaceholder() {
            return this.placeholder;
        }

        public AISaleEntityDetailResponseBodyResultFieldInstances setRequired(Boolean required) {
            this.required = required;
            return this;
        }
        public Boolean getRequired() {
            return this.required;
        }

        public AISaleEntityDetailResponseBodyResultFieldInstances setSource(String source) {
            this.source = source;
            return this;
        }
        public String getSource() {
            return this.source;
        }

        public AISaleEntityDetailResponseBodyResultFieldInstances setSubFields(java.util.List<AISaleEntityDetailResponseBodyResultFieldInstancesSubFields> subFields) {
            this.subFields = subFields;
            return this;
        }
        public java.util.List<AISaleEntityDetailResponseBodyResultFieldInstancesSubFields> getSubFields() {
            return this.subFields;
        }

    }

    public static class AISaleEntityDetailResponseBodyResult extends TeaModel {
        @NameInMap("entityId")
        public String entityId;

        @NameInMap("entityType")
        public String entityType;

        @NameInMap("fieldInstances")
        public java.util.List<AISaleEntityDetailResponseBodyResultFieldInstances> fieldInstances;

        @NameInMap("userId")
        public String userId;

        public static AISaleEntityDetailResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            AISaleEntityDetailResponseBodyResult self = new AISaleEntityDetailResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public AISaleEntityDetailResponseBodyResult setEntityId(String entityId) {
            this.entityId = entityId;
            return this;
        }
        public String getEntityId() {
            return this.entityId;
        }

        public AISaleEntityDetailResponseBodyResult setEntityType(String entityType) {
            this.entityType = entityType;
            return this;
        }
        public String getEntityType() {
            return this.entityType;
        }

        public AISaleEntityDetailResponseBodyResult setFieldInstances(java.util.List<AISaleEntityDetailResponseBodyResultFieldInstances> fieldInstances) {
            this.fieldInstances = fieldInstances;
            return this;
        }
        public java.util.List<AISaleEntityDetailResponseBodyResultFieldInstances> getFieldInstances() {
            return this.fieldInstances;
        }

        public AISaleEntityDetailResponseBodyResult setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

}
