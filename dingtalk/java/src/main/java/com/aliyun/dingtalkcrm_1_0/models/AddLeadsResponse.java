// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class AddLeadsResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public AddLeadsResponseBody body;

    public static AddLeadsResponse build(java.util.Map<String, ?> map) throws Exception {
        AddLeadsResponse self = new AddLeadsResponse();
        return TeaModel.build(map, self);
    }

    public AddLeadsResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public AddLeadsResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public AddLeadsResponse setBody(AddLeadsResponseBody body) {
        this.body = body;
        return this;
    }
    public AddLeadsResponseBody getBody() {
        return this.body;
    }

}
