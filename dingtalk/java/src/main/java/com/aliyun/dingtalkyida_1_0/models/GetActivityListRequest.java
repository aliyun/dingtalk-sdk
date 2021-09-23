// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class GetActivityListRequest extends TeaModel {
    @NameInMap("processCode")
    public String processCode;

    @NameInMap("appType")
    public String appType;

    @NameInMap("systemToken")
    public String systemToken;

    @NameInMap("language")
    public String language;

    @NameInMap("userId")
    public String userId;

    public static GetActivityListRequest build(java.util.Map<String, ?> map) throws Exception {
        GetActivityListRequest self = new GetActivityListRequest();
        return TeaModel.build(map, self);
    }

    public GetActivityListRequest setProcessCode(String processCode) {
        this.processCode = processCode;
        return this;
    }
    public String getProcessCode() {
        return this.processCode;
    }

    public GetActivityListRequest setAppType(String appType) {
        this.appType = appType;
        return this;
    }
    public String getAppType() {
        return this.appType;
    }

    public GetActivityListRequest setSystemToken(String systemToken) {
        this.systemToken = systemToken;
        return this;
    }
    public String getSystemToken() {
        return this.systemToken;
    }

    public GetActivityListRequest setLanguage(String language) {
        this.language = language;
        return this;
    }
    public String getLanguage() {
        return this.language;
    }

    public GetActivityListRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
