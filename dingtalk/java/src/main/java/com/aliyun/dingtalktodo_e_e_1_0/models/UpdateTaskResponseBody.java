// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktodo_e_e_1_0.models;

import com.aliyun.tea.*;

public class UpdateTaskResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>true</p>
     */
    @NameInMap("result")
    public Boolean result;

    public static UpdateTaskResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdateTaskResponseBody self = new UpdateTaskResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdateTaskResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
