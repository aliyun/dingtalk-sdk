// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class BatchUpdateFollowRecordsResponseBody extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>true</p>
     */
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
