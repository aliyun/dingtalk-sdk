// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class InsertOrUpdateDirResponseBody extends TeaModel {
    @NameInMap("result")
    public InsertOrUpdateDirResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static InsertOrUpdateDirResponseBody build(java.util.Map<String, ?> map) throws Exception {
        InsertOrUpdateDirResponseBody self = new InsertOrUpdateDirResponseBody();
        return TeaModel.build(map, self);
    }

    public InsertOrUpdateDirResponseBody setResult(InsertOrUpdateDirResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public InsertOrUpdateDirResponseBodyResult getResult() {
        return this.result;
    }

    public InsertOrUpdateDirResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class InsertOrUpdateDirResponseBodyResult extends TeaModel {
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

        public static InsertOrUpdateDirResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            InsertOrUpdateDirResponseBodyResult self = new InsertOrUpdateDirResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public InsertOrUpdateDirResponseBodyResult setBizGroup(String bizGroup) {
            this.bizGroup = bizGroup;
            return this;
        }
        public String getBizGroup() {
            return this.bizGroup;
        }

        public InsertOrUpdateDirResponseBodyResult setDirId(String dirId) {
            this.dirId = dirId;
            return this;
        }
        public String getDirId() {
            return this.dirId;
        }

    }

}
