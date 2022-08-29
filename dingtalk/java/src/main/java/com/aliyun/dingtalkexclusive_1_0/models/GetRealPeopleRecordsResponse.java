// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class GetRealPeopleRecordsResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public GetRealPeopleRecordsResponseBody body;

    public static GetRealPeopleRecordsResponse build(java.util.Map<String, ?> map) throws Exception {
        GetRealPeopleRecordsResponse self = new GetRealPeopleRecordsResponse();
        return TeaModel.build(map, self);
    }

    public GetRealPeopleRecordsResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetRealPeopleRecordsResponse setBody(GetRealPeopleRecordsResponseBody body) {
        this.body = body;
        return this;
    }
    public GetRealPeopleRecordsResponseBody getBody() {
        return this.body;
    }

}
