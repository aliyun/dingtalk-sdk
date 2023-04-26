// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class ListMiniAppHistoryVersionResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public ListMiniAppHistoryVersionResponseBody body;

    public static ListMiniAppHistoryVersionResponse build(java.util.Map<String, ?> map) throws Exception {
        ListMiniAppHistoryVersionResponse self = new ListMiniAppHistoryVersionResponse();
        return TeaModel.build(map, self);
    }

    public ListMiniAppHistoryVersionResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ListMiniAppHistoryVersionResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ListMiniAppHistoryVersionResponse setBody(ListMiniAppHistoryVersionResponseBody body) {
        this.body = body;
        return this;
    }
    public ListMiniAppHistoryVersionResponseBody getBody() {
        return this.body;
    }

}
