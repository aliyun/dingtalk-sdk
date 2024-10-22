// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class ChatAIListDatasetResponseBody extends TeaModel {
    @NameInMap("result")
    public java.util.List<ChatAIListDatasetResponseBodyResult> result;

    public static ChatAIListDatasetResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ChatAIListDatasetResponseBody self = new ChatAIListDatasetResponseBody();
        return TeaModel.build(map, self);
    }

    public ChatAIListDatasetResponseBody setResult(java.util.List<ChatAIListDatasetResponseBodyResult> result) {
        this.result = result;
        return this;
    }
    public java.util.List<ChatAIListDatasetResponseBodyResult> getResult() {
        return this.result;
    }

    public static class ChatAIListDatasetResponseBodyResult extends TeaModel {
        @NameInMap("datasetDesc")
        public String datasetDesc;

        @NameInMap("datasetId")
        public Long datasetId;

        @NameInMap("datasetName")
        public String datasetName;

        @NameInMap("memoType")
        public String memoType;

        @NameInMap("resourceType")
        public String resourceType;

        public static ChatAIListDatasetResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            ChatAIListDatasetResponseBodyResult self = new ChatAIListDatasetResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public ChatAIListDatasetResponseBodyResult setDatasetDesc(String datasetDesc) {
            this.datasetDesc = datasetDesc;
            return this;
        }
        public String getDatasetDesc() {
            return this.datasetDesc;
        }

        public ChatAIListDatasetResponseBodyResult setDatasetId(Long datasetId) {
            this.datasetId = datasetId;
            return this;
        }
        public Long getDatasetId() {
            return this.datasetId;
        }

        public ChatAIListDatasetResponseBodyResult setDatasetName(String datasetName) {
            this.datasetName = datasetName;
            return this;
        }
        public String getDatasetName() {
            return this.datasetName;
        }

        public ChatAIListDatasetResponseBodyResult setMemoType(String memoType) {
            this.memoType = memoType;
            return this;
        }
        public String getMemoType() {
            return this.memoType;
        }

        public ChatAIListDatasetResponseBodyResult setResourceType(String resourceType) {
            this.resourceType = resourceType;
            return this;
        }
        public String getResourceType() {
            return this.resourceType;
        }

    }

}
