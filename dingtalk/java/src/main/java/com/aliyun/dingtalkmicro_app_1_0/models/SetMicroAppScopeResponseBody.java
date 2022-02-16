// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmicro_app_1_0.models;

import com.aliyun.tea.*;

public class SetMicroAppScopeResponseBody extends TeaModel {
    // 结果
    @NameInMap("result")
    public Boolean result;

    public static SetMicroAppScopeResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SetMicroAppScopeResponseBody self = new SetMicroAppScopeResponseBody();
        return TeaModel.build(map, self);
    }

    public SetMicroAppScopeResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
