// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class ListProcessInstanceIdsResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public ListProcessInstanceIdsResponseBody body;

    public static ListProcessInstanceIdsResponse build(java.util.Map<String, ?> map) throws Exception {
        ListProcessInstanceIdsResponse self = new ListProcessInstanceIdsResponse();
        return TeaModel.build(map, self);
    }

    public ListProcessInstanceIdsResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ListProcessInstanceIdsResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ListProcessInstanceIdsResponse setBody(ListProcessInstanceIdsResponseBody body) {
        this.body = body;
        return this;
    }
    public ListProcessInstanceIdsResponseBody getBody() {
        return this.body;
    }

}
