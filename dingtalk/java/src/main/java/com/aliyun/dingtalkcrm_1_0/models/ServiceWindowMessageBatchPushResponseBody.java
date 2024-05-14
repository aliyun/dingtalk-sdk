// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class ServiceWindowMessageBatchPushResponseBody extends TeaModel {
    @NameInMap("requestId")
    public String requestId;

    @NameInMap("result")
    public ServiceWindowMessageBatchPushResponseBodyResult result;

    public static ServiceWindowMessageBatchPushResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ServiceWindowMessageBatchPushResponseBody self = new ServiceWindowMessageBatchPushResponseBody();
        return TeaModel.build(map, self);
    }

    public ServiceWindowMessageBatchPushResponseBody setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public ServiceWindowMessageBatchPushResponseBody setResult(ServiceWindowMessageBatchPushResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public ServiceWindowMessageBatchPushResponseBodyResult getResult() {
        return this.result;
    }

    public static class ServiceWindowMessageBatchPushResponseBodyResult extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("openPushId")
        public String openPushId;

        public static ServiceWindowMessageBatchPushResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            ServiceWindowMessageBatchPushResponseBodyResult self = new ServiceWindowMessageBatchPushResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public ServiceWindowMessageBatchPushResponseBodyResult setOpenPushId(String openPushId) {
            this.openPushId = openPushId;
            return this;
        }
        public String getOpenPushId() {
            return this.openPushId;
        }

    }

}
