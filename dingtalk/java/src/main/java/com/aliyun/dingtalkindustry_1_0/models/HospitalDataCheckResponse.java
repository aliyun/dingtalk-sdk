// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class HospitalDataCheckResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
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

    public HospitalDataCheckResponse setBody(HospitalDataCheckResponseBody body) {
        this.body = body;
        return this;
    }
    public HospitalDataCheckResponseBody getBody() {
        return this.body;
    }

}
