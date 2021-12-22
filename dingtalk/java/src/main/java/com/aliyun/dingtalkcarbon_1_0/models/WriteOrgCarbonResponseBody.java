// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcarbon_1_0.models;

import com.aliyun.tea.*;

public class WriteOrgCarbonResponseBody extends TeaModel {
    // 请求是否成功
    @NameInMap("success")
    public Boolean success;

    // 请求成功返回的个数
    @NameInMap("result")
    public Integer result;

    public static WriteOrgCarbonResponseBody build(java.util.Map<String, ?> map) throws Exception {
        WriteOrgCarbonResponseBody self = new WriteOrgCarbonResponseBody();
        return TeaModel.build(map, self);
    }

    public WriteOrgCarbonResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public WriteOrgCarbonResponseBody setResult(Integer result) {
        this.result = result;
        return this;
    }
    public Integer getResult() {
        return this.result;
    }

}
