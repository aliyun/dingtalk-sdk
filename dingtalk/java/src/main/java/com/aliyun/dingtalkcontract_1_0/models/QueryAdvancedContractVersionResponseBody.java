// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontract_1_0.models;

import com.aliyun.tea.*;

public class QueryAdvancedContractVersionResponseBody extends TeaModel {
    @NameInMap("result")
    public QueryAdvancedContractVersionResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static QueryAdvancedContractVersionResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryAdvancedContractVersionResponseBody self = new QueryAdvancedContractVersionResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryAdvancedContractVersionResponseBody setResult(QueryAdvancedContractVersionResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public QueryAdvancedContractVersionResponseBodyResult getResult() {
        return this.result;
    }

    public QueryAdvancedContractVersionResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class QueryAdvancedContractVersionResponseBodyResult extends TeaModel {
        @NameInMap("enableEsignAttachmentSign")
        public Boolean enableEsignAttachmentSign;

        @NameInMap("extension")
        public java.util.Map<String, String> extension;

        /**
         * <strong>example:</strong>
         * <p>advanced</p>
         */
        @NameInMap("version")
        public String version;

        public static QueryAdvancedContractVersionResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            QueryAdvancedContractVersionResponseBodyResult self = new QueryAdvancedContractVersionResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public QueryAdvancedContractVersionResponseBodyResult setEnableEsignAttachmentSign(Boolean enableEsignAttachmentSign) {
            this.enableEsignAttachmentSign = enableEsignAttachmentSign;
            return this;
        }
        public Boolean getEnableEsignAttachmentSign() {
            return this.enableEsignAttachmentSign;
        }

        public QueryAdvancedContractVersionResponseBodyResult setExtension(java.util.Map<String, String> extension) {
            this.extension = extension;
            return this;
        }
        public java.util.Map<String, String> getExtension() {
            return this.extension;
        }

        public QueryAdvancedContractVersionResponseBodyResult setVersion(String version) {
            this.version = version;
            return this;
        }
        public String getVersion() {
            return this.version;
        }

    }

}
