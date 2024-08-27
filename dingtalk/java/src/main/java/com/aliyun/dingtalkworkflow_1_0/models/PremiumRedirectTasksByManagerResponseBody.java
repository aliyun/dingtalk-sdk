// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class PremiumRedirectTasksByManagerResponseBody extends TeaModel {
    @NameInMap("result")
    public PremiumRedirectTasksByManagerResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static PremiumRedirectTasksByManagerResponseBody build(java.util.Map<String, ?> map) throws Exception {
        PremiumRedirectTasksByManagerResponseBody self = new PremiumRedirectTasksByManagerResponseBody();
        return TeaModel.build(map, self);
    }

    public PremiumRedirectTasksByManagerResponseBody setResult(PremiumRedirectTasksByManagerResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public PremiumRedirectTasksByManagerResponseBodyResult getResult() {
        return this.result;
    }

    public PremiumRedirectTasksByManagerResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class PremiumRedirectTasksByManagerResponseBodyResultRedirectResults extends TeaModel {
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

        public static PremiumRedirectTasksByManagerResponseBodyResultRedirectResults build(java.util.Map<String, ?> map) throws Exception {
            PremiumRedirectTasksByManagerResponseBodyResultRedirectResults self = new PremiumRedirectTasksByManagerResponseBodyResultRedirectResults();
            return TeaModel.build(map, self);
        }

        public PremiumRedirectTasksByManagerResponseBodyResultRedirectResults setErrorMsg(String errorMsg) {
            this.errorMsg = errorMsg;
            return this;
        }
        public String getErrorMsg() {
            return this.errorMsg;
        }

        public PremiumRedirectTasksByManagerResponseBodyResultRedirectResults setSuccess(Boolean success) {
            this.success = success;
            return this;
        }
        public Boolean getSuccess() {
            return this.success;
        }

        public PremiumRedirectTasksByManagerResponseBodyResultRedirectResults setTaskId(Long taskId) {
            this.taskId = taskId;
            return this;
        }
        public Long getTaskId() {
            return this.taskId;
        }

    }

    public static class PremiumRedirectTasksByManagerResponseBodyResult extends TeaModel {
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
        public java.util.List<PremiumRedirectTasksByManagerResponseBodyResultRedirectResults> redirectResults;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>20</p>
         */
        @NameInMap("totalCount")
        public Long totalCount;

        public static PremiumRedirectTasksByManagerResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            PremiumRedirectTasksByManagerResponseBodyResult self = new PremiumRedirectTasksByManagerResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public PremiumRedirectTasksByManagerResponseBodyResult setFailCount(Long failCount) {
            this.failCount = failCount;
            return this;
        }
        public Long getFailCount() {
            return this.failCount;
        }

        public PremiumRedirectTasksByManagerResponseBodyResult setRedirectResults(java.util.List<PremiumRedirectTasksByManagerResponseBodyResultRedirectResults> redirectResults) {
            this.redirectResults = redirectResults;
            return this;
        }
        public java.util.List<PremiumRedirectTasksByManagerResponseBodyResultRedirectResults> getRedirectResults() {
            return this.redirectResults;
        }

        public PremiumRedirectTasksByManagerResponseBodyResult setTotalCount(Long totalCount) {
            this.totalCount = totalCount;
            return this;
        }
        public Long getTotalCount() {
            return this.totalCount;
        }

    }

}
