// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class DeleteFormDataRequest extends TeaModel {
    /**
     * <p>应用ID</p>
     */
    @NameInMap("appType")
    public String appType;

    /**
     * <p>要删除的表单数据ID</p>
     */
    @NameInMap("formInstanceId")
    public String formInstanceId;

    /**
     * <p>语言</p>
     */
    @NameInMap("language")
    public String language;

    /**
     * <p>应用秘钥</p>
     */
    @NameInMap("systemToken")
    public String systemToken;

    /**
     * <p>钉钉的userId</p>
     */
    @NameInMap("userId")
    public String userId;

    public static DeleteFormDataRequest build(java.util.Map<String, ?> map) throws Exception {
        DeleteFormDataRequest self = new DeleteFormDataRequest();
        return TeaModel.build(map, self);
    }

    public DeleteFormDataRequest setAppType(String appType) {
        this.appType = appType;
        return this;
    }
    public String getAppType() {
        return this.appType;
    }

    public DeleteFormDataRequest setFormInstanceId(String formInstanceId) {
        this.formInstanceId = formInstanceId;
        return this;
    }
    public String getFormInstanceId() {
        return this.formInstanceId;
    }

    public DeleteFormDataRequest setLanguage(String language) {
        this.language = language;
        return this;
    }
    public String getLanguage() {
        return this.language;
    }

    public DeleteFormDataRequest setSystemToken(String systemToken) {
        this.systemToken = systemToken;
        return this;
    }
    public String getSystemToken() {
        return this.systemToken;
    }

    public DeleteFormDataRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
