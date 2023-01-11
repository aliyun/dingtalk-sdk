// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class SaveFormDataRequest extends TeaModel {
    /**
     * <p>应用编码</p>
     */
    @NameInMap("appType")
    public String appType;

    /**
     * <p>表单数据</p>
     */
    @NameInMap("formDataJson")
    public String formDataJson;

    /**
     * <p>表单ID</p>
     */
    @NameInMap("formUuid")
    public String formUuid;

    /**
     * <p>语言。可选值：zh_CN/en_US 默认：zh_CN</p>
     */
    @NameInMap("language")
    public String language;

    /**
     * <p>应用秘钥。在应用数据中获取。</p>
     */
    @NameInMap("systemToken")
    public String systemToken;

    /**
     * <p>钉钉userId</p>
     */
    @NameInMap("userId")
    public String userId;

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

    public SaveFormDataRequest setFormDataJson(String formDataJson) {
        this.formDataJson = formDataJson;
        return this;
    }
    public String getFormDataJson() {
        return this.formDataJson;
    }

    public SaveFormDataRequest setFormUuid(String formUuid) {
        this.formUuid = formUuid;
        return this;
    }
    public String getFormUuid() {
        return this.formUuid;
    }

    public SaveFormDataRequest setLanguage(String language) {
        this.language = language;
        return this;
    }
    public String getLanguage() {
        return this.language;
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

}
