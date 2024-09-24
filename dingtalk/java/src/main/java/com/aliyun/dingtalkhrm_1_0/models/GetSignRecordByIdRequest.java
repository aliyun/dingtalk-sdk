// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class GetSignRecordByIdRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("body")
    public java.util.List<String> body;

    public static GetSignRecordByIdRequest build(java.util.Map<String, ?> map) throws Exception {
        GetSignRecordByIdRequest self = new GetSignRecordByIdRequest();
        return TeaModel.build(map, self);
    }

    public GetSignRecordByIdRequest setBody(java.util.List<String> body) {
        this.body = body;
        return this;
    }
    public java.util.List<String> getBody() {
        return this.body;
    }

}
