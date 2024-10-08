// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_2_0.models;

import com.aliyun.tea.*;

public class GetFormDataByIDRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>APP_PBKT0MFBEBTDO8T7SLVP</p>
     */
    @NameInMap("appType")
    public String appType;

    /**
     * <strong>example:</strong>
     * <p>FORM-AA28579F69644FC19A47FE267457E664ZVR1</p>
     */
    @NameInMap("formUuid")
    public String formUuid;

    /**
     * <strong>example:</strong>
     * <p>zh_CN</p>
     */
    @NameInMap("language")
    public String language;

    /**
     * <strong>example:</strong>
     * <p>hexxx</p>
     */
    @NameInMap("systemToken")
    public String systemToken;

    /**
     * <strong>example:</strong>
     * <p>false</p>
     */
    @NameInMap("useAlias")
    public Boolean useAlias;

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

    public GetFormDataByIDRequest setFormUuid(String formUuid) {
        this.formUuid = formUuid;
        return this;
    }
    public String getFormUuid() {
        return this.formUuid;
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

    public GetFormDataByIDRequest setUseAlias(Boolean useAlias) {
        this.useAlias = useAlias;
        return this;
    }
    public Boolean getUseAlias() {
        return this.useAlias;
    }

    public GetFormDataByIDRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
