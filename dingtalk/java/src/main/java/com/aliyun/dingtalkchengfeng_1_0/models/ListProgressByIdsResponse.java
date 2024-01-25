// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkchengfeng_1_0.models;

import com.aliyun.tea.*;

public class ListProgressByIdsResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public ListProgressByIdsResponseBody body;

    public static ListProgressByIdsResponse build(java.util.Map<String, ?> map) throws Exception {
        ListProgressByIdsResponse self = new ListProgressByIdsResponse();
        return TeaModel.build(map, self);
    }

    public ListProgressByIdsResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ListProgressByIdsResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ListProgressByIdsResponse setBody(ListProgressByIdsResponseBody body) {
        this.body = body;
        return this;
    }
    public ListProgressByIdsResponseBody getBody() {
        return this.body;
    }

}
