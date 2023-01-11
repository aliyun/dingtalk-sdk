// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class UpdateOrganizationTaskNoteRequest extends TeaModel {
    /**
     * <p>是否禁用动态</p>
     */
    @NameInMap("disableActivity")
    public Boolean disableActivity;

    /**
     * <p>是否禁用通知</p>
     */
    @NameInMap("disableNotification")
    public Boolean disableNotification;

    /**
     * <p>任务备注</p>
     */
    @NameInMap("note")
    public String note;

    public static UpdateOrganizationTaskNoteRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateOrganizationTaskNoteRequest self = new UpdateOrganizationTaskNoteRequest();
        return TeaModel.build(map, self);
    }

    public UpdateOrganizationTaskNoteRequest setDisableActivity(Boolean disableActivity) {
        this.disableActivity = disableActivity;
        return this;
    }
    public Boolean getDisableActivity() {
        return this.disableActivity;
    }

    public UpdateOrganizationTaskNoteRequest setDisableNotification(Boolean disableNotification) {
        this.disableNotification = disableNotification;
        return this;
    }
    public Boolean getDisableNotification() {
        return this.disableNotification;
    }

    public UpdateOrganizationTaskNoteRequest setNote(String note) {
        this.note = note;
        return this;
    }
    public String getNote() {
        return this.note;
    }

}
