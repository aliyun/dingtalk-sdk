// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class CreateTrustedDeviceBatchResponseBody extends TeaModel {
    // 处理结果
    @NameInMap("result")
    public Boolean result;

    public static CreateTrustedDeviceBatchResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CreateTrustedDeviceBatchResponseBody self = new CreateTrustedDeviceBatchResponseBody();
        return TeaModel.build(map, self);
    }

    public CreateTrustedDeviceBatchResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
