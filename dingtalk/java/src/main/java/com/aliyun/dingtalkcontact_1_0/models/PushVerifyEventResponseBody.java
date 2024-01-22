// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class PushVerifyEventResponseBody extends TeaModel {
    @NameInMap("verifyId")
    public String verifyId;

    public static PushVerifyEventResponseBody build(java.util.Map<String, ?> map) throws Exception {
        PushVerifyEventResponseBody self = new PushVerifyEventResponseBody();
        return TeaModel.build(map, self);
    }

    public PushVerifyEventResponseBody setVerifyId(String verifyId) {
        this.verifyId = verifyId;
        return this;
    }
    public String getVerifyId() {
        return this.verifyId;
    }

}
