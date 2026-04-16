// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkminutes_1_0.models;

import com.aliyun.tea.*;

public class BatchToggleVoicePrintSwitchStatusRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("items")
    public java.util.List<BatchToggleVoicePrintSwitchStatusRequestItems> items;

    public static BatchToggleVoicePrintSwitchStatusRequest build(java.util.Map<String, ?> map) throws Exception {
        BatchToggleVoicePrintSwitchStatusRequest self = new BatchToggleVoicePrintSwitchStatusRequest();
        return TeaModel.build(map, self);
    }

    public BatchToggleVoicePrintSwitchStatusRequest setItems(java.util.List<BatchToggleVoicePrintSwitchStatusRequestItems> items) {
        this.items = items;
        return this;
    }
    public java.util.List<BatchToggleVoicePrintSwitchStatusRequestItems> getItems() {
        return this.items;
    }

    public static class BatchToggleVoicePrintSwitchStatusRequestItems extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("open")
        public Boolean open;

        @NameInMap("shouldClearVoicePrint")
        public Boolean shouldClearVoicePrint;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("unionId")
        public String unionId;

        public static BatchToggleVoicePrintSwitchStatusRequestItems build(java.util.Map<String, ?> map) throws Exception {
            BatchToggleVoicePrintSwitchStatusRequestItems self = new BatchToggleVoicePrintSwitchStatusRequestItems();
            return TeaModel.build(map, self);
        }

        public BatchToggleVoicePrintSwitchStatusRequestItems setOpen(Boolean open) {
            this.open = open;
            return this;
        }
        public Boolean getOpen() {
            return this.open;
        }

        public BatchToggleVoicePrintSwitchStatusRequestItems setShouldClearVoicePrint(Boolean shouldClearVoicePrint) {
            this.shouldClearVoicePrint = shouldClearVoicePrint;
            return this;
        }
        public Boolean getShouldClearVoicePrint() {
            return this.shouldClearVoicePrint;
        }

        public BatchToggleVoicePrintSwitchStatusRequestItems setUnionId(String unionId) {
            this.unionId = unionId;
            return this;
        }
        public String getUnionId() {
            return this.unionId;
        }

    }

}
