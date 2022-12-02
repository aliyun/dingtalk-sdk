// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class GetFamilySchoolConversationsResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
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

    public GetFamilySchoolConversationsResponse setBody(GetFamilySchoolConversationsResponseBody body) {
        this.body = body;
        return this;
    }
    public GetFamilySchoolConversationsResponseBody getBody() {
        return this.body;
    }

}
