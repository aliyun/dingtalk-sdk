// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class FreezeGroupResponseBody extends TeaModel {
    @NameInMap("success")
    public Boolean success;

    public static FreezeGroupResponseBody build(java.util.Map<String, ?> map) throws Exception {
        FreezeGroupResponseBody self = new FreezeGroupResponseBody();
        return TeaModel.build(map, self);
    }

    public FreezeGroupResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
