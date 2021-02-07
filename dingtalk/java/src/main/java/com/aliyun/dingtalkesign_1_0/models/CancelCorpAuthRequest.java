// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkesign_1_0.models;

import com.aliyun.tea.*;

public class CancelCorpAuthRequest extends TeaModel {
    @NameInMap("appId")
    public Long appId;

    @NameInMap("dingCorpId")
    public String dingCorpId;

    @NameInMap("dingIsvAccessToken")
    public String dingIsvAccessToken;

    @NameInMap("dingSuiteKey")
    public String dingSuiteKey;

    public static CancelCorpAuthRequest build(java.util.Map<String, ?> map) throws Exception {
        CancelCorpAuthRequest self = new CancelCorpAuthRequest();
        return TeaModel.build(map, self);
    }

    public CancelCorpAuthRequest setAppId(Long appId) {
        this.appId = appId;
        return this;
    }
    public Long getAppId() {
        return this.appId;
    }

    public CancelCorpAuthRequest setDingCorpId(String dingCorpId) {
        this.dingCorpId = dingCorpId;
        return this;
    }
    public String getDingCorpId() {
        return this.dingCorpId;
    }

    public CancelCorpAuthRequest setDingIsvAccessToken(String dingIsvAccessToken) {
        this.dingIsvAccessToken = dingIsvAccessToken;
        return this;
    }
    public String getDingIsvAccessToken() {
        return this.dingIsvAccessToken;
    }

    public CancelCorpAuthRequest setDingSuiteKey(String dingSuiteKey) {
        this.dingSuiteKey = dingSuiteKey;
        return this;
    }
    public String getDingSuiteKey() {
        return this.dingSuiteKey;
    }

}
