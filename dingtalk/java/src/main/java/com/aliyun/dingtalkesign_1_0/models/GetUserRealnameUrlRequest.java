// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkesign_1_0.models;

import com.aliyun.tea.*;

public class GetUserRealnameUrlRequest extends TeaModel {
    @NameInMap("appId")
    public Long appId;

    @NameInMap("dingCorpId")
    public String dingCorpId;

    @NameInMap("userId")
    public String userId;

    @NameInMap("redirectUrl")
    public String redirectUrl;

    @NameInMap("dingIsvAccessToken")
    public String dingIsvAccessToken;

    @NameInMap("dingSuiteKey")
    public String dingSuiteKey;

    public static GetUserRealnameUrlRequest build(java.util.Map<String, ?> map) throws Exception {
        GetUserRealnameUrlRequest self = new GetUserRealnameUrlRequest();
        return TeaModel.build(map, self);
    }

    public GetUserRealnameUrlRequest setAppId(Long appId) {
        this.appId = appId;
        return this;
    }
    public Long getAppId() {
        return this.appId;
    }

    public GetUserRealnameUrlRequest setDingCorpId(String dingCorpId) {
        this.dingCorpId = dingCorpId;
        return this;
    }
    public String getDingCorpId() {
        return this.dingCorpId;
    }

    public GetUserRealnameUrlRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

    public GetUserRealnameUrlRequest setRedirectUrl(String redirectUrl) {
        this.redirectUrl = redirectUrl;
        return this;
    }
    public String getRedirectUrl() {
        return this.redirectUrl;
    }

    public GetUserRealnameUrlRequest setDingIsvAccessToken(String dingIsvAccessToken) {
        this.dingIsvAccessToken = dingIsvAccessToken;
        return this;
    }
    public String getDingIsvAccessToken() {
        return this.dingIsvAccessToken;
    }

    public GetUserRealnameUrlRequest setDingSuiteKey(String dingSuiteKey) {
        this.dingSuiteKey = dingSuiteKey;
        return this;
    }
    public String getDingSuiteKey() {
        return this.dingSuiteKey;
    }

}
