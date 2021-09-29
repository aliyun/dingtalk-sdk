// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class GetActivityButtonListRequest extends TeaModel {
    // 应用秘钥
    @NameInMap("systemToken")
    public String systemToken;

    // 钉钉的userId
    @NameInMap("userId")
    public String userId;

    // 语言环境
    @NameInMap("language")
    public String language;

    public static GetActivityButtonListRequest build(java.util.Map<String, ?> map) throws Exception {
        GetActivityButtonListRequest self = new GetActivityButtonListRequest();
        return TeaModel.build(map, self);
    }

    public GetActivityButtonListRequest setSystemToken(String systemToken) {
        this.systemToken = systemToken;
        return this;
    }
    public String getSystemToken() {
        return this.systemToken;
    }

    public GetActivityButtonListRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

    public GetActivityButtonListRequest setLanguage(String language) {
        this.language = language;
        return this;
    }
    public String getLanguage() {
        return this.language;
    }

}
