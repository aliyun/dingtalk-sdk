// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class IndustryManufactureMesProductionPlanResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
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

    public IndustryManufactureMesProductionPlanResponse setBody(IndustryManufactureMesProductionPlanResponseBody body) {
        this.body = body;
        return this;
    }
    public IndustryManufactureMesProductionPlanResponseBody getBody() {
        return this.body;
    }

}
