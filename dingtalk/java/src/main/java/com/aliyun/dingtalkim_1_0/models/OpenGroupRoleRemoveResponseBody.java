// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class OpenGroupRoleRemoveResponseBody extends TeaModel {
    @NameInMap("result")
    public Boolean result;

    @NameInMap("success")
    public Boolean success;

    public static OpenGroupRoleRemoveResponseBody build(java.util.Map<String, ?> map) throws Exception {
        OpenGroupRoleRemoveResponseBody self = new OpenGroupRoleRemoveResponseBody();
        return TeaModel.build(map, self);
    }

    public OpenGroupRoleRemoveResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

    public OpenGroupRoleRemoveResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
