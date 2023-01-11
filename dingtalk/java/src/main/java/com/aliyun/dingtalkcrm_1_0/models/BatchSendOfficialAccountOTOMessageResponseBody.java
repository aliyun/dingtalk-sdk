// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class BatchSendOfficialAccountOTOMessageResponseBody extends TeaModel {
    /**
     * <p>开放API</p>
     */
    @NameInMap("requestId")
    public String requestId;

    /**
     * <p>result</p>
     */
    @NameInMap("result")
    public BatchSendOfficialAccountOTOMessageResponseBodyResult result;

    public static BatchSendOfficialAccountOTOMessageResponseBody build(java.util.Map<String, ?> map) throws Exception {
        BatchSendOfficialAccountOTOMessageResponseBody self = new BatchSendOfficialAccountOTOMessageResponseBody();
        return TeaModel.build(map, self);
    }

    public BatchSendOfficialAccountOTOMessageResponseBody setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public BatchSendOfficialAccountOTOMessageResponseBody setResult(BatchSendOfficialAccountOTOMessageResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public BatchSendOfficialAccountOTOMessageResponseBodyResult getResult() {
        return this.result;
    }

    public static class BatchSendOfficialAccountOTOMessageResponseBodyResult extends TeaModel {
        @NameInMap("openPushId")
        public String openPushId;

        public static BatchSendOfficialAccountOTOMessageResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            BatchSendOfficialAccountOTOMessageResponseBodyResult self = new BatchSendOfficialAccountOTOMessageResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public BatchSendOfficialAccountOTOMessageResponseBodyResult setOpenPushId(String openPushId) {
            this.openPushId = openPushId;
            return this;
        }
        public String getOpenPushId() {
            return this.openPushId;
        }

    }

}
