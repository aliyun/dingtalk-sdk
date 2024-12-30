// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontract_1_0.models;

import com.aliyun.tea.*;

public class QueryContractExtractResultResponseBody extends TeaModel {
    @NameInMap("result")
    public QueryContractExtractResultResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static QueryContractExtractResultResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryContractExtractResultResponseBody self = new QueryContractExtractResultResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryContractExtractResultResponseBody setResult(QueryContractExtractResultResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public QueryContractExtractResultResponseBodyResult getResult() {
        return this.result;
    }

    public QueryContractExtractResultResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class QueryContractExtractResultResponseBodyResultDataExtractEntities extends TeaModel {
        @NameInMap("key")
        public String key;

        @NameInMap("value")
        public String value;

        public static QueryContractExtractResultResponseBodyResultDataExtractEntities build(java.util.Map<String, ?> map) throws Exception {
            QueryContractExtractResultResponseBodyResultDataExtractEntities self = new QueryContractExtractResultResponseBodyResultDataExtractEntities();
            return TeaModel.build(map, self);
        }

        public QueryContractExtractResultResponseBodyResultDataExtractEntities setKey(String key) {
            this.key = key;
            return this;
        }
        public String getKey() {
            return this.key;
        }

        public QueryContractExtractResultResponseBodyResultDataExtractEntities setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

    }

    public static class QueryContractExtractResultResponseBodyResultData extends TeaModel {
        @NameInMap("extractEntities")
        public java.util.List<QueryContractExtractResultResponseBodyResultDataExtractEntities> extractEntities;

        @NameInMap("extractStatus")
        public String extractStatus;

        public static QueryContractExtractResultResponseBodyResultData build(java.util.Map<String, ?> map) throws Exception {
            QueryContractExtractResultResponseBodyResultData self = new QueryContractExtractResultResponseBodyResultData();
            return TeaModel.build(map, self);
        }

        public QueryContractExtractResultResponseBodyResultData setExtractEntities(java.util.List<QueryContractExtractResultResponseBodyResultDataExtractEntities> extractEntities) {
            this.extractEntities = extractEntities;
            return this;
        }
        public java.util.List<QueryContractExtractResultResponseBodyResultDataExtractEntities> getExtractEntities() {
            return this.extractEntities;
        }

        public QueryContractExtractResultResponseBodyResultData setExtractStatus(String extractStatus) {
            this.extractStatus = extractStatus;
            return this;
        }
        public String getExtractStatus() {
            return this.extractStatus;
        }

    }

    public static class QueryContractExtractResultResponseBodyResult extends TeaModel {
        @NameInMap("data")
        public QueryContractExtractResultResponseBodyResultData data;

        @NameInMap("requestId")
        public String requestId;

        public static QueryContractExtractResultResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            QueryContractExtractResultResponseBodyResult self = new QueryContractExtractResultResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public QueryContractExtractResultResponseBodyResult setData(QueryContractExtractResultResponseBodyResultData data) {
            this.data = data;
            return this;
        }
        public QueryContractExtractResultResponseBodyResultData getData() {
            return this.data;
        }

        public QueryContractExtractResultResponseBodyResult setRequestId(String requestId) {
            this.requestId = requestId;
            return this;
        }
        public String getRequestId() {
            return this.requestId;
        }

    }

}
