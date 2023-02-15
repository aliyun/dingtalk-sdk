// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class BatchAddFollowRecordsResponseBody extends TeaModel {
    /**
     * <p>批量插入结果列表，results的结果和要新增的数据是一一对应的，可以获取到每条数据分别是否成功。</p>
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
         * <p>如果保存失败，则表示失败的错误码。</p>
         */
        @NameInMap("errorCode")
        public String errorCode;

        /**
         * <p>如果保存失败，则表示失败的错误原因。</p>
         */
        @NameInMap("errorMsg")
        public String errorMsg;

        /**
         * <p>保存成功的关系id。</p>
         */
        @NameInMap("instanceId")
        public String instanceId;

        /**
         * <p>数据是否保存成功。</p>
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
