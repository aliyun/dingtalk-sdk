// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class ConversationTransferBeginNotifyRequest extends TeaModel {
    /**
     * <p>DT端会话ID</p>
     */
    @NameInMap("conversationId")
    public String conversationId;

    /**
     * <p>转接备注</p>
     */
    @NameInMap("memo")
    public String memo;

    /**
     * <p>团队ID</p>
     */
    @NameInMap("openTeamId")
    public String openTeamId;

    /**
     * <p>对应外部渠道的会话ID</p>
     */
    @NameInMap("serviceToken")
    public String serviceToken;

    /**
     * <p>原始技能组ID</p>
     */
    @NameInMap("sourceSkillGroupId")
    public String sourceSkillGroupId;

    /**
     * <p>目标技能组ID</p>
     */
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
