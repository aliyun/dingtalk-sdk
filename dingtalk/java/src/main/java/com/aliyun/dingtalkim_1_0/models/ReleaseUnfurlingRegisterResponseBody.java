// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class ReleaseUnfurlingRegisterResponseBody extends TeaModel {
    @NameInMap("success")
    public Boolean success;

    public static ReleaseUnfurlingRegisterResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ReleaseUnfurlingRegisterResponseBody self = new ReleaseUnfurlingRegisterResponseBody();
        return TeaModel.build(map, self);
    }

    public ReleaseUnfurlingRegisterResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
