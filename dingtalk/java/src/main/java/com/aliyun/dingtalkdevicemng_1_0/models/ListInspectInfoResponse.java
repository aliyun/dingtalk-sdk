// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdevicemng_1_0.models;

import com.aliyun.tea.*;

public class ListInspectInfoResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public ListInspectInfoResponseBody body;

    public static ListInspectInfoResponse build(java.util.Map<String, ?> map) throws Exception {
        ListInspectInfoResponse self = new ListInspectInfoResponse();
        return TeaModel.build(map, self);
    }

    public ListInspectInfoResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ListInspectInfoResponse setBody(ListInspectInfoResponseBody body) {
        this.body = body;
        return this;
    }
    public ListInspectInfoResponseBody getBody() {
        return this.body;
    }

}
