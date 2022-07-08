// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class CreateTaskResponseBody extends TeaModel {
    // 返回结果对象
    @NameInMap("result")
    public CreateTaskResponseBodyResult result;

    public static CreateTaskResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CreateTaskResponseBody self = new CreateTaskResponseBody();
        return TeaModel.build(map, self);
    }

    public CreateTaskResponseBody setResult(CreateTaskResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public CreateTaskResponseBodyResult getResult() {
        return this.result;
    }

    public static class CreateTaskResponseBodyResult extends TeaModel {
        // 任务标题
        @NameInMap("content")
        public String content;

        // 创建时间
        @NameInMap("created")
        public String created;

        // 任务创建者userId
        @NameInMap("creatorId")
        public String creatorId;

        // 任务截止时间
        @NameInMap("dueDate")
        public String dueDate;

        // 任务执行者userId
        @NameInMap("executorId")
        public String executorId;

        // 任务参与者列表
        @NameInMap("involveMembers")
        public java.util.List<String> involveMembers;

        // 任务备注
        @NameInMap("note")
        public String note;

        // 任务优先级
        @NameInMap("priority")
        public Integer priority;

        // 项目id
        @NameInMap("projectId")
        public String projectId;

        // 任务id
        @NameInMap("taskId")
        public String taskId;

        // 更新时间
        @NameInMap("updated")
        public String updated;

        public static CreateTaskResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            CreateTaskResponseBodyResult self = new CreateTaskResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public CreateTaskResponseBodyResult setContent(String content) {
            this.content = content;
            return this;
        }
        public String getContent() {
            return this.content;
        }

        public CreateTaskResponseBodyResult setCreated(String created) {
            this.created = created;
            return this;
        }
        public String getCreated() {
            return this.created;
        }

        public CreateTaskResponseBodyResult setCreatorId(String creatorId) {
            this.creatorId = creatorId;
            return this;
        }
        public String getCreatorId() {
            return this.creatorId;
        }

        public CreateTaskResponseBodyResult setDueDate(String dueDate) {
            this.dueDate = dueDate;
            return this;
        }
        public String getDueDate() {
            return this.dueDate;
        }

        public CreateTaskResponseBodyResult setExecutorId(String executorId) {
            this.executorId = executorId;
            return this;
        }
        public String getExecutorId() {
            return this.executorId;
        }

        public CreateTaskResponseBodyResult setInvolveMembers(java.util.List<String> involveMembers) {
            this.involveMembers = involveMembers;
            return this;
        }
        public java.util.List<String> getInvolveMembers() {
            return this.involveMembers;
        }

        public CreateTaskResponseBodyResult setNote(String note) {
            this.note = note;
            return this;
        }
        public String getNote() {
            return this.note;
        }

        public CreateTaskResponseBodyResult setPriority(Integer priority) {
            this.priority = priority;
            return this;
        }
        public Integer getPriority() {
            return this.priority;
        }

        public CreateTaskResponseBodyResult setProjectId(String projectId) {
            this.projectId = projectId;
            return this;
        }
        public String getProjectId() {
            return this.projectId;
        }

        public CreateTaskResponseBodyResult setTaskId(String taskId) {
            this.taskId = taskId;
            return this;
        }
        public String getTaskId() {
            return this.taskId;
        }

        public CreateTaskResponseBodyResult setUpdated(String updated) {
            this.updated = updated;
            return this;
        }
        public String getUpdated() {
            return this.updated;
        }

    }

}
