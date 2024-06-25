// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class CreateWorkTimeApproveResponseBody extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>执行成功</p>
     */
    @NameInMap("message")
    public String message;

    /**
     * <strong>example:</strong>
     * <p>1234</p>
     */
    @NameInMap("requestId")
    public String requestId;

    @NameInMap("result")
    public CreateWorkTimeApproveResponseBodyResult result;

    public static CreateWorkTimeApproveResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CreateWorkTimeApproveResponseBody self = new CreateWorkTimeApproveResponseBody();
        return TeaModel.build(map, self);
    }

    public CreateWorkTimeApproveResponseBody setMessage(String message) {
        this.message = message;
        return this;
    }
    public String getMessage() {
        return this.message;
    }

    public CreateWorkTimeApproveResponseBody setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public CreateWorkTimeApproveResponseBody setResult(CreateWorkTimeApproveResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public CreateWorkTimeApproveResponseBodyResult getResult() {
        return this.result;
    }

    public static class CreateWorkTimeApproveResponseBodyResult extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>636c9634b183ac0040ee85b4</p>
         */
        @NameInMap("approveOpenId")
        public String approveOpenId;

        /**
         * <strong>example:</strong>
         * <p>2022-07-04T03:29:34.770Z</p>
         */
        @NameInMap("createdAt")
        public String createdAt;

        /**
         * <strong>example:</strong>
         * <p>6446626a9fb5a70c05fc3fc3</p>
         */
        @NameInMap("creatorId")
        public String creatorId;

        /**
         * <strong>example:</strong>
         * <p>ding123xxx</p>
         */
        @NameInMap("organizationId")
        public String organizationId;

        /**
         * <strong>example:</strong>
         * <p>NEW</p>
         */
        @NameInMap("status")
        public String status;

        /**
         * <strong>example:</strong>
         * <p>636c9634b183ac0040ee85b4</p>
         */
        @NameInMap("taskId")
        public String taskId;

        /**
         * <strong>example:</strong>
         * <p>100000</p>
         */
        @NameInMap("time")
        public Integer time;

        /**
         * <strong>example:</strong>
         * <p>2022-07-04T03:29:34.770Z</p>
         */
        @NameInMap("updatedAt")
        public String updatedAt;

        /**
         * <strong>example:</strong>
         * <p>6446626a9fb5a70c05fc3fc3</p>
         */
        @NameInMap("userId")
        public String userId;

        @NameInMap("workTimeIds")
        public java.util.List<String> workTimeIds;

        public static CreateWorkTimeApproveResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            CreateWorkTimeApproveResponseBodyResult self = new CreateWorkTimeApproveResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public CreateWorkTimeApproveResponseBodyResult setApproveOpenId(String approveOpenId) {
            this.approveOpenId = approveOpenId;
            return this;
        }
        public String getApproveOpenId() {
            return this.approveOpenId;
        }

        public CreateWorkTimeApproveResponseBodyResult setCreatedAt(String createdAt) {
            this.createdAt = createdAt;
            return this;
        }
        public String getCreatedAt() {
            return this.createdAt;
        }

        public CreateWorkTimeApproveResponseBodyResult setCreatorId(String creatorId) {
            this.creatorId = creatorId;
            return this;
        }
        public String getCreatorId() {
            return this.creatorId;
        }

        public CreateWorkTimeApproveResponseBodyResult setOrganizationId(String organizationId) {
            this.organizationId = organizationId;
            return this;
        }
        public String getOrganizationId() {
            return this.organizationId;
        }

        public CreateWorkTimeApproveResponseBodyResult setStatus(String status) {
            this.status = status;
            return this;
        }
        public String getStatus() {
            return this.status;
        }

        public CreateWorkTimeApproveResponseBodyResult setTaskId(String taskId) {
            this.taskId = taskId;
            return this;
        }
        public String getTaskId() {
            return this.taskId;
        }

        public CreateWorkTimeApproveResponseBodyResult setTime(Integer time) {
            this.time = time;
            return this;
        }
        public Integer getTime() {
            return this.time;
        }

        public CreateWorkTimeApproveResponseBodyResult setUpdatedAt(String updatedAt) {
            this.updatedAt = updatedAt;
            return this;
        }
        public String getUpdatedAt() {
            return this.updatedAt;
        }

        public CreateWorkTimeApproveResponseBodyResult setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

        public CreateWorkTimeApproveResponseBodyResult setWorkTimeIds(java.util.List<String> workTimeIds) {
            this.workTimeIds = workTimeIds;
            return this;
        }
        public java.util.List<String> getWorkTimeIds() {
            return this.workTimeIds;
        }

    }

}
