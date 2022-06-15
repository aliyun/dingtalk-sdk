// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class CreateOrganizationTaskRequest extends TeaModel {
    // 任务标题
    @NameInMap("content")
    public String content;

    // 任务创建日期
    @NameInMap("createTime")
    public String createTime;

    // 是否禁止动态
    @NameInMap("disableActivity")
    public Boolean disableActivity;

    // 是否禁止通知
    @NameInMap("disableNotification")
    public Boolean disableNotification;

    // 任务截止日期
    @NameInMap("dueDate")
    public String dueDate;

    // 执行者id
    @NameInMap("executorId")
    public String executorId;

    // 参与者id
    @NameInMap("involveMembers")
    public java.util.List<String> involveMembers;

    // 任务是否完成
    @NameInMap("isDone")
    public Boolean isDone;

    // 任务自定义标记
    @NameInMap("label")
    public String label;

    // 任务备注
    @NameInMap("note")
    public String note;

    // 优先级【-10,0,1,2】中选一个
    @NameInMap("priority")
    public Integer priority;

    // 任务可见性。involves：仅参与者可见。members:所有人可见
    @NameInMap("visible")
    public String visible;

    public static CreateOrganizationTaskRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateOrganizationTaskRequest self = new CreateOrganizationTaskRequest();
        return TeaModel.build(map, self);
    }

    public CreateOrganizationTaskRequest setContent(String content) {
        this.content = content;
        return this;
    }
    public String getContent() {
        return this.content;
    }

    public CreateOrganizationTaskRequest setCreateTime(String createTime) {
        this.createTime = createTime;
        return this;
    }
    public String getCreateTime() {
        return this.createTime;
    }

    public CreateOrganizationTaskRequest setDisableActivity(Boolean disableActivity) {
        this.disableActivity = disableActivity;
        return this;
    }
    public Boolean getDisableActivity() {
        return this.disableActivity;
    }

    public CreateOrganizationTaskRequest setDisableNotification(Boolean disableNotification) {
        this.disableNotification = disableNotification;
        return this;
    }
    public Boolean getDisableNotification() {
        return this.disableNotification;
    }

    public CreateOrganizationTaskRequest setDueDate(String dueDate) {
        this.dueDate = dueDate;
        return this;
    }
    public String getDueDate() {
        return this.dueDate;
    }

    public CreateOrganizationTaskRequest setExecutorId(String executorId) {
        this.executorId = executorId;
        return this;
    }
    public String getExecutorId() {
        return this.executorId;
    }

    public CreateOrganizationTaskRequest setInvolveMembers(java.util.List<String> involveMembers) {
        this.involveMembers = involveMembers;
        return this;
    }
    public java.util.List<String> getInvolveMembers() {
        return this.involveMembers;
    }

    public CreateOrganizationTaskRequest setIsDone(Boolean isDone) {
        this.isDone = isDone;
        return this;
    }
    public Boolean getIsDone() {
        return this.isDone;
    }

    public CreateOrganizationTaskRequest setLabel(String label) {
        this.label = label;
        return this;
    }
    public String getLabel() {
        return this.label;
    }

    public CreateOrganizationTaskRequest setNote(String note) {
        this.note = note;
        return this;
    }
    public String getNote() {
        return this.note;
    }

    public CreateOrganizationTaskRequest setPriority(Integer priority) {
        this.priority = priority;
        return this;
    }
    public Integer getPriority() {
        return this.priority;
    }

    public CreateOrganizationTaskRequest setVisible(String visible) {
        this.visible = visible;
        return this;
    }
    public String getVisible() {
        return this.visible;
    }

}
