// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkchengfeng_1_0.models;

import com.aliyun.tea.*;

public class ListObjectiveByIdsResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public ListObjectiveByIdsResponseBody body;

    public static ListObjectiveByIdsResponse build(java.util.Map<String, ?> map) throws Exception {
        ListObjectiveByIdsResponse self = new ListObjectiveByIdsResponse();
        return TeaModel.build(map, self);
    }

    public ListObjectiveByIdsResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ListObjectiveByIdsResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ListObjectiveByIdsResponse setBody(ListObjectiveByIdsResponseBody body) {
        this.body = body;
        return this;
    }
    public ListObjectiveByIdsResponseBody getBody() {
        return this.body;
    }

}
