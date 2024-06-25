// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkresident_1_0.models;

import com.aliyun.tea.*;

public class UpdateResideceGroupResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>true</p>
     */
    @NameInMap("result")
    public Boolean result;

    public static UpdateResideceGroupResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdateResideceGroupResponseBody self = new UpdateResideceGroupResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdateResideceGroupResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
