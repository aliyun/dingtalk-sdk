// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class UpdateOrganizationTaskInvolveMembersRequest extends TeaModel {
    // 增加的参与者uid
    @NameInMap("addInvolvers")
    public java.util.List<String> addInvolvers;

    // 删除的参与者uid
    @NameInMap("delInvolvers")
    public java.util.List<String> delInvolvers;

    // 是否禁用动态
    @NameInMap("disableActivity")
    public Boolean disableActivity;

    // 是否禁用通知
    @NameInMap("disableNotification")
    public Boolean disableNotification;

    // 所有参与者uid
    @NameInMap("involveMembers")
    public java.util.List<String> involveMembers;

    public static UpdateOrganizationTaskInvolveMembersRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateOrganizationTaskInvolveMembersRequest self = new UpdateOrganizationTaskInvolveMembersRequest();
        return TeaModel.build(map, self);
    }

    public UpdateOrganizationTaskInvolveMembersRequest setAddInvolvers(java.util.List<String> addInvolvers) {
        this.addInvolvers = addInvolvers;
        return this;
    }
    public java.util.List<String> getAddInvolvers() {
        return this.addInvolvers;
    }

    public UpdateOrganizationTaskInvolveMembersRequest setDelInvolvers(java.util.List<String> delInvolvers) {
        this.delInvolvers = delInvolvers;
        return this;
    }
    public java.util.List<String> getDelInvolvers() {
        return this.delInvolvers;
    }

    public UpdateOrganizationTaskInvolveMembersRequest setDisableActivity(Boolean disableActivity) {
        this.disableActivity = disableActivity;
        return this;
    }
    public Boolean getDisableActivity() {
        return this.disableActivity;
    }

    public UpdateOrganizationTaskInvolveMembersRequest setDisableNotification(Boolean disableNotification) {
        this.disableNotification = disableNotification;
        return this;
    }
    public Boolean getDisableNotification() {
        return this.disableNotification;
    }

    public UpdateOrganizationTaskInvolveMembersRequest setInvolveMembers(java.util.List<String> involveMembers) {
        this.involveMembers = involveMembers;
        return this;
    }
    public java.util.List<String> getInvolveMembers() {
        return this.involveMembers;
    }

}
