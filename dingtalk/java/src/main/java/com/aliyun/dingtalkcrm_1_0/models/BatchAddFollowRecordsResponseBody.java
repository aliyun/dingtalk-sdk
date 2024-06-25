// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class BatchAddFollowRecordsResponseBody extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>true</p>
     */
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
        /**
         * <strong>example:</strong>
         * <p>1002</p>
         */
        @NameInMap("errorCode")
        public String errorCode;

        /**
         * <strong>example:</strong>
         * <p>查重失败</p>
         */
        @NameInMap("errorMsg")
        public String errorMsg;

        /**
         * <strong>example:</strong>
         * <p>yU9TbER1TDazjPq1rRCzwg04841675924041</p>
         */
        @NameInMap("instanceId")
        public String instanceId;

        /**
         * <strong>example:</strong>
         * <p>true</p>
         */
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
