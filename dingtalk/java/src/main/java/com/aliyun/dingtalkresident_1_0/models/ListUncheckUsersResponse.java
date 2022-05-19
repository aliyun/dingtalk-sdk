// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkresident_1_0.models;

import com.aliyun.tea.*;

public class ListUncheckUsersResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public ListUncheckUsersResponseBody body;

    public static ListUncheckUsersResponse build(java.util.Map<String, ?> map) throws Exception {
        ListUncheckUsersResponse self = new ListUncheckUsersResponse();
        return TeaModel.build(map, self);
    }

    public ListUncheckUsersResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ListUncheckUsersResponse setBody(ListUncheckUsersResponseBody body) {
        this.body = body;
        return this;
    }
    public ListUncheckUsersResponseBody getBody() {
        return this.body;
    }

}
