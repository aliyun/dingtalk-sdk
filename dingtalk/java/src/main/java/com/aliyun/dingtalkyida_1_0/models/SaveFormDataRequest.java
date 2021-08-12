// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class SaveFormDataRequest extends TeaModel {
    // 应用编码
    @NameInMap("appType")
    public String appType;

    // 应用秘钥。在应用数据中获取。
    @NameInMap("systemToken")
    public String systemToken;

    // 钉钉userId
    @NameInMap("userId")
    public String userId;

    // 语言。可选值：zh_CN/en_US 默认：zh_CN
    @NameInMap("language")
    public String language;

    // 表单ID
    @NameInMap("formUuid")
    public String formUuid;

    // 表单数据
    @NameInMap("formDataJson")
    public String formDataJson;

    public static SaveFormDataRequest build(java.util.Map<String, ?> map) throws Exception {
        SaveFormDataRequest self = new SaveFormDataRequest();
        return TeaModel.build(map, self);
    }

    public SaveFormDataRequest setAppType(String appType) {
        this.appType = appType;
        return this;
    }
    public String getAppType() {
        return this.appType;
    }

    public SaveFormDataRequest setSystemToken(String systemToken) {
        this.systemToken = systemToken;
        return this;
    }
    public String getSystemToken() {
        return this.systemToken;
    }

    public SaveFormDataRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

    public SaveFormDataRequest setLanguage(String language) {
        this.language = language;
        return this;
    }
    public String getLanguage() {
        return this.language;
    }

    public SaveFormDataRequest setFormUuid(String formUuid) {
        this.formUuid = formUuid;
        return this;
    }
    public String getFormUuid() {
        return this.formUuid;
    }

    public SaveFormDataRequest setFormDataJson(String formDataJson) {
        this.formDataJson = formDataJson;
        return this;
    }
    public String getFormDataJson() {
        return this.formDataJson;
    }

}
