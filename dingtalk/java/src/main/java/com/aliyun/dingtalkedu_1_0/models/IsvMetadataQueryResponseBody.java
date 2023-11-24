// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class IsvMetadataQueryResponseBody extends TeaModel {
    @NameInMap("result")
    public IsvMetadataQueryResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static IsvMetadataQueryResponseBody build(java.util.Map<String, ?> map) throws Exception {
        IsvMetadataQueryResponseBody self = new IsvMetadataQueryResponseBody();
        return TeaModel.build(map, self);
    }

    public IsvMetadataQueryResponseBody setResult(IsvMetadataQueryResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public IsvMetadataQueryResponseBodyResult getResult() {
        return this.result;
    }

    public IsvMetadataQueryResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class IsvMetadataQueryResponseBodyResultFields extends TeaModel {
        @NameInMap("description")
        public String description;

        @NameInMap("fieldKey")
        public String fieldKey;

        @NameInMap("fieldName")
        public String fieldName;

        @NameInMap("fieldType")
        public String fieldType;

        @NameInMap("primaryKey")
        public Boolean primaryKey;

        @NameInMap("required")
        public Boolean required;

        public static IsvMetadataQueryResponseBodyResultFields build(java.util.Map<String, ?> map) throws Exception {
            IsvMetadataQueryResponseBodyResultFields self = new IsvMetadataQueryResponseBodyResultFields();
            return TeaModel.build(map, self);
        }

        public IsvMetadataQueryResponseBodyResultFields setDescription(String description) {
            this.description = description;
            return this;
        }
        public String getDescription() {
            return this.description;
        }

        public IsvMetadataQueryResponseBodyResultFields setFieldKey(String fieldKey) {
            this.fieldKey = fieldKey;
            return this;
        }
        public String getFieldKey() {
            return this.fieldKey;
        }

        public IsvMetadataQueryResponseBodyResultFields setFieldName(String fieldName) {
            this.fieldName = fieldName;
            return this;
        }
        public String getFieldName() {
            return this.fieldName;
        }

        public IsvMetadataQueryResponseBodyResultFields setFieldType(String fieldType) {
            this.fieldType = fieldType;
            return this;
        }
        public String getFieldType() {
            return this.fieldType;
        }

        public IsvMetadataQueryResponseBodyResultFields setPrimaryKey(Boolean primaryKey) {
            this.primaryKey = primaryKey;
            return this;
        }
        public Boolean getPrimaryKey() {
            return this.primaryKey;
        }

        public IsvMetadataQueryResponseBodyResultFields setRequired(Boolean required) {
            this.required = required;
            return this;
        }
        public Boolean getRequired() {
            return this.required;
        }

    }

    public static class IsvMetadataQueryResponseBodyResult extends TeaModel {
        @NameInMap("fields")
        public java.util.List<IsvMetadataQueryResponseBodyResultFields> fields;

        @NameInMap("tableCode")
        public String tableCode;

        @NameInMap("tableExist")
        public Boolean tableExist;

        public static IsvMetadataQueryResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            IsvMetadataQueryResponseBodyResult self = new IsvMetadataQueryResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public IsvMetadataQueryResponseBodyResult setFields(java.util.List<IsvMetadataQueryResponseBodyResultFields> fields) {
            this.fields = fields;
            return this;
        }
        public java.util.List<IsvMetadataQueryResponseBodyResultFields> getFields() {
            return this.fields;
        }

        public IsvMetadataQueryResponseBodyResult setTableCode(String tableCode) {
            this.tableCode = tableCode;
            return this;
        }
        public String getTableCode() {
            return this.tableCode;
        }

        public IsvMetadataQueryResponseBodyResult setTableExist(Boolean tableExist) {
            this.tableExist = tableExist;
            return this;
        }
        public Boolean getTableExist() {
            return this.tableExist;
        }

    }

}
