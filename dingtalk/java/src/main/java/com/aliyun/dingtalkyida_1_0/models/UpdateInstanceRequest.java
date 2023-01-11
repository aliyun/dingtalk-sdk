// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class UpdateInstanceRequest extends TeaModel {
    /**
     * <p>应用ID</p>
     */
    @NameInMap("appType")
    public String appType;

    /**
     * <p>语言环境</p>
     */
    @NameInMap("language")
    public String language;

    /**
     * <p>实例ID</p>
     */
    @NameInMap("processInstanceId")
    public String processInstanceId;

    /**
     * <p>应用秘钥</p>
     */
    @NameInMap("systemToken")
    public String systemToken;

    /**
     * <p>更新的表单数据</p>
     */
    @NameInMap("updateFormDataJson")
    public String updateFormDataJson;

    /**
     * <p>钉钉的userId</p>
     */
    @NameInMap("userId")
    public String userId;

    public static UpdateInstanceRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateInstanceRequest self = new UpdateInstanceRequest();
        return TeaModel.build(map, self);
    }

    public UpdateInstanceRequest setAppType(String appType) {
        this.appType = appType;
        return this;
    }
    public String getAppType() {
        return this.appType;
    }

    public UpdateInstanceRequest setLanguage(String language) {
        this.language = language;
        return this;
    }
    public String getLanguage() {
        return this.language;
    }

    public UpdateInstanceRequest setProcessInstanceId(String processInstanceId) {
        this.processInstanceId = processInstanceId;
        return this;
    }
    public String getProcessInstanceId() {
        return this.processInstanceId;
    }

    public UpdateInstanceRequest setSystemToken(String systemToken) {
        this.systemToken = systemToken;
        return this;
    }
    public String getSystemToken() {
        return this.systemToken;
    }

    public UpdateInstanceRequest setUpdateFormDataJson(String updateFormDataJson) {
        this.updateFormDataJson = updateFormDataJson;
        return this;
    }
    public String getUpdateFormDataJson() {
        return this.updateFormDataJson;
    }

    public UpdateInstanceRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
