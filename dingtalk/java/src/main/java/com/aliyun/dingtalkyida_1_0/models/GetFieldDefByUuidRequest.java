// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class GetFieldDefByUuidRequest extends TeaModel {
    /**
     * <p>应用编码。应用唯一标识。如：APP_XXX</p>
     */
    @NameInMap("appType")
    public String appType;

    /**
     * <p>表单唯一标识</p>
     */
    @NameInMap("formUuid")
    public String formUuid;

    /**
     * <p>应用秘钥。在应用设置-部署运维-应用密钥中获取。</p>
     */
    @NameInMap("systemToken")
    public String systemToken;

    /**
     * <p>操作人userId</p>
     */
    @NameInMap("userId")
    public String userId;

    public static GetFieldDefByUuidRequest build(java.util.Map<String, ?> map) throws Exception {
        GetFieldDefByUuidRequest self = new GetFieldDefByUuidRequest();
        return TeaModel.build(map, self);
    }

    public GetFieldDefByUuidRequest setAppType(String appType) {
        this.appType = appType;
        return this;
    }
    public String getAppType() {
        return this.appType;
    }

    public GetFieldDefByUuidRequest setFormUuid(String formUuid) {
        this.formUuid = formUuid;
        return this;
    }
    public String getFormUuid() {
        return this.formUuid;
    }

    public GetFieldDefByUuidRequest setSystemToken(String systemToken) {
        this.systemToken = systemToken;
        return this;
    }
    public String getSystemToken() {
        return this.systemToken;
    }

    public GetFieldDefByUuidRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
