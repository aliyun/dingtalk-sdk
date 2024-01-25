// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class IndustryManufactureMaterialListResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public IndustryManufactureMaterialListResponseBody body;

    public static IndustryManufactureMaterialListResponse build(java.util.Map<String, ?> map) throws Exception {
        IndustryManufactureMaterialListResponse self = new IndustryManufactureMaterialListResponse();
        return TeaModel.build(map, self);
    }

    public IndustryManufactureMaterialListResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public IndustryManufactureMaterialListResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public IndustryManufactureMaterialListResponse setBody(IndustryManufactureMaterialListResponseBody body) {
        this.body = body;
        return this;
    }
    public IndustryManufactureMaterialListResponseBody getBody() {
        return this.body;
    }

}
