// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class PutMsgCardTopByIntelligentResponseBody extends TeaModel {
    @NameInMap("success")
    public String success;

    public static PutMsgCardTopByIntelligentResponseBody build(java.util.Map<String, ?> map) throws Exception {
        PutMsgCardTopByIntelligentResponseBody self = new PutMsgCardTopByIntelligentResponseBody();
        return TeaModel.build(map, self);
    }

    public PutMsgCardTopByIntelligentResponseBody setSuccess(String success) {
        this.success = success;
        return this;
    }
    public String getSuccess() {
        return this.success;
    }

}
