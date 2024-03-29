// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class CreateOrganizationTaskRequest extends TeaModel {
    @NameInMap("content")
    public String content;

    @NameInMap("createTime")
    public String createTime;

    @NameInMap("disableActivity")
    public Boolean disableActivity;

    @NameInMap("disableNotification")
    public Boolean disableNotification;

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
