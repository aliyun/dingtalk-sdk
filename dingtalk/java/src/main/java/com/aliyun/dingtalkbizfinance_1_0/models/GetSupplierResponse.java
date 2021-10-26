// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class GetSupplierResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public GetSupplierResponseBody body;

    public static GetSupplierResponse build(java.util.Map<String, ?> map) throws Exception {
        GetSupplierResponse self = new GetSupplierResponse();
        return TeaModel.build(map, self);
    }

    public GetSupplierResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetSupplierResponse setBody(GetSupplierResponseBody body) {
        this.body = body;
        return this;
    }
    public GetSupplierResponseBody getBody() {
        return this.body;
    }

}
