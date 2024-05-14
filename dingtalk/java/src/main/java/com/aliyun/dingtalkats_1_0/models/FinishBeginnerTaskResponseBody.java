// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkats_1_0.models;

import com.aliyun.tea.*;

public class FinishBeginnerTaskResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("result")
    public Boolean result;

    public static FinishBeginnerTaskResponseBody build(java.util.Map<String, ?> map) throws Exception {
        FinishBeginnerTaskResponseBody self = new FinishBeginnerTaskResponseBody();
        return TeaModel.build(map, self);
    }

    public FinishBeginnerTaskResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
