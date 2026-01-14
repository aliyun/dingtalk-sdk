// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class IntelligentSendCardResponseBody extends TeaModel {
    @NameInMap("result")
    public IntelligentSendCardResponseBodyResult result;

    @NameInMap("success")
    public String success;

    public static IntelligentSendCardResponseBody build(java.util.Map<String, ?> map) throws Exception {
        IntelligentSendCardResponseBody self = new IntelligentSendCardResponseBody();
        return TeaModel.build(map, self);
    }

    public IntelligentSendCardResponseBody setResult(IntelligentSendCardResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public IntelligentSendCardResponseBodyResult getResult() {
        return this.result;
    }

    public IntelligentSendCardResponseBody setSuccess(String success) {
        this.success = success;
        return this;
    }
    public String getSuccess() {
        return this.success;
    }

    public static class IntelligentSendCardResponseBodyResult extends TeaModel {
        @NameInMap("openTaskId")
        public String openTaskId;

        public static IntelligentSendCardResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            IntelligentSendCardResponseBodyResult self = new IntelligentSendCardResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public IntelligentSendCardResponseBodyResult setOpenTaskId(String openTaskId) {
            this.openTaskId = openTaskId;
            return this;
        }
        public String getOpenTaskId() {
            return this.openTaskId;
        }

    }

}
