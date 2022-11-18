// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class GetFieldDefByUuidRequest extends TeaModel {
    // 应用编码。应用唯一标识。如：APP_XXX
    @NameInMap("appType")
    public String appType;

    // 表单唯一标识
    @NameInMap("formUuid")
    public String formUuid;

    // 应用秘钥。在应用设置-部署运维-应用密钥中获取。
    @NameInMap("systemToken")
    public String systemToken;

    // 操作人userId
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
