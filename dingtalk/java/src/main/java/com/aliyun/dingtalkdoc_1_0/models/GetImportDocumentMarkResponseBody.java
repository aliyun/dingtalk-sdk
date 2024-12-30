// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class GetImportDocumentMarkResponseBody extends TeaModel {
    @NameInMap("result")
    public GetImportDocumentMarkResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static GetImportDocumentMarkResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetImportDocumentMarkResponseBody self = new GetImportDocumentMarkResponseBody();
        return TeaModel.build(map, self);
    }

    public GetImportDocumentMarkResponseBody setResult(GetImportDocumentMarkResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public GetImportDocumentMarkResponseBodyResult getResult() {
        return this.result;
    }

    public GetImportDocumentMarkResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class GetImportDocumentMarkResponseBodyResult extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>doc_id</p>
         */
        @NameInMap("docId")
        public String docId;

        /**
         * <strong>example:</strong>
         * <p>mark_map</p>
         */
        @NameInMap("markMap")
        public java.util.Map<String, String> markMap;

        public static GetImportDocumentMarkResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            GetImportDocumentMarkResponseBodyResult self = new GetImportDocumentMarkResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public GetImportDocumentMarkResponseBodyResult setDocId(String docId) {
            this.docId = docId;
            return this;
        }
        public String getDocId() {
            return this.docId;
        }

        public GetImportDocumentMarkResponseBodyResult setMarkMap(java.util.Map<String, String> markMap) {
            this.markMap = markMap;
            return this;
        }
        public java.util.Map<String, String> getMarkMap() {
            return this.markMap;
        }

    }

}
