// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class UpdateUnfurlingRegisterStatusResponseBody extends TeaModel {
    @NameInMap("success")
    public Boolean success;

    public static UpdateUnfurlingRegisterStatusResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdateUnfurlingRegisterStatusResponseBody self = new UpdateUnfurlingRegisterStatusResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdateUnfurlingRegisterStatusResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
