// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class ExecuteCustomApiResponseBody extends TeaModel {
    @NameInMap("result")
    public String result;

    public static ExecuteCustomApiResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ExecuteCustomApiResponseBody self = new ExecuteCustomApiResponseBody();
        return TeaModel.build(map, self);
    }

    public ExecuteCustomApiResponseBody setResult(String result) {
        this.result = result;
        return this;
    }
    public String getResult() {
        return this.result;
    }

}
