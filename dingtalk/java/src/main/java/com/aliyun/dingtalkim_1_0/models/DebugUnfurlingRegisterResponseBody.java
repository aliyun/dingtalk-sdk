// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class DebugUnfurlingRegisterResponseBody extends TeaModel {
    @NameInMap("success")
    public Boolean success;

    public static DebugUnfurlingRegisterResponseBody build(java.util.Map<String, ?> map) throws Exception {
        DebugUnfurlingRegisterResponseBody self = new DebugUnfurlingRegisterResponseBody();
        return TeaModel.build(map, self);
    }

    public DebugUnfurlingRegisterResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
