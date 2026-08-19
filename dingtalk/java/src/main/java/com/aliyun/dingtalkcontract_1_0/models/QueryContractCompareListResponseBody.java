// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontract_1_0.models;

import com.aliyun.tea.*;

public class QueryContractCompareListResponseBody extends TeaModel {
    @NameInMap("errorCode")
    public String errorCode;

    @NameInMap("errorMsg")
    public String errorMsg;

    @NameInMap("result")
    public QueryContractCompareListResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static QueryContractCompareListResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryContractCompareListResponseBody self = new QueryContractCompareListResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryContractCompareListResponseBody setErrorCode(String errorCode) {
        this.errorCode = errorCode;
        return this;
    }
    public String getErrorCode() {
        return this.errorCode;
    }

    public QueryContractCompareListResponseBody setErrorMsg(String errorMsg) {
        this.errorMsg = errorMsg;
        return this;
    }
    public String getErrorMsg() {
        return this.errorMsg;
    }

    public QueryContractCompareListResponseBody setResult(QueryContractCompareListResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public QueryContractCompareListResponseBodyResult getResult() {
        return this.result;
    }

    public QueryContractCompareListResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class QueryContractCompareListResponseBodyResultData extends TeaModel {
        @NameInMap("comparativeFileName")
        public String comparativeFileName;

        @NameInMap("compareStatus")
        public String compareStatus;

        @NameInMap("compareTaskId")
        public String compareTaskId;

        @NameInMap("gmtCreate")
        public String gmtCreate;

        @NameInMap("gmtModified")
        public String gmtModified;

        @NameInMap("initiatorUid")
        public String initiatorUid;

        @NameInMap("requestId")
        public String requestId;

        @NameInMap("result")
        public String result;

        @NameInMap("standardFileName")
        public String standardFileName;

        public static QueryContractCompareListResponseBodyResultData build(java.util.Map<String, ?> map) throws Exception {
            QueryContractCompareListResponseBodyResultData self = new QueryContractCompareListResponseBodyResultData();
            return TeaModel.build(map, self);
        }

        public QueryContractCompareListResponseBodyResultData setComparativeFileName(String comparativeFileName) {
            this.comparativeFileName = comparativeFileName;
            return this;
        }
        public String getComparativeFileName() {
            return this.comparativeFileName;
        }

        public QueryContractCompareListResponseBodyResultData setCompareStatus(String compareStatus) {
            this.compareStatus = compareStatus;
            return this;
        }
        public String getCompareStatus() {
            return this.compareStatus;
        }

        public QueryContractCompareListResponseBodyResultData setCompareTaskId(String compareTaskId) {
            this.compareTaskId = compareTaskId;
            return this;
        }
        public String getCompareTaskId() {
            return this.compareTaskId;
        }

        public QueryContractCompareListResponseBodyResultData setGmtCreate(String gmtCreate) {
            this.gmtCreate = gmtCreate;
            return this;
        }
        public String getGmtCreate() {
            return this.gmtCreate;
        }

        public QueryContractCompareListResponseBodyResultData setGmtModified(String gmtModified) {
            this.gmtModified = gmtModified;
            return this;
        }
        public String getGmtModified() {
            return this.gmtModified;
        }

        public QueryContractCompareListResponseBodyResultData setInitiatorUid(String initiatorUid) {
            this.initiatorUid = initiatorUid;
            return this;
        }
        public String getInitiatorUid() {
            return this.initiatorUid;
        }

        public QueryContractCompareListResponseBodyResultData setRequestId(String requestId) {
            this.requestId = requestId;
            return this;
        }
        public String getRequestId() {
            return this.requestId;
        }

        public QueryContractCompareListResponseBodyResultData setResult(String result) {
            this.result = result;
            return this;
        }
        public String getResult() {
            return this.result;
        }

        public QueryContractCompareListResponseBodyResultData setStandardFileName(String standardFileName) {
            this.standardFileName = standardFileName;
            return this;
        }
        public String getStandardFileName() {
            return this.standardFileName;
        }

    }

    public static class QueryContractCompareListResponseBodyResult extends TeaModel {
        @NameInMap("currentPage")
        public Integer currentPage;

        @NameInMap("data")
        public java.util.List<QueryContractCompareListResponseBodyResultData> data;

        @NameInMap("totalCount")
        public Integer totalCount;

        public static QueryContractCompareListResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            QueryContractCompareListResponseBodyResult self = new QueryContractCompareListResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public QueryContractCompareListResponseBodyResult setCurrentPage(Integer currentPage) {
            this.currentPage = currentPage;
            return this;
        }
        public Integer getCurrentPage() {
            return this.currentPage;
        }

        public QueryContractCompareListResponseBodyResult setData(java.util.List<QueryContractCompareListResponseBodyResultData> data) {
            this.data = data;
            return this;
        }
        public java.util.List<QueryContractCompareListResponseBodyResultData> getData() {
            return this.data;
        }

        public QueryContractCompareListResponseBodyResult setTotalCount(Integer totalCount) {
            this.totalCount = totalCount;
            return this;
        }
        public Integer getTotalCount() {
            return this.totalCount;
        }

    }

}
