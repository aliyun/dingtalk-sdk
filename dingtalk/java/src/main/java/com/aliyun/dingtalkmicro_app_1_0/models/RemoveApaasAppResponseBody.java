// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmicro_app_1_0.models;

import com.aliyun.tea.*;

public class RemoveApaasAppResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("result")
    public Boolean result;

    public static RemoveApaasAppResponseBody build(java.util.Map<String, ?> map) throws Exception {
        RemoveApaasAppResponseBody self = new RemoveApaasAppResponseBody();
        return TeaModel.build(map, self);
    }

    public RemoveApaasAppResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
