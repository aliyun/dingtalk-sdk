// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class CreateTaskResponseBody extends TeaModel {
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

    public static class CreateTaskResponseBodyResultCustomfieldsValue extends TeaModel {
        @NameInMap("title")
        public String title;

        public static CreateTaskResponseBodyResultCustomfieldsValue build(java.util.Map<String, ?> map) throws Exception {
            CreateTaskResponseBodyResultCustomfieldsValue self = new CreateTaskResponseBodyResultCustomfieldsValue();
            return TeaModel.build(map, self);
        }

        public CreateTaskResponseBodyResultCustomfieldsValue setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

    }

    public static class CreateTaskResponseBodyResultCustomfields extends TeaModel {
        @NameInMap("customfieldId")
        public String customfieldId;

        @NameInMap("value")
        public java.util.List<CreateTaskResponseBodyResultCustomfieldsValue> value;

        public static CreateTaskResponseBodyResultCustomfields build(java.util.Map<String, ?> map) throws Exception {
            CreateTaskResponseBodyResultCustomfields self = new CreateTaskResponseBodyResultCustomfields();
            return TeaModel.build(map, self);
        }

        public CreateTaskResponseBodyResultCustomfields setCustomfieldId(String customfieldId) {
            this.customfieldId = customfieldId;
            return this;
        }
        public String getCustomfieldId() {
            return this.customfieldId;
        }

        public CreateTaskResponseBodyResultCustomfields setValue(java.util.List<CreateTaskResponseBodyResultCustomfieldsValue> value) {
            this.value = value;
            return this;
        }
        public java.util.List<CreateTaskResponseBodyResultCustomfieldsValue> getValue() {
            return this.value;
        }

    }

    public static class CreateTaskResponseBodyResult extends TeaModel {
        @NameInMap("content")
        public String content;

        @NameInMap("created")
        public String created;

        @NameInMap("creatorId")
        public String creatorId;

        @NameInMap("customfields")
        public java.util.List<CreateTaskResponseBodyResultCustomfields> customfields;

        @NameInMap("dueDate")
        public String dueDate;

        @NameInMap("executorId")
        public String executorId;

        @NameInMap("involveMembers")
        public java.util.List<String> involveMembers;

        @NameInMap("note")
        public String note;

        @NameInMap("priority")
        public Integer priority;

        @NameInMap("projectId")
        public String projectId;

        @NameInMap("taskId")
        public String taskId;

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

        public CreateTaskResponseBodyResult setCustomfields(java.util.List<CreateTaskResponseBodyResultCustomfields> customfields) {
            this.customfields = customfields;
            return this;
        }
        public java.util.List<CreateTaskResponseBodyResultCustomfields> getCustomfields() {
            return this.customfields;
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
