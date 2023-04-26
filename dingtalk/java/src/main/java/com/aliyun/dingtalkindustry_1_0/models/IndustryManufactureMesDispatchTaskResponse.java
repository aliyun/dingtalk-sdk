// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class IndustryManufactureMesDispatchTaskResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public IndustryManufactureMesDispatchTaskResponseBody body;

    public static IndustryManufactureMesDispatchTaskResponse build(java.util.Map<String, ?> map) throws Exception {
        IndustryManufactureMesDispatchTaskResponse self = new IndustryManufactureMesDispatchTaskResponse();
        return TeaModel.build(map, self);
    }

    public IndustryManufactureMesDispatchTaskResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public IndustryManufactureMesDispatchTaskResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public IndustryManufactureMesDispatchTaskResponse setBody(IndustryManufactureMesDispatchTaskResponseBody body) {
        this.body = body;
        return this;
    }
    public IndustryManufactureMesDispatchTaskResponseBody getBody() {
        return this.body;
    }

}
