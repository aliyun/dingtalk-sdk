// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class UpdateWorkTimeApproveResponseBody extends TeaModel {
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
    public UpdateWorkTimeApproveResponseBodyResult result;

    public static UpdateWorkTimeApproveResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdateWorkTimeApproveResponseBody self = new UpdateWorkTimeApproveResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdateWorkTimeApproveResponseBody setMessage(String message) {
        this.message = message;
        return this;
    }
    public String getMessage() {
        return this.message;
    }

    public UpdateWorkTimeApproveResponseBody setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public UpdateWorkTimeApproveResponseBody setResult(UpdateWorkTimeApproveResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public UpdateWorkTimeApproveResponseBodyResult getResult() {
        return this.result;
    }

    public static class UpdateWorkTimeApproveResponseBodyResult extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>6446626a9fb5a70c05fc3fc3</p>
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
         * <p>2023-04-04T00:00:00.000Z</p>
         */
        @NameInMap("finishTime")
        public String finishTime;

        /**
         * <strong>example:</strong>
         * <p>12345</p>
         */
        @NameInMap("instanceId")
        public String instanceId;

        /**
         * <strong>example:</strong>
         * <p>dingxxxx</p>
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
         * <p>2023-04-04T00:00:00.000Z</p>
         */
        @NameInMap("submitTime")
        public String submitTime;

        /**
         * <strong>example:</strong>
         * <p>6446626a9fb5a70c05fc3fc3</p>
         */
        @NameInMap("taskId")
        public String taskId;

        /**
         * <strong>example:</strong>
         * <p>10000</p>
         */
        @NameInMap("time")
        public Integer time;

        /**
         * <strong>example:</strong>
         * <p>xxx用工申请</p>
         */
        @NameInMap("title")
        public String title;

        /**
         * <strong>example:</strong>
         * <p>2022-07-04T03:29:34.770Z</p>
         */
        @NameInMap("updatedAt")
        public String updatedAt;

        /**
         * <strong>example:</strong>
         * <p><a href="https://xxxbpms.xxx/xxxx">https://xxxbpms.xxx/xxxx</a></p>
         */
        @NameInMap("url")
        public String url;

        /**
         * <strong>example:</strong>
         * <p>6446626a9fb5a70c05fc3fc3</p>
         */
        @NameInMap("userId")
        public String userId;

        @NameInMap("workTimeIds")
        public java.util.List<String> workTimeIds;

        public static UpdateWorkTimeApproveResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            UpdateWorkTimeApproveResponseBodyResult self = new UpdateWorkTimeApproveResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public UpdateWorkTimeApproveResponseBodyResult setApproveOpenId(String approveOpenId) {
            this.approveOpenId = approveOpenId;
            return this;
        }
        public String getApproveOpenId() {
            return this.approveOpenId;
        }

        public UpdateWorkTimeApproveResponseBodyResult setCreatedAt(String createdAt) {
            this.createdAt = createdAt;
            return this;
        }
        public String getCreatedAt() {
            return this.createdAt;
        }

        public UpdateWorkTimeApproveResponseBodyResult setCreatorId(String creatorId) {
            this.creatorId = creatorId;
            return this;
        }
        public String getCreatorId() {
            return this.creatorId;
        }

        public UpdateWorkTimeApproveResponseBodyResult setFinishTime(String finishTime) {
            this.finishTime = finishTime;
            return this;
        }
        public String getFinishTime() {
            return this.finishTime;
        }

        public UpdateWorkTimeApproveResponseBodyResult setInstanceId(String instanceId) {
            this.instanceId = instanceId;
            return this;
        }
        public String getInstanceId() {
            return this.instanceId;
        }

        public UpdateWorkTimeApproveResponseBodyResult setOrganizationId(String organizationId) {
            this.organizationId = organizationId;
            return this;
        }
        public String getOrganizationId() {
            return this.organizationId;
        }

        public UpdateWorkTimeApproveResponseBodyResult setStatus(String status) {
            this.status = status;
            return this;
        }
        public String getStatus() {
            return this.status;
        }

        public UpdateWorkTimeApproveResponseBodyResult setSubmitTime(String submitTime) {
            this.submitTime = submitTime;
            return this;
        }
        public String getSubmitTime() {
            return this.submitTime;
        }

        public UpdateWorkTimeApproveResponseBodyResult setTaskId(String taskId) {
            this.taskId = taskId;
            return this;
        }
        public String getTaskId() {
            return this.taskId;
        }

        public UpdateWorkTimeApproveResponseBodyResult setTime(Integer time) {
            this.time = time;
            return this;
        }
        public Integer getTime() {
            return this.time;
        }

        public UpdateWorkTimeApproveResponseBodyResult setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

        public UpdateWorkTimeApproveResponseBodyResult setUpdatedAt(String updatedAt) {
            this.updatedAt = updatedAt;
            return this;
        }
        public String getUpdatedAt() {
            return this.updatedAt;
        }

        public UpdateWorkTimeApproveResponseBodyResult setUrl(String url) {
            this.url = url;
            return this;
        }
        public String getUrl() {
            return this.url;
        }

        public UpdateWorkTimeApproveResponseBodyResult setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

        public UpdateWorkTimeApproveResponseBodyResult setWorkTimeIds(java.util.List<String> workTimeIds) {
            this.workTimeIds = workTimeIds;
            return this;
        }
        public java.util.List<String> getWorkTimeIds() {
            return this.workTimeIds;
        }

    }

}
