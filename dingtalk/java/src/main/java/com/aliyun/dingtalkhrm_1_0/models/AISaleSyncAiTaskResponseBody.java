// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class AISaleSyncAiTaskResponseBody extends TeaModel {
    @NameInMap("errorCode")
    public String errorCode;

    @NameInMap("errorMsg")
    public String errorMsg;

    @NameInMap("result")
    public AISaleSyncAiTaskResponseBodyResult result;

    @NameInMap("success")
    public String success;

    public static AISaleSyncAiTaskResponseBody build(java.util.Map<String, ?> map) throws Exception {
        AISaleSyncAiTaskResponseBody self = new AISaleSyncAiTaskResponseBody();
        return TeaModel.build(map, self);
    }

    public AISaleSyncAiTaskResponseBody setErrorCode(String errorCode) {
        this.errorCode = errorCode;
        return this;
    }
    public String getErrorCode() {
        return this.errorCode;
    }

    public AISaleSyncAiTaskResponseBody setErrorMsg(String errorMsg) {
        this.errorMsg = errorMsg;
        return this;
    }
    public String getErrorMsg() {
        return this.errorMsg;
    }

    public AISaleSyncAiTaskResponseBody setResult(AISaleSyncAiTaskResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public AISaleSyncAiTaskResponseBodyResult getResult() {
        return this.result;
    }

    public AISaleSyncAiTaskResponseBody setSuccess(String success) {
        this.success = success;
        return this;
    }
    public String getSuccess() {
        return this.success;
    }

    public static class AISaleSyncAiTaskResponseBodyResult extends TeaModel {
        @NameInMap("content")
        public String content;

        public static AISaleSyncAiTaskResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            AISaleSyncAiTaskResponseBodyResult self = new AISaleSyncAiTaskResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public AISaleSyncAiTaskResponseBodyResult setContent(String content) {
            this.content = content;
            return this;
        }
        public String getContent() {
            return this.content;
        }

    }

}
