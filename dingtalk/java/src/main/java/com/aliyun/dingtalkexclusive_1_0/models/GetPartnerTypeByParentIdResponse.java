// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class GetPartnerTypeByParentIdResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetPartnerTypeByParentIdResponseBody body;

    public static GetPartnerTypeByParentIdResponse build(java.util.Map<String, ?> map) throws Exception {
        GetPartnerTypeByParentIdResponse self = new GetPartnerTypeByParentIdResponse();
        return TeaModel.build(map, self);
    }

    public GetPartnerTypeByParentIdResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetPartnerTypeByParentIdResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetPartnerTypeByParentIdResponse setBody(GetPartnerTypeByParentIdResponseBody body) {
        this.body = body;
        return this;
    }
    public GetPartnerTypeByParentIdResponseBody getBody() {
        return this.body;
    }

}
