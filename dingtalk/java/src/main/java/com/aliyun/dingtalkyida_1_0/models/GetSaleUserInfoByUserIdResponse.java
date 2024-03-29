// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class GetSaleUserInfoByUserIdResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetSaleUserInfoByUserIdResponseBody body;

    public static GetSaleUserInfoByUserIdResponse build(java.util.Map<String, ?> map) throws Exception {
        GetSaleUserInfoByUserIdResponse self = new GetSaleUserInfoByUserIdResponse();
        return TeaModel.build(map, self);
    }

    public GetSaleUserInfoByUserIdResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetSaleUserInfoByUserIdResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetSaleUserInfoByUserIdResponse setBody(GetSaleUserInfoByUserIdResponseBody body) {
        this.body = body;
        return this;
    }
    public GetSaleUserInfoByUserIdResponseBody getBody() {
        return this.body;
    }

}
