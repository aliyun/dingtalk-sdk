// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontent_1_0.models;

import com.aliyun.tea.*;

public class ListItemUserDataResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public ListItemUserDataResponseBody body;

    public static ListItemUserDataResponse build(java.util.Map<String, ?> map) throws Exception {
        ListItemUserDataResponse self = new ListItemUserDataResponse();
        return TeaModel.build(map, self);
    }

    public ListItemUserDataResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ListItemUserDataResponse setBody(ListItemUserDataResponseBody body) {
        this.body = body;
        return this;
    }
    public ListItemUserDataResponseBody getBody() {
        return this.body;
    }

}
