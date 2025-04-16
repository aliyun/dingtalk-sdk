// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class GetUserSignedRecordsByOuterIdRequest extends TeaModel {
    @NameInMap("body")
    public java.util.List<String> body;

    public static GetUserSignedRecordsByOuterIdRequest build(java.util.Map<String, ?> map) throws Exception {
        GetUserSignedRecordsByOuterIdRequest self = new GetUserSignedRecordsByOuterIdRequest();
        return TeaModel.build(map, self);
    }

    public GetUserSignedRecordsByOuterIdRequest setBody(java.util.List<String> body) {
        this.body = body;
        return this;
    }
    public java.util.List<String> getBody() {
        return this.body;
    }

}
