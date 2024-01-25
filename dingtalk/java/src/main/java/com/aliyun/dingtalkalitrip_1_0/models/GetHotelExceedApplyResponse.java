// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkalitrip_1_0.models;

import com.aliyun.tea.*;

public class GetHotelExceedApplyResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetHotelExceedApplyResponseBody body;

    public static GetHotelExceedApplyResponse build(java.util.Map<String, ?> map) throws Exception {
        GetHotelExceedApplyResponse self = new GetHotelExceedApplyResponse();
        return TeaModel.build(map, self);
    }

    public GetHotelExceedApplyResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetHotelExceedApplyResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetHotelExceedApplyResponse setBody(GetHotelExceedApplyResponseBody body) {
        this.body = body;
        return this;
    }
    public GetHotelExceedApplyResponseBody getBody() {
        return this.body;
    }

}
