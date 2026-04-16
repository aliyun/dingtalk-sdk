// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkminutes_1_0.models;

import com.aliyun.tea.*;

public class BatchGetVoicePrintIdentifyConfigResponseBody extends TeaModel {
    @NameInMap("configItems")
    public java.util.List<BatchGetVoicePrintIdentifyConfigResponseBodyConfigItems> configItems;

    public static BatchGetVoicePrintIdentifyConfigResponseBody build(java.util.Map<String, ?> map) throws Exception {
        BatchGetVoicePrintIdentifyConfigResponseBody self = new BatchGetVoicePrintIdentifyConfigResponseBody();
        return TeaModel.build(map, self);
    }

    public BatchGetVoicePrintIdentifyConfigResponseBody setConfigItems(java.util.List<BatchGetVoicePrintIdentifyConfigResponseBodyConfigItems> configItems) {
        this.configItems = configItems;
        return this;
    }
    public java.util.List<BatchGetVoicePrintIdentifyConfigResponseBodyConfigItems> getConfigItems() {
        return this.configItems;
    }

    public static class BatchGetVoicePrintIdentifyConfigResponseBodyConfigItems extends TeaModel {
        @NameInMap("allowConfigVoicePrint")
        public Boolean allowConfigVoicePrint;

        @NameInMap("enableVoicePrint")
        public Boolean enableVoicePrint;

        @NameInMap("hasVoicePrintRecord")
        public Boolean hasVoicePrintRecord;

        @NameInMap("unionId")
        public String unionId;

        public static BatchGetVoicePrintIdentifyConfigResponseBodyConfigItems build(java.util.Map<String, ?> map) throws Exception {
            BatchGetVoicePrintIdentifyConfigResponseBodyConfigItems self = new BatchGetVoicePrintIdentifyConfigResponseBodyConfigItems();
            return TeaModel.build(map, self);
        }

        public BatchGetVoicePrintIdentifyConfigResponseBodyConfigItems setAllowConfigVoicePrint(Boolean allowConfigVoicePrint) {
            this.allowConfigVoicePrint = allowConfigVoicePrint;
            return this;
        }
        public Boolean getAllowConfigVoicePrint() {
            return this.allowConfigVoicePrint;
        }

        public BatchGetVoicePrintIdentifyConfigResponseBodyConfigItems setEnableVoicePrint(Boolean enableVoicePrint) {
            this.enableVoicePrint = enableVoicePrint;
            return this;
        }
        public Boolean getEnableVoicePrint() {
            return this.enableVoicePrint;
        }

        public BatchGetVoicePrintIdentifyConfigResponseBodyConfigItems setHasVoicePrintRecord(Boolean hasVoicePrintRecord) {
            this.hasVoicePrintRecord = hasVoicePrintRecord;
            return this;
        }
        public Boolean getHasVoicePrintRecord() {
            return this.hasVoicePrintRecord;
        }

        public BatchGetVoicePrintIdentifyConfigResponseBodyConfigItems setUnionId(String unionId) {
            this.unionId = unionId;
            return this;
        }
        public String getUnionId() {
            return this.unionId;
        }

    }

}
