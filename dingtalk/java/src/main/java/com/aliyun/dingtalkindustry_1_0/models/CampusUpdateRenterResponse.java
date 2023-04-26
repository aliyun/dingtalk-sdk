// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class CampusUpdateRenterResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public CampusUpdateRenterResponseBody body;

    public static CampusUpdateRenterResponse build(java.util.Map<String, ?> map) throws Exception {
        CampusUpdateRenterResponse self = new CampusUpdateRenterResponse();
        return TeaModel.build(map, self);
    }

    public CampusUpdateRenterResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CampusUpdateRenterResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CampusUpdateRenterResponse setBody(CampusUpdateRenterResponseBody body) {
        this.body = body;
        return this;
    }
    public CampusUpdateRenterResponseBody getBody() {
        return this.body;
    }

}
