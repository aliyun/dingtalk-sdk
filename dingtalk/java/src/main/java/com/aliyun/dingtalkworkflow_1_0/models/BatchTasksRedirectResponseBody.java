// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class BatchTasksRedirectResponseBody extends TeaModel {
    @NameInMap("result")
    public BatchTasksRedirectResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static BatchTasksRedirectResponseBody build(java.util.Map<String, ?> map) throws Exception {
        BatchTasksRedirectResponseBody self = new BatchTasksRedirectResponseBody();
        return TeaModel.build(map, self);
    }

    public BatchTasksRedirectResponseBody setResult(BatchTasksRedirectResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public BatchTasksRedirectResponseBodyResult getResult() {
        return this.result;
    }

    public BatchTasksRedirectResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class BatchTasksRedirectResponseBodyResultRedirectResults extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>外部流程不允许转交</p>
         */
        @NameInMap("errorMsg")
        public String errorMsg;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>success</p>
         */
        @NameInMap("success")
        public Boolean success;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>1234567</p>
         */
        @NameInMap("taskId")
        public Long taskId;

        public static BatchTasksRedirectResponseBodyResultRedirectResults build(java.util.Map<String, ?> map) throws Exception {
            BatchTasksRedirectResponseBodyResultRedirectResults self = new BatchTasksRedirectResponseBodyResultRedirectResults();
            return TeaModel.build(map, self);
        }

        public BatchTasksRedirectResponseBodyResultRedirectResults setErrorMsg(String errorMsg) {
            this.errorMsg = errorMsg;
            return this;
        }
        public String getErrorMsg() {
            return this.errorMsg;
        }

        public BatchTasksRedirectResponseBodyResultRedirectResults setSuccess(Boolean success) {
            this.success = success;
            return this;
        }
        public Boolean getSuccess() {
            return this.success;
        }

        public BatchTasksRedirectResponseBodyResultRedirectResults setTaskId(Long taskId) {
            this.taskId = taskId;
            return this;
        }
        public Long getTaskId() {
            return this.taskId;
        }

    }

    public static class BatchTasksRedirectResponseBodyResult extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>1</p>
         */
        @NameInMap("failCount")
        public Long failCount;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("redirectResults")
        public java.util.List<BatchTasksRedirectResponseBodyResultRedirectResults> redirectResults;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>20</p>
         */
        @NameInMap("totalCount")
        public Long totalCount;

        public static BatchTasksRedirectResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            BatchTasksRedirectResponseBodyResult self = new BatchTasksRedirectResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public BatchTasksRedirectResponseBodyResult setFailCount(Long failCount) {
            this.failCount = failCount;
            return this;
        }
        public Long getFailCount() {
            return this.failCount;
        }

        public BatchTasksRedirectResponseBodyResult setRedirectResults(java.util.List<BatchTasksRedirectResponseBodyResultRedirectResults> redirectResults) {
            this.redirectResults = redirectResults;
            return this;
        }
        public java.util.List<BatchTasksRedirectResponseBodyResultRedirectResults> getRedirectResults() {
            return this.redirectResults;
        }

        public BatchTasksRedirectResponseBodyResult setTotalCount(Long totalCount) {
            this.totalCount = totalCount;
            return this;
        }
        public Long getTotalCount() {
            return this.totalCount;
        }

    }

}
