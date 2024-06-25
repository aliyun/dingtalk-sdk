// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkattendance_1_0.models;

import com.aliyun.tea.*;

public class BatchBossCheckResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>true</p>
     */
    @NameInMap("result")
    public Boolean result;

    public static BatchBossCheckResponseBody build(java.util.Map<String, ?> map) throws Exception {
        BatchBossCheckResponseBody self = new BatchBossCheckResponseBody();
        return TeaModel.build(map, self);
    }

    public BatchBossCheckResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
