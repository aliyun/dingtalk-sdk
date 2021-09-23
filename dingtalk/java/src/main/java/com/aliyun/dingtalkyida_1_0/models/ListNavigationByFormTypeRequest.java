// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class ListNavigationByFormTypeRequest extends TeaModel {
    // 应用ID
    @NameInMap("appType")
    public String appType;

    // 应用秘钥
    @NameInMap("systemToken")
    public String systemToken;

    // 评论人钉钉的userId
    @NameInMap("userId")
    public String userId;

    // 语言
    @NameInMap("language")
    public String language;

    // 页面类型
    @NameInMap("formType")
    public String formType;

    public static ListNavigationByFormTypeRequest build(java.util.Map<String, ?> map) throws Exception {
        ListNavigationByFormTypeRequest self = new ListNavigationByFormTypeRequest();
        return TeaModel.build(map, self);
    }

    public ListNavigationByFormTypeRequest setAppType(String appType) {
        this.appType = appType;
        return this;
    }
    public String getAppType() {
        return this.appType;
    }

    public ListNavigationByFormTypeRequest setSystemToken(String systemToken) {
        this.systemToken = systemToken;
        return this;
    }
    public String getSystemToken() {
        return this.systemToken;
    }

    public ListNavigationByFormTypeRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

    public ListNavigationByFormTypeRequest setLanguage(String language) {
        this.language = language;
        return this;
    }
    public String getLanguage() {
        return this.language;
    }

    public ListNavigationByFormTypeRequest setFormType(String formType) {
        this.formType = formType;
        return this;
    }
    public String getFormType() {
        return this.formType;
    }

}
