// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class UpdateFormDataRequest extends TeaModel {
    /**
     * <p>应用编码</p>
     */
    @NameInMap("appType")
    public String appType;

    /**
     * <p>要更新的表单数据ID</p>
     */
    @NameInMap("formInstanceId")
    public String formInstanceId;

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
     * <p>要更新的表单组件值。参数有的组件更新，没有的组件保持不变。 明细的值只能统一更新，无法只更新明细下某个组件的值</p>
     */
    @NameInMap("updateFormDataJson")
    public String updateFormDataJson;

    /**
     * <p>使用最新的表单版本进行更新。默认为false</p>
     */
    @NameInMap("useLatestVersion")
    public Boolean useLatestVersion;

    /**
     * <p>钉钉userId</p>
     */
    @NameInMap("userId")
    public String userId;

    public static UpdateFormDataRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateFormDataRequest self = new UpdateFormDataRequest();
        return TeaModel.build(map, self);
    }

    public UpdateFormDataRequest setAppType(String appType) {
        this.appType = appType;
        return this;
    }
    public String getAppType() {
        return this.appType;
    }

    public UpdateFormDataRequest setFormInstanceId(String formInstanceId) {
        this.formInstanceId = formInstanceId;
        return this;
    }
    public String getFormInstanceId() {
        return this.formInstanceId;
    }

    public UpdateFormDataRequest setLanguage(String language) {
        this.language = language;
        return this;
    }
    public String getLanguage() {
        return this.language;
    }

    public UpdateFormDataRequest setSystemToken(String systemToken) {
        this.systemToken = systemToken;
        return this;
    }
    public String getSystemToken() {
        return this.systemToken;
    }

    public UpdateFormDataRequest setUpdateFormDataJson(String updateFormDataJson) {
        this.updateFormDataJson = updateFormDataJson;
        return this;
    }
    public String getUpdateFormDataJson() {
        return this.updateFormDataJson;
    }

    public UpdateFormDataRequest setUseLatestVersion(Boolean useLatestVersion) {
        this.useLatestVersion = useLatestVersion;
        return this;
    }
    public Boolean getUseLatestVersion() {
        return this.useLatestVersion;
    }

    public UpdateFormDataRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
