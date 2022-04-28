// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class BatchUpdateContactsResponseBody extends TeaModel {
    // 批量插入结果列表，results的结果和要新增的数据是一一对应的，可以获取到每条数据分别是否成功。
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
        // 如果保存失败，则表示失败的错误码。
        @NameInMap("errorCode")
        public String errorCode;

        // 如果保存失败，则表示失败的错误原因。
        @NameInMap("errorMsg")
        public String errorMsg;

        // 保存成功的关系id。
        @NameInMap("relationId")
        public String relationId;

        // 数据是否保存成功。
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
