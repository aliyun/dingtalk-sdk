// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class IndustryManufactureMesOutPlanResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public IndustryManufactureMesOutPlanResponseBody body;

    public static IndustryManufactureMesOutPlanResponse build(java.util.Map<String, ?> map) throws Exception {
        IndustryManufactureMesOutPlanResponse self = new IndustryManufactureMesOutPlanResponse();
        return TeaModel.build(map, self);
    }

    public IndustryManufactureMesOutPlanResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public IndustryManufactureMesOutPlanResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public IndustryManufactureMesOutPlanResponse setBody(IndustryManufactureMesOutPlanResponseBody body) {
        this.body = body;
        return this;
    }
    public IndustryManufactureMesOutPlanResponseBody getBody() {
        return this.body;
    }

}
