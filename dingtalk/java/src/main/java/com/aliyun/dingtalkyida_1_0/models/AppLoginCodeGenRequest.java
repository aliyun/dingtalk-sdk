// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class AppLoginCodeGenRequest extends TeaModel {
    @NameInMap("appKey")
    public String appKey;

    @NameInMap("signTimestampStr")
    public String signTimestampStr;

    @NameInMap("signature")
    public String signature;

    @NameInMap("fullUrl")
    public String fullUrl;

    @NameInMap("userId")
    public String userId;

    public static AppLoginCodeGenRequest build(java.util.Map<String, ?> map) throws Exception {
        AppLoginCodeGenRequest self = new AppLoginCodeGenRequest();
        return TeaModel.build(map, self);
    }

    public AppLoginCodeGenRequest setAppKey(String appKey) {
        this.appKey = appKey;
        return this;
    }
    public String getAppKey() {
        return this.appKey;
    }

    public AppLoginCodeGenRequest setSignTimestampStr(String signTimestampStr) {
        this.signTimestampStr = signTimestampStr;
        return this;
    }
    public String getSignTimestampStr() {
        return this.signTimestampStr;
    }

    public AppLoginCodeGenRequest setSignature(String signature) {
        this.signature = signature;
        return this;
    }
    public String getSignature() {
        return this.signature;
    }

    public AppLoginCodeGenRequest setFullUrl(String fullUrl) {
        this.fullUrl = fullUrl;
        return this;
    }
    public String getFullUrl() {
        return this.fullUrl;
    }

    public AppLoginCodeGenRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
