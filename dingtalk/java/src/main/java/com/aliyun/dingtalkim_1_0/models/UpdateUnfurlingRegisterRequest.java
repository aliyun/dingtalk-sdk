// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class UpdateUnfurlingRegisterRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>123xxxx</p>
     */
    @NameInMap("apiSecret")
    public String apiSecret;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>3102xxxxxxx</p>
     */
    @NameInMap("appId")
    public String appId;

    @NameInMap("callbackType")
    public Integer callbackType;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p><a href="https://xxx.xxx.com/api/dingtalk/link_unfurling">https://xxx.xxx.com/api/dingtalk/link_unfurling</a></p>
     */
    @NameInMap("callbackUrl")
    public String callbackUrl;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>d7b9xxx-xxx-xxxx-xxxx-xxxxxxx.schema</p>
     */
    @NameInMap("cardTemplateId")
    public String cardTemplateId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p><a href="http://www.dingtalk.com">www.dingtalk.com</a></p>
     */
    @NameInMap("domain")
    public String domain;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>1</p>
     */
    @NameInMap("id")
    public Long id;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>/a</p>
     */
    @NameInMap("path")
    public String path;

    /**
     * <strong>example:</strong>
     * <p>规则描述</p>
     */
    @NameInMap("ruleDesc")
    public String ruleDesc;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>0</p>
     */
    @NameInMap("ruleMatchType")
    public Integer ruleMatchType;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>37xxxx</p>
     */
    @NameInMap("userId")
    public String userId;

    public static UpdateUnfurlingRegisterRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateUnfurlingRegisterRequest self = new UpdateUnfurlingRegisterRequest();
        return TeaModel.build(map, self);
    }

    public UpdateUnfurlingRegisterRequest setApiSecret(String apiSecret) {
        this.apiSecret = apiSecret;
        return this;
    }
    public String getApiSecret() {
        return this.apiSecret;
    }

    public UpdateUnfurlingRegisterRequest setAppId(String appId) {
        this.appId = appId;
        return this;
    }
    public String getAppId() {
        return this.appId;
    }

    public UpdateUnfurlingRegisterRequest setCallbackType(Integer callbackType) {
        this.callbackType = callbackType;
        return this;
    }
    public Integer getCallbackType() {
        return this.callbackType;
    }

    public UpdateUnfurlingRegisterRequest setCallbackUrl(String callbackUrl) {
        this.callbackUrl = callbackUrl;
        return this;
    }
    public String getCallbackUrl() {
        return this.callbackUrl;
    }

    public UpdateUnfurlingRegisterRequest setCardTemplateId(String cardTemplateId) {
        this.cardTemplateId = cardTemplateId;
        return this;
    }
    public String getCardTemplateId() {
        return this.cardTemplateId;
    }

    public UpdateUnfurlingRegisterRequest setDomain(String domain) {
        this.domain = domain;
        return this;
    }
    public String getDomain() {
        return this.domain;
    }

    public UpdateUnfurlingRegisterRequest setId(Long id) {
        this.id = id;
        return this;
    }
    public Long getId() {
        return this.id;
    }

    public UpdateUnfurlingRegisterRequest setPath(String path) {
        this.path = path;
        return this;
    }
    public String getPath() {
        return this.path;
    }

    public UpdateUnfurlingRegisterRequest setRuleDesc(String ruleDesc) {
        this.ruleDesc = ruleDesc;
        return this;
    }
    public String getRuleDesc() {
        return this.ruleDesc;
    }

    public UpdateUnfurlingRegisterRequest setRuleMatchType(Integer ruleMatchType) {
        this.ruleMatchType = ruleMatchType;
        return this;
    }
    public Integer getRuleMatchType() {
        return this.ruleMatchType;
    }

    public UpdateUnfurlingRegisterRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
