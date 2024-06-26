// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class GetOrganizationTaskResponseBody extends TeaModel {
    @NameInMap("result")
    public GetOrganizationTaskResponseBodyResult result;

    public static GetOrganizationTaskResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetOrganizationTaskResponseBody self = new GetOrganizationTaskResponseBody();
        return TeaModel.build(map, self);
    }

    public GetOrganizationTaskResponseBody setResult(GetOrganizationTaskResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public GetOrganizationTaskResponseBodyResult getResult() {
        return this.result;
    }

    public static class GetOrganizationTaskResponseBodyResult extends TeaModel {
        @NameInMap("ancestorIds")
        public java.util.List<String> ancestorIds;

        /**
         * <strong>example:</strong>
         * <p>明天12点前写好周报</p>
         */
        @NameInMap("content")
        public String content;

        /**
         * <strong>example:</strong>
         * <p>2021-08-13T07:36:50.318Z</p>
         */
        @NameInMap("created")
        public String created;

        /**
         * <strong>example:</strong>
         * <p>173xxxx</p>
         */
        @NameInMap("creatorId")
        public String creatorId;

        /**
         * <strong>example:</strong>
         * <p>2021-08-13T07:36:50.318Z</p>
         */
        @NameInMap("dueDate")
        public String dueDate;

        /**
         * <strong>example:</strong>
         * <p>173xxxx</p>
         */
        @NameInMap("executorId")
        public String executorId;

        @NameInMap("involveMembers")
        public java.util.List<String> involveMembers;

        /**
         * <strong>example:</strong>
         * <p>false</p>
         */
        @NameInMap("isDeleted")
        public Boolean isDeleted;

        /**
         * <strong>example:</strong>
         * <p>false</p>
         */
        @NameInMap("isDone")
        public Boolean isDone;

        @NameInMap("labels")
        public java.util.List<String> labels;

        /**
         * <strong>example:</strong>
         * <p>我是一条备注哦</p>
         */
        @NameInMap("note")
        public String note;

        /**
         * <strong>example:</strong>
         * <p>-10</p>
         */
        @NameInMap("priority")
        public Integer priority;

        /**
         * <strong>example:</strong>
         * <p>2021-08-13T07:36:50.318Z</p>
         */
        @NameInMap("startDate")
        public String startDate;

        /**
         * <strong>example:</strong>
         * <p>62a010c153c2exxxxxxxxx</p>
         */
        @NameInMap("taskId")
        public String taskId;

        /**
         * <strong>example:</strong>
         * <p>2021-08-13T07:36:50.318Z</p>
         */
        @NameInMap("updated")
        public String updated;

        /**
         * <strong>example:</strong>
         * <p>members</p>
         */
        @NameInMap("visible")
        public String visible;

        public static GetOrganizationTaskResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            GetOrganizationTaskResponseBodyResult self = new GetOrganizationTaskResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public GetOrganizationTaskResponseBodyResult setAncestorIds(java.util.List<String> ancestorIds) {
            this.ancestorIds = ancestorIds;
            return this;
        }
        public java.util.List<String> getAncestorIds() {
            return this.ancestorIds;
        }

        public GetOrganizationTaskResponseBodyResult setContent(String content) {
            this.content = content;
            return this;
        }
        public String getContent() {
            return this.content;
        }

        public GetOrganizationTaskResponseBodyResult setCreated(String created) {
            this.created = created;
            return this;
        }
        public String getCreated() {
            return this.created;
        }

        public GetOrganizationTaskResponseBodyResult setCreatorId(String creatorId) {
            this.creatorId = creatorId;
            return this;
        }
        public String getCreatorId() {
            return this.creatorId;
        }

        public GetOrganizationTaskResponseBodyResult setDueDate(String dueDate) {
            this.dueDate = dueDate;
            return this;
        }
        public String getDueDate() {
            return this.dueDate;
        }

        public GetOrganizationTaskResponseBodyResult setExecutorId(String executorId) {
            this.executorId = executorId;
            return this;
        }
        public String getExecutorId() {
            return this.executorId;
        }

        public GetOrganizationTaskResponseBodyResult setInvolveMembers(java.util.List<String> involveMembers) {
            this.involveMembers = involveMembers;
            return this;
        }
        public java.util.List<String> getInvolveMembers() {
            return this.involveMembers;
        }

        public GetOrganizationTaskResponseBodyResult setIsDeleted(Boolean isDeleted) {
            this.isDeleted = isDeleted;
            return this;
        }
        public Boolean getIsDeleted() {
            return this.isDeleted;
        }

        public GetOrganizationTaskResponseBodyResult setIsDone(Boolean isDone) {
            this.isDone = isDone;
            return this;
        }
        public Boolean getIsDone() {
            return this.isDone;
        }

        public GetOrganizationTaskResponseBodyResult setLabels(java.util.List<String> labels) {
            this.labels = labels;
            return this;
        }
        public java.util.List<String> getLabels() {
            return this.labels;
        }

        public GetOrganizationTaskResponseBodyResult setNote(String note) {
            this.note = note;
            return this;
        }
        public String getNote() {
            return this.note;
        }

        public GetOrganizationTaskResponseBodyResult setPriority(Integer priority) {
            this.priority = priority;
            return this;
        }
        public Integer getPriority() {
            return this.priority;
        }

        public GetOrganizationTaskResponseBodyResult setStartDate(String startDate) {
            this.startDate = startDate;
            return this;
        }
        public String getStartDate() {
            return this.startDate;
        }

        public GetOrganizationTaskResponseBodyResult setTaskId(String taskId) {
            this.taskId = taskId;
            return this;
        }
        public String getTaskId() {
            return this.taskId;
        }

        public GetOrganizationTaskResponseBodyResult setUpdated(String updated) {
            this.updated = updated;
            return this;
        }
        public String getUpdated() {
            return this.updated;
        }

        public GetOrganizationTaskResponseBodyResult setVisible(String visible) {
            this.visible = visible;
            return this;
        }
        public String getVisible() {
            return this.visible;
        }

    }

}
