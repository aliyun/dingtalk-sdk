// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktrip_1_0.models;

import com.aliyun.tea.*;

public class TripPlatformUnifiedEntryResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public TripPlatformUnifiedEntryResponseBody body;

    public static TripPlatformUnifiedEntryResponse build(java.util.Map<String, ?> map) throws Exception {
        TripPlatformUnifiedEntryResponse self = new TripPlatformUnifiedEntryResponse();
        return TeaModel.build(map, self);
    }

    public TripPlatformUnifiedEntryResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public TripPlatformUnifiedEntryResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public TripPlatformUnifiedEntryResponse setBody(TripPlatformUnifiedEntryResponseBody body) {
        this.body = body;
        return this;
    }
    public TripPlatformUnifiedEntryResponseBody getBody() {
        return this.body;
    }

}
