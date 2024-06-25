// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkassistant_1_0.models;

import com.aliyun.tea.*;

public class GetKnowledgeListResponseBody extends TeaModel {
    @NameInMap("result")
    public java.util.List<GetKnowledgeListResponseBodyResult> result;

    @NameInMap("success")
    public Boolean success;

    public static GetKnowledgeListResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetKnowledgeListResponseBody self = new GetKnowledgeListResponseBody();
        return TeaModel.build(map, self);
    }

    public GetKnowledgeListResponseBody setResult(java.util.List<GetKnowledgeListResponseBodyResult> result) {
        this.result = result;
        return this;
    }
    public java.util.List<GetKnowledgeListResponseBodyResult> getResult() {
        return this.result;
    }

    public GetKnowledgeListResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class GetKnowledgeListResponseBodyResult extends TeaModel {
        @NameInMap("docFormat")
        public String docFormat;

        @NameInMap("docName")
        public String docName;

        @NameInMap("docUrl")
        public String docUrl;

        @NameInMap("status")
        public String status;

        @NameInMap("studyId")
        public String studyId;

        public static GetKnowledgeListResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            GetKnowledgeListResponseBodyResult self = new GetKnowledgeListResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public GetKnowledgeListResponseBodyResult setDocFormat(String docFormat) {
            this.docFormat = docFormat;
            return this;
        }
        public String getDocFormat() {
            return this.docFormat;
        }

        public GetKnowledgeListResponseBodyResult setDocName(String docName) {
            this.docName = docName;
            return this;
        }
        public String getDocName() {
            return this.docName;
        }

        public GetKnowledgeListResponseBodyResult setDocUrl(String docUrl) {
            this.docUrl = docUrl;
            return this;
        }
        public String getDocUrl() {
            return this.docUrl;
        }

        public GetKnowledgeListResponseBodyResult setStatus(String status) {
            this.status = status;
            return this;
        }
        public String getStatus() {
            return this.status;
        }

        public GetKnowledgeListResponseBodyResult setStudyId(String studyId) {
            this.studyId = studyId;
            return this;
        }
        public String getStudyId() {
            return this.studyId;
        }

    }

}
