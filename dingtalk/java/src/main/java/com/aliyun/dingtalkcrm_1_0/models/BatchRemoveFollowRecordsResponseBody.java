// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class BatchRemoveFollowRecordsResponseBody extends TeaModel {
    @NameInMap("results")
    public java.util.List<BatchRemoveFollowRecordsResponseBodyResults> results;

    public static BatchRemoveFollowRecordsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        BatchRemoveFollowRecordsResponseBody self = new BatchRemoveFollowRecordsResponseBody();
        return TeaModel.build(map, self);
    }

    public BatchRemoveFollowRecordsResponseBody setResults(java.util.List<BatchRemoveFollowRecordsResponseBodyResults> results) {
        this.results = results;
        return this;
    }
    public java.util.List<BatchRemoveFollowRecordsResponseBodyResults> getResults() {
        return this.results;
    }

    public static class BatchRemoveFollowRecordsResponseBodyResults extends TeaModel {
        @NameInMap("errorCode")
        public String errorCode;

        @NameInMap("errorMsg")
        public String errorMsg;

        @NameInMap("instanceId")
        public String instanceId;

        @NameInMap("success")
        public Boolean success;

        public static BatchRemoveFollowRecordsResponseBodyResults build(java.util.Map<String, ?> map) throws Exception {
            BatchRemoveFollowRecordsResponseBodyResults self = new BatchRemoveFollowRecordsResponseBodyResults();
            return TeaModel.build(map, self);
        }

        public BatchRemoveFollowRecordsResponseBodyResults setErrorCode(String errorCode) {
            this.errorCode = errorCode;
            return this;
        }
        public String getErrorCode() {
            return this.errorCode;
        }

        public BatchRemoveFollowRecordsResponseBodyResults setErrorMsg(String errorMsg) {
            this.errorMsg = errorMsg;
            return this;
        }
        public String getErrorMsg() {
            return this.errorMsg;
        }

        public BatchRemoveFollowRecordsResponseBodyResults setInstanceId(String instanceId) {
            this.instanceId = instanceId;
            return this;
        }
        public String getInstanceId() {
            return this.instanceId;
        }

        public BatchRemoveFollowRecordsResponseBodyResults setSuccess(Boolean success) {
            this.success = success;
            return this;
        }
        public Boolean getSuccess() {
            return this.success;
        }

    }

}
