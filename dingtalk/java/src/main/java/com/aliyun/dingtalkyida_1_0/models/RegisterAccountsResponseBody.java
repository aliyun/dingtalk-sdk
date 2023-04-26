// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class RegisterAccountsResponseBody extends TeaModel {
    @NameInMap("instanceId")
    public String instanceId;

    public static RegisterAccountsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        RegisterAccountsResponseBody self = new RegisterAccountsResponseBody();
        return TeaModel.build(map, self);
    }

    public RegisterAccountsResponseBody setInstanceId(String instanceId) {
        this.instanceId = instanceId;
        return this;
    }
    public String getInstanceId() {
        return this.instanceId;
    }

}
