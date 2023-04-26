// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconference_1_0.models;

import com.aliyun.tea.*;

public class CreateVideoConferenceRequest extends TeaModel {
    @NameInMap("confTitle")
    public String confTitle;

    @NameInMap("inviteCaller")
    public Boolean inviteCaller;

    @NameInMap("inviteUserIds")
    public java.util.List<String> inviteUserIds;

    @NameInMap("userId")
    public String userId;

    public static CreateVideoConferenceRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateVideoConferenceRequest self = new CreateVideoConferenceRequest();
        return TeaModel.build(map, self);
    }

    public CreateVideoConferenceRequest setConfTitle(String confTitle) {
        this.confTitle = confTitle;
        return this;
    }
    public String getConfTitle() {
        return this.confTitle;
    }

    public CreateVideoConferenceRequest setInviteCaller(Boolean inviteCaller) {
        this.inviteCaller = inviteCaller;
        return this;
    }
    public Boolean getInviteCaller() {
        return this.inviteCaller;
    }

    public CreateVideoConferenceRequest setInviteUserIds(java.util.List<String> inviteUserIds) {
        this.inviteUserIds = inviteUserIds;
        return this;
    }
    public java.util.List<String> getInviteUserIds() {
        return this.inviteUserIds;
    }

    public CreateVideoConferenceRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
