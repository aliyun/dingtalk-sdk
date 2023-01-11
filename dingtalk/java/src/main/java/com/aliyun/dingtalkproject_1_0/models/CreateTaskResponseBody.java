// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class CreateTaskResponseBody extends TeaModel {
    /**
     * <p>返回结果对象</p>
     */
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
        /**
         * <p>自定义字段显示值</p>
         */
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
        /**
         * <p>自定义字段id</p>
         */
        @NameInMap("customfieldId")
        public String customfieldId;

        /**
         * <p>自定义字段值</p>
         */
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
         * <p>任务创建者userId</p>
         */
        @NameInMap("creatorId")
        public String creatorId;

        /**
         * <p>自定义字段列表</p>
         */
        @NameInMap("customfields")
        public java.util.List<CreateTaskResponseBodyResultCustomfields> customfields;

        /**
         * <p>任务截止时间</p>
         */
        @NameInMap("dueDate")
        public String dueDate;

        /**
         * <p>任务执行者userId</p>
         */
        @NameInMap("executorId")
        public String executorId;

        /**
         * <p>任务参与者列表</p>
         */
        @NameInMap("involveMembers")
        public java.util.List<String> involveMembers;

        /**
         * <p>任务备注</p>
         */
        @NameInMap("note")
        public String note;

        /**
         * <p>任务优先级</p>
         */
        @NameInMap("priority")
        public Integer priority;

        /**
         * <p>项目id</p>
         */
        @NameInMap("projectId")
        public String projectId;

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
