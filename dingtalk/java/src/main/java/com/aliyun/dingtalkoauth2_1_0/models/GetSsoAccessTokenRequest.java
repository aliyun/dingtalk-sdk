// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkoauth2_1_0.models;

import com.aliyun.tea.*;

public class GetSsoAccessTokenRequest extends TeaModel {
    // 企业id
    @NameInMap("corpid")
    public String corpid;

    // sso密码
    @NameInMap("ssoSecret")
    public String ssoSecret;

    public static GetSsoAccessTokenRequest build(java.util.Map<String, ?> map) throws Exception {
        GetSsoAccessTokenRequest self = new GetSsoAccessTokenRequest();
        return TeaModel.build(map, self);
    }

    public GetSsoAccessTokenRequest setCorpid(String corpid) {
        this.corpid = corpid;
        return this;
    }
    public String getCorpid() {
        return this.corpid;
    }

    public GetSsoAccessTokenRequest setSsoSecret(String ssoSecret) {
        this.ssoSecret = ssoSecret;
        return this;
    }
    public String getSsoSecret() {
        return this.ssoSecret;
    }

}
