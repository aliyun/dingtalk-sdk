// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_2_0.models;

import com.aliyun.tea.*;

public class GetSupplierResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
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

    public GetSupplierResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetSupplierResponse setBody(GetSupplierResponseBody body) {
        this.body = body;
        return this;
    }
    public GetSupplierResponseBody getBody() {
        return this.body;
    }

}
