// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkminutes_1_0.models;

import com.aliyun.tea.*;

public class AdminSearchMinutesResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public AdminSearchMinutesResponseBody body;

    public static AdminSearchMinutesResponse build(java.util.Map<String, ?> map) throws Exception {
        AdminSearchMinutesResponse self = new AdminSearchMinutesResponse();
        return TeaModel.build(map, self);
    }

    public AdminSearchMinutesResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public AdminSearchMinutesResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public AdminSearchMinutesResponse setBody(AdminSearchMinutesResponseBody body) {
        this.body = body;
        return this;
    }
    public AdminSearchMinutesResponseBody getBody() {
        return this.body;
    }

}
