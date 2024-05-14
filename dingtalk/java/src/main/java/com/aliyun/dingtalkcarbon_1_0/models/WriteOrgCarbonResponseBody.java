// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcarbon_1_0.models;

import com.aliyun.tea.*;

public class WriteOrgCarbonResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("result")
    public Integer result;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("success")
    public Boolean success;

    public static WriteOrgCarbonResponseBody build(java.util.Map<String, ?> map) throws Exception {
        WriteOrgCarbonResponseBody self = new WriteOrgCarbonResponseBody();
        return TeaModel.build(map, self);
    }

    public WriteOrgCarbonResponseBody setResult(Integer result) {
        this.result = result;
        return this;
    }
    public Integer getResult() {
        return this.result;
    }

    public WriteOrgCarbonResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
