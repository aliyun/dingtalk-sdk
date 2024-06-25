// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmicro_app_1_0.models;

import com.aliyun.tea.*;

public class UpdateInnerAppResponseBody extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>true</p>
     */
    @NameInMap("result")
    public Boolean result;

    public static UpdateInnerAppResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdateInnerAppResponseBody self = new UpdateInnerAppResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdateInnerAppResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
