// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcarbon_1_0.models;

import com.aliyun.tea.*;

public class WriteUserCarbonResponseBody extends TeaModel {
    @NameInMap("result")
    public Integer result;

    @NameInMap("success")
    public Boolean success;

    public static WriteUserCarbonResponseBody build(java.util.Map<String, ?> map) throws Exception {
        WriteUserCarbonResponseBody self = new WriteUserCarbonResponseBody();
        return TeaModel.build(map, self);
    }

    public WriteUserCarbonResponseBody setResult(Integer result) {
        this.result = result;
        return this;
    }
    public Integer getResult() {
        return this.result;
    }

    public WriteUserCarbonResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
