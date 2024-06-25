// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkai_paa_s_1_0.models;

import com.aliyun.tea.*;

public class LiandanluExclusiveModelResponseBody extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>requestId_123</p>
     */
    @NameInMap("requestId")
    public String requestId;

    /**
     * <strong>example:</strong>
     * <p>{        &quot;content&quot;:&quot;OKR 全称为 Objective and Key Results，即目标与关键结果法，是一套明确和跟踪目标及其完成情况的管理工具和方法。&quot;   }</p>
     */
    @NameInMap("result")
    public java.util.Map<String, ?> result;

    public static LiandanluExclusiveModelResponseBody build(java.util.Map<String, ?> map) throws Exception {
        LiandanluExclusiveModelResponseBody self = new LiandanluExclusiveModelResponseBody();
        return TeaModel.build(map, self);
    }

    public LiandanluExclusiveModelResponseBody setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public LiandanluExclusiveModelResponseBody setResult(java.util.Map<String, ?> result) {
        this.result = result;
        return this;
    }
    public java.util.Map<String, ?> getResult() {
        return this.result;
    }

}
