// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkbench_1_0.models;

import com.aliyun.tea.*;

public class UndoDeletionResponseBody extends TeaModel {
    @NameInMap("result")
    public Boolean result;

    public static UndoDeletionResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UndoDeletionResponseBody self = new UndoDeletionResponseBody();
        return TeaModel.build(map, self);
    }

    public UndoDeletionResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
