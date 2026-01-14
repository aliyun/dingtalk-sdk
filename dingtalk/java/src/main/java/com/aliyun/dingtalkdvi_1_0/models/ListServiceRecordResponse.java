// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdvi_1_0.models;

import com.aliyun.tea.*;

public class ListServiceRecordResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public ListServiceRecordResponseBody body;

    public static ListServiceRecordResponse build(java.util.Map<String, ?> map) throws Exception {
        ListServiceRecordResponse self = new ListServiceRecordResponse();
        return TeaModel.build(map, self);
    }

    public ListServiceRecordResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ListServiceRecordResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ListServiceRecordResponse setBody(ListServiceRecordResponseBody body) {
        this.body = body;
        return this;
    }
    public ListServiceRecordResponseBody getBody() {
        return this.body;
    }

}
