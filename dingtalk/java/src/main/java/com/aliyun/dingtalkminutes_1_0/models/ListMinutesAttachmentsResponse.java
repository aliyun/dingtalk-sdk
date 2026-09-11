// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkminutes_1_0.models;

import com.aliyun.tea.*;

public class ListMinutesAttachmentsResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public ListMinutesAttachmentsResponseBody body;

    public static ListMinutesAttachmentsResponse build(java.util.Map<String, ?> map) throws Exception {
        ListMinutesAttachmentsResponse self = new ListMinutesAttachmentsResponse();
        return TeaModel.build(map, self);
    }

    public ListMinutesAttachmentsResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ListMinutesAttachmentsResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ListMinutesAttachmentsResponse setBody(ListMinutesAttachmentsResponseBody body) {
        this.body = body;
        return this;
    }
    public ListMinutesAttachmentsResponseBody getBody() {
        return this.body;
    }

}
