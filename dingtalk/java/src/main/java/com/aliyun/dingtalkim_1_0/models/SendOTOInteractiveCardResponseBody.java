// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class SendOTOInteractiveCardResponseBody extends TeaModel {
    // 创建卡片结果
    @NameInMap("result")
    public SendOTOInteractiveCardResponseBodyResult result;

    // success
    @NameInMap("success")
    public Boolean success;

    public static SendOTOInteractiveCardResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SendOTOInteractiveCardResponseBody self = new SendOTOInteractiveCardResponseBody();
        return TeaModel.build(map, self);
    }

    public SendOTOInteractiveCardResponseBody setResult(SendOTOInteractiveCardResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public SendOTOInteractiveCardResponseBodyResult getResult() {
        return this.result;
    }

    public SendOTOInteractiveCardResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class SendOTOInteractiveCardResponseBodyResult extends TeaModel {
        // 用于业务方后续查看已读列表的查询key
        @NameInMap("processQueryKey")
        public String processQueryKey;

        public static SendOTOInteractiveCardResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            SendOTOInteractiveCardResponseBodyResult self = new SendOTOInteractiveCardResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public SendOTOInteractiveCardResponseBodyResult setProcessQueryKey(String processQueryKey) {
            this.processQueryKey = processQueryKey;
            return this;
        }
        public String getProcessQueryKey() {
            return this.processQueryKey;
        }

    }

}
