// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcalendar_1_0.models;

import com.aliyun.tea.*;

public class GetScheduleByMeResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetScheduleByMeResponseBody body;

    public static GetScheduleByMeResponse build(java.util.Map<String, ?> map) throws Exception {
        GetScheduleByMeResponse self = new GetScheduleByMeResponse();
        return TeaModel.build(map, self);
    }

    public GetScheduleByMeResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetScheduleByMeResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetScheduleByMeResponse setBody(GetScheduleByMeResponseBody body) {
        this.body = body;
        return this;
    }
    public GetScheduleByMeResponseBody getBody() {
        return this.body;
    }

}
