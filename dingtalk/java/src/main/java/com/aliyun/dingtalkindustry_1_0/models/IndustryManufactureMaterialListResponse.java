// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class IndustryManufactureMaterialListResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
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

    public IndustryManufactureMaterialListResponse setBody(IndustryManufactureMaterialListResponseBody body) {
        this.body = body;
        return this;
    }
    public IndustryManufactureMaterialListResponseBody getBody() {
        return this.body;
    }

}
