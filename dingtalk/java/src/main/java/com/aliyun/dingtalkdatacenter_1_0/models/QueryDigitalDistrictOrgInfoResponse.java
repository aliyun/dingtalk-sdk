// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryDigitalDistrictOrgInfoResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public QueryDigitalDistrictOrgInfoResponseBody body;

    public static QueryDigitalDistrictOrgInfoResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryDigitalDistrictOrgInfoResponse self = new QueryDigitalDistrictOrgInfoResponse();
        return TeaModel.build(map, self);
    }

    public QueryDigitalDistrictOrgInfoResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryDigitalDistrictOrgInfoResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryDigitalDistrictOrgInfoResponse setBody(QueryDigitalDistrictOrgInfoResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryDigitalDistrictOrgInfoResponseBody getBody() {
        return this.body;
    }

}
