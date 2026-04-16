// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkminutes_1_0.models;

import com.aliyun.tea.*;

public class BatchGetVoicePrintIdentifyConfigRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("items")
    public java.util.List<BatchGetVoicePrintIdentifyConfigRequestItems> items;

    public static BatchGetVoicePrintIdentifyConfigRequest build(java.util.Map<String, ?> map) throws Exception {
        BatchGetVoicePrintIdentifyConfigRequest self = new BatchGetVoicePrintIdentifyConfigRequest();
        return TeaModel.build(map, self);
    }

    public BatchGetVoicePrintIdentifyConfigRequest setItems(java.util.List<BatchGetVoicePrintIdentifyConfigRequestItems> items) {
        this.items = items;
        return this;
    }
    public java.util.List<BatchGetVoicePrintIdentifyConfigRequestItems> getItems() {
        return this.items;
    }

    public static class BatchGetVoicePrintIdentifyConfigRequestItems extends TeaModel {
        @NameInMap("lang")
        public String lang;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("unionId")
        public String unionId;

        public static BatchGetVoicePrintIdentifyConfigRequestItems build(java.util.Map<String, ?> map) throws Exception {
            BatchGetVoicePrintIdentifyConfigRequestItems self = new BatchGetVoicePrintIdentifyConfigRequestItems();
            return TeaModel.build(map, self);
        }

        public BatchGetVoicePrintIdentifyConfigRequestItems setLang(String lang) {
            this.lang = lang;
            return this;
        }
        public String getLang() {
            return this.lang;
        }

        public BatchGetVoicePrintIdentifyConfigRequestItems setUnionId(String unionId) {
            this.unionId = unionId;
            return this;
        }
        public String getUnionId() {
            return this.unionId;
        }

    }

}
