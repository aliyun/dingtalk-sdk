// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class IndustryManufactureFeeListGetResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
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

    public IndustryManufactureFeeListGetResponse setBody(IndustryManufactureFeeListGetResponseBody body) {
        this.body = body;
        return this;
    }
    public IndustryManufactureFeeListGetResponseBody getBody() {
        return this.body;
    }

}
