// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class CreateIntegratedTaskResponseBody extends TeaModel {
    @NameInMap("result")
    public java.util.List<CreateIntegratedTaskResponseBodyResult> result;

    /**
     * <p>是否创建成功</p>
     */
    @NameInMap("success")
    public Boolean success;

    public static CreateIntegratedTaskResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CreateIntegratedTaskResponseBody self = new CreateIntegratedTaskResponseBody();
        return TeaModel.build(map, self);
    }

    public CreateIntegratedTaskResponseBody setResult(java.util.List<CreateIntegratedTaskResponseBodyResult> result) {
        this.result = result;
        return this;
    }
    public java.util.List<CreateIntegratedTaskResponseBodyResult> getResult() {
        return this.result;
    }

    public CreateIntegratedTaskResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class CreateIntegratedTaskResponseBodyResult extends TeaModel {
        /**
         * <p>OA审批任务ID</p>
         */
        @NameInMap("taskId")
        public Long taskId;

        /**
         * <p>OA审批任务执行人用户ID</p>
         */
        @NameInMap("userId")
        public String userId;

        public static CreateIntegratedTaskResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            CreateIntegratedTaskResponseBodyResult self = new CreateIntegratedTaskResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public CreateIntegratedTaskResponseBodyResult setTaskId(Long taskId) {
            this.taskId = taskId;
            return this;
        }
        public Long getTaskId() {
            return this.taskId;
        }

        public CreateIntegratedTaskResponseBodyResult setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

}
