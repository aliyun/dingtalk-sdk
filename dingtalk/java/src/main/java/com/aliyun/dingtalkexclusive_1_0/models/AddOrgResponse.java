// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class AddOrgResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
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

    public AddOrgResponse setBody(AddOrgResponseBody body) {
        this.body = body;
        return this;
    }
    public AddOrgResponseBody getBody() {
        return this.body;
    }

}
