// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class ImportMessageResponseBody extends TeaModel {
    @NameInMap("result")
    public ImportMessageResponseBodyResult result;

    @NameInMap("success")
    public String success;

    public static ImportMessageResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ImportMessageResponseBody self = new ImportMessageResponseBody();
        return TeaModel.build(map, self);
    }

    public ImportMessageResponseBody setResult(ImportMessageResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public ImportMessageResponseBodyResult getResult() {
        return this.result;
    }

    public ImportMessageResponseBody setSuccess(String success) {
        this.success = success;
        return this;
    }
    public String getSuccess() {
        return this.success;
    }

    public static class ImportMessageResponseBodyResult extends TeaModel {
        @NameInMap("openTaskId")
        public String openTaskId;

        public static ImportMessageResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            ImportMessageResponseBodyResult self = new ImportMessageResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public ImportMessageResponseBodyResult setOpenTaskId(String openTaskId) {
            this.openTaskId = openTaskId;
            return this;
        }
        public String getOpenTaskId() {
            return this.openTaskId;
        }

    }

}
