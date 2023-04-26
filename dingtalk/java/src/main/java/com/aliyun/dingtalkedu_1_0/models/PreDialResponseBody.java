// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class PreDialResponseBody extends TeaModel {
    @NameInMap("result")
    public Boolean result;

    public static PreDialResponseBody build(java.util.Map<String, ?> map) throws Exception {
        PreDialResponseBody self = new PreDialResponseBody();
        return TeaModel.build(map, self);
    }

    public PreDialResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
