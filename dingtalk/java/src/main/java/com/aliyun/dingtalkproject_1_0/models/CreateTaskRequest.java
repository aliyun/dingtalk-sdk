// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class CreateTaskRequest extends TeaModel {
    // 任务标题
    @NameInMap("content")
    public String content;

    // 自定义字段列表
    @NameInMap("customfields")
    public java.util.List<CreateTaskRequestCustomfields> customfields;

    // 任务截止时间
    @NameInMap("dueDate")
    public String dueDate;

    // 执行者userId
    @NameInMap("executorId")
    public String executorId;

    // 任务备注
    @NameInMap("note")
    public String note;

    // 父任务id。
    @NameInMap("parentTaskId")
    public String parentTaskId;

    // 任务优先级
    @NameInMap("priority")
    public Integer priority;

    // 项目id
    @NameInMap("projectId")
    public String projectId;

    // 任务类型id，任务类型比如：缺陷、需求。。
    @NameInMap("scenariofieldconfigId")
    public String scenariofieldconfigId;

    // 任务列id。
    @NameInMap("stageId")
    public String stageId;

    // 任务开始时间。
    @NameInMap("startDate")
    public String startDate;

    // 任务可见性,members,involves。
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
        // 自定义字段显示值
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
        // 自定义字段id
        @NameInMap("customfieldId")
        public String customfieldId;

        // 自定义字段名称
        @NameInMap("customfieldName")
        public String customfieldName;

        // 自定义字段值
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
