// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkwiki_2_0.models;

import com.aliyun.tea.*;

public class SetDefaultHandOverUserResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public SetDefaultHandOverUserResponseBody body;

    public static SetDefaultHandOverUserResponse build(java.util.Map<String, ?> map) throws Exception {
        SetDefaultHandOverUserResponse self = new SetDefaultHandOverUserResponse();
        return TeaModel.build(map, self);
    }

    public SetDefaultHandOverUserResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SetDefaultHandOverUserResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public SetDefaultHandOverUserResponse setBody(SetDefaultHandOverUserResponseBody body) {
        this.body = body;
        return this;
    }
    public SetDefaultHandOverUserResponseBody getBody() {
        return this.body;
    }

}
