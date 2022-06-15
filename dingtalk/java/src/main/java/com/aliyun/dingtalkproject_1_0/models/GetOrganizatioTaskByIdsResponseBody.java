// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class GetOrganizatioTaskByIdsResponseBody extends TeaModel {
    // 返回结构体
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
        // 父任务id
        @NameInMap("ancestorIds")
        public java.util.List<String> ancestorIds;

        // 任务标题
        @NameInMap("content")
        public String content;

        // 创建时间
        @NameInMap("created")
        public String created;

        // 创建者id
        @NameInMap("creatorId")
        public String creatorId;

        // 任务截止时间
        @NameInMap("dueDate")
        public String dueDate;

        // 执行者id
        @NameInMap("executorId")
        public String executorId;

        // 参与者列表
        @NameInMap("involveMembers")
        public java.util.List<String> involveMembers;

        // 任务是否已删除
        @NameInMap("isDeleted")
        public Boolean isDeleted;

        // 任务是否已完成
        @NameInMap("isDone")
        public Boolean isDone;

        // 任务自定义标记
        @NameInMap("labels")
        public java.util.List<String> labels;

        // 任务备注
        @NameInMap("note")
        public String note;

        // 优先级【-10,0,1,2】中选一个
        @NameInMap("priority")
        public Integer priority;

        // 任务开始时间
        @NameInMap("startDate")
        public String startDate;

        // 任务id
        @NameInMap("taskId")
        public String taskId;

        // 更新时间
        @NameInMap("updated")
        public String updated;

        // 任务可见性。involves：仅参与者可见。members:所有人可见
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
