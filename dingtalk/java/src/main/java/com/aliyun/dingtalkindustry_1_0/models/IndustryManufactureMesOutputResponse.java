// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class IndustryManufactureMesOutputResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public IndustryManufactureMesOutputResponseBody body;

    public static IndustryManufactureMesOutputResponse build(java.util.Map<String, ?> map) throws Exception {
        IndustryManufactureMesOutputResponse self = new IndustryManufactureMesOutputResponse();
        return TeaModel.build(map, self);
    }

    public IndustryManufactureMesOutputResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public IndustryManufactureMesOutputResponse setBody(IndustryManufactureMesOutputResponseBody body) {
        this.body = body;
        return this;
    }
    public IndustryManufactureMesOutputResponseBody getBody() {
        return this.body;
    }

}
