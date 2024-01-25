// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class HospitalDataCheckResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public HospitalDataCheckResponseBody body;

    public static HospitalDataCheckResponse build(java.util.Map<String, ?> map) throws Exception {
        HospitalDataCheckResponse self = new HospitalDataCheckResponse();
        return TeaModel.build(map, self);
    }

    public HospitalDataCheckResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public HospitalDataCheckResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public HospitalDataCheckResponse setBody(HospitalDataCheckResponseBody body) {
        this.body = body;
        return this;
    }
    public HospitalDataCheckResponseBody getBody() {
        return this.body;
    }

}
