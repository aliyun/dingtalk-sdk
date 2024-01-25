// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdevicemng_1_0.models;

import com.aliyun.tea.*;

public class ListInspectInfoResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
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

    public ListInspectInfoResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ListInspectInfoResponse setBody(ListInspectInfoResponseBody body) {
        this.body = body;
        return this;
    }
    public ListInspectInfoResponseBody getBody() {
        return this.body;
    }

}
