// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcarbon_1_0.models;

import com.aliyun.tea.*;

public class WriteUserCarbonEnergyResponseBody extends TeaModel {
    /**
     * <p>返回结果</p>
     */
    @NameInMap("result")
    public Integer result;

    /**
     * <p>输出状态</p>
     */
    @NameInMap("success")
    public Boolean success;

    public static WriteUserCarbonEnergyResponseBody build(java.util.Map<String, ?> map) throws Exception {
        WriteUserCarbonEnergyResponseBody self = new WriteUserCarbonEnergyResponseBody();
        return TeaModel.build(map, self);
    }

    public WriteUserCarbonEnergyResponseBody setResult(Integer result) {
        this.result = result;
        return this;
    }
    public Integer getResult() {
        return this.result;
    }

    public WriteUserCarbonEnergyResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
