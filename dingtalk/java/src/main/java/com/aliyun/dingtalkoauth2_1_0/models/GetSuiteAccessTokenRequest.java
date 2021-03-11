// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkoauth2_1_0.models;

import com.aliyun.tea.*;

public class GetSuiteAccessTokenRequest extends TeaModel {
    // 应用id
    @NameInMap("suiteKey")
    public String suiteKey;

    // 应用密码
    @NameInMap("suiteSecret")
    public String suiteSecret;

    // suiteTicket
    @NameInMap("suiteTicket")
    public String suiteTicket;

    public static GetSuiteAccessTokenRequest build(java.util.Map<String, ?> map) throws Exception {
        GetSuiteAccessTokenRequest self = new GetSuiteAccessTokenRequest();
        return TeaModel.build(map, self);
    }

    public GetSuiteAccessTokenRequest setSuiteKey(String suiteKey) {
        this.suiteKey = suiteKey;
        return this;
    }
    public String getSuiteKey() {
        return this.suiteKey;
    }

    public GetSuiteAccessTokenRequest setSuiteSecret(String suiteSecret) {
        this.suiteSecret = suiteSecret;
        return this;
    }
    public String getSuiteSecret() {
        return this.suiteSecret;
    }

    public GetSuiteAccessTokenRequest setSuiteTicket(String suiteTicket) {
        this.suiteTicket = suiteTicket;
        return this;
    }
    public String getSuiteTicket() {
        return this.suiteTicket;
    }

}
