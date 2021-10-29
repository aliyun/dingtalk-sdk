// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class CreateInviteUrlRequest extends TeaModel {
    @NameInMap("dingCorpId")
    public String dingCorpId;

    @NameInMap("dingSuiteKey")
    public String dingSuiteKey;

    @NameInMap("dingTokenGrantType")
    public Integer dingTokenGrantType;

    @NameInMap("dingOauthAppId")
    public Long dingOauthAppId;

    @NameInMap("targetCorpId")
    public String targetCorpId;

    @NameInMap("authCode")
    public String authCode;

    @NameInMap("targetOperator")
    public String targetOperator;

    @NameInMap("dingIsvOrgId")
    public Long dingIsvOrgId;

    public static CreateInviteUrlRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateInviteUrlRequest self = new CreateInviteUrlRequest();
        return TeaModel.build(map, self);
    }

    public CreateInviteUrlRequest setDingCorpId(String dingCorpId) {
        this.dingCorpId = dingCorpId;
        return this;
    }
    public String getDingCorpId() {
        return this.dingCorpId;
    }

    public CreateInviteUrlRequest setDingSuiteKey(String dingSuiteKey) {
        this.dingSuiteKey = dingSuiteKey;
        return this;
    }
    public String getDingSuiteKey() {
        return this.dingSuiteKey;
    }

    public CreateInviteUrlRequest setDingTokenGrantType(Integer dingTokenGrantType) {
        this.dingTokenGrantType = dingTokenGrantType;
        return this;
    }
    public Integer getDingTokenGrantType() {
        return this.dingTokenGrantType;
    }

    public CreateInviteUrlRequest setDingOauthAppId(Long dingOauthAppId) {
        this.dingOauthAppId = dingOauthAppId;
        return this;
    }
    public Long getDingOauthAppId() {
        return this.dingOauthAppId;
    }

    public CreateInviteUrlRequest setTargetCorpId(String targetCorpId) {
        this.targetCorpId = targetCorpId;
        return this;
    }
    public String getTargetCorpId() {
        return this.targetCorpId;
    }

    public CreateInviteUrlRequest setAuthCode(String authCode) {
        this.authCode = authCode;
        return this;
    }
    public String getAuthCode() {
        return this.authCode;
    }

    public CreateInviteUrlRequest setTargetOperator(String targetOperator) {
        this.targetOperator = targetOperator;
        return this;
    }
    public String getTargetOperator() {
        return this.targetOperator;
    }

    public CreateInviteUrlRequest setDingIsvOrgId(Long dingIsvOrgId) {
        this.dingIsvOrgId = dingIsvOrgId;
        return this;
    }
    public Long getDingIsvOrgId() {
        return this.dingIsvOrgId;
    }

}
