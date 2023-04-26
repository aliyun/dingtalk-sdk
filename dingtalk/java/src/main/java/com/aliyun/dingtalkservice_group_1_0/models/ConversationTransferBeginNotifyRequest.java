// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class ConversationTransferBeginNotifyRequest extends TeaModel {
    @NameInMap("conversationId")
    public String conversationId;

    @NameInMap("memo")
    public String memo;

    @NameInMap("openTeamId")
    public String openTeamId;

    @NameInMap("serviceToken")
    public String serviceToken;

    @NameInMap("sourceSkillGroupId")
    public String sourceSkillGroupId;

    @NameInMap("targetSkillGroupId")
    public String targetSkillGroupId;

    public static ConversationTransferBeginNotifyRequest build(java.util.Map<String, ?> map) throws Exception {
        ConversationTransferBeginNotifyRequest self = new ConversationTransferBeginNotifyRequest();
        return TeaModel.build(map, self);
    }

    public ConversationTransferBeginNotifyRequest setConversationId(String conversationId) {
        this.conversationId = conversationId;
        return this;
    }
    public String getConversationId() {
        return this.conversationId;
    }

    public ConversationTransferBeginNotifyRequest setMemo(String memo) {
        this.memo = memo;
        return this;
    }
    public String getMemo() {
        return this.memo;
    }

    public ConversationTransferBeginNotifyRequest setOpenTeamId(String openTeamId) {
        this.openTeamId = openTeamId;
        return this;
    }
    public String getOpenTeamId() {
        return this.openTeamId;
    }

    public ConversationTransferBeginNotifyRequest setServiceToken(String serviceToken) {
        this.serviceToken = serviceToken;
        return this;
    }
    public String getServiceToken() {
        return this.serviceToken;
    }

    public ConversationTransferBeginNotifyRequest setSourceSkillGroupId(String sourceSkillGroupId) {
        this.sourceSkillGroupId = sourceSkillGroupId;
        return this;
    }
    public String getSourceSkillGroupId() {
        return this.sourceSkillGroupId;
    }

    public ConversationTransferBeginNotifyRequest setTargetSkillGroupId(String targetSkillGroupId) {
        this.targetSkillGroupId = targetSkillGroupId;
        return this;
    }
    public String getTargetSkillGroupId() {
        return this.targetSkillGroupId;
    }

}
