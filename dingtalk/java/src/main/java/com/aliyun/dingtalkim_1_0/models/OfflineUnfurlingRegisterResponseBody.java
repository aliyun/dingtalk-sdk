// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class OfflineUnfurlingRegisterResponseBody extends TeaModel {
    @NameInMap("success")
    public Boolean success;

    public static OfflineUnfurlingRegisterResponseBody build(java.util.Map<String, ?> map) throws Exception {
        OfflineUnfurlingRegisterResponseBody self = new OfflineUnfurlingRegisterResponseBody();
        return TeaModel.build(map, self);
    }

    public OfflineUnfurlingRegisterResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
