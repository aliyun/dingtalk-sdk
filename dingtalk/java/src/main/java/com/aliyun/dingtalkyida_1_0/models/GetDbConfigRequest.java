// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class GetDbConfigRequest extends TeaModel {
    @NameInMap("appType")
    public String appType;

    @NameInMap("corpId")
    public String corpId;

    @NameInMap("systemToken")
    public String systemToken;

    @NameInMap("userId")
    public String userId;

    public static GetDbConfigRequest build(java.util.Map<String, ?> map) throws Exception {
        GetDbConfigRequest self = new GetDbConfigRequest();
        return TeaModel.build(map, self);
    }

    public GetDbConfigRequest setAppType(String appType) {
        this.appType = appType;
        return this;
    }
    public String getAppType() {
        return this.appType;
    }

    public GetDbConfigRequest setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public GetDbConfigRequest setSystemToken(String systemToken) {
        this.systemToken = systemToken;
        return this;
    }
    public String getSystemToken() {
        return this.systemToken;
    }

    public GetDbConfigRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
