// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class UpdateMemberBanWordsRequest extends TeaModel {
    // 禁言持续时长（单位：毫秒）
    @NameInMap("muteDuration")
    public Long muteDuration;

    // 禁言状态(0表示取消禁言，1表示禁言)
    @NameInMap("muteStatus")
    public Integer muteStatus;

    // 开放群id
    @NameInMap("openConversationId")
    public String openConversationId;

    // 需要禁言或取消禁言的群成员列表
    @NameInMap("userIdList")
    public java.util.List<String> userIdList;

    public static UpdateMemberBanWordsRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateMemberBanWordsRequest self = new UpdateMemberBanWordsRequest();
        return TeaModel.build(map, self);
    }

    public UpdateMemberBanWordsRequest setMuteDuration(Long muteDuration) {
        this.muteDuration = muteDuration;
        return this;
    }
    public Long getMuteDuration() {
        return this.muteDuration;
    }

    public UpdateMemberBanWordsRequest setMuteStatus(Integer muteStatus) {
        this.muteStatus = muteStatus;
        return this;
    }
    public Integer getMuteStatus() {
        return this.muteStatus;
    }

    public UpdateMemberBanWordsRequest setOpenConversationId(String openConversationId) {
        this.openConversationId = openConversationId;
        return this;
    }
    public String getOpenConversationId() {
        return this.openConversationId;
    }

    public UpdateMemberBanWordsRequest setUserIdList(java.util.List<String> userIdList) {
        this.userIdList = userIdList;
        return this;
    }
    public java.util.List<String> getUserIdList() {
        return this.userIdList;
    }

}
