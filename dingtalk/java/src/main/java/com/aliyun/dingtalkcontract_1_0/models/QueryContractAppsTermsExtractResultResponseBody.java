// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontract_1_0.models;

import com.aliyun.tea.*;

public class QueryContractAppsTermsExtractResultResponseBody extends TeaModel {
    @NameInMap("result")
    public QueryContractAppsTermsExtractResultResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static QueryContractAppsTermsExtractResultResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryContractAppsTermsExtractResultResponseBody self = new QueryContractAppsTermsExtractResultResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryContractAppsTermsExtractResultResponseBody setResult(QueryContractAppsTermsExtractResultResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public QueryContractAppsTermsExtractResultResponseBodyResult getResult() {
        return this.result;
    }

    public QueryContractAppsTermsExtractResultResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class QueryContractAppsTermsExtractResultResponseBodyResultDataExtractedContentsTermContents extends TeaModel {
        @NameInMap("detailTerm")
        public String detailTerm;

        @NameInMap("exist")
        public String exist;

        @NameInMap("shortTerm")
        public String shortTerm;

        @NameInMap("termCategory")
        public String termCategory;

        public static QueryContractAppsTermsExtractResultResponseBodyResultDataExtractedContentsTermContents build(java.util.Map<String, ?> map) throws Exception {
            QueryContractAppsTermsExtractResultResponseBodyResultDataExtractedContentsTermContents self = new QueryContractAppsTermsExtractResultResponseBodyResultDataExtractedContentsTermContents();
            return TeaModel.build(map, self);
        }

        public QueryContractAppsTermsExtractResultResponseBodyResultDataExtractedContentsTermContents setDetailTerm(String detailTerm) {
            this.detailTerm = detailTerm;
            return this;
        }
        public String getDetailTerm() {
            return this.detailTerm;
        }

        public QueryContractAppsTermsExtractResultResponseBodyResultDataExtractedContentsTermContents setExist(String exist) {
            this.exist = exist;
            return this;
        }
        public String getExist() {
            return this.exist;
        }

        public QueryContractAppsTermsExtractResultResponseBodyResultDataExtractedContentsTermContents setShortTerm(String shortTerm) {
            this.shortTerm = shortTerm;
            return this;
        }
        public String getShortTerm() {
            return this.shortTerm;
        }

        public QueryContractAppsTermsExtractResultResponseBodyResultDataExtractedContentsTermContents setTermCategory(String termCategory) {
            this.termCategory = termCategory;
            return this;
        }
        public String getTermCategory() {
            return this.termCategory;
        }

    }

    public static class QueryContractAppsTermsExtractResultResponseBodyResultDataExtractedContents extends TeaModel {
        @NameInMap("ruleCategory")
        public String ruleCategory;

        @NameInMap("termContents")
        public java.util.List<QueryContractAppsTermsExtractResultResponseBodyResultDataExtractedContentsTermContents> termContents;

        public static QueryContractAppsTermsExtractResultResponseBodyResultDataExtractedContents build(java.util.Map<String, ?> map) throws Exception {
            QueryContractAppsTermsExtractResultResponseBodyResultDataExtractedContents self = new QueryContractAppsTermsExtractResultResponseBodyResultDataExtractedContents();
            return TeaModel.build(map, self);
        }

        public QueryContractAppsTermsExtractResultResponseBodyResultDataExtractedContents setRuleCategory(String ruleCategory) {
            this.ruleCategory = ruleCategory;
            return this;
        }
        public String getRuleCategory() {
            return this.ruleCategory;
        }

        public QueryContractAppsTermsExtractResultResponseBodyResultDataExtractedContents setTermContents(java.util.List<QueryContractAppsTermsExtractResultResponseBodyResultDataExtractedContentsTermContents> termContents) {
            this.termContents = termContents;
            return this;
        }
        public java.util.List<QueryContractAppsTermsExtractResultResponseBodyResultDataExtractedContentsTermContents> getTermContents() {
            return this.termContents;
        }

    }

    public static class QueryContractAppsTermsExtractResultResponseBodyResultData extends TeaModel {
        @NameInMap("extractedContents")
        public java.util.List<QueryContractAppsTermsExtractResultResponseBodyResultDataExtractedContents> extractedContents;

        @NameInMap("status")
        public String status;

        public static QueryContractAppsTermsExtractResultResponseBodyResultData build(java.util.Map<String, ?> map) throws Exception {
            QueryContractAppsTermsExtractResultResponseBodyResultData self = new QueryContractAppsTermsExtractResultResponseBodyResultData();
            return TeaModel.build(map, self);
        }

        public QueryContractAppsTermsExtractResultResponseBodyResultData setExtractedContents(java.util.List<QueryContractAppsTermsExtractResultResponseBodyResultDataExtractedContents> extractedContents) {
            this.extractedContents = extractedContents;
            return this;
        }
        public java.util.List<QueryContractAppsTermsExtractResultResponseBodyResultDataExtractedContents> getExtractedContents() {
            return this.extractedContents;
        }

        public QueryContractAppsTermsExtractResultResponseBodyResultData setStatus(String status) {
            this.status = status;
            return this;
        }
        public String getStatus() {
            return this.status;
        }

    }

    public static class QueryContractAppsTermsExtractResultResponseBodyResult extends TeaModel {
        @NameInMap("data")
        public QueryContractAppsTermsExtractResultResponseBodyResultData data;

        @NameInMap("requestId")
        public String requestId;

        public static QueryContractAppsTermsExtractResultResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            QueryContractAppsTermsExtractResultResponseBodyResult self = new QueryContractAppsTermsExtractResultResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public QueryContractAppsTermsExtractResultResponseBodyResult setData(QueryContractAppsTermsExtractResultResponseBodyResultData data) {
            this.data = data;
            return this;
        }
        public QueryContractAppsTermsExtractResultResponseBodyResultData getData() {
            return this.data;
        }

        public QueryContractAppsTermsExtractResultResponseBodyResult setRequestId(String requestId) {
            this.requestId = requestId;
            return this;
        }
        public String getRequestId() {
            return this.requestId;
        }

    }

}
