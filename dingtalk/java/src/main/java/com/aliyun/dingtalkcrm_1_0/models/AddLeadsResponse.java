// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class AddLeadsResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
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

    public AddLeadsResponse setBody(AddLeadsResponseBody body) {
        this.body = body;
        return this;
    }
    public AddLeadsResponseBody getBody() {
        return this.body;
    }

}
