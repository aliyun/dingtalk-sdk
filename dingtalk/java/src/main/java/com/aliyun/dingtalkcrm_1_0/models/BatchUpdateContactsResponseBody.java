// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class BatchUpdateContactsResponseBody extends TeaModel {
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
        @NameInMap("errorCode")
        public String errorCode;

        @NameInMap("errorMsg")
        public String errorMsg;

        @NameInMap("relationId")
        public String relationId;

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
