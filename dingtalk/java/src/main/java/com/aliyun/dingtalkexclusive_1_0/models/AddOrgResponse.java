// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class AddOrgResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public AddOrgResponseBody body;

    public static AddOrgResponse build(java.util.Map<String, ?> map) throws Exception {
        AddOrgResponse self = new AddOrgResponse();
        return TeaModel.build(map, self);
    }

    public AddOrgResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public AddOrgResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public AddOrgResponse setBody(AddOrgResponseBody body) {
        this.body = body;
        return this;
    }
    public AddOrgResponseBody getBody() {
        return this.body;
    }

}
