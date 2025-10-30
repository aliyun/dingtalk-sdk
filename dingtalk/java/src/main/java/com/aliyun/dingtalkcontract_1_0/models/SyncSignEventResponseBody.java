// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontract_1_0.models;

import com.aliyun.tea.*;

public class SyncSignEventResponseBody extends TeaModel {
    @NameInMap("result")
    public SyncSignEventResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static SyncSignEventResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SyncSignEventResponseBody self = new SyncSignEventResponseBody();
        return TeaModel.build(map, self);
    }

    public SyncSignEventResponseBody setResult(SyncSignEventResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public SyncSignEventResponseBodyResult getResult() {
        return this.result;
    }

    public SyncSignEventResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class SyncSignEventResponseBodyResult extends TeaModel {
        @NameInMap("result")
        public Boolean result;

        public static SyncSignEventResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            SyncSignEventResponseBodyResult self = new SyncSignEventResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public SyncSignEventResponseBodyResult setResult(Boolean result) {
            this.result = result;
            return this;
        }
        public Boolean getResult() {
            return this.result;
        }

    }

}
