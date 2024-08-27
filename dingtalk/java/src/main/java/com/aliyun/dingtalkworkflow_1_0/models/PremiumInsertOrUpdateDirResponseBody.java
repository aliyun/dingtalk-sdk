// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class PremiumInsertOrUpdateDirResponseBody extends TeaModel {
    @NameInMap("result")
    public PremiumInsertOrUpdateDirResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static PremiumInsertOrUpdateDirResponseBody build(java.util.Map<String, ?> map) throws Exception {
        PremiumInsertOrUpdateDirResponseBody self = new PremiumInsertOrUpdateDirResponseBody();
        return TeaModel.build(map, self);
    }

    public PremiumInsertOrUpdateDirResponseBody setResult(PremiumInsertOrUpdateDirResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public PremiumInsertOrUpdateDirResponseBodyResult getResult() {
        return this.result;
    }

    public PremiumInsertOrUpdateDirResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class PremiumInsertOrUpdateDirResponseBodyResult extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>{应用appId}_administeration</p>
         */
        @NameInMap("bizGroup")
        public String bizGroup;

        /**
         * <strong>example:</strong>
         * <p>oaDirIdxxx</p>
         */
        @NameInMap("dirId")
        public String dirId;

        public static PremiumInsertOrUpdateDirResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            PremiumInsertOrUpdateDirResponseBodyResult self = new PremiumInsertOrUpdateDirResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public PremiumInsertOrUpdateDirResponseBodyResult setBizGroup(String bizGroup) {
            this.bizGroup = bizGroup;
            return this;
        }
        public String getBizGroup() {
            return this.bizGroup;
        }

        public PremiumInsertOrUpdateDirResponseBodyResult setDirId(String dirId) {
            this.dirId = dirId;
            return this;
        }
        public String getDirId() {
            return this.dirId;
        }

    }

}
