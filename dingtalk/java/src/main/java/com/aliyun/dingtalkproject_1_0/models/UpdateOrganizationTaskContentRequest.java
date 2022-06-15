// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class UpdateOrganizationTaskContentRequest extends TeaModel {
    // 任务标题
    @NameInMap("content")
    public String content;

    // 是否禁止动态
    @NameInMap("disableActivity")
    public Boolean disableActivity;

    // 是否禁止通知
    @NameInMap("disableNotification")
    public Boolean disableNotification;

    public static UpdateOrganizationTaskContentRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateOrganizationTaskContentRequest self = new UpdateOrganizationTaskContentRequest();
        return TeaModel.build(map, self);
    }

    public UpdateOrganizationTaskContentRequest setContent(String content) {
        this.content = content;
        return this;
    }
    public String getContent() {
        return this.content;
    }

    public UpdateOrganizationTaskContentRequest setDisableActivity(Boolean disableActivity) {
        this.disableActivity = disableActivity;
        return this;
    }
    public Boolean getDisableActivity() {
        return this.disableActivity;
    }

    public UpdateOrganizationTaskContentRequest setDisableNotification(Boolean disableNotification) {
        this.disableNotification = disableNotification;
        return this;
    }
    public Boolean getDisableNotification() {
        return this.disableNotification;
    }

}
