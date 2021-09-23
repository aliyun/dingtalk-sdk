// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class GetOperationRecordsRequest extends TeaModel {
    // 应用ID
    @NameInMap("appType")
    public String appType;

    // 应用秘钥
    @NameInMap("systemToken")
    public String systemToken;

    // 钉钉的userId
    @NameInMap("userId")
    public String userId;

    // 语言
    @NameInMap("language")
    public String language;

    // 流程实例ID
    @NameInMap("processInstanceId")
    public String processInstanceId;

    public static GetOperationRecordsRequest build(java.util.Map<String, ?> map) throws Exception {
        GetOperationRecordsRequest self = new GetOperationRecordsRequest();
        return TeaModel.build(map, self);
    }

    public GetOperationRecordsRequest setAppType(String appType) {
        this.appType = appType;
        return this;
    }
    public String getAppType() {
        return this.appType;
    }

    public GetOperationRecordsRequest setSystemToken(String systemToken) {
        this.systemToken = systemToken;
        return this;
    }
    public String getSystemToken() {
        return this.systemToken;
    }

    public GetOperationRecordsRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

    public GetOperationRecordsRequest setLanguage(String language) {
        this.language = language;
        return this;
    }
    public String getLanguage() {
        return this.language;
    }

    public GetOperationRecordsRequest setProcessInstanceId(String processInstanceId) {
        this.processInstanceId = processInstanceId;
        return this;
    }
    public String getProcessInstanceId() {
        return this.processInstanceId;
    }

}
