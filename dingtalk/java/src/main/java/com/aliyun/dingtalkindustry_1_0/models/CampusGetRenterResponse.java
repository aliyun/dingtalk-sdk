// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class CampusGetRenterResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public CampusGetRenterResponseBody body;

    public static CampusGetRenterResponse build(java.util.Map<String, ?> map) throws Exception {
        CampusGetRenterResponse self = new CampusGetRenterResponse();
        return TeaModel.build(map, self);
    }

    public CampusGetRenterResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CampusGetRenterResponse setBody(CampusGetRenterResponseBody body) {
        this.body = body;
        return this;
    }
    public CampusGetRenterResponseBody getBody() {
        return this.body;
    }

}
