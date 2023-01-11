// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class GetOrganizatioTaskByIdsResponseBody extends TeaModel {
    /**
     * <p>返回结构体</p>
     */
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
        /**
         * <p>父任务id</p>
         */
        @NameInMap("ancestorIds")
        public java.util.List<String> ancestorIds;

        /**
         * <p>任务标题</p>
         */
        @NameInMap("content")
        public String content;

        /**
         * <p>创建时间</p>
         */
        @NameInMap("created")
        public String created;

        /**
         * <p>创建者id</p>
         */
        @NameInMap("creatorId")
        public String creatorId;

        /**
         * <p>任务截止时间</p>
         */
        @NameInMap("dueDate")
        public String dueDate;

        /**
         * <p>执行者id</p>
         */
        @NameInMap("executorId")
        public String executorId;

        /**
         * <p>参与者列表</p>
         */
        @NameInMap("involveMembers")
        public java.util.List<String> involveMembers;

        /**
         * <p>任务是否已删除</p>
         */
        @NameInMap("isDeleted")
        public Boolean isDeleted;

        /**
         * <p>任务是否已完成</p>
         */
        @NameInMap("isDone")
        public Boolean isDone;

        /**
         * <p>任务自定义标记</p>
         */
        @NameInMap("labels")
        public java.util.List<String> labels;

        /**
         * <p>任务备注</p>
         */
        @NameInMap("note")
        public String note;

        /**
         * <p>优先级【-10,0,1,2】中选一个</p>
         */
        @NameInMap("priority")
        public Integer priority;

        /**
         * <p>任务开始时间</p>
         */
        @NameInMap("startDate")
        public String startDate;

        /**
         * <p>任务id</p>
         */
        @NameInMap("taskId")
        public String taskId;

        /**
         * <p>更新时间</p>
         */
        @NameInMap("updated")
        public String updated;

        /**
         * <p>任务可见性。involves：仅参与者可见。members:所有人可见</p>
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
