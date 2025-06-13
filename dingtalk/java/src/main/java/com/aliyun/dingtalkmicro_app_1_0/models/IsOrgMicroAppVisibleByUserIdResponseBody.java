// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmicro_app_1_0.models;

import com.aliyun.tea.*;

public class IsOrgMicroAppVisibleByUserIdResponseBody extends TeaModel {
    @NameInMap("result")
    public Boolean result;

    public static IsOrgMicroAppVisibleByUserIdResponseBody build(java.util.Map<String, ?> map) throws Exception {
        IsOrgMicroAppVisibleByUserIdResponseBody self = new IsOrgMicroAppVisibleByUserIdResponseBody();
        return TeaModel.build(map, self);
    }

    public IsOrgMicroAppVisibleByUserIdResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
