// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class CreateGroupConversationRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>dingadc88253b4d581bd35c2f4657eb6378f</p>
     */
    @NameInMap("corpId")
    public String corpId;

    /**
     * <strong>example:</strong>
     * <p>fsfsfadfasfdasdfsaf</p>
     */
    @NameInMap("dingGroupId")
    public String dingGroupId;

    @NameInMap("dingSuiteKey")
    public String dingSuiteKey;

    @NameInMap("dingTokenGrantType")
    public Long dingTokenGrantType;

    /**
     * <strong>example:</strong>
     * <p>57675657</p>
     */
    @NameInMap("dingUserId")
    public String dingUserId;

    /**
     * <strong>example:</strong>
     * <p>张三</p>
     */
    @NameInMap("dingUserName")
    public String dingUserName;

    /**
     * <strong>example:</strong>
     * <p>{&quot;isServerInitiative&quot;:&quot;true&quot;}</p>
     */
    @NameInMap("extValues")
    public String extValues;

    @NameInMap("openTeamId")
    public String openTeamId;

    /**
     * <strong>example:</strong>
     * <p>3434</p>
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
