// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class BatchAddContactsResponseBody extends TeaModel {
    @NameInMap("results")
    public java.util.List<BatchAddContactsResponseBodyResults> results;

    public static BatchAddContactsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        BatchAddContactsResponseBody self = new BatchAddContactsResponseBody();
        return TeaModel.build(map, self);
    }

    public BatchAddContactsResponseBody setResults(java.util.List<BatchAddContactsResponseBodyResults> results) {
        this.results = results;
        return this;
    }
    public java.util.List<BatchAddContactsResponseBodyResults> getResults() {
        return this.results;
    }

    public static class BatchAddContactsResponseBodyResults extends TeaModel {
        @NameInMap("errorCode")
        public String errorCode;

        @NameInMap("errorMsg")
        public String errorMsg;

        @NameInMap("relationId")
        public String relationId;

        @NameInMap("success")
        public Boolean success;

        public static BatchAddContactsResponseBodyResults build(java.util.Map<String, ?> map) throws Exception {
            BatchAddContactsResponseBodyResults self = new BatchAddContactsResponseBodyResults();
            return TeaModel.build(map, self);
        }

        public BatchAddContactsResponseBodyResults setErrorCode(String errorCode) {
            this.errorCode = errorCode;
            return this;
        }
        public String getErrorCode() {
            return this.errorCode;
        }

        public BatchAddContactsResponseBodyResults setErrorMsg(String errorMsg) {
            this.errorMsg = errorMsg;
            return this;
        }
        public String getErrorMsg() {
            return this.errorMsg;
        }

        public BatchAddContactsResponseBodyResults setRelationId(String relationId) {
            this.relationId = relationId;
            return this;
        }
        public String getRelationId() {
            return this.relationId;
        }

        public BatchAddContactsResponseBodyResults setSuccess(Boolean success) {
            this.success = success;
            return this;
        }
        public Boolean getSuccess() {
            return this.success;
        }

    }

}
