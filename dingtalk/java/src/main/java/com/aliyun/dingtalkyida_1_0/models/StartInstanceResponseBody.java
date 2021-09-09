// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class StartInstanceResponseBody extends TeaModel {
    // 流程实例ID
    @NameInMap("result")
    public String result;

    public static StartInstanceResponseBody build(java.util.Map<String, ?> map) throws Exception {
        StartInstanceResponseBody self = new StartInstanceResponseBody();
        return TeaModel.build(map, self);
    }

    public StartInstanceResponseBody setResult(String result) {
        this.result = result;
        return this;
    }
    public String getResult() {
        return this.result;
    }

}
