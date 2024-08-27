// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class PremiumSaveIntegratedTaskResponseBody extends TeaModel {
    @NameInMap("result")
    public java.util.List<PremiumSaveIntegratedTaskResponseBodyResult> result;

    @NameInMap("success")
    public Boolean success;

    public static PremiumSaveIntegratedTaskResponseBody build(java.util.Map<String, ?> map) throws Exception {
        PremiumSaveIntegratedTaskResponseBody self = new PremiumSaveIntegratedTaskResponseBody();
        return TeaModel.build(map, self);
    }

    public PremiumSaveIntegratedTaskResponseBody setResult(java.util.List<PremiumSaveIntegratedTaskResponseBodyResult> result) {
        this.result = result;
        return this;
    }
    public java.util.List<PremiumSaveIntegratedTaskResponseBodyResult> getResult() {
        return this.result;
    }

    public PremiumSaveIntegratedTaskResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class PremiumSaveIntegratedTaskResponseBodyResult extends TeaModel {
        @NameInMap("taskId")
        public Long taskId;

        @NameInMap("userId")
        public String userId;

        public static PremiumSaveIntegratedTaskResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            PremiumSaveIntegratedTaskResponseBodyResult self = new PremiumSaveIntegratedTaskResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public PremiumSaveIntegratedTaskResponseBodyResult setTaskId(Long taskId) {
            this.taskId = taskId;
            return this;
        }
        public Long getTaskId() {
            return this.taskId;
        }

        public PremiumSaveIntegratedTaskResponseBodyResult setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

}
