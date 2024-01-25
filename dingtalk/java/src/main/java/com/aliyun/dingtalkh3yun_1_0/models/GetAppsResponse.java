// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkh3yun_1_0.models;

import com.aliyun.tea.*;

public class GetAppsResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetAppsResponseBody body;

    public static GetAppsResponse build(java.util.Map<String, ?> map) throws Exception {
        GetAppsResponse self = new GetAppsResponse();
        return TeaModel.build(map, self);
    }

    public GetAppsResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetAppsResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetAppsResponse setBody(GetAppsResponseBody body) {
        this.body = body;
        return this;
    }
    public GetAppsResponseBody getBody() {
        return this.body;
    }

}
