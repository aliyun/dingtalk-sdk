// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdvi_1_0.models;

import com.aliyun.tea.*;

public class ListA1DeviceResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public ListA1DeviceResponseBody body;

    public static ListA1DeviceResponse build(java.util.Map<String, ?> map) throws Exception {
        ListA1DeviceResponse self = new ListA1DeviceResponse();
        return TeaModel.build(map, self);
    }

    public ListA1DeviceResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ListA1DeviceResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ListA1DeviceResponse setBody(ListA1DeviceResponseBody body) {
        this.body = body;
        return this;
    }
    public ListA1DeviceResponseBody getBody() {
        return this.body;
    }

}
