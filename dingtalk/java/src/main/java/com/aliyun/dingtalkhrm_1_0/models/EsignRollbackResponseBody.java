// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class EsignRollbackResponseBody extends TeaModel {
    @NameInMap("result")
    public Boolean result;

    public static EsignRollbackResponseBody build(java.util.Map<String, ?> map) throws Exception {
        EsignRollbackResponseBody self = new EsignRollbackResponseBody();
        return TeaModel.build(map, self);
    }

    public EsignRollbackResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
