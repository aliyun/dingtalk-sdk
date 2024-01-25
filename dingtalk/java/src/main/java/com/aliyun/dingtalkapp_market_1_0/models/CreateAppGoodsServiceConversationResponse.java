// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkapp_market_1_0.models;

import com.aliyun.tea.*;

public class CreateAppGoodsServiceConversationResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public CreateAppGoodsServiceConversationResponseBody body;

    public static CreateAppGoodsServiceConversationResponse build(java.util.Map<String, ?> map) throws Exception {
        CreateAppGoodsServiceConversationResponse self = new CreateAppGoodsServiceConversationResponse();
        return TeaModel.build(map, self);
    }

    public CreateAppGoodsServiceConversationResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CreateAppGoodsServiceConversationResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CreateAppGoodsServiceConversationResponse setBody(CreateAppGoodsServiceConversationResponseBody body) {
        this.body = body;
        return this;
    }
    public CreateAppGoodsServiceConversationResponseBody getBody() {
        return this.body;
    }

}
