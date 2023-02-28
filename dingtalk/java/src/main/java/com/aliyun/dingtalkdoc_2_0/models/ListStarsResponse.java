// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class ListStarsResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public ListStarsResponseBody body;

    public static ListStarsResponse build(java.util.Map<String, ?> map) throws Exception {
        ListStarsResponse self = new ListStarsResponse();
        return TeaModel.build(map, self);
    }

    public ListStarsResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ListStarsResponse setBody(ListStarsResponseBody body) {
        this.body = body;
        return this;
    }
    public ListStarsResponseBody getBody() {
        return this.body;
    }

}
