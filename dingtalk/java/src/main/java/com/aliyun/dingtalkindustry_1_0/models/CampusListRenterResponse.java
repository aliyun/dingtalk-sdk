// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class CampusListRenterResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public CampusListRenterResponseBody body;

    public static CampusListRenterResponse build(java.util.Map<String, ?> map) throws Exception {
        CampusListRenterResponse self = new CampusListRenterResponse();
        return TeaModel.build(map, self);
    }

    public CampusListRenterResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CampusListRenterResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CampusListRenterResponse setBody(CampusListRenterResponseBody body) {
        this.body = body;
        return this;
    }
    public CampusListRenterResponseBody getBody() {
        return this.body;
    }

}
