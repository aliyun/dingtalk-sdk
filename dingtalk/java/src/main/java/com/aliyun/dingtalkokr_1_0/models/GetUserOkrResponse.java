// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkokr_1_0.models;

import com.aliyun.tea.*;

public class GetUserOkrResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetUserOkrResponseBody body;

    public static GetUserOkrResponse build(java.util.Map<String, ?> map) throws Exception {
        GetUserOkrResponse self = new GetUserOkrResponse();
        return TeaModel.build(map, self);
    }

    public GetUserOkrResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetUserOkrResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetUserOkrResponse setBody(GetUserOkrResponseBody body) {
        this.body = body;
        return this;
    }
    public GetUserOkrResponseBody getBody() {
        return this.body;
    }

}
