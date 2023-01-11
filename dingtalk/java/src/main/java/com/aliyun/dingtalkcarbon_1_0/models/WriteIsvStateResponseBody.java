// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcarbon_1_0.models;

import com.aliyun.tea.*;

public class WriteIsvStateResponseBody extends TeaModel {
    /**
     * <p>数据写入标识</p>
     */
    @NameInMap("result")
    public Long result;

    public static WriteIsvStateResponseBody build(java.util.Map<String, ?> map) throws Exception {
        WriteIsvStateResponseBody self = new WriteIsvStateResponseBody();
        return TeaModel.build(map, self);
    }

    public WriteIsvStateResponseBody setResult(Long result) {
        this.result = result;
        return this;
    }
    public Long getResult() {
        return this.result;
    }

}
