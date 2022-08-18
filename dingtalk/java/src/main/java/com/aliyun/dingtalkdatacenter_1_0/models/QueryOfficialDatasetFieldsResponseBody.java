// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryOfficialDatasetFieldsResponseBody extends TeaModel {
    @NameInMap("result")
    public QueryOfficialDatasetFieldsResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static QueryOfficialDatasetFieldsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryOfficialDatasetFieldsResponseBody self = new QueryOfficialDatasetFieldsResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryOfficialDatasetFieldsResponseBody setResult(QueryOfficialDatasetFieldsResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public QueryOfficialDatasetFieldsResponseBodyResult getResult() {
        return this.result;
    }

    public QueryOfficialDatasetFieldsResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class QueryOfficialDatasetFieldsResponseBodyResultFields extends TeaModel {
        @NameInMap("displayName")
        public String displayName;

        @NameInMap("fieldId")
        public String fieldId;

        @NameInMap("fieldType")
        public String fieldType;

        public static QueryOfficialDatasetFieldsResponseBodyResultFields build(java.util.Map<String, ?> map) throws Exception {
            QueryOfficialDatasetFieldsResponseBodyResultFields self = new QueryOfficialDatasetFieldsResponseBodyResultFields();
            return TeaModel.build(map, self);
        }

        public QueryOfficialDatasetFieldsResponseBodyResultFields setDisplayName(String displayName) {
            this.displayName = displayName;
            return this;
        }
        public String getDisplayName() {
            return this.displayName;
        }

        public QueryOfficialDatasetFieldsResponseBodyResultFields setFieldId(String fieldId) {
            this.fieldId = fieldId;
            return this;
        }
        public String getFieldId() {
            return this.fieldId;
        }

        public QueryOfficialDatasetFieldsResponseBodyResultFields setFieldType(String fieldType) {
            this.fieldType = fieldType;
            return this;
        }
        public String getFieldType() {
            return this.fieldType;
        }

    }

    public static class QueryOfficialDatasetFieldsResponseBodyResult extends TeaModel {
        @NameInMap("displayName")
        public String displayName;

        @NameInMap("dsId")
        public String dsId;

        @NameInMap("fields")
        public java.util.List<QueryOfficialDatasetFieldsResponseBodyResultFields> fields;

        public static QueryOfficialDatasetFieldsResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            QueryOfficialDatasetFieldsResponseBodyResult self = new QueryOfficialDatasetFieldsResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public QueryOfficialDatasetFieldsResponseBodyResult setDisplayName(String displayName) {
            this.displayName = displayName;
            return this;
        }
        public String getDisplayName() {
            return this.displayName;
        }

        public QueryOfficialDatasetFieldsResponseBodyResult setDsId(String dsId) {
            this.dsId = dsId;
            return this;
        }
        public String getDsId() {
            return this.dsId;
        }

        public QueryOfficialDatasetFieldsResponseBodyResult setFields(java.util.List<QueryOfficialDatasetFieldsResponseBodyResultFields> fields) {
            this.fields = fields;
            return this;
        }
        public java.util.List<QueryOfficialDatasetFieldsResponseBodyResultFields> getFields() {
            return this.fields;
        }

    }

}
