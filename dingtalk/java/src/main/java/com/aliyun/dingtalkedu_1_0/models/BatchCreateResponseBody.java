// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class BatchCreateResponseBody extends TeaModel {
    // result
    @NameInMap("result")
    public BatchCreateResponseBodyResult result;

    public static BatchCreateResponseBody build(java.util.Map<String, ?> map) throws Exception {
        BatchCreateResponseBody self = new BatchCreateResponseBody();
        return TeaModel.build(map, self);
    }

    public BatchCreateResponseBody setResult(BatchCreateResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public BatchCreateResponseBodyResult getResult() {
        return this.result;
    }

    public static class BatchCreateResponseBodyResult extends TeaModel {
        @NameInMap("corpIdCardIdMap")
        public java.util.Map<String, String> corpIdCardIdMap;

        public static BatchCreateResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            BatchCreateResponseBodyResult self = new BatchCreateResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public BatchCreateResponseBodyResult setCorpIdCardIdMap(java.util.Map<String, String> corpIdCardIdMap) {
            this.corpIdCardIdMap = corpIdCardIdMap;
            return this;
        }
        public java.util.Map<String, String> getCorpIdCardIdMap() {
            return this.corpIdCardIdMap;
        }

    }

}
