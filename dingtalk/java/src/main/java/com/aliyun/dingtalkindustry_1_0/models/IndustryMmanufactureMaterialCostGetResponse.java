// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class IndustryMmanufactureMaterialCostGetResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public IndustryMmanufactureMaterialCostGetResponseBody body;

    public static IndustryMmanufactureMaterialCostGetResponse build(java.util.Map<String, ?> map) throws Exception {
        IndustryMmanufactureMaterialCostGetResponse self = new IndustryMmanufactureMaterialCostGetResponse();
        return TeaModel.build(map, self);
    }

    public IndustryMmanufactureMaterialCostGetResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public IndustryMmanufactureMaterialCostGetResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public IndustryMmanufactureMaterialCostGetResponse setBody(IndustryMmanufactureMaterialCostGetResponseBody body) {
        this.body = body;
        return this;
    }
    public IndustryMmanufactureMaterialCostGetResponseBody getBody() {
        return this.body;
    }

}
