// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class BatchUpdateContactsResponseBody extends TeaModel {
    /**
     * <p>批量插入结果列表，results的结果和要新增的数据是一一对应的，可以获取到每条数据分别是否成功。</p>
     */
    @NameInMap("results")
    public java.util.List<BatchUpdateContactsResponseBodyResults> results;

    public static BatchUpdateContactsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        BatchUpdateContactsResponseBody self = new BatchUpdateContactsResponseBody();
        return TeaModel.build(map, self);
    }

    public BatchUpdateContactsResponseBody setResults(java.util.List<BatchUpdateContactsResponseBodyResults> results) {
        this.results = results;
        return this;
    }
    public java.util.List<BatchUpdateContactsResponseBodyResults> getResults() {
        return this.results;
    }

    public static class BatchUpdateContactsResponseBodyResults extends TeaModel {
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
        @NameInMap("relationId")
        public String relationId;

        /**
         * <p>数据是否保存成功。</p>
         */
        @NameInMap("success")
        public Boolean success;

        public static BatchUpdateContactsResponseBodyResults build(java.util.Map<String, ?> map) throws Exception {
            BatchUpdateContactsResponseBodyResults self = new BatchUpdateContactsResponseBodyResults();
            return TeaModel.build(map, self);
        }

        public BatchUpdateContactsResponseBodyResults setErrorCode(String errorCode) {
            this.errorCode = errorCode;
            return this;
        }
        public String getErrorCode() {
            return this.errorCode;
        }

        public BatchUpdateContactsResponseBodyResults setErrorMsg(String errorMsg) {
            this.errorMsg = errorMsg;
            return this;
        }
        public String getErrorMsg() {
            return this.errorMsg;
        }

        public BatchUpdateContactsResponseBodyResults setRelationId(String relationId) {
            this.relationId = relationId;
            return this;
        }
        public String getRelationId() {
            return this.relationId;
        }

        public BatchUpdateContactsResponseBodyResults setSuccess(Boolean success) {
            this.success = success;
            return this;
        }
        public Boolean getSuccess() {
            return this.success;
        }

    }

}
