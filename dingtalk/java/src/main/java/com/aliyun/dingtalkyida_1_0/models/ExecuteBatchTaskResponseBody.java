// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class ExecuteBatchTaskResponseBody extends TeaModel {
    @NameInMap("failNumber")
    public Integer failNumber;

    @NameInMap("successNumber")
    public Integer successNumber;

    @NameInMap("total")
    public Integer total;

    public static ExecuteBatchTaskResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ExecuteBatchTaskResponseBody self = new ExecuteBatchTaskResponseBody();
        return TeaModel.build(map, self);
    }

    public ExecuteBatchTaskResponseBody setFailNumber(Integer failNumber) {
        this.failNumber = failNumber;
        return this;
    }
    public Integer getFailNumber() {
        return this.failNumber;
    }

    public ExecuteBatchTaskResponseBody setSuccessNumber(Integer successNumber) {
        this.successNumber = successNumber;
        return this;
    }
    public Integer getSuccessNumber() {
        return this.successNumber;
    }

    public ExecuteBatchTaskResponseBody setTotal(Integer total) {
        this.total = total;
        return this;
    }
    public Integer getTotal() {
        return this.total;
    }

}
