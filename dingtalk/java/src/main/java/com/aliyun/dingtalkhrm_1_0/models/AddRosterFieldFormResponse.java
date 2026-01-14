// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class AddRosterFieldFormResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public AddRosterFieldFormResponseBody body;

    public static AddRosterFieldFormResponse build(java.util.Map<String, ?> map) throws Exception {
        AddRosterFieldFormResponse self = new AddRosterFieldFormResponse();
        return TeaModel.build(map, self);
    }

    public AddRosterFieldFormResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public AddRosterFieldFormResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public AddRosterFieldFormResponse setBody(AddRosterFieldFormResponseBody body) {
        this.body = body;
        return this;
    }
    public AddRosterFieldFormResponseBody getBody() {
        return this.body;
    }

}
