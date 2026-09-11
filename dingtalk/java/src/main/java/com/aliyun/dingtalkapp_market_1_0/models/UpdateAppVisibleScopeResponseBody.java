// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkapp_market_1_0.models;

import com.aliyun.tea.*;

public class UpdateAppVisibleScopeResponseBody extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>true</p>
     */
    @NameInMap("result")
    public Boolean result;

    public static UpdateAppVisibleScopeResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdateAppVisibleScopeResponseBody self = new UpdateAppVisibleScopeResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdateAppVisibleScopeResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
