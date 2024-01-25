// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class UserTemplatesResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public UserTemplatesResponseBody body;

    public static UserTemplatesResponse build(java.util.Map<String, ?> map) throws Exception {
        UserTemplatesResponse self = new UserTemplatesResponse();
        return TeaModel.build(map, self);
    }

    public UserTemplatesResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UserTemplatesResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public UserTemplatesResponse setBody(UserTemplatesResponseBody body) {
        this.body = body;
        return this;
    }
    public UserTemplatesResponseBody getBody() {
        return this.body;
    }

}
