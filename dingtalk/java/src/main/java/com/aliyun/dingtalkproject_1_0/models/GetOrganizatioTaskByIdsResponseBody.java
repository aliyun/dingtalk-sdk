// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class GetOrganizatioTaskByIdsResponseBody extends TeaModel {
    @NameInMap("result")
    public java.util.List<GetOrganizatioTaskByIdsResponseBodyResult> result;

    public static GetOrganizatioTaskByIdsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetOrganizatioTaskByIdsResponseBody self = new GetOrganizatioTaskByIdsResponseBody();
        return TeaModel.build(map, self);
    }

    public GetOrganizatioTaskByIdsResponseBody setResult(java.util.List<GetOrganizatioTaskByIdsResponseBodyResult> result) {
        this.result = result;
        return this;
    }
    public java.util.List<GetOrganizatioTaskByIdsResponseBodyResult> getResult() {
        return this.result;
    }

    public static class GetOrganizatioTaskByIdsResponseBodyResult extends TeaModel {
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
         * <p>62a010c153c2efxxxxxxx</p>
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

        public static GetOrganizatioTaskByIdsResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            GetOrganizatioTaskByIdsResponseBodyResult self = new GetOrganizatioTaskByIdsResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public GetOrganizatioTaskByIdsResponseBodyResult setAncestorIds(java.util.List<String> ancestorIds) {
            this.ancestorIds = ancestorIds;
            return this;
        }
        public java.util.List<String> getAncestorIds() {
            return this.ancestorIds;
        }

        public GetOrganizatioTaskByIdsResponseBodyResult setContent(String content) {
            this.content = content;
            return this;
        }
        public String getContent() {
            return this.content;
        }

        public GetOrganizatioTaskByIdsResponseBodyResult setCreated(String created) {
            this.created = created;
            return this;
        }
        public String getCreated() {
            return this.created;
        }

        public GetOrganizatioTaskByIdsResponseBodyResult setCreatorId(String creatorId) {
            this.creatorId = creatorId;
            return this;
        }
        public String getCreatorId() {
            return this.creatorId;
        }

        public GetOrganizatioTaskByIdsResponseBodyResult setDueDate(String dueDate) {
            this.dueDate = dueDate;
            return this;
        }
        public String getDueDate() {
            return this.dueDate;
        }

        public GetOrganizatioTaskByIdsResponseBodyResult setExecutorId(String executorId) {
            this.executorId = executorId;
            return this;
        }
        public String getExecutorId() {
            return this.executorId;
        }

        public GetOrganizatioTaskByIdsResponseBodyResult setInvolveMembers(java.util.List<String> involveMembers) {
            this.involveMembers = involveMembers;
            return this;
        }
        public java.util.List<String> getInvolveMembers() {
            return this.involveMembers;
        }

        public GetOrganizatioTaskByIdsResponseBodyResult setIsDeleted(Boolean isDeleted) {
            this.isDeleted = isDeleted;
            return this;
        }
        public Boolean getIsDeleted() {
            return this.isDeleted;
        }

        public GetOrganizatioTaskByIdsResponseBodyResult setIsDone(Boolean isDone) {
            this.isDone = isDone;
            return this;
        }
        public Boolean getIsDone() {
            return this.isDone;
        }

        public GetOrganizatioTaskByIdsResponseBodyResult setLabels(java.util.List<String> labels) {
            this.labels = labels;
            return this;
        }
        public java.util.List<String> getLabels() {
            return this.labels;
        }

        public GetOrganizatioTaskByIdsResponseBodyResult setNote(String note) {
            this.note = note;
            return this;
        }
        public String getNote() {
            return this.note;
        }

        public GetOrganizatioTaskByIdsResponseBodyResult setPriority(Integer priority) {
            this.priority = priority;
            return this;
        }
        public Integer getPriority() {
            return this.priority;
        }

        public GetOrganizatioTaskByIdsResponseBodyResult setStartDate(String startDate) {
            this.startDate = startDate;
            return this;
        }
        public String getStartDate() {
            return this.startDate;
        }

        public GetOrganizatioTaskByIdsResponseBodyResult setTaskId(String taskId) {
            this.taskId = taskId;
            return this;
        }
        public String getTaskId() {
            return this.taskId;
        }

        public GetOrganizatioTaskByIdsResponseBodyResult setUpdated(String updated) {
            this.updated = updated;
            return this;
        }
        public String getUpdated() {
            return this.updated;
        }

        public GetOrganizatioTaskByIdsResponseBodyResult setVisible(String visible) {
            this.visible = visible;
            return this;
        }
        public String getVisible() {
            return this.visible;
        }

    }

}
