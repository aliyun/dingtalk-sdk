// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class IndustryManufactureMesMaterialResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public IndustryManufactureMesMaterialResponseBody body;

    public static IndustryManufactureMesMaterialResponse build(java.util.Map<String, ?> map) throws Exception {
        IndustryManufactureMesMaterialResponse self = new IndustryManufactureMesMaterialResponse();
        return TeaModel.build(map, self);
    }

    public IndustryManufactureMesMaterialResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public IndustryManufactureMesMaterialResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public IndustryManufactureMesMaterialResponse setBody(IndustryManufactureMesMaterialResponseBody body) {
        this.body = body;
        return this;
    }
    public IndustryManufactureMesMaterialResponseBody getBody() {
        return this.body;
    }

}
