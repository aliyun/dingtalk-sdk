// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_2_0.models;

import com.aliyun.tea.*;

public class UpdateAuxiliaryStatusResponseBody extends TeaModel {
    @NameInMap("result")
    public Boolean result;

    public static UpdateAuxiliaryStatusResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdateAuxiliaryStatusResponseBody self = new UpdateAuxiliaryStatusResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdateAuxiliaryStatusResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
