// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class CampusCreateRenterResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public CampusCreateRenterResponseBody body;

    public static CampusCreateRenterResponse build(java.util.Map<String, ?> map) throws Exception {
        CampusCreateRenterResponse self = new CampusCreateRenterResponse();
        return TeaModel.build(map, self);
    }

    public CampusCreateRenterResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CampusCreateRenterResponse setBody(CampusCreateRenterResponseBody body) {
        this.body = body;
        return this;
    }
    public CampusCreateRenterResponseBody getBody() {
        return this.body;
    }

}
