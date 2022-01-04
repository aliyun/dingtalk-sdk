// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkfinance_1_0.models;

import com.aliyun.tea.*;

public class CreatWithholdingOrderAndPayResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public CreatWithholdingOrderAndPayResponseBody body;

    public static CreatWithholdingOrderAndPayResponse build(java.util.Map<String, ?> map) throws Exception {
        CreatWithholdingOrderAndPayResponse self = new CreatWithholdingOrderAndPayResponse();
        return TeaModel.build(map, self);
    }

    public CreatWithholdingOrderAndPayResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CreatWithholdingOrderAndPayResponse setBody(CreatWithholdingOrderAndPayResponseBody body) {
        this.body = body;
        return this;
    }
    public CreatWithholdingOrderAndPayResponseBody getBody() {
        return this.body;
    }

}
