// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontract_1_0.models;

import com.aliyun.tea.*;

public class CreateTemplateProcessTaskResponseBody extends TeaModel {
    @NameInMap("errorCode")
    public String errorCode;

    @NameInMap("errorMsg")
    public String errorMsg;

    @NameInMap("result")
    public CreateTemplateProcessTaskResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static CreateTemplateProcessTaskResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CreateTemplateProcessTaskResponseBody self = new CreateTemplateProcessTaskResponseBody();
        return TeaModel.build(map, self);
    }

    public CreateTemplateProcessTaskResponseBody setErrorCode(String errorCode) {
        this.errorCode = errorCode;
        return this;
    }
    public String getErrorCode() {
        return this.errorCode;
    }

    public CreateTemplateProcessTaskResponseBody setErrorMsg(String errorMsg) {
        this.errorMsg = errorMsg;
        return this;
    }
    public String getErrorMsg() {
        return this.errorMsg;
    }

    public CreateTemplateProcessTaskResponseBody setResult(CreateTemplateProcessTaskResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public CreateTemplateProcessTaskResponseBodyResult getResult() {
        return this.result;
    }

    public CreateTemplateProcessTaskResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class CreateTemplateProcessTaskResponseBodyResult extends TeaModel {
        @NameInMap("downloadUrl")
        public String downloadUrl;

        @NameInMap("fillTaskId")
        public String fillTaskId;

        @NameInMap("mode")
        public String mode;

        @NameInMap("renderTaskId")
        public String renderTaskId;

        public static CreateTemplateProcessTaskResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            CreateTemplateProcessTaskResponseBodyResult self = new CreateTemplateProcessTaskResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public CreateTemplateProcessTaskResponseBodyResult setDownloadUrl(String downloadUrl) {
            this.downloadUrl = downloadUrl;
            return this;
        }
        public String getDownloadUrl() {
            return this.downloadUrl;
        }

        public CreateTemplateProcessTaskResponseBodyResult setFillTaskId(String fillTaskId) {
            this.fillTaskId = fillTaskId;
            return this;
        }
        public String getFillTaskId() {
            return this.fillTaskId;
        }

        public CreateTemplateProcessTaskResponseBodyResult setMode(String mode) {
            this.mode = mode;
            return this;
        }
        public String getMode() {
            return this.mode;
        }

        public CreateTemplateProcessTaskResponseBodyResult setRenderTaskId(String renderTaskId) {
            this.renderTaskId = renderTaskId;
            return this;
        }
        public String getRenderTaskId() {
            return this.renderTaskId;
        }

    }

}
