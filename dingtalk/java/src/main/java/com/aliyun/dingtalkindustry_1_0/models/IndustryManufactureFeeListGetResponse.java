// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class IndustryManufactureFeeListGetResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public IndustryManufactureFeeListGetResponseBody body;

    public static IndustryManufactureFeeListGetResponse build(java.util.Map<String, ?> map) throws Exception {
        IndustryManufactureFeeListGetResponse self = new IndustryManufactureFeeListGetResponse();
        return TeaModel.build(map, self);
    }

    public IndustryManufactureFeeListGetResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public IndustryManufactureFeeListGetResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public IndustryManufactureFeeListGetResponse setBody(IndustryManufactureFeeListGetResponseBody body) {
        this.body = body;
        return this;
    }
    public IndustryManufactureFeeListGetResponseBody getBody() {
        return this.body;
    }

}
