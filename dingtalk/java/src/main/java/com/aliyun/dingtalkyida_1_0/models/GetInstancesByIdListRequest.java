// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class GetInstancesByIdListRequest extends TeaModel {
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

    // 流程实例ID列表，多个用,分割
    @NameInMap("processInstanceIds")
    public String processInstanceIds;

    public static GetInstancesByIdListRequest build(java.util.Map<String, ?> map) throws Exception {
        GetInstancesByIdListRequest self = new GetInstancesByIdListRequest();
        return TeaModel.build(map, self);
    }

    public GetInstancesByIdListRequest setAppType(String appType) {
        this.appType = appType;
        return this;
    }
    public String getAppType() {
        return this.appType;
    }

    public GetInstancesByIdListRequest setSystemToken(String systemToken) {
        this.systemToken = systemToken;
        return this;
    }
    public String getSystemToken() {
        return this.systemToken;
    }

    public GetInstancesByIdListRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

    public GetInstancesByIdListRequest setLanguage(String language) {
        this.language = language;
        return this;
    }
    public String getLanguage() {
        return this.language;
    }

    public GetInstancesByIdListRequest setProcessInstanceIds(String processInstanceIds) {
        this.processInstanceIds = processInstanceIds;
        return this;
    }
    public String getProcessInstanceIds() {
        return this.processInstanceIds;
    }

}
