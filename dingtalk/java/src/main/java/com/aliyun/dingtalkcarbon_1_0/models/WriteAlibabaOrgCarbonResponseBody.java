// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcarbon_1_0.models;

import com.aliyun.tea.*;

public class WriteAlibabaOrgCarbonResponseBody extends TeaModel {
    // 返回请求成功的数量
    @NameInMap("result")
    public Integer result;

    // 请求是否成功
    @NameInMap("success")
    public Boolean success;

    public static WriteAlibabaOrgCarbonResponseBody build(java.util.Map<String, ?> map) throws Exception {
        WriteAlibabaOrgCarbonResponseBody self = new WriteAlibabaOrgCarbonResponseBody();
        return TeaModel.build(map, self);
    }

    public WriteAlibabaOrgCarbonResponseBody setResult(Integer result) {
        this.result = result;
        return this;
    }
    public Integer getResult() {
        return this.result;
    }

    public WriteAlibabaOrgCarbonResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
