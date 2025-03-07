// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontract_1_0.models;

import com.aliyun.tea.*;

public class QueryContractAppsExtractResultResponseBody extends TeaModel {
    @NameInMap("result")
    public QueryContractAppsExtractResultResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static QueryContractAppsExtractResultResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryContractAppsExtractResultResponseBody self = new QueryContractAppsExtractResultResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryContractAppsExtractResultResponseBody setResult(QueryContractAppsExtractResultResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public QueryContractAppsExtractResultResponseBodyResult getResult() {
        return this.result;
    }

    public QueryContractAppsExtractResultResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class QueryContractAppsExtractResultResponseBodyResultDataExtractEntities extends TeaModel {
        @NameInMap("key")
        public String key;

        @NameInMap("value")
        public String value;

        public static QueryContractAppsExtractResultResponseBodyResultDataExtractEntities build(java.util.Map<String, ?> map) throws Exception {
            QueryContractAppsExtractResultResponseBodyResultDataExtractEntities self = new QueryContractAppsExtractResultResponseBodyResultDataExtractEntities();
            return TeaModel.build(map, self);
        }

        public QueryContractAppsExtractResultResponseBodyResultDataExtractEntities setKey(String key) {
            this.key = key;
            return this;
        }
        public String getKey() {
            return this.key;
        }

        public QueryContractAppsExtractResultResponseBodyResultDataExtractEntities setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

    }

    public static class QueryContractAppsExtractResultResponseBodyResultData extends TeaModel {
        @NameInMap("extractEntities")
        public java.util.List<QueryContractAppsExtractResultResponseBodyResultDataExtractEntities> extractEntities;

        @NameInMap("extractStatus")
        public String extractStatus;

        public static QueryContractAppsExtractResultResponseBodyResultData build(java.util.Map<String, ?> map) throws Exception {
            QueryContractAppsExtractResultResponseBodyResultData self = new QueryContractAppsExtractResultResponseBodyResultData();
            return TeaModel.build(map, self);
        }

        public QueryContractAppsExtractResultResponseBodyResultData setExtractEntities(java.util.List<QueryContractAppsExtractResultResponseBodyResultDataExtractEntities> extractEntities) {
            this.extractEntities = extractEntities;
            return this;
        }
        public java.util.List<QueryContractAppsExtractResultResponseBodyResultDataExtractEntities> getExtractEntities() {
            return this.extractEntities;
        }

        public QueryContractAppsExtractResultResponseBodyResultData setExtractStatus(String extractStatus) {
            this.extractStatus = extractStatus;
            return this;
        }
        public String getExtractStatus() {
            return this.extractStatus;
        }

    }

    public static class QueryContractAppsExtractResultResponseBodyResult extends TeaModel {
        @NameInMap("data")
        public QueryContractAppsExtractResultResponseBodyResultData data;

        @NameInMap("requestId")
        public String requestId;

        public static QueryContractAppsExtractResultResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            QueryContractAppsExtractResultResponseBodyResult self = new QueryContractAppsExtractResultResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public QueryContractAppsExtractResultResponseBodyResult setData(QueryContractAppsExtractResultResponseBodyResultData data) {
            this.data = data;
            return this;
        }
        public QueryContractAppsExtractResultResponseBodyResultData getData() {
            return this.data;
        }

        public QueryContractAppsExtractResultResponseBodyResult setRequestId(String requestId) {
            this.requestId = requestId;
            return this;
        }
        public String getRequestId() {
            return this.requestId;
        }

    }

}
