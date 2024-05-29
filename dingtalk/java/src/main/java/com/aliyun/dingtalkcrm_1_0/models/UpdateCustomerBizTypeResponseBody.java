// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class UpdateCustomerBizTypeResponseBody extends TeaModel {
    @NameInMap("result")
    public Boolean result;

    public static UpdateCustomerBizTypeResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdateCustomerBizTypeResponseBody self = new UpdateCustomerBizTypeResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdateCustomerBizTypeResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
