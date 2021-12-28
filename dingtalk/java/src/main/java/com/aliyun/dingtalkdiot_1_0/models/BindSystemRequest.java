// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdiot_1_0.models;

import com.aliyun.tea.*;

public class BindSystemRequest extends TeaModel {
    // 三方平台的用户的钉钉物联组织ID。
    @NameInMap("corpId")
    public String corpId;

    // 与三方平台绑定验证的临时授权码。
    @NameInMap("authCode")
    public String authCode;

    // 三方平台的用户ID。
    @NameInMap("clientId")
    public String clientId;

    // 三方平台的用户名。
    @NameInMap("clientName")
    public String clientName;

    // 三方平台协定的其它参数。
    @NameInMap("extraData")
    public java.util.Map<String, ?> extraData;

    public static BindSystemRequest build(java.util.Map<String, ?> map) throws Exception {
        BindSystemRequest self = new BindSystemRequest();
        return TeaModel.build(map, self);
    }

    public BindSystemRequest setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public BindSystemRequest setAuthCode(String authCode) {
        this.authCode = authCode;
        return this;
    }
    public String getAuthCode() {
        return this.authCode;
    }

    public BindSystemRequest setClientId(String clientId) {
        this.clientId = clientId;
        return this;
    }
    public String getClientId() {
        return this.clientId;
    }

    public BindSystemRequest setClientName(String clientName) {
        this.clientName = clientName;
        return this;
    }
    public String getClientName() {
        return this.clientName;
    }

    public BindSystemRequest setExtraData(java.util.Map<String, ?> extraData) {
        this.extraData = extraData;
        return this;
    }
    public java.util.Map<String, ?> getExtraData() {
        return this.extraData;
    }

}
