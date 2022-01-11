// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class GetFormDataByIDRequest extends TeaModel {
    // 应用编码
    @NameInMap("appType")
    public String appType;

    // 语言。可选值：zh_CN/en_US 默认：zh_CN
    @NameInMap("language")
    public String language;

    // 应用秘钥。在应用数据中获取。
    @NameInMap("systemToken")
    public String systemToken;

    // 钉钉userId
    @NameInMap("userId")
    public String userId;

    public static GetFormDataByIDRequest build(java.util.Map<String, ?> map) throws Exception {
        GetFormDataByIDRequest self = new GetFormDataByIDRequest();
        return TeaModel.build(map, self);
    }

    public GetFormDataByIDRequest setAppType(String appType) {
        this.appType = appType;
        return this;
    }
    public String getAppType() {
        return this.appType;
    }

    public GetFormDataByIDRequest setLanguage(String language) {
        this.language = language;
        return this;
    }
    public String getLanguage() {
        return this.language;
    }

    public GetFormDataByIDRequest setSystemToken(String systemToken) {
        this.systemToken = systemToken;
        return this;
    }
    public String getSystemToken() {
        return this.systemToken;
    }

    public GetFormDataByIDRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
