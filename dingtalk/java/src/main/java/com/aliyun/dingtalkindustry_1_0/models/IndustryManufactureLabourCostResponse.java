// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class IndustryManufactureLabourCostResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public IndustryManufactureLabourCostResponseBody body;

    public static IndustryManufactureLabourCostResponse build(java.util.Map<String, ?> map) throws Exception {
        IndustryManufactureLabourCostResponse self = new IndustryManufactureLabourCostResponse();
        return TeaModel.build(map, self);
    }

    public IndustryManufactureLabourCostResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public IndustryManufactureLabourCostResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public IndustryManufactureLabourCostResponse setBody(IndustryManufactureLabourCostResponseBody body) {
        this.body = body;
        return this;
    }
    public IndustryManufactureLabourCostResponseBody getBody() {
        return this.body;
    }

}
