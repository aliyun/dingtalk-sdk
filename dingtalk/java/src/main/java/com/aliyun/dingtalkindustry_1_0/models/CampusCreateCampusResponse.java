// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class CampusCreateCampusResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public CampusCreateCampusResponseBody body;

    public static CampusCreateCampusResponse build(java.util.Map<String, ?> map) throws Exception {
        CampusCreateCampusResponse self = new CampusCreateCampusResponse();
        return TeaModel.build(map, self);
    }

    public CampusCreateCampusResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CampusCreateCampusResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CampusCreateCampusResponse setBody(CampusCreateCampusResponseBody body) {
        this.body = body;
        return this;
    }
    public CampusCreateCampusResponseBody getBody() {
        return this.body;
    }

}
