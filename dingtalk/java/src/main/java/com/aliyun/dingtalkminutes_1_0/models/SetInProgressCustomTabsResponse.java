// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkminutes_1_0.models;

import com.aliyun.tea.*;

public class SetInProgressCustomTabsResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public SetInProgressCustomTabsResponseBody body;

    public static SetInProgressCustomTabsResponse build(java.util.Map<String, ?> map) throws Exception {
        SetInProgressCustomTabsResponse self = new SetInProgressCustomTabsResponse();
        return TeaModel.build(map, self);
    }

    public SetInProgressCustomTabsResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SetInProgressCustomTabsResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public SetInProgressCustomTabsResponse setBody(SetInProgressCustomTabsResponseBody body) {
        this.body = body;
        return this;
    }
    public SetInProgressCustomTabsResponseBody getBody() {
        return this.body;
    }

}
