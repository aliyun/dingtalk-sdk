// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class OpenGroupRoleUpdateResponseBody extends TeaModel {
    @NameInMap("result")
    public Boolean result;

    @NameInMap("success")
    public Boolean success;

    public static OpenGroupRoleUpdateResponseBody build(java.util.Map<String, ?> map) throws Exception {
        OpenGroupRoleUpdateResponseBody self = new OpenGroupRoleUpdateResponseBody();
        return TeaModel.build(map, self);
    }

    public OpenGroupRoleUpdateResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

    public OpenGroupRoleUpdateResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
