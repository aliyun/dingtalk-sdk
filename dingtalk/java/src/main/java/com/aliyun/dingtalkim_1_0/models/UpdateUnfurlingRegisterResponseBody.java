// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class UpdateUnfurlingRegisterResponseBody extends TeaModel {
    @NameInMap("success")
    public Boolean success;

    public static UpdateUnfurlingRegisterResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdateUnfurlingRegisterResponseBody self = new UpdateUnfurlingRegisterResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdateUnfurlingRegisterResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
