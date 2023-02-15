// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class BatchRemoveFollowRecordsResponseBody extends TeaModel {
    /**
     * <p>批量插入结果列表，results的结果和要新增的数据是一一对应的，可以获取到每条数据分别是否成功。</p>
     */
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
