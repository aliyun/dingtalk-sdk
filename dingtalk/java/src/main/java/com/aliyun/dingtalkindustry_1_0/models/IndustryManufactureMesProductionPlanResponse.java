// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class IndustryManufactureMesProductionPlanResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public IndustryManufactureMesProductionPlanResponseBody body;

    public static IndustryManufactureMesProductionPlanResponse build(java.util.Map<String, ?> map) throws Exception {
        IndustryManufactureMesProductionPlanResponse self = new IndustryManufactureMesProductionPlanResponse();
        return TeaModel.build(map, self);
    }

    public IndustryManufactureMesProductionPlanResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public IndustryManufactureMesProductionPlanResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public IndustryManufactureMesProductionPlanResponse setBody(IndustryManufactureMesProductionPlanResponseBody body) {
        this.body = body;
        return this;
    }
    public IndustryManufactureMesProductionPlanResponseBody getBody() {
        return this.body;
    }

}
