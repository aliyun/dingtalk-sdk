// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class CreateWorkTimeApproveResponseBody extends TeaModel {
    @NameInMap("message")
    public String message;

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
        @NameInMap("approveOpenId")
        public String approveOpenId;

        @NameInMap("createdAt")
        public String createdAt;

        @NameInMap("creatorId")
        public String creatorId;

        @NameInMap("organizationId")
        public String organizationId;

        @NameInMap("status")
        public String status;

        @NameInMap("taskId")
        public String taskId;

        @NameInMap("time")
        public Integer time;

        @NameInMap("updatedAt")
        public String updatedAt;

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
