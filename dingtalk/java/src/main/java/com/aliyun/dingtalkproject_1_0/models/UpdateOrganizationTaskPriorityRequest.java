// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class UpdateOrganizationTaskPriorityRequest extends TeaModel {
    // 是否禁止动态
    @NameInMap("disableActivity")
    public Boolean disableActivity;

    // 是否禁止通知
    @NameInMap("disableNotification")
    public Boolean disableNotification;

    // 优先级【-10,0,1,2】中的一个值
    @NameInMap("priority")
    public Integer priority;

    public static UpdateOrganizationTaskPriorityRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateOrganizationTaskPriorityRequest self = new UpdateOrganizationTaskPriorityRequest();
        return TeaModel.build(map, self);
    }

    public UpdateOrganizationTaskPriorityRequest setDisableActivity(Boolean disableActivity) {
        this.disableActivity = disableActivity;
        return this;
    }
    public Boolean getDisableActivity() {
        return this.disableActivity;
    }

    public UpdateOrganizationTaskPriorityRequest setDisableNotification(Boolean disableNotification) {
        this.disableNotification = disableNotification;
        return this;
    }
    public Boolean getDisableNotification() {
        return this.disableNotification;
    }

    public UpdateOrganizationTaskPriorityRequest setPriority(Integer priority) {
        this.priority = priority;
        return this;
    }
    public Integer getPriority() {
        return this.priority;
    }

}
