// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontract_1_0.models;

import com.aliyun.tea.*;

public class QueryFileProcessResultResponseBody extends TeaModel {
    @NameInMap("errorCode")
    public String errorCode;

    @NameInMap("errorMsg")
    public String errorMsg;

    @NameInMap("result")
    public QueryFileProcessResultResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static QueryFileProcessResultResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryFileProcessResultResponseBody self = new QueryFileProcessResultResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryFileProcessResultResponseBody setErrorCode(String errorCode) {
        this.errorCode = errorCode;
        return this;
    }
    public String getErrorCode() {
        return this.errorCode;
    }

    public QueryFileProcessResultResponseBody setErrorMsg(String errorMsg) {
        this.errorMsg = errorMsg;
        return this;
    }
    public String getErrorMsg() {
        return this.errorMsg;
    }

    public QueryFileProcessResultResponseBody setResult(QueryFileProcessResultResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public QueryFileProcessResultResponseBodyResult getResult() {
        return this.result;
    }

    public QueryFileProcessResultResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class QueryFileProcessResultResponseBodyResult extends TeaModel {
        @NameInMap("downloadUrl")
        public String downloadUrl;

        @NameInMap("pdfStatus")
        public String pdfStatus;

        @NameInMap("renderTaskId")
        public String renderTaskId;

        public static QueryFileProcessResultResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            QueryFileProcessResultResponseBodyResult self = new QueryFileProcessResultResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public QueryFileProcessResultResponseBodyResult setDownloadUrl(String downloadUrl) {
            this.downloadUrl = downloadUrl;
            return this;
        }
        public String getDownloadUrl() {
            return this.downloadUrl;
        }

        public QueryFileProcessResultResponseBodyResult setPdfStatus(String pdfStatus) {
            this.pdfStatus = pdfStatus;
            return this;
        }
        public String getPdfStatus() {
            return this.pdfStatus;
        }

        public QueryFileProcessResultResponseBodyResult setRenderTaskId(String renderTaskId) {
            this.renderTaskId = renderTaskId;
            return this;
        }
        public String getRenderTaskId() {
            return this.renderTaskId;
        }

    }

}
