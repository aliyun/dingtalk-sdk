// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class SaveFormDataRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>APP_PBKT0MFBEBTDO8T7SLVP</p>
     */
    @NameInMap("appType")
    public String appType;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>{&quot;textField_jcpm6agt&quot;: &quot;单行&quot;,&quot;employeeField_jcos0sar&quot;: [&quot;workno&quot;]}</p>
     */
    @NameInMap("formDataJson")
    public String formDataJson;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>FORM-NJYJZELV8YZRDEI2N5IQ7L6VEDMR1VE9GMPCJB</p>
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
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>hexxx</p>
     */
    @NameInMap("systemToken")
    public String systemToken;

    /**
     * <p>This parameter is required.</p>
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
