// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class BatchUpdateFollowRecordsResponseBody extends TeaModel {
    @NameInMap("results")
    public java.util.List<BatchUpdateFollowRecordsResponseBodyResults> results;

    public static BatchUpdateFollowRecordsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        BatchUpdateFollowRecordsResponseBody self = new BatchUpdateFollowRecordsResponseBody();
        return TeaModel.build(map, self);
    }

    public BatchUpdateFollowRecordsResponseBody setResults(java.util.List<BatchUpdateFollowRecordsResponseBodyResults> results) {
        this.results = results;
        return this;
    }
    public java.util.List<BatchUpdateFollowRecordsResponseBodyResults> getResults() {
        return this.results;
    }

    public static class BatchUpdateFollowRecordsResponseBodyResults extends TeaModel {
        @NameInMap("errorCode")
        public String errorCode;

        @NameInMap("errorMsg")
        public String errorMsg;

        @NameInMap("instanceId")
        public String instanceId;

        @NameInMap("success")
        public Boolean success;

        public static BatchUpdateFollowRecordsResponseBodyResults build(java.util.Map<String, ?> map) throws Exception {
            BatchUpdateFollowRecordsResponseBodyResults self = new BatchUpdateFollowRecordsResponseBodyResults();
            return TeaModel.build(map, self);
        }

        public BatchUpdateFollowRecordsResponseBodyResults setErrorCode(String errorCode) {
            this.errorCode = errorCode;
            return this;
        }
        public String getErrorCode() {
            return this.errorCode;
        }

        public BatchUpdateFollowRecordsResponseBodyResults setErrorMsg(String errorMsg) {
            this.errorMsg = errorMsg;
            return this;
        }
        public String getErrorMsg() {
            return this.errorMsg;
        }

        public BatchUpdateFollowRecordsResponseBodyResults setInstanceId(String instanceId) {
            this.instanceId = instanceId;
            return this;
        }
        public String getInstanceId() {
            return this.instanceId;
        }

        public BatchUpdateFollowRecordsResponseBodyResults setSuccess(Boolean success) {
            this.success = success;
            return this;
        }
        public Boolean getSuccess() {
            return this.success;
        }

    }

}
