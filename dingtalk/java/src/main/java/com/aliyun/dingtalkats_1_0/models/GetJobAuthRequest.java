// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkats_1_0.models;

import com.aliyun.tea.*;

public class GetJobAuthRequest extends TeaModel {
    @NameInMap("opUserId")
    public String opUserId;

    public static GetJobAuthRequest build(java.util.Map<String, ?> map) throws Exception {
        GetJobAuthRequest self = new GetJobAuthRequest();
        return TeaModel.build(map, self);
    }

    public GetJobAuthRequest setOpUserId(String opUserId) {
        this.opUserId = opUserId;
        return this;
    }
    public String getOpUserId() {
        return this.opUserId;
    }

}
