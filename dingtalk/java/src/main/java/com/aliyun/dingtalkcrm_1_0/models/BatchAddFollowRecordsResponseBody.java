// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class BatchAddFollowRecordsResponseBody extends TeaModel {
    @NameInMap("results")
    public java.util.List<BatchAddFollowRecordsResponseBodyResults> results;

    public static BatchAddFollowRecordsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        BatchAddFollowRecordsResponseBody self = new BatchAddFollowRecordsResponseBody();
        return TeaModel.build(map, self);
    }

    public BatchAddFollowRecordsResponseBody setResults(java.util.List<BatchAddFollowRecordsResponseBodyResults> results) {
        this.results = results;
        return this;
    }
    public java.util.List<BatchAddFollowRecordsResponseBodyResults> getResults() {
        return this.results;
    }

    public static class BatchAddFollowRecordsResponseBodyResults extends TeaModel {
        @NameInMap("errorCode")
        public String errorCode;

        @NameInMap("errorMsg")
        public String errorMsg;

        @NameInMap("instanceId")
        public String instanceId;

        @NameInMap("success")
        public Boolean success;

        public static BatchAddFollowRecordsResponseBodyResults build(java.util.Map<String, ?> map) throws Exception {
            BatchAddFollowRecordsResponseBodyResults self = new BatchAddFollowRecordsResponseBodyResults();
            return TeaModel.build(map, self);
        }

        public BatchAddFollowRecordsResponseBodyResults setErrorCode(String errorCode) {
            this.errorCode = errorCode;
            return this;
        }
        public String getErrorCode() {
            return this.errorCode;
        }

        public BatchAddFollowRecordsResponseBodyResults setErrorMsg(String errorMsg) {
            this.errorMsg = errorMsg;
            return this;
        }
        public String getErrorMsg() {
            return this.errorMsg;
        }

        public BatchAddFollowRecordsResponseBodyResults setInstanceId(String instanceId) {
            this.instanceId = instanceId;
            return this;
        }
        public String getInstanceId() {
            return this.instanceId;
        }

        public BatchAddFollowRecordsResponseBodyResults setSuccess(Boolean success) {
            this.success = success;
            return this;
        }
        public Boolean getSuccess() {
            return this.success;
        }

    }

}
