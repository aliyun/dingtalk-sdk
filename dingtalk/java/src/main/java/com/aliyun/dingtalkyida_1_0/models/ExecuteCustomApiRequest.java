// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class ExecuteCustomApiRequest extends TeaModel {
    @NameInMap("appType")
    public String appType;

    @NameInMap("data")
    public String data;

    @NameInMap("language")
    public String language;

    @NameInMap("serviceId")
    public String serviceId;

    @NameInMap("systemToken")
    public String systemToken;

    @NameInMap("userId")
    public String userId;

    public static ExecuteCustomApiRequest build(java.util.Map<String, ?> map) throws Exception {
        ExecuteCustomApiRequest self = new ExecuteCustomApiRequest();
        return TeaModel.build(map, self);
    }

    public ExecuteCustomApiRequest setAppType(String appType) {
        this.appType = appType;
        return this;
    }
    public String getAppType() {
        return this.appType;
    }

    public ExecuteCustomApiRequest setData(String data) {
        this.data = data;
        return this;
    }
    public String getData() {
        return this.data;
    }

    public ExecuteCustomApiRequest setLanguage(String language) {
        this.language = language;
        return this;
    }
    public String getLanguage() {
        return this.language;
    }

    public ExecuteCustomApiRequest setServiceId(String serviceId) {
        this.serviceId = serviceId;
        return this;
    }
    public String getServiceId() {
        return this.serviceId;
    }

    public ExecuteCustomApiRequest setSystemToken(String systemToken) {
        this.systemToken = systemToken;
        return this;
    }
    public String getSystemToken() {
        return this.systemToken;
    }

    public ExecuteCustomApiRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
