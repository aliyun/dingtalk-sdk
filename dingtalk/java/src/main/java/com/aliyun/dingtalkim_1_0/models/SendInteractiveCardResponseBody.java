// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class SendInteractiveCardResponseBody extends TeaModel {
    /**
     * <p>创建卡片结果</p>
     */
    @NameInMap("result")
    public SendInteractiveCardResponseBodyResult result;

    /**
     * <p>success</p>
     */
    @NameInMap("success")
    public Boolean success;

    public static SendInteractiveCardResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SendInteractiveCardResponseBody self = new SendInteractiveCardResponseBody();
        return TeaModel.build(map, self);
    }

    public SendInteractiveCardResponseBody setResult(SendInteractiveCardResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public SendInteractiveCardResponseBodyResult getResult() {
        return this.result;
    }

    public SendInteractiveCardResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class SendInteractiveCardResponseBodyResult extends TeaModel {
        /**
         * <p>用于业务方后续查看已读列表的查询key</p>
         */
        @NameInMap("processQueryKey")
        public String processQueryKey;

        public static SendInteractiveCardResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            SendInteractiveCardResponseBodyResult self = new SendInteractiveCardResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public SendInteractiveCardResponseBodyResult setProcessQueryKey(String processQueryKey) {
            this.processQueryKey = processQueryKey;
            return this;
        }
        public String getProcessQueryKey() {
            return this.processQueryKey;
        }

    }

}
