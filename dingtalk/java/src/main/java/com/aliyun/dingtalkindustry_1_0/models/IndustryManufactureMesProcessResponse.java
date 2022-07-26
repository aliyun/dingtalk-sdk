// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class IndustryManufactureMesProcessResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
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

    public IndustryManufactureMesProcessResponse setBody(IndustryManufactureMesProcessResponseBody body) {
        this.body = body;
        return this;
    }
    public IndustryManufactureMesProcessResponseBody getBody() {
        return this.body;
    }

}
