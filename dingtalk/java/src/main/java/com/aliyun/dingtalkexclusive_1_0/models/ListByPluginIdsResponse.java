// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class ListByPluginIdsResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public ListByPluginIdsResponseBody body;

    public static ListByPluginIdsResponse build(java.util.Map<String, ?> map) throws Exception {
        ListByPluginIdsResponse self = new ListByPluginIdsResponse();
        return TeaModel.build(map, self);
    }

    public ListByPluginIdsResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ListByPluginIdsResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ListByPluginIdsResponse setBody(ListByPluginIdsResponseBody body) {
        this.body = body;
        return this;
    }
    public ListByPluginIdsResponseBody getBody() {
        return this.body;
    }

}
