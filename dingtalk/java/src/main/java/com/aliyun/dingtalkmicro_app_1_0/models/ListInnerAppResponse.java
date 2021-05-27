// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmicro_app_1_0.models;

import com.aliyun.tea.*;

public class ListInnerAppResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public ListInnerAppResponseBody body;

    public static ListInnerAppResponse build(java.util.Map<String, ?> map) throws Exception {
        ListInnerAppResponse self = new ListInnerAppResponse();
        return TeaModel.build(map, self);
    }

    public ListInnerAppResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ListInnerAppResponse setBody(ListInnerAppResponseBody body) {
        this.body = body;
        return this;
    }
    public ListInnerAppResponseBody getBody() {
        return this.body;
    }

}
