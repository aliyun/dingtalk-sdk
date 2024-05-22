// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class OpenInnerGroupTransferToDeptGroupResponseBody extends TeaModel {
    @NameInMap("success")
    public Boolean success;

    public static OpenInnerGroupTransferToDeptGroupResponseBody build(java.util.Map<String, ?> map) throws Exception {
        OpenInnerGroupTransferToDeptGroupResponseBody self = new OpenInnerGroupTransferToDeptGroupResponseBody();
        return TeaModel.build(map, self);
    }

    public OpenInnerGroupTransferToDeptGroupResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
