// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalksmart_device_1_0.models;

import com.aliyun.tea.*;

public class QueryDeviceVideoConferenceBookResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public QueryDeviceVideoConferenceBookResponseBody body;

    public static QueryDeviceVideoConferenceBookResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryDeviceVideoConferenceBookResponse self = new QueryDeviceVideoConferenceBookResponse();
        return TeaModel.build(map, self);
    }

    public QueryDeviceVideoConferenceBookResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryDeviceVideoConferenceBookResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryDeviceVideoConferenceBookResponse setBody(QueryDeviceVideoConferenceBookResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryDeviceVideoConferenceBookResponseBody getBody() {
        return this.body;
    }

}
