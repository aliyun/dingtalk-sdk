// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcalendar_1_0.models;

import com.aliyun.tea.*;

public class TransferEventResponseBody extends TeaModel {
    @NameInMap("result")
    public Boolean result;

    public static TransferEventResponseBody build(java.util.Map<String, ?> map) throws Exception {
        TransferEventResponseBody self = new TransferEventResponseBody();
        return TeaModel.build(map, self);
    }

    public TransferEventResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
