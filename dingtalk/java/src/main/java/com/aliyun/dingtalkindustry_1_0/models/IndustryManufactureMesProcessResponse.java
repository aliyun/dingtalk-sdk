// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class IndustryManufactureMesProcessResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public IndustryManufactureMesProcessResponseBody body;

    public static IndustryManufactureMesProcessResponse build(java.util.Map<String, ?> map) throws Exception {
        IndustryManufactureMesProcessResponse self = new IndustryManufactureMesProcessResponse();
        return TeaModel.build(map, self);
    }

    public IndustryManufactureMesProcessResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public IndustryManufactureMesProcessResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public IndustryManufactureMesProcessResponse setBody(IndustryManufactureMesProcessResponseBody body) {
        this.body = body;
        return this;
    }
    public IndustryManufactureMesProcessResponseBody getBody() {
        return this.body;
    }

}
