// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkminiapp_1_0.models;

import com.aliyun.tea.*;

public class GetMaxVersionResponseBody extends TeaModel {
    /**
     * <p>result</p>
     */
    @NameInMap("result")
    public String result;

    public static GetMaxVersionResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetMaxVersionResponseBody self = new GetMaxVersionResponseBody();
        return TeaModel.build(map, self);
    }

    public GetMaxVersionResponseBody setResult(String result) {
        this.result = result;
        return this;
    }
    public String getResult() {
        return this.result;
    }

}
