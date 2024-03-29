// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class GetFamilySchoolConversationsResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetFamilySchoolConversationsResponseBody body;

    public static GetFamilySchoolConversationsResponse build(java.util.Map<String, ?> map) throws Exception {
        GetFamilySchoolConversationsResponse self = new GetFamilySchoolConversationsResponse();
        return TeaModel.build(map, self);
    }

    public GetFamilySchoolConversationsResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetFamilySchoolConversationsResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetFamilySchoolConversationsResponse setBody(GetFamilySchoolConversationsResponseBody body) {
        this.body = body;
        return this;
    }
    public GetFamilySchoolConversationsResponseBody getBody() {
        return this.body;
    }

}
