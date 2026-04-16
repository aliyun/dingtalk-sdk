// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkminutes_1_0.models;

import com.aliyun.tea.*;

public class BatchToggleVoicePrintSwitchStatusResponseBody extends TeaModel {
    @NameInMap("resultItems")
    public java.util.List<BatchToggleVoicePrintSwitchStatusResponseBodyResultItems> resultItems;

    public static BatchToggleVoicePrintSwitchStatusResponseBody build(java.util.Map<String, ?> map) throws Exception {
        BatchToggleVoicePrintSwitchStatusResponseBody self = new BatchToggleVoicePrintSwitchStatusResponseBody();
        return TeaModel.build(map, self);
    }

    public BatchToggleVoicePrintSwitchStatusResponseBody setResultItems(java.util.List<BatchToggleVoicePrintSwitchStatusResponseBodyResultItems> resultItems) {
        this.resultItems = resultItems;
        return this;
    }
    public java.util.List<BatchToggleVoicePrintSwitchStatusResponseBodyResultItems> getResultItems() {
        return this.resultItems;
    }

    public static class BatchToggleVoicePrintSwitchStatusResponseBodyResultItems extends TeaModel {
        @NameInMap("message")
        public String message;

        @NameInMap("success")
        public Boolean success;

        @NameInMap("unionId")
        public String unionId;

        public static BatchToggleVoicePrintSwitchStatusResponseBodyResultItems build(java.util.Map<String, ?> map) throws Exception {
            BatchToggleVoicePrintSwitchStatusResponseBodyResultItems self = new BatchToggleVoicePrintSwitchStatusResponseBodyResultItems();
            return TeaModel.build(map, self);
        }

        public BatchToggleVoicePrintSwitchStatusResponseBodyResultItems setMessage(String message) {
            this.message = message;
            return this;
        }
        public String getMessage() {
            return this.message;
        }

        public BatchToggleVoicePrintSwitchStatusResponseBodyResultItems setSuccess(Boolean success) {
            this.success = success;
            return this;
        }
        public Boolean getSuccess() {
            return this.success;
        }

        public BatchToggleVoicePrintSwitchStatusResponseBodyResultItems setUnionId(String unionId) {
            this.unionId = unionId;
            return this;
        }
        public String getUnionId() {
            return this.unionId;
        }

    }

}
