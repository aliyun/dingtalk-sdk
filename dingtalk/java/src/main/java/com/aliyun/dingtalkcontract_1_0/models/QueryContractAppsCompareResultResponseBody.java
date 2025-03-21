// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontract_1_0.models;

import com.aliyun.tea.*;

public class QueryContractAppsCompareResultResponseBody extends TeaModel {
    @NameInMap("result")
    public QueryContractAppsCompareResultResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static QueryContractAppsCompareResultResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryContractAppsCompareResultResponseBody self = new QueryContractAppsCompareResultResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryContractAppsCompareResultResponseBody setResult(QueryContractAppsCompareResultResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public QueryContractAppsCompareResultResponseBodyResult getResult() {
        return this.result;
    }

    public QueryContractAppsCompareResultResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class QueryContractAppsCompareResultResponseBodyResultDataCompareDetailDetails extends TeaModel {
        @NameInMap("compareWords")
        public String compareWords;

        @NameInMap("originalWords")
        public String originalWords;

        @NameInMap("type")
        public Integer type;

        public static QueryContractAppsCompareResultResponseBodyResultDataCompareDetailDetails build(java.util.Map<String, ?> map) throws Exception {
            QueryContractAppsCompareResultResponseBodyResultDataCompareDetailDetails self = new QueryContractAppsCompareResultResponseBodyResultDataCompareDetailDetails();
            return TeaModel.build(map, self);
        }

        public QueryContractAppsCompareResultResponseBodyResultDataCompareDetailDetails setCompareWords(String compareWords) {
            this.compareWords = compareWords;
            return this;
        }
        public String getCompareWords() {
            return this.compareWords;
        }

        public QueryContractAppsCompareResultResponseBodyResultDataCompareDetailDetails setOriginalWords(String originalWords) {
            this.originalWords = originalWords;
            return this;
        }
        public String getOriginalWords() {
            return this.originalWords;
        }

        public QueryContractAppsCompareResultResponseBodyResultDataCompareDetailDetails setType(Integer type) {
            this.type = type;
            return this;
        }
        public Integer getType() {
            return this.type;
        }

    }

    public static class QueryContractAppsCompareResultResponseBodyResultDataCompareDetailDifferenceCount extends TeaModel {
        @NameInMap("add")
        public Integer add;

        @NameInMap("delete")
        public Integer delete;

        @NameInMap("replace")
        public Integer replace;

        @NameInMap("total")
        public Integer total;

        public static QueryContractAppsCompareResultResponseBodyResultDataCompareDetailDifferenceCount build(java.util.Map<String, ?> map) throws Exception {
            QueryContractAppsCompareResultResponseBodyResultDataCompareDetailDifferenceCount self = new QueryContractAppsCompareResultResponseBodyResultDataCompareDetailDifferenceCount();
            return TeaModel.build(map, self);
        }

        public QueryContractAppsCompareResultResponseBodyResultDataCompareDetailDifferenceCount setAdd(Integer add) {
            this.add = add;
            return this;
        }
        public Integer getAdd() {
            return this.add;
        }

        public QueryContractAppsCompareResultResponseBodyResultDataCompareDetailDifferenceCount setDelete(Integer delete) {
            this.delete = delete;
            return this;
        }
        public Integer getDelete() {
            return this.delete;
        }

        public QueryContractAppsCompareResultResponseBodyResultDataCompareDetailDifferenceCount setReplace(Integer replace) {
            this.replace = replace;
            return this;
        }
        public Integer getReplace() {
            return this.replace;
        }

        public QueryContractAppsCompareResultResponseBodyResultDataCompareDetailDifferenceCount setTotal(Integer total) {
            this.total = total;
            return this;
        }
        public Integer getTotal() {
            return this.total;
        }

    }

    public static class QueryContractAppsCompareResultResponseBodyResultDataCompareDetail extends TeaModel {
        @NameInMap("details")
        public java.util.List<QueryContractAppsCompareResultResponseBodyResultDataCompareDetailDetails> details;

        @NameInMap("differenceCount")
        public QueryContractAppsCompareResultResponseBodyResultDataCompareDetailDifferenceCount differenceCount;

        public static QueryContractAppsCompareResultResponseBodyResultDataCompareDetail build(java.util.Map<String, ?> map) throws Exception {
            QueryContractAppsCompareResultResponseBodyResultDataCompareDetail self = new QueryContractAppsCompareResultResponseBodyResultDataCompareDetail();
            return TeaModel.build(map, self);
        }

        public QueryContractAppsCompareResultResponseBodyResultDataCompareDetail setDetails(java.util.List<QueryContractAppsCompareResultResponseBodyResultDataCompareDetailDetails> details) {
            this.details = details;
            return this;
        }
        public java.util.List<QueryContractAppsCompareResultResponseBodyResultDataCompareDetailDetails> getDetails() {
            return this.details;
        }

        public QueryContractAppsCompareResultResponseBodyResultDataCompareDetail setDifferenceCount(QueryContractAppsCompareResultResponseBodyResultDataCompareDetailDifferenceCount differenceCount) {
            this.differenceCount = differenceCount;
            return this;
        }
        public QueryContractAppsCompareResultResponseBodyResultDataCompareDetailDifferenceCount getDifferenceCount() {
            return this.differenceCount;
        }

    }

    public static class QueryContractAppsCompareResultResponseBodyResultData extends TeaModel {
        @NameInMap("compareDetail")
        public QueryContractAppsCompareResultResponseBodyResultDataCompareDetail compareDetail;

        @NameInMap("compareDetailUrl")
        public String compareDetailUrl;

        @NameInMap("compareStatus")
        public String compareStatus;

        public static QueryContractAppsCompareResultResponseBodyResultData build(java.util.Map<String, ?> map) throws Exception {
            QueryContractAppsCompareResultResponseBodyResultData self = new QueryContractAppsCompareResultResponseBodyResultData();
            return TeaModel.build(map, self);
        }

        public QueryContractAppsCompareResultResponseBodyResultData setCompareDetail(QueryContractAppsCompareResultResponseBodyResultDataCompareDetail compareDetail) {
            this.compareDetail = compareDetail;
            return this;
        }
        public QueryContractAppsCompareResultResponseBodyResultDataCompareDetail getCompareDetail() {
            return this.compareDetail;
        }

        public QueryContractAppsCompareResultResponseBodyResultData setCompareDetailUrl(String compareDetailUrl) {
            this.compareDetailUrl = compareDetailUrl;
            return this;
        }
        public String getCompareDetailUrl() {
            return this.compareDetailUrl;
        }

        public QueryContractAppsCompareResultResponseBodyResultData setCompareStatus(String compareStatus) {
            this.compareStatus = compareStatus;
            return this;
        }
        public String getCompareStatus() {
            return this.compareStatus;
        }

    }

    public static class QueryContractAppsCompareResultResponseBodyResult extends TeaModel {
        @NameInMap("data")
        public QueryContractAppsCompareResultResponseBodyResultData data;

        @NameInMap("requestId")
        public String requestId;

        public static QueryContractAppsCompareResultResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            QueryContractAppsCompareResultResponseBodyResult self = new QueryContractAppsCompareResultResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public QueryContractAppsCompareResultResponseBodyResult setData(QueryContractAppsCompareResultResponseBodyResultData data) {
            this.data = data;
            return this;
        }
        public QueryContractAppsCompareResultResponseBodyResultData getData() {
            return this.data;
        }

        public QueryContractAppsCompareResultResponseBodyResult setRequestId(String requestId) {
            this.requestId = requestId;
            return this;
        }
        public String getRequestId() {
            return this.requestId;
        }

    }

}
