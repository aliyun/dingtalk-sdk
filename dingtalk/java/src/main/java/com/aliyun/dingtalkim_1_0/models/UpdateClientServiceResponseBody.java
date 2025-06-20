// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class UpdateClientServiceResponseBody extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>true</p>
     */
    @NameInMap("result")
    public Boolean result;

    public static UpdateClientServiceResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdateClientServiceResponseBody self = new UpdateClientServiceResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdateClientServiceResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
