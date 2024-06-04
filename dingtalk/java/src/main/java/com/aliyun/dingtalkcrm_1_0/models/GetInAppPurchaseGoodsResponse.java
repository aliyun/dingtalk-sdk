// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class GetInAppPurchaseGoodsResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetInAppPurchaseGoodsResponseBody body;

    public static GetInAppPurchaseGoodsResponse build(java.util.Map<String, ?> map) throws Exception {
        GetInAppPurchaseGoodsResponse self = new GetInAppPurchaseGoodsResponse();
        return TeaModel.build(map, self);
    }

    public GetInAppPurchaseGoodsResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetInAppPurchaseGoodsResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetInAppPurchaseGoodsResponse setBody(GetInAppPurchaseGoodsResponseBody body) {
        this.body = body;
        return this;
    }
    public GetInAppPurchaseGoodsResponseBody getBody() {
        return this.body;
    }

}
