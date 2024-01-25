// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkwiki_2_0.models;

import com.aliyun.tea.*;

public class GetDefaultHandOverUserResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetDefaultHandOverUserResponseBody body;

    public static GetDefaultHandOverUserResponse build(java.util.Map<String, ?> map) throws Exception {
        GetDefaultHandOverUserResponse self = new GetDefaultHandOverUserResponse();
        return TeaModel.build(map, self);
    }

    public GetDefaultHandOverUserResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetDefaultHandOverUserResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetDefaultHandOverUserResponse setBody(GetDefaultHandOverUserResponseBody body) {
        this.body = body;
        return this;
    }
    public GetDefaultHandOverUserResponseBody getBody() {
        return this.body;
    }

}
