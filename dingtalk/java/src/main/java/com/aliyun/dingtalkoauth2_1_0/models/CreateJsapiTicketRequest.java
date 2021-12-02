// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkoauth2_1_0.models;

import com.aliyun.tea.*;

public class CreateJsapiTicketRequest extends TeaModel {
    @NameInMap("agentId")
    public Long agentId;

    @NameInMap("dingTokenGrantType")
    public Integer dingTokenGrantType;

    @NameInMap("dingOauthAppId")
    public Long dingOauthAppId;

    @NameInMap("dingSuiteKey")
    public String dingSuiteKey;

    public static CreateJsapiTicketRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateJsapiTicketRequest self = new CreateJsapiTicketRequest();
        return TeaModel.build(map, self);
    }

    public CreateJsapiTicketRequest setAgentId(Long agentId) {
        this.agentId = agentId;
        return this;
    }
    public Long getAgentId() {
        return this.agentId;
    }

    public CreateJsapiTicketRequest setDingTokenGrantType(Integer dingTokenGrantType) {
        this.dingTokenGrantType = dingTokenGrantType;
        return this;
    }
    public Integer getDingTokenGrantType() {
        return this.dingTokenGrantType;
    }

    public CreateJsapiTicketRequest setDingOauthAppId(Long dingOauthAppId) {
        this.dingOauthAppId = dingOauthAppId;
        return this;
    }
    public Long getDingOauthAppId() {
        return this.dingOauthAppId;
    }

    public CreateJsapiTicketRequest setDingSuiteKey(String dingSuiteKey) {
        this.dingSuiteKey = dingSuiteKey;
        return this;
    }
    public String getDingSuiteKey() {
        return this.dingSuiteKey;
    }

}
