// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontract_1_0.models;

import com.aliyun.tea.*;

public class EsignSyncEventResponseBody extends TeaModel {
    @NameInMap("result")
    public EsignSyncEventResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static EsignSyncEventResponseBody build(java.util.Map<String, ?> map) throws Exception {
        EsignSyncEventResponseBody self = new EsignSyncEventResponseBody();
        return TeaModel.build(map, self);
    }

    public EsignSyncEventResponseBody setResult(EsignSyncEventResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public EsignSyncEventResponseBodyResult getResult() {
        return this.result;
    }

    public EsignSyncEventResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class EsignSyncEventResponseBodyResult extends TeaModel {
        @NameInMap("message")
        public String message;

        public static EsignSyncEventResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            EsignSyncEventResponseBodyResult self = new EsignSyncEventResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public EsignSyncEventResponseBodyResult setMessage(String message) {
            this.message = message;
            return this;
        }
        public String getMessage() {
            return this.message;
        }

    }

}
