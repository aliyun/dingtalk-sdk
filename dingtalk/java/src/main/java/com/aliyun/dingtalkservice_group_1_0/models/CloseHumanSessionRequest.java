// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class CloseHumanSessionRequest extends TeaModel {
    @NameInMap("dingIsvOrgId")
    public Long dingIsvOrgId;

    @NameInMap("dingOrgId")
    public Long dingOrgId;

    @NameInMap("dingSuiteKey")
    public String dingSuiteKey;

    @NameInMap("dingTokenGrantType")
    public Long dingTokenGrantType;

    // 开放团队id
    @NameInMap("openTeamId")
    public String openTeamId;

    // 开放会话id
    @NameInMap("openConversationId")
    public String openConversationId;

    // 访客unionid
    @NameInMap("visitorUnionId")
    public Long visitorUnionId;

    public static CloseHumanSessionRequest build(java.util.Map<String, ?> map) throws Exception {
        CloseHumanSessionRequest self = new CloseHumanSessionRequest();
        return TeaModel.build(map, self);
    }

    public CloseHumanSessionRequest setDingIsvOrgId(Long dingIsvOrgId) {
        this.dingIsvOrgId = dingIsvOrgId;
        return this;
    }
    public Long getDingIsvOrgId() {
        return this.dingIsvOrgId;
    }

    public CloseHumanSessionRequest setDingOrgId(Long dingOrgId) {
        this.dingOrgId = dingOrgId;
        return this;
    }
    public Long getDingOrgId() {
        return this.dingOrgId;
    }

    public CloseHumanSessionRequest setDingSuiteKey(String dingSuiteKey) {
        this.dingSuiteKey = dingSuiteKey;
        return this;
    }
    public String getDingSuiteKey() {
        return this.dingSuiteKey;
    }

    public CloseHumanSessionRequest setDingTokenGrantType(Long dingTokenGrantType) {
        this.dingTokenGrantType = dingTokenGrantType;
        return this;
    }
    public Long getDingTokenGrantType() {
        return this.dingTokenGrantType;
    }

    public CloseHumanSessionRequest setOpenTeamId(String openTeamId) {
        this.openTeamId = openTeamId;
        return this;
    }
    public String getOpenTeamId() {
        return this.openTeamId;
    }

    public CloseHumanSessionRequest setOpenConversationId(String openConversationId) {
        this.openConversationId = openConversationId;
        return this;
    }
    public String getOpenConversationId() {
        return this.openConversationId;
    }

    public CloseHumanSessionRequest setVisitorUnionId(Long visitorUnionId) {
        this.visitorUnionId = visitorUnionId;
        return this;
    }
    public Long getVisitorUnionId() {
        return this.visitorUnionId;
    }

}
