// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdiot_1_0.models;

import com.aliyun.tea.*;

public class BindSystemRequest extends TeaModel {
    @NameInMap("authCode")
    public String authCode;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("clientId")
    public String clientId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("clientName")
    public String clientName;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("corpId")
    public String corpId;

    @NameInMap("extraData")
    public java.util.Map<String, ?> extraData;

    public static BindSystemRequest build(java.util.Map<String, ?> map) throws Exception {
        BindSystemRequest self = new BindSystemRequest();
        return TeaModel.build(map, self);
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

    public BindSystemRequest setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public BindSystemRequest setExtraData(java.util.Map<String, ?> extraData) {
        this.extraData = extraData;
        return this;
    }
    public java.util.Map<String, ?> getExtraData() {
        return this.extraData;
    }

}
