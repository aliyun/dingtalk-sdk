// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmicro_app_1_0.models;

import com.aliyun.tea.*;

public class ListInnerAppResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
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

    public ListInnerAppResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ListInnerAppResponse setBody(ListInnerAppResponseBody body) {
        this.body = body;
        return this;
    }
    public ListInnerAppResponseBody getBody() {
        return this.body;
    }

}
