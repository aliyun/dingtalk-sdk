// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcalendar_1_0.models;

import com.aliyun.tea.*;

public class ListAiMinutesResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public ListAiMinutesResponseBody body;

    public static ListAiMinutesResponse build(java.util.Map<String, ?> map) throws Exception {
        ListAiMinutesResponse self = new ListAiMinutesResponse();
        return TeaModel.build(map, self);
    }

    public ListAiMinutesResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ListAiMinutesResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ListAiMinutesResponse setBody(ListAiMinutesResponseBody body) {
        this.body = body;
        return this;
    }
    public ListAiMinutesResponseBody getBody() {
        return this.body;
    }

}
