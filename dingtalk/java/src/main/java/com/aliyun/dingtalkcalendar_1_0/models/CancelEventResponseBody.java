// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcalendar_1_0.models;

import com.aliyun.tea.*;

public class CancelEventResponseBody extends TeaModel {
    @NameInMap("result")
    public Boolean result;

    public static CancelEventResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CancelEventResponseBody self = new CancelEventResponseBody();
        return TeaModel.build(map, self);
    }

    public CancelEventResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
