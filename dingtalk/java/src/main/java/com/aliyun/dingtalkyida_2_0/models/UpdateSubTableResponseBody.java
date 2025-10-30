// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_2_0.models;

import com.aliyun.tea.*;

public class UpdateSubTableResponseBody extends TeaModel {
    @NameInMap("result")
    public Boolean result;

    public static UpdateSubTableResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdateSubTableResponseBody self = new UpdateSubTableResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdateSubTableResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
