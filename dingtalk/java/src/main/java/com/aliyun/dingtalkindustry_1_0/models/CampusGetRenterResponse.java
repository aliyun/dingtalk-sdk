// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class CampusGetRenterResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
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

    public CampusGetRenterResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CampusGetRenterResponse setBody(CampusGetRenterResponseBody body) {
        this.body = body;
        return this;
    }
    public CampusGetRenterResponseBody getBody() {
        return this.body;
    }

}
