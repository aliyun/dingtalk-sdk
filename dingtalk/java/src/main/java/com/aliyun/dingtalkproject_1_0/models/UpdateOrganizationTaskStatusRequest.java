// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class UpdateOrganizationTaskStatusRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>false</p>
     */
    @NameInMap("disableActivity")
    public Boolean disableActivity;

    /**
     * <strong>example:</strong>
     * <p>false</p>
     */
    @NameInMap("disableNotification")
    public Boolean disableNotification;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>true</p>
     */
    @NameInMap("isDone")
    public Boolean isDone;

    public static UpdateOrganizationTaskStatusRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateOrganizationTaskStatusRequest self = new UpdateOrganizationTaskStatusRequest();
        return TeaModel.build(map, self);
    }

    public UpdateOrganizationTaskStatusRequest setDisableActivity(Boolean disableActivity) {
        this.disableActivity = disableActivity;
        return this;
    }
    public Boolean getDisableActivity() {
        return this.disableActivity;
    }

    public UpdateOrganizationTaskStatusRequest setDisableNotification(Boolean disableNotification) {
        this.disableNotification = disableNotification;
        return this;
    }
    public Boolean getDisableNotification() {
        return this.disableNotification;
    }

    public UpdateOrganizationTaskStatusRequest setIsDone(Boolean isDone) {
        this.isDone = isDone;
        return this;
    }
    public Boolean getIsDone() {
        return this.isDone;
    }

}
