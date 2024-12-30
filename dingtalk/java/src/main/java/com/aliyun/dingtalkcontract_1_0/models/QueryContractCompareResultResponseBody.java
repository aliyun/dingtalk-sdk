// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontract_1_0.models;

import com.aliyun.tea.*;

public class QueryContractCompareResultResponseBody extends TeaModel {
    @NameInMap("result")
    public QueryContractCompareResultResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static QueryContractCompareResultResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryContractCompareResultResponseBody self = new QueryContractCompareResultResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryContractCompareResultResponseBody setResult(QueryContractCompareResultResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public QueryContractCompareResultResponseBodyResult getResult() {
        return this.result;
    }

    public QueryContractCompareResultResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class QueryContractCompareResultResponseBodyResultDataCompareDetailDetails extends TeaModel {
        @NameInMap("compareWords")
        public String compareWords;

        @NameInMap("originalWords")
        public String originalWords;

        @NameInMap("type")
        public Integer type;

        public static QueryContractCompareResultResponseBodyResultDataCompareDetailDetails build(java.util.Map<String, ?> map) throws Exception {
            QueryContractCompareResultResponseBodyResultDataCompareDetailDetails self = new QueryContractCompareResultResponseBodyResultDataCompareDetailDetails();
            return TeaModel.build(map, self);
        }

        public QueryContractCompareResultResponseBodyResultDataCompareDetailDetails setCompareWords(String compareWords) {
            this.compareWords = compareWords;
            return this;
        }
        public String getCompareWords() {
            return this.compareWords;
        }

        public QueryContractCompareResultResponseBodyResultDataCompareDetailDetails setOriginalWords(String originalWords) {
            this.originalWords = originalWords;
            return this;
        }
        public String getOriginalWords() {
            return this.originalWords;
        }

        public QueryContractCompareResultResponseBodyResultDataCompareDetailDetails setType(Integer type) {
            this.type = type;
            return this;
        }
        public Integer getType() {
            return this.type;
        }

    }

    public static class QueryContractCompareResultResponseBodyResultDataCompareDetailDifferenceCount extends TeaModel {
        @NameInMap("add")
        public Integer add;

        @NameInMap("delete")
        public Integer delete;

        @NameInMap("replace")
        public Integer replace;

        @NameInMap("total")
        public Integer total;

        public static QueryContractCompareResultResponseBodyResultDataCompareDetailDifferenceCount build(java.util.Map<String, ?> map) throws Exception {
            QueryContractCompareResultResponseBodyResultDataCompareDetailDifferenceCount self = new QueryContractCompareResultResponseBodyResultDataCompareDetailDifferenceCount();
            return TeaModel.build(map, self);
        }

        public QueryContractCompareResultResponseBodyResultDataCompareDetailDifferenceCount setAdd(Integer add) {
            this.add = add;
            return this;
        }
        public Integer getAdd() {
            return this.add;
        }

        public QueryContractCompareResultResponseBodyResultDataCompareDetailDifferenceCount setDelete(Integer delete) {
            this.delete = delete;
            return this;
        }
        public Integer getDelete() {
            return this.delete;
        }

        public QueryContractCompareResultResponseBodyResultDataCompareDetailDifferenceCount setReplace(Integer replace) {
            this.replace = replace;
            return this;
        }
        public Integer getReplace() {
            return this.replace;
        }

        public QueryContractCompareResultResponseBodyResultDataCompareDetailDifferenceCount setTotal(Integer total) {
            this.total = total;
            return this;
        }
        public Integer getTotal() {
            return this.total;
        }

    }

    public static class QueryContractCompareResultResponseBodyResultDataCompareDetail extends TeaModel {
        @NameInMap("details")
        public java.util.List<QueryContractCompareResultResponseBodyResultDataCompareDetailDetails> details;

        @NameInMap("differenceCount")
        public QueryContractCompareResultResponseBodyResultDataCompareDetailDifferenceCount differenceCount;

        public static QueryContractCompareResultResponseBodyResultDataCompareDetail build(java.util.Map<String, ?> map) throws Exception {
            QueryContractCompareResultResponseBodyResultDataCompareDetail self = new QueryContractCompareResultResponseBodyResultDataCompareDetail();
            return TeaModel.build(map, self);
        }

        public QueryContractCompareResultResponseBodyResultDataCompareDetail setDetails(java.util.List<QueryContractCompareResultResponseBodyResultDataCompareDetailDetails> details) {
            this.details = details;
            return this;
        }
        public java.util.List<QueryContractCompareResultResponseBodyResultDataCompareDetailDetails> getDetails() {
            return this.details;
        }

        public QueryContractCompareResultResponseBodyResultDataCompareDetail setDifferenceCount(QueryContractCompareResultResponseBodyResultDataCompareDetailDifferenceCount differenceCount) {
            this.differenceCount = differenceCount;
            return this;
        }
        public QueryContractCompareResultResponseBodyResultDataCompareDetailDifferenceCount getDifferenceCount() {
            return this.differenceCount;
        }

    }

    public static class QueryContractCompareResultResponseBodyResultData extends TeaModel {
        @NameInMap("compareDetail")
        public QueryContractCompareResultResponseBodyResultDataCompareDetail compareDetail;

        @NameInMap("compareDetailUrl")
        public String compareDetailUrl;

        @NameInMap("compareStatus")
        public String compareStatus;

        public static QueryContractCompareResultResponseBodyResultData build(java.util.Map<String, ?> map) throws Exception {
            QueryContractCompareResultResponseBodyResultData self = new QueryContractCompareResultResponseBodyResultData();
            return TeaModel.build(map, self);
        }

        public QueryContractCompareResultResponseBodyResultData setCompareDetail(QueryContractCompareResultResponseBodyResultDataCompareDetail compareDetail) {
            this.compareDetail = compareDetail;
            return this;
        }
        public QueryContractCompareResultResponseBodyResultDataCompareDetail getCompareDetail() {
            return this.compareDetail;
        }

        public QueryContractCompareResultResponseBodyResultData setCompareDetailUrl(String compareDetailUrl) {
            this.compareDetailUrl = compareDetailUrl;
            return this;
        }
        public String getCompareDetailUrl() {
            return this.compareDetailUrl;
        }

        public QueryContractCompareResultResponseBodyResultData setCompareStatus(String compareStatus) {
            this.compareStatus = compareStatus;
            return this;
        }
        public String getCompareStatus() {
            return this.compareStatus;
        }

    }

    public static class QueryContractCompareResultResponseBodyResult extends TeaModel {
        @NameInMap("data")
        public QueryContractCompareResultResponseBodyResultData data;

        @NameInMap("requestId")
        public String requestId;

        public static QueryContractCompareResultResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            QueryContractCompareResultResponseBodyResult self = new QueryContractCompareResultResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public QueryContractCompareResultResponseBodyResult setData(QueryContractCompareResultResponseBodyResultData data) {
            this.data = data;
            return this;
        }
        public QueryContractCompareResultResponseBodyResultData getData() {
            return this.data;
        }

        public QueryContractCompareResultResponseBodyResult setRequestId(String requestId) {
            this.requestId = requestId;
            return this;
        }
        public String getRequestId() {
            return this.requestId;
        }

    }

}
