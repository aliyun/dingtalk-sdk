// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class UpdateOrganizationTaskDueDateRequest extends TeaModel {
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
     * <p>任务截止时间</p>
     */
    @NameInMap("dueDate")
    public String dueDate;

    public static UpdateOrganizationTaskDueDateRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateOrganizationTaskDueDateRequest self = new UpdateOrganizationTaskDueDateRequest();
        return TeaModel.build(map, self);
    }

    public UpdateOrganizationTaskDueDateRequest setDisableActivity(Boolean disableActivity) {
        this.disableActivity = disableActivity;
        return this;
    }
    public Boolean getDisableActivity() {
        return this.disableActivity;
    }

    public UpdateOrganizationTaskDueDateRequest setDisableNotification(Boolean disableNotification) {
        this.disableNotification = disableNotification;
        return this;
    }
    public Boolean getDisableNotification() {
        return this.disableNotification;
    }

    public UpdateOrganizationTaskDueDateRequest setDueDate(String dueDate) {
        this.dueDate = dueDate;
        return this;
    }
    public String getDueDate() {
        return this.dueDate;
    }

}
