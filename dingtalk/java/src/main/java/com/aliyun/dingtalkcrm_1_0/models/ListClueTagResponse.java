// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class ListClueTagResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public ListClueTagResponseBody body;

    public static ListClueTagResponse build(java.util.Map<String, ?> map) throws Exception {
        ListClueTagResponse self = new ListClueTagResponse();
        return TeaModel.build(map, self);
    }

    public ListClueTagResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ListClueTagResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ListClueTagResponse setBody(ListClueTagResponseBody body) {
        this.body = body;
        return this;
    }
    public ListClueTagResponseBody getBody() {
        return this.body;
    }

}
