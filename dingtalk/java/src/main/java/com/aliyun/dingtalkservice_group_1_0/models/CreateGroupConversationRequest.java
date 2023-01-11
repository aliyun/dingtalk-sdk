// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class CreateGroupConversationRequest extends TeaModel {
    /**
     * <p>开放corpid</p>
     */
    @NameInMap("corpId")
    public String corpId;

    /**
     * <p>钉群openID</p>
     */
    @NameInMap("dingGroupId")
    public String dingGroupId;

    @NameInMap("dingSuiteKey")
    public String dingSuiteKey;

    @NameInMap("dingTokenGrantType")
    public Long dingTokenGrantType;

    /**
     * <p>钉群内发起人工服务的客户的ID</p>
     */
    @NameInMap("dingUserId")
    public String dingUserId;

    /**
     * <p>钉群内发起人工服务的客户的名称</p>
     */
    @NameInMap("dingUserName")
    public String dingUserName;

    /**
     * <p>扩展信息</p>
     */
    @NameInMap("extValues")
    public String extValues;

    @NameInMap("openTeamId")
    public String openTeamId;

    /**
     * <p>小二技能组ID</p>
     */
    @NameInMap("serverGroupId")
    public String serverGroupId;

    public static CreateGroupConversationRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateGroupConversationRequest self = new CreateGroupConversationRequest();
        return TeaModel.build(map, self);
    }

    public CreateGroupConversationRequest setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public CreateGroupConversationRequest setDingGroupId(String dingGroupId) {
        this.dingGroupId = dingGroupId;
        return this;
    }
    public String getDingGroupId() {
        return this.dingGroupId;
    }

    public CreateGroupConversationRequest setDingSuiteKey(String dingSuiteKey) {
        this.dingSuiteKey = dingSuiteKey;
        return this;
    }
    public String getDingSuiteKey() {
        return this.dingSuiteKey;
    }

    public CreateGroupConversationRequest setDingTokenGrantType(Long dingTokenGrantType) {
        this.dingTokenGrantType = dingTokenGrantType;
        return this;
    }
    public Long getDingTokenGrantType() {
        return this.dingTokenGrantType;
    }

    public CreateGroupConversationRequest setDingUserId(String dingUserId) {
        this.dingUserId = dingUserId;
        return this;
    }
    public String getDingUserId() {
        return this.dingUserId;
    }

    public CreateGroupConversationRequest setDingUserName(String dingUserName) {
        this.dingUserName = dingUserName;
        return this;
    }
    public String getDingUserName() {
        return this.dingUserName;
    }

    public CreateGroupConversationRequest setExtValues(String extValues) {
        this.extValues = extValues;
        return this;
    }
    public String getExtValues() {
        return this.extValues;
    }

    public CreateGroupConversationRequest setOpenTeamId(String openTeamId) {
        this.openTeamId = openTeamId;
        return this;
    }
    public String getOpenTeamId() {
        return this.openTeamId;
    }

    public CreateGroupConversationRequest setServerGroupId(String serverGroupId) {
        this.serverGroupId = serverGroupId;
        return this;
    }
    public String getServerGroupId() {
        return this.serverGroupId;
    }

}
