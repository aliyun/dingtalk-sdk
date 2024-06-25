// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class BatchUpdateRelationDatasResponseBody extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>true</p>
     */
    @NameInMap("results")
    public java.util.List<BatchUpdateRelationDatasResponseBodyResults> results;

    public static BatchUpdateRelationDatasResponseBody build(java.util.Map<String, ?> map) throws Exception {
        BatchUpdateRelationDatasResponseBody self = new BatchUpdateRelationDatasResponseBody();
        return TeaModel.build(map, self);
    }

    public BatchUpdateRelationDatasResponseBody setResults(java.util.List<BatchUpdateRelationDatasResponseBodyResults> results) {
        this.results = results;
        return this;
    }
    public java.util.List<BatchUpdateRelationDatasResponseBodyResults> getResults() {
        return this.results;
    }

    public static class BatchUpdateRelationDatasResponseBodyResults extends TeaModel {
        @NameInMap("duplicatedRelationIds")
        public java.util.List<String> duplicatedRelationIds;

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
         * <p>gads1ag-sfgasdfxcvxb</p>
         */
        @NameInMap("relationId")
        public String relationId;

        /**
         * <strong>example:</strong>
         * <p>true</p>
         */
        @NameInMap("success")
        public Boolean success;

        public static BatchUpdateRelationDatasResponseBodyResults build(java.util.Map<String, ?> map) throws Exception {
            BatchUpdateRelationDatasResponseBodyResults self = new BatchUpdateRelationDatasResponseBodyResults();
            return TeaModel.build(map, self);
        }

        public BatchUpdateRelationDatasResponseBodyResults setDuplicatedRelationIds(java.util.List<String> duplicatedRelationIds) {
            this.duplicatedRelationIds = duplicatedRelationIds;
            return this;
        }
        public java.util.List<String> getDuplicatedRelationIds() {
            return this.duplicatedRelationIds;
        }

        public BatchUpdateRelationDatasResponseBodyResults setErrorCode(String errorCode) {
            this.errorCode = errorCode;
            return this;
        }
        public String getErrorCode() {
            return this.errorCode;
        }

        public BatchUpdateRelationDatasResponseBodyResults setErrorMsg(String errorMsg) {
            this.errorMsg = errorMsg;
            return this;
        }
        public String getErrorMsg() {
            return this.errorMsg;
        }

        public BatchUpdateRelationDatasResponseBodyResults setRelationId(String relationId) {
            this.relationId = relationId;
            return this;
        }
        public String getRelationId() {
            return this.relationId;
        }

        public BatchUpdateRelationDatasResponseBodyResults setSuccess(Boolean success) {
            this.success = success;
            return this;
        }
        public Boolean getSuccess() {
            return this.success;
        }

    }

}
