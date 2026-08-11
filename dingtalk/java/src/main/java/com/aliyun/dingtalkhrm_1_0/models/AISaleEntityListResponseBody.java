// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class AISaleEntityListResponseBody extends TeaModel {
    @NameInMap("errorCode")
    public String errorCode;

    @NameInMap("errorMsg")
    public String errorMsg;

    @NameInMap("result")
    public AISaleEntityListResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static AISaleEntityListResponseBody build(java.util.Map<String, ?> map) throws Exception {
        AISaleEntityListResponseBody self = new AISaleEntityListResponseBody();
        return TeaModel.build(map, self);
    }

    public AISaleEntityListResponseBody setErrorCode(String errorCode) {
        this.errorCode = errorCode;
        return this;
    }
    public String getErrorCode() {
        return this.errorCode;
    }

    public AISaleEntityListResponseBody setErrorMsg(String errorMsg) {
        this.errorMsg = errorMsg;
        return this;
    }
    public String getErrorMsg() {
        return this.errorMsg;
    }

    public AISaleEntityListResponseBody setResult(AISaleEntityListResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public AISaleEntityListResponseBodyResult getResult() {
        return this.result;
    }

    public AISaleEntityListResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class AISaleEntityListResponseBodyResultDataFieldInstancesOptions extends TeaModel {
        @NameInMap("label")
        public String label;

        @NameInMap("value")
        public String value;

        public static AISaleEntityListResponseBodyResultDataFieldInstancesOptions build(java.util.Map<String, ?> map) throws Exception {
            AISaleEntityListResponseBodyResultDataFieldInstancesOptions self = new AISaleEntityListResponseBodyResultDataFieldInstancesOptions();
            return TeaModel.build(map, self);
        }

        public AISaleEntityListResponseBodyResultDataFieldInstancesOptions setLabel(String label) {
            this.label = label;
            return this;
        }
        public String getLabel() {
            return this.label;
        }

        public AISaleEntityListResponseBodyResultDataFieldInstancesOptions setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

    }

    public static class AISaleEntityListResponseBodyResultDataFieldInstancesSubFieldsOptions extends TeaModel {
        @NameInMap("label")
        public String label;

        @NameInMap("value")
        public String value;

        public static AISaleEntityListResponseBodyResultDataFieldInstancesSubFieldsOptions build(java.util.Map<String, ?> map) throws Exception {
            AISaleEntityListResponseBodyResultDataFieldInstancesSubFieldsOptions self = new AISaleEntityListResponseBodyResultDataFieldInstancesSubFieldsOptions();
            return TeaModel.build(map, self);
        }

        public AISaleEntityListResponseBodyResultDataFieldInstancesSubFieldsOptions setLabel(String label) {
            this.label = label;
            return this;
        }
        public String getLabel() {
            return this.label;
        }

        public AISaleEntityListResponseBodyResultDataFieldInstancesSubFieldsOptions setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

    }

    public static class AISaleEntityListResponseBodyResultDataFieldInstancesSubFields extends TeaModel {
        @NameInMap("fieldKey")
        public String fieldKey;

        @NameInMap("fieldLabel")
        public String fieldLabel;

        @NameInMap("fieldValue")
        public String fieldValue;

        @NameInMap("options")
        public java.util.List<AISaleEntityListResponseBodyResultDataFieldInstancesSubFieldsOptions> options;

        @NameInMap("placeholder")
        public String placeholder;

        @NameInMap("required")
        public Boolean required;

        @NameInMap("source")
        public String source;

        public static AISaleEntityListResponseBodyResultDataFieldInstancesSubFields build(java.util.Map<String, ?> map) throws Exception {
            AISaleEntityListResponseBodyResultDataFieldInstancesSubFields self = new AISaleEntityListResponseBodyResultDataFieldInstancesSubFields();
            return TeaModel.build(map, self);
        }

        public AISaleEntityListResponseBodyResultDataFieldInstancesSubFields setFieldKey(String fieldKey) {
            this.fieldKey = fieldKey;
            return this;
        }
        public String getFieldKey() {
            return this.fieldKey;
        }

        public AISaleEntityListResponseBodyResultDataFieldInstancesSubFields setFieldLabel(String fieldLabel) {
            this.fieldLabel = fieldLabel;
            return this;
        }
        public String getFieldLabel() {
            return this.fieldLabel;
        }

        public AISaleEntityListResponseBodyResultDataFieldInstancesSubFields setFieldValue(String fieldValue) {
            this.fieldValue = fieldValue;
            return this;
        }
        public String getFieldValue() {
            return this.fieldValue;
        }

        public AISaleEntityListResponseBodyResultDataFieldInstancesSubFields setOptions(java.util.List<AISaleEntityListResponseBodyResultDataFieldInstancesSubFieldsOptions> options) {
            this.options = options;
            return this;
        }
        public java.util.List<AISaleEntityListResponseBodyResultDataFieldInstancesSubFieldsOptions> getOptions() {
            return this.options;
        }

        public AISaleEntityListResponseBodyResultDataFieldInstancesSubFields setPlaceholder(String placeholder) {
            this.placeholder = placeholder;
            return this;
        }
        public String getPlaceholder() {
            return this.placeholder;
        }

        public AISaleEntityListResponseBodyResultDataFieldInstancesSubFields setRequired(Boolean required) {
            this.required = required;
            return this;
        }
        public Boolean getRequired() {
            return this.required;
        }

        public AISaleEntityListResponseBodyResultDataFieldInstancesSubFields setSource(String source) {
            this.source = source;
            return this;
        }
        public String getSource() {
            return this.source;
        }

    }

    public static class AISaleEntityListResponseBodyResultDataFieldInstances extends TeaModel {
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
        public java.util.List<AISaleEntityListResponseBodyResultDataFieldInstancesOptions> options;

        @NameInMap("placeholder")
        public String placeholder;

        @NameInMap("required")
        public Boolean required;

        @NameInMap("source")
        public String source;

        @NameInMap("subFields")
        public java.util.List<AISaleEntityListResponseBodyResultDataFieldInstancesSubFields> subFields;

        public static AISaleEntityListResponseBodyResultDataFieldInstances build(java.util.Map<String, ?> map) throws Exception {
            AISaleEntityListResponseBodyResultDataFieldInstances self = new AISaleEntityListResponseBodyResultDataFieldInstances();
            return TeaModel.build(map, self);
        }

        public AISaleEntityListResponseBodyResultDataFieldInstances setFieldKey(String fieldKey) {
            this.fieldKey = fieldKey;
            return this;
        }
        public String getFieldKey() {
            return this.fieldKey;
        }

        public AISaleEntityListResponseBodyResultDataFieldInstances setFieldLabel(String fieldLabel) {
            this.fieldLabel = fieldLabel;
            return this;
        }
        public String getFieldLabel() {
            return this.fieldLabel;
        }

        public AISaleEntityListResponseBodyResultDataFieldInstances setFieldType(String fieldType) {
            this.fieldType = fieldType;
            return this;
        }
        public String getFieldType() {
            return this.fieldType;
        }

        public AISaleEntityListResponseBodyResultDataFieldInstances setFieldValue(String fieldValue) {
            this.fieldValue = fieldValue;
            return this;
        }
        public String getFieldValue() {
            return this.fieldValue;
        }

        public AISaleEntityListResponseBodyResultDataFieldInstances setItemType(String itemType) {
            this.itemType = itemType;
            return this;
        }
        public String getItemType() {
            return this.itemType;
        }

        public AISaleEntityListResponseBodyResultDataFieldInstances setOptions(java.util.List<AISaleEntityListResponseBodyResultDataFieldInstancesOptions> options) {
            this.options = options;
            return this;
        }
        public java.util.List<AISaleEntityListResponseBodyResultDataFieldInstancesOptions> getOptions() {
            return this.options;
        }

        public AISaleEntityListResponseBodyResultDataFieldInstances setPlaceholder(String placeholder) {
            this.placeholder = placeholder;
            return this;
        }
        public String getPlaceholder() {
            return this.placeholder;
        }

        public AISaleEntityListResponseBodyResultDataFieldInstances setRequired(Boolean required) {
            this.required = required;
            return this;
        }
        public Boolean getRequired() {
            return this.required;
        }

        public AISaleEntityListResponseBodyResultDataFieldInstances setSource(String source) {
            this.source = source;
            return this;
        }
        public String getSource() {
            return this.source;
        }

        public AISaleEntityListResponseBodyResultDataFieldInstances setSubFields(java.util.List<AISaleEntityListResponseBodyResultDataFieldInstancesSubFields> subFields) {
            this.subFields = subFields;
            return this;
        }
        public java.util.List<AISaleEntityListResponseBodyResultDataFieldInstancesSubFields> getSubFields() {
            return this.subFields;
        }

    }

    public static class AISaleEntityListResponseBodyResultData extends TeaModel {
        @NameInMap("entityId")
        public String entityId;

        @NameInMap("entityType")
        public String entityType;

        @NameInMap("fieldInstances")
        public java.util.List<AISaleEntityListResponseBodyResultDataFieldInstances> fieldInstances;

        public static AISaleEntityListResponseBodyResultData build(java.util.Map<String, ?> map) throws Exception {
            AISaleEntityListResponseBodyResultData self = new AISaleEntityListResponseBodyResultData();
            return TeaModel.build(map, self);
        }

        public AISaleEntityListResponseBodyResultData setEntityId(String entityId) {
            this.entityId = entityId;
            return this;
        }
        public String getEntityId() {
            return this.entityId;
        }

        public AISaleEntityListResponseBodyResultData setEntityType(String entityType) {
            this.entityType = entityType;
            return this;
        }
        public String getEntityType() {
            return this.entityType;
        }

        public AISaleEntityListResponseBodyResultData setFieldInstances(java.util.List<AISaleEntityListResponseBodyResultDataFieldInstances> fieldInstances) {
            this.fieldInstances = fieldInstances;
            return this;
        }
        public java.util.List<AISaleEntityListResponseBodyResultDataFieldInstances> getFieldInstances() {
            return this.fieldInstances;
        }

    }

    public static class AISaleEntityListResponseBodyResult extends TeaModel {
        @NameInMap("data")
        public java.util.List<AISaleEntityListResponseBodyResultData> data;

        @NameInMap("hasMore")
        public Boolean hasMore;

        @NameInMap("nextCursor")
        public String nextCursor;

        @NameInMap("pageSize")
        public Integer pageSize;

        public static AISaleEntityListResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            AISaleEntityListResponseBodyResult self = new AISaleEntityListResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public AISaleEntityListResponseBodyResult setData(java.util.List<AISaleEntityListResponseBodyResultData> data) {
            this.data = data;
            return this;
        }
        public java.util.List<AISaleEntityListResponseBodyResultData> getData() {
            return this.data;
        }

        public AISaleEntityListResponseBodyResult setHasMore(Boolean hasMore) {
            this.hasMore = hasMore;
            return this;
        }
        public Boolean getHasMore() {
            return this.hasMore;
        }

        public AISaleEntityListResponseBodyResult setNextCursor(String nextCursor) {
            this.nextCursor = nextCursor;
            return this;
        }
        public String getNextCursor() {
            return this.nextCursor;
        }

        public AISaleEntityListResponseBodyResult setPageSize(Integer pageSize) {
            this.pageSize = pageSize;
            return this;
        }
        public Integer getPageSize() {
            return this.pageSize;
        }

    }

}
