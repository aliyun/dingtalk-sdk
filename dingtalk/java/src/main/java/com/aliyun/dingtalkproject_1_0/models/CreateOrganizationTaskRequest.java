// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class CreateOrganizationTaskRequest extends TeaModel {
    /**
     * <p>任务标题</p>
     */
    @NameInMap("content")
    public String content;

    /**
     * <p>任务创建日期</p>
     */
    @NameInMap("createTime")
    public String createTime;

    /**
     * <p>是否禁止动态</p>
     */
    @NameInMap("disableActivity")
    public Boolean disableActivity;

    /**
     * <p>是否禁止通知</p>
     */
    @NameInMap("disableNotification")
    public Boolean disableNotification;

    /**
     * <p>任务截止日期</p>
     */
    @NameInMap("dueDate")
    public String dueDate;

    /**
     * <p>执行者id</p>
     */
    @NameInMap("executorId")
    public String executorId;

    /**
     * <p>参与者id</p>
     */
    @NameInMap("involveMembers")
    public java.util.List<String> involveMembers;

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
     * <p>任务可见性。involves：仅参与者可见。members:所有人可见</p>
     */
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
