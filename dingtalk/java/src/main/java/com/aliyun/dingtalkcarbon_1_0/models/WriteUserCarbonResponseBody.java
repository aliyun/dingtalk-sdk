// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcarbon_1_0.models;

import com.aliyun.tea.*;

public class WriteUserCarbonResponseBody extends TeaModel {
    // 请求是否写入成功
    @NameInMap("success")
    public Boolean success;

    // 返回请求成功个数
    @NameInMap("result")
    public Integer result;

    public static WriteUserCarbonResponseBody build(java.util.Map<String, ?> map) throws Exception {
        WriteUserCarbonResponseBody self = new WriteUserCarbonResponseBody();
        return TeaModel.build(map, self);
    }

    public WriteUserCarbonResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public WriteUserCarbonResponseBody setResult(Integer result) {
        this.result = result;
        return this;
    }
    public Integer getResult() {
        return this.result;
    }

}
