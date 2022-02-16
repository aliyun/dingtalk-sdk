// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class CardTemplateBuildActionResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public CardTemplateBuildActionResponseBody body;

    public static CardTemplateBuildActionResponse build(java.util.Map<String, ?> map) throws Exception {
        CardTemplateBuildActionResponse self = new CardTemplateBuildActionResponse();
        return TeaModel.build(map, self);
    }

    public CardTemplateBuildActionResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CardTemplateBuildActionResponse setBody(CardTemplateBuildActionResponseBody body) {
        this.body = body;
        return this;
    }
    public CardTemplateBuildActionResponseBody getBody() {
        return this.body;
    }

}
