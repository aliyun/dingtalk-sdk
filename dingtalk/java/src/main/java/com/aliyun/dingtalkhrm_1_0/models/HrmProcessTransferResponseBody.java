// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class HrmProcessTransferResponseBody extends TeaModel {
    @NameInMap("result")
    public Boolean result;

    public static HrmProcessTransferResponseBody build(java.util.Map<String, ?> map) throws Exception {
        HrmProcessTransferResponseBody self = new HrmProcessTransferResponseBody();
        return TeaModel.build(map, self);
    }

    public HrmProcessTransferResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
