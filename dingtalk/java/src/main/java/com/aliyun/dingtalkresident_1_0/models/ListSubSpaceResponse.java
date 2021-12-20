// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkresident_1_0.models;

import com.aliyun.tea.*;

public class ListSubSpaceResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public ListSubSpaceResponseBody body;

    public static ListSubSpaceResponse build(java.util.Map<String, ?> map) throws Exception {
        ListSubSpaceResponse self = new ListSubSpaceResponse();
        return TeaModel.build(map, self);
    }

    public ListSubSpaceResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ListSubSpaceResponse setBody(ListSubSpaceResponseBody body) {
        this.body = body;
        return this;
    }
    public ListSubSpaceResponseBody getBody() {
        return this.body;
    }

}
