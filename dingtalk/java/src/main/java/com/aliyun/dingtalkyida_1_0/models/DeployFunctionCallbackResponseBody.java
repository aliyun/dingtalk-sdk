// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class DeployFunctionCallbackResponseBody extends TeaModel {
    /**
     * <p>是否处理成功</p>
     */
    @NameInMap("result")
    public Boolean result;

    public static DeployFunctionCallbackResponseBody build(java.util.Map<String, ?> map) throws Exception {
        DeployFunctionCallbackResponseBody self = new DeployFunctionCallbackResponseBody();
        return TeaModel.build(map, self);
    }

    public DeployFunctionCallbackResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
