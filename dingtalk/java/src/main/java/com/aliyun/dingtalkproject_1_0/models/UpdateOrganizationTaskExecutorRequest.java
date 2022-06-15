// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class UpdateOrganizationTaskExecutorRequest extends TeaModel {
    @NameInMap("disableActivity")
    public Boolean disableActivity;

    @NameInMap("disableNotification")
    public Boolean disableNotification;

    @NameInMap("executorId")
    public String executorId;

    public static UpdateOrganizationTaskExecutorRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateOrganizationTaskExecutorRequest self = new UpdateOrganizationTaskExecutorRequest();
        return TeaModel.build(map, self);
    }

    public UpdateOrganizationTaskExecutorRequest setDisableActivity(Boolean disableActivity) {
        this.disableActivity = disableActivity;
        return this;
    }
    public Boolean getDisableActivity() {
        return this.disableActivity;
    }

    public UpdateOrganizationTaskExecutorRequest setDisableNotification(Boolean disableNotification) {
        this.disableNotification = disableNotification;
        return this;
    }
    public Boolean getDisableNotification() {
        return this.disableNotification;
    }

    public UpdateOrganizationTaskExecutorRequest setExecutorId(String executorId) {
        this.executorId = executorId;
        return this;
    }
    public String getExecutorId() {
        return this.executorId;
    }

}
