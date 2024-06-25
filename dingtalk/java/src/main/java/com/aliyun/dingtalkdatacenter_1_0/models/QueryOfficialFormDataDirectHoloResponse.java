// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryOfficialFormDataDirectHoloResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryOfficialFormDataDirectHoloResponseBody body;

    public static QueryOfficialFormDataDirectHoloResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryOfficialFormDataDirectHoloResponse self = new QueryOfficialFormDataDirectHoloResponse();
        return TeaModel.build(map, self);
    }

    public QueryOfficialFormDataDirectHoloResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryOfficialFormDataDirectHoloResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryOfficialFormDataDirectHoloResponse setBody(QueryOfficialFormDataDirectHoloResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryOfficialFormDataDirectHoloResponseBody getBody() {
        return this.body;
    }

}
