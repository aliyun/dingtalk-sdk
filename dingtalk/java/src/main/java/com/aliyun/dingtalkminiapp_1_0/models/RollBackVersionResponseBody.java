// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkminiapp_1_0.models;

import com.aliyun.tea.*;

public class RollBackVersionResponseBody extends TeaModel {
    /**
     * <p>Id of the request</p>
     */
    @NameInMap("result")
    public String result;

    public static RollBackVersionResponseBody build(java.util.Map<String, ?> map) throws Exception {
        RollBackVersionResponseBody self = new RollBackVersionResponseBody();
        return TeaModel.build(map, self);
    }

    public RollBackVersionResponseBody setResult(String result) {
        this.result = result;
        return this;
    }
    public String getResult() {
        return this.result;
    }

}
