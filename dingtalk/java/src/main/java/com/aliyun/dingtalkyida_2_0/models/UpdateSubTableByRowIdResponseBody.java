// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_2_0.models;

import com.aliyun.tea.*;

public class UpdateSubTableByRowIdResponseBody extends TeaModel {
    @NameInMap("result")
    public Boolean result;

    public static UpdateSubTableByRowIdResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdateSubTableByRowIdResponseBody self = new UpdateSubTableByRowIdResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdateSubTableByRowIdResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
