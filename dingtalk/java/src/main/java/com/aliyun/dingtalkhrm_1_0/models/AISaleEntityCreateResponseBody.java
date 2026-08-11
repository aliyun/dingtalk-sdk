// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class AISaleEntityCreateResponseBody extends TeaModel {
    @NameInMap("errorCode")
    public String errorCode;

    @NameInMap("errorMsg")
    public String errorMsg;

    @NameInMap("result")
    public AISaleEntityCreateResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static AISaleEntityCreateResponseBody build(java.util.Map<String, ?> map) throws Exception {
        AISaleEntityCreateResponseBody self = new AISaleEntityCreateResponseBody();
        return TeaModel.build(map, self);
    }

    public AISaleEntityCreateResponseBody setErrorCode(String errorCode) {
        this.errorCode = errorCode;
        return this;
    }
    public String getErrorCode() {
        return this.errorCode;
    }

    public AISaleEntityCreateResponseBody setErrorMsg(String errorMsg) {
        this.errorMsg = errorMsg;
        return this;
    }
    public String getErrorMsg() {
        return this.errorMsg;
    }

    public AISaleEntityCreateResponseBody setResult(AISaleEntityCreateResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public AISaleEntityCreateResponseBodyResult getResult() {
        return this.result;
    }

    public AISaleEntityCreateResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class AISaleEntityCreateResponseBodyResultFieldInstancesOptions extends TeaModel {
        @NameInMap("label")
        public String label;

        @NameInMap("value")
        public String value;

        public static AISaleEntityCreateResponseBodyResultFieldInstancesOptions build(java.util.Map<String, ?> map) throws Exception {
            AISaleEntityCreateResponseBodyResultFieldInstancesOptions self = new AISaleEntityCreateResponseBodyResultFieldInstancesOptions();
            return TeaModel.build(map, self);
        }

        public AISaleEntityCreateResponseBodyResultFieldInstancesOptions setLabel(String label) {
            this.label = label;
            return this;
        }
        public String getLabel() {
            return this.label;
        }

        public AISaleEntityCreateResponseBodyResultFieldInstancesOptions setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

    }

    public static class AISaleEntityCreateResponseBodyResultFieldInstances extends TeaModel {
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
        public java.util.List<AISaleEntityCreateResponseBodyResultFieldInstancesOptions> options;

        @NameInMap("placeholder")
        public String placeholder;

        @NameInMap("required")
        public Boolean required;

        @NameInMap("source")
        public String source;

        public static AISaleEntityCreateResponseBodyResultFieldInstances build(java.util.Map<String, ?> map) throws Exception {
            AISaleEntityCreateResponseBodyResultFieldInstances self = new AISaleEntityCreateResponseBodyResultFieldInstances();
            return TeaModel.build(map, self);
        }

        public AISaleEntityCreateResponseBodyResultFieldInstances setFieldKey(String fieldKey) {
            this.fieldKey = fieldKey;
            return this;
        }
        public String getFieldKey() {
            return this.fieldKey;
        }

        public AISaleEntityCreateResponseBodyResultFieldInstances setFieldLabel(String fieldLabel) {
            this.fieldLabel = fieldLabel;
            return this;
        }
        public String getFieldLabel() {
            return this.fieldLabel;
        }

        public AISaleEntityCreateResponseBodyResultFieldInstances setFieldType(String fieldType) {
            this.fieldType = fieldType;
            return this;
        }
        public String getFieldType() {
            return this.fieldType;
        }

        public AISaleEntityCreateResponseBodyResultFieldInstances setFieldValue(String fieldValue) {
            this.fieldValue = fieldValue;
            return this;
        }
        public String getFieldValue() {
            return this.fieldValue;
        }

        public AISaleEntityCreateResponseBodyResultFieldInstances setItemType(String itemType) {
            this.itemType = itemType;
            return this;
        }
        public String getItemType() {
            return this.itemType;
        }

        public AISaleEntityCreateResponseBodyResultFieldInstances setOptions(java.util.List<AISaleEntityCreateResponseBodyResultFieldInstancesOptions> options) {
            this.options = options;
            return this;
        }
        public java.util.List<AISaleEntityCreateResponseBodyResultFieldInstancesOptions> getOptions() {
            return this.options;
        }

        public AISaleEntityCreateResponseBodyResultFieldInstances setPlaceholder(String placeholder) {
            this.placeholder = placeholder;
            return this;
        }
        public String getPlaceholder() {
            return this.placeholder;
        }

        public AISaleEntityCreateResponseBodyResultFieldInstances setRequired(Boolean required) {
            this.required = required;
            return this;
        }
        public Boolean getRequired() {
            return this.required;
        }

        public AISaleEntityCreateResponseBodyResultFieldInstances setSource(String source) {
            this.source = source;
            return this;
        }
        public String getSource() {
            return this.source;
        }

    }

    public static class AISaleEntityCreateResponseBodyResult extends TeaModel {
        @NameInMap("entityId")
        public String entityId;

        @NameInMap("entityType")
        public String entityType;

        @NameInMap("fieldInstances")
        public java.util.List<AISaleEntityCreateResponseBodyResultFieldInstances> fieldInstances;

        @NameInMap("userId")
        public String userId;

        public static AISaleEntityCreateResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            AISaleEntityCreateResponseBodyResult self = new AISaleEntityCreateResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public AISaleEntityCreateResponseBodyResult setEntityId(String entityId) {
            this.entityId = entityId;
            return this;
        }
        public String getEntityId() {
            return this.entityId;
        }

        public AISaleEntityCreateResponseBodyResult setEntityType(String entityType) {
            this.entityType = entityType;
            return this;
        }
        public String getEntityType() {
            return this.entityType;
        }

        public AISaleEntityCreateResponseBodyResult setFieldInstances(java.util.List<AISaleEntityCreateResponseBodyResultFieldInstances> fieldInstances) {
            this.fieldInstances = fieldInstances;
            return this;
        }
        public java.util.List<AISaleEntityCreateResponseBodyResultFieldInstances> getFieldInstances() {
            return this.fieldInstances;
        }

        public AISaleEntityCreateResponseBodyResult setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

}
