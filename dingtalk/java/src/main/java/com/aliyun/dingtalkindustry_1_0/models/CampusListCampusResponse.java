// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class CampusListCampusResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public CampusListCampusResponseBody body;

    public static CampusListCampusResponse build(java.util.Map<String, ?> map) throws Exception {
        CampusListCampusResponse self = new CampusListCampusResponse();
        return TeaModel.build(map, self);
    }

    public CampusListCampusResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CampusListCampusResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CampusListCampusResponse setBody(CampusListCampusResponseBody body) {
        this.body = body;
        return this;
    }
    public CampusListCampusResponseBody getBody() {
        return this.body;
    }

}
