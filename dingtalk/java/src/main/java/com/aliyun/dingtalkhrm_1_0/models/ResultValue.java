// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class ResultValue extends TeaModel {
    @NameInMap("status")
    public String status;

    public static ResultValue build(java.util.Map<String, ?> map) throws Exception {
        ResultValue self = new ResultValue();
        return TeaModel.build(map, self);
    }

    public ResultValue setStatus(String status) {
        this.status = status;
        return this;
    }
    public String getStatus() {
        return this.status;
    }

}
