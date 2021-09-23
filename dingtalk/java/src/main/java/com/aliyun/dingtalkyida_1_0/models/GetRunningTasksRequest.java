// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class GetRunningTasksRequest extends TeaModel {
    @NameInMap("processInstanceId")
    public String processInstanceId;

    @NameInMap("appType")
    public String appType;

    @NameInMap("systemToken")
    public String systemToken;

    @NameInMap("language")
    public String language;

    @NameInMap("userId")
    public String userId;

    public static GetRunningTasksRequest build(java.util.Map<String, ?> map) throws Exception {
        GetRunningTasksRequest self = new GetRunningTasksRequest();
        return TeaModel.build(map, self);
    }

    public GetRunningTasksRequest setProcessInstanceId(String processInstanceId) {
        this.processInstanceId = processInstanceId;
        return this;
    }
    public String getProcessInstanceId() {
        return this.processInstanceId;
    }

    public GetRunningTasksRequest setAppType(String appType) {
        this.appType = appType;
        return this;
    }
    public String getAppType() {
        return this.appType;
    }

    public GetRunningTasksRequest setSystemToken(String systemToken) {
        this.systemToken = systemToken;
        return this;
    }
    public String getSystemToken() {
        return this.systemToken;
    }

    public GetRunningTasksRequest setLanguage(String language) {
        this.language = language;
        return this;
    }
    public String getLanguage() {
        return this.language;
    }

    public GetRunningTasksRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
