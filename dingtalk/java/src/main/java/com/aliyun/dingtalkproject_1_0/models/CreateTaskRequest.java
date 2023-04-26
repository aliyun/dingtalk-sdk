// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class CreateTaskRequest extends TeaModel {
    @NameInMap("content")
    public String content;

    @NameInMap("customfields")
    public java.util.List<CreateTaskRequestCustomfields> customfields;

    @NameInMap("dueDate")
    public String dueDate;

    @NameInMap("executorId")
    public String executorId;

    @NameInMap("note")
    public String note;

    @NameInMap("parentTaskId")
    public String parentTaskId;

    @NameInMap("priority")
    public Integer priority;

    @NameInMap("projectId")
    public String projectId;

    @NameInMap("scenariofieldconfigId")
    public String scenariofieldconfigId;

    @NameInMap("stageId")
    public String stageId;

    @NameInMap("startDate")
    public String startDate;

    @NameInMap("visible")
    public String visible;

    public static CreateTaskRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateTaskRequest self = new CreateTaskRequest();
        return TeaModel.build(map, self);
    }

    public CreateTaskRequest setContent(String content) {
        this.content = content;
        return this;
    }
    public String getContent() {
        return this.content;
    }

    public CreateTaskRequest setCustomfields(java.util.List<CreateTaskRequestCustomfields> customfields) {
        this.customfields = customfields;
        return this;
    }
    public java.util.List<CreateTaskRequestCustomfields> getCustomfields() {
        return this.customfields;
    }

    public CreateTaskRequest setDueDate(String dueDate) {
        this.dueDate = dueDate;
        return this;
    }
    public String getDueDate() {
        return this.dueDate;
    }

    public CreateTaskRequest setExecutorId(String executorId) {
        this.executorId = executorId;
        return this;
    }
    public String getExecutorId() {
        return this.executorId;
    }

    public CreateTaskRequest setNote(String note) {
        this.note = note;
        return this;
    }
    public String getNote() {
        return this.note;
    }

    public CreateTaskRequest setParentTaskId(String parentTaskId) {
        this.parentTaskId = parentTaskId;
        return this;
    }
    public String getParentTaskId() {
        return this.parentTaskId;
    }

    public CreateTaskRequest setPriority(Integer priority) {
        this.priority = priority;
        return this;
    }
    public Integer getPriority() {
        return this.priority;
    }

    public CreateTaskRequest setProjectId(String projectId) {
        this.projectId = projectId;
        return this;
    }
    public String getProjectId() {
        return this.projectId;
    }

    public CreateTaskRequest setScenariofieldconfigId(String scenariofieldconfigId) {
        this.scenariofieldconfigId = scenariofieldconfigId;
        return this;
    }
    public String getScenariofieldconfigId() {
        return this.scenariofieldconfigId;
    }

    public CreateTaskRequest setStageId(String stageId) {
        this.stageId = stageId;
        return this;
    }
    public String getStageId() {
        return this.stageId;
    }

    public CreateTaskRequest setStartDate(String startDate) {
        this.startDate = startDate;
        return this;
    }
    public String getStartDate() {
        return this.startDate;
    }

    public CreateTaskRequest setVisible(String visible) {
        this.visible = visible;
        return this;
    }
    public String getVisible() {
        return this.visible;
    }

    public static class CreateTaskRequestCustomfieldsValue extends TeaModel {
        @NameInMap("title")
        public String title;

        public static CreateTaskRequestCustomfieldsValue build(java.util.Map<String, ?> map) throws Exception {
            CreateTaskRequestCustomfieldsValue self = new CreateTaskRequestCustomfieldsValue();
            return TeaModel.build(map, self);
        }

        public CreateTaskRequestCustomfieldsValue setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

    }

    public static class CreateTaskRequestCustomfields extends TeaModel {
        @NameInMap("customfieldId")
        public String customfieldId;

        @NameInMap("customfieldName")
        public String customfieldName;

        @NameInMap("value")
        public java.util.List<CreateTaskRequestCustomfieldsValue> value;

        public static CreateTaskRequestCustomfields build(java.util.Map<String, ?> map) throws Exception {
            CreateTaskRequestCustomfields self = new CreateTaskRequestCustomfields();
            return TeaModel.build(map, self);
        }

        public CreateTaskRequestCustomfields setCustomfieldId(String customfieldId) {
            this.customfieldId = customfieldId;
            return this;
        }
        public String getCustomfieldId() {
            return this.customfieldId;
        }

        public CreateTaskRequestCustomfields setCustomfieldName(String customfieldName) {
            this.customfieldName = customfieldName;
            return this;
        }
        public String getCustomfieldName() {
            return this.customfieldName;
        }

        public CreateTaskRequestCustomfields setValue(java.util.List<CreateTaskRequestCustomfieldsValue> value) {
            this.value = value;
            return this;
        }
        public java.util.List<CreateTaskRequestCustomfieldsValue> getValue() {
            return this.value;
        }

    }

}
