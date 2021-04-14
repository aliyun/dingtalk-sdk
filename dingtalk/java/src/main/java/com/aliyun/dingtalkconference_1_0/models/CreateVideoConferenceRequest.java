// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconference_1_0.models;

import com.aliyun.tea.*;

public class CreateVideoConferenceRequest extends TeaModel {
    // 会议发起人UID
    @NameInMap("userId")
    public String userId;

    // 会议主题： 文字，不超过20中文
    @NameInMap("confTitle")
    public String confTitle;

    // 邀请参会人员UID列表（必须好友或同事）
    @NameInMap("inviteUserIds")
    public java.util.List<String> inviteUserIds;

    public static CreateVideoConferenceRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateVideoConferenceRequest self = new CreateVideoConferenceRequest();
        return TeaModel.build(map, self);
    }

    public CreateVideoConferenceRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

    public CreateVideoConferenceRequest setConfTitle(String confTitle) {
        this.confTitle = confTitle;
        return this;
    }
    public String getConfTitle() {
        return this.confTitle;
    }

    public CreateVideoConferenceRequest setInviteUserIds(java.util.List<String> inviteUserIds) {
        this.inviteUserIds = inviteUserIds;
        return this;
    }
    public java.util.List<String> getInviteUserIds() {
        return this.inviteUserIds;
    }

}
