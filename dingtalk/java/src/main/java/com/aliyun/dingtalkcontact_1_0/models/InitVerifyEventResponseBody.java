// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class InitVerifyEventResponseBody extends TeaModel {
    @NameInMap("verifyId")
    public String verifyId;

    public static InitVerifyEventResponseBody build(java.util.Map<String, ?> map) throws Exception {
        InitVerifyEventResponseBody self = new InitVerifyEventResponseBody();
        return TeaModel.build(map, self);
    }

    public InitVerifyEventResponseBody setVerifyId(String verifyId) {
        this.verifyId = verifyId;
        return this;
    }
    public String getVerifyId() {
        return this.verifyId;
    }

}
