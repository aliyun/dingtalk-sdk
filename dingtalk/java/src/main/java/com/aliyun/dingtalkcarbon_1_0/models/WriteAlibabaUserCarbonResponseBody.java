// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcarbon_1_0.models;

import com.aliyun.tea.*;

public class WriteAlibabaUserCarbonResponseBody extends TeaModel {
    // 返回请求成功个数
    @NameInMap("result")
    public Integer result;

    // 请求是否写入成功
    @NameInMap("success")
    public Boolean success;

    public static WriteAlibabaUserCarbonResponseBody build(java.util.Map<String, ?> map) throws Exception {
        WriteAlibabaUserCarbonResponseBody self = new WriteAlibabaUserCarbonResponseBody();
        return TeaModel.build(map, self);
    }

    public WriteAlibabaUserCarbonResponseBody setResult(Integer result) {
        this.result = result;
        return this;
    }
    public Integer getResult() {
        return this.result;
    }

    public WriteAlibabaUserCarbonResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
