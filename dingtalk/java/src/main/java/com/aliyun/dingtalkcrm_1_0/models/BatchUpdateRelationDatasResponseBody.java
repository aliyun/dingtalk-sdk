// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class BatchUpdateRelationDatasResponseBody extends TeaModel {
    /**
     * <p>批量插入结果列表，results的结果和要新增的数据是一一对应的，可以获取到每条数据分别是否成功。</p>
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
        /**
         * <p>如果因为查重导致失败，表示重复的关系数据id列表。</p>
         */
        @NameInMap("duplicatedRelationIds")
        public java.util.List<String> duplicatedRelationIds;

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
