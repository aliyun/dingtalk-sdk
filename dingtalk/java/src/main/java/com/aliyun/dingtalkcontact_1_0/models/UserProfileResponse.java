// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class UserProfileResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public UserProfileResponseBody body;

    public static UserProfileResponse build(java.util.Map<String, ?> map) throws Exception {
        UserProfileResponse self = new UserProfileResponse();
        return TeaModel.build(map, self);
    }

    public UserProfileResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UserProfileResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public UserProfileResponse setBody(UserProfileResponseBody body) {
        this.body = body;
        return this;
    }
    public UserProfileResponseBody getBody() {
        return this.body;
    }

}
