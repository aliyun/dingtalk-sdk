// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class AISaleEntityUpdateResponseBody extends TeaModel {
    @NameInMap("errorCode")
    public String errorCode;

    @NameInMap("errorMsg")
    public String errorMsg;

    @NameInMap("result")
    public AISaleEntityUpdateResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static AISaleEntityUpdateResponseBody build(java.util.Map<String, ?> map) throws Exception {
        AISaleEntityUpdateResponseBody self = new AISaleEntityUpdateResponseBody();
        return TeaModel.build(map, self);
    }

    public AISaleEntityUpdateResponseBody setErrorCode(String errorCode) {
        this.errorCode = errorCode;
        return this;
    }
    public String getErrorCode() {
        return this.errorCode;
    }

    public AISaleEntityUpdateResponseBody setErrorMsg(String errorMsg) {
        this.errorMsg = errorMsg;
        return this;
    }
    public String getErrorMsg() {
        return this.errorMsg;
    }

    public AISaleEntityUpdateResponseBody setResult(AISaleEntityUpdateResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public AISaleEntityUpdateResponseBodyResult getResult() {
        return this.result;
    }

    public AISaleEntityUpdateResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class AISaleEntityUpdateResponseBodyResultFieldInstancesOptions extends TeaModel {
        @NameInMap("label")
        public String label;

        @NameInMap("value")
        public String value;

        public static AISaleEntityUpdateResponseBodyResultFieldInstancesOptions build(java.util.Map<String, ?> map) throws Exception {
            AISaleEntityUpdateResponseBodyResultFieldInstancesOptions self = new AISaleEntityUpdateResponseBodyResultFieldInstancesOptions();
            return TeaModel.build(map, self);
        }

        public AISaleEntityUpdateResponseBodyResultFieldInstancesOptions setLabel(String label) {
            this.label = label;
            return this;
        }
        public String getLabel() {
            return this.label;
        }

        public AISaleEntityUpdateResponseBodyResultFieldInstancesOptions setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

    }

    public static class AISaleEntityUpdateResponseBodyResultFieldInstances extends TeaModel {
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
        public java.util.List<AISaleEntityUpdateResponseBodyResultFieldInstancesOptions> options;

        @NameInMap("placeholder")
        public String placeholder;

        @NameInMap("required")
        public Boolean required;

        @NameInMap("source")
        public String source;

        public static AISaleEntityUpdateResponseBodyResultFieldInstances build(java.util.Map<String, ?> map) throws Exception {
            AISaleEntityUpdateResponseBodyResultFieldInstances self = new AISaleEntityUpdateResponseBodyResultFieldInstances();
            return TeaModel.build(map, self);
        }

        public AISaleEntityUpdateResponseBodyResultFieldInstances setFieldKey(String fieldKey) {
            this.fieldKey = fieldKey;
            return this;
        }
        public String getFieldKey() {
            return this.fieldKey;
        }

        public AISaleEntityUpdateResponseBodyResultFieldInstances setFieldLabel(String fieldLabel) {
            this.fieldLabel = fieldLabel;
            return this;
        }
        public String getFieldLabel() {
            return this.fieldLabel;
        }

        public AISaleEntityUpdateResponseBodyResultFieldInstances setFieldType(String fieldType) {
            this.fieldType = fieldType;
            return this;
        }
        public String getFieldType() {
            return this.fieldType;
        }

        public AISaleEntityUpdateResponseBodyResultFieldInstances setFieldValue(String fieldValue) {
            this.fieldValue = fieldValue;
            return this;
        }
        public String getFieldValue() {
            return this.fieldValue;
        }

        public AISaleEntityUpdateResponseBodyResultFieldInstances setItemType(String itemType) {
            this.itemType = itemType;
            return this;
        }
        public String getItemType() {
            return this.itemType;
        }

        public AISaleEntityUpdateResponseBodyResultFieldInstances setOptions(java.util.List<AISaleEntityUpdateResponseBodyResultFieldInstancesOptions> options) {
            this.options = options;
            return this;
        }
        public java.util.List<AISaleEntityUpdateResponseBodyResultFieldInstancesOptions> getOptions() {
            return this.options;
        }

        public AISaleEntityUpdateResponseBodyResultFieldInstances setPlaceholder(String placeholder) {
            this.placeholder = placeholder;
            return this;
        }
        public String getPlaceholder() {
            return this.placeholder;
        }

        public AISaleEntityUpdateResponseBodyResultFieldInstances setRequired(Boolean required) {
            this.required = required;
            return this;
        }
        public Boolean getRequired() {
            return this.required;
        }

        public AISaleEntityUpdateResponseBodyResultFieldInstances setSource(String source) {
            this.source = source;
            return this;
        }
        public String getSource() {
            return this.source;
        }

    }

    public static class AISaleEntityUpdateResponseBodyResult extends TeaModel {
        @NameInMap("entityId")
        public String entityId;

        @NameInMap("entityType")
        public String entityType;

        @NameInMap("fieldInstances")
        public java.util.List<AISaleEntityUpdateResponseBodyResultFieldInstances> fieldInstances;

        @NameInMap("userId")
        public String userId;

        public static AISaleEntityUpdateResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            AISaleEntityUpdateResponseBodyResult self = new AISaleEntityUpdateResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public AISaleEntityUpdateResponseBodyResult setEntityId(String entityId) {
            this.entityId = entityId;
            return this;
        }
        public String getEntityId() {
            return this.entityId;
        }

        public AISaleEntityUpdateResponseBodyResult setEntityType(String entityType) {
            this.entityType = entityType;
            return this;
        }
        public String getEntityType() {
            return this.entityType;
        }

        public AISaleEntityUpdateResponseBodyResult setFieldInstances(java.util.List<AISaleEntityUpdateResponseBodyResultFieldInstances> fieldInstances) {
            this.fieldInstances = fieldInstances;
            return this;
        }
        public java.util.List<AISaleEntityUpdateResponseBodyResultFieldInstances> getFieldInstances() {
            return this.fieldInstances;
        }

        public AISaleEntityUpdateResponseBodyResult setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

}
