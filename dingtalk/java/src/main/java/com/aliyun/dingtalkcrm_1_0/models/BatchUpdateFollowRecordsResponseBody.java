// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class BatchUpdateFollowRecordsResponseBody extends TeaModel {
    /**
     * <p>批量插入结果列表，results的结果和要新增的数据是一一对应的，可以获取到每条数据分别是否成功。</p>
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
