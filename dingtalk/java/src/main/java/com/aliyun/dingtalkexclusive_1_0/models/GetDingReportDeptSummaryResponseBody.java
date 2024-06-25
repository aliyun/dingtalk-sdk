// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class GetDingReportDeptSummaryResponseBody extends TeaModel {
    @NameInMap("data")
    public java.util.List<GetDingReportDeptSummaryResponseBodyData> data;

    /**
     * <strong>example:</strong>
     * <p>false</p>
     */
    @NameInMap("hasMore")
    public Boolean hasMore;

    /**
     * <strong>example:</strong>
     * <p>2</p>
     */
    @NameInMap("nextToken")
    public Long nextToken;

    public static GetDingReportDeptSummaryResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetDingReportDeptSummaryResponseBody self = new GetDingReportDeptSummaryResponseBody();
        return TeaModel.build(map, self);
    }

    public GetDingReportDeptSummaryResponseBody setData(java.util.List<GetDingReportDeptSummaryResponseBodyData> data) {
        this.data = data;
        return this;
    }
    public java.util.List<GetDingReportDeptSummaryResponseBodyData> getData() {
        return this.data;
    }

    public GetDingReportDeptSummaryResponseBody setHasMore(Boolean hasMore) {
        this.hasMore = hasMore;
        return this;
    }
    public Boolean getHasMore() {
        return this.hasMore;
    }

    public GetDingReportDeptSummaryResponseBody setNextToken(Long nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public Long getNextToken() {
        return this.nextToken;
    }

    public static class GetDingReportDeptSummaryResponseBodyData extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>123</p>
         */
        @NameInMap("deptId")
        public String deptId;

        /**
         * <strong>example:</strong>
         * <p>部门A</p>
         */
        @NameInMap("deptName")
        public String deptName;

        /**
         * <strong>example:</strong>
         * <p>100</p>
         */
        @NameInMap("dingReportSendCnt")
        public String dingReportSendCnt;

        /**
         * <strong>example:</strong>
         * <p>100</p>
         */
        @NameInMap("dingReportSendUsrCnt")
        public String dingReportSendUsrCnt;

        public static GetDingReportDeptSummaryResponseBodyData build(java.util.Map<String, ?> map) throws Exception {
            GetDingReportDeptSummaryResponseBodyData self = new GetDingReportDeptSummaryResponseBodyData();
            return TeaModel.build(map, self);
        }

        public GetDingReportDeptSummaryResponseBodyData setDeptId(String deptId) {
            this.deptId = deptId;
            return this;
        }
        public String getDeptId() {
            return this.deptId;
        }

        public GetDingReportDeptSummaryResponseBodyData setDeptName(String deptName) {
            this.deptName = deptName;
            return this;
        }
        public String getDeptName() {
            return this.deptName;
        }

        public GetDingReportDeptSummaryResponseBodyData setDingReportSendCnt(String dingReportSendCnt) {
            this.dingReportSendCnt = dingReportSendCnt;
            return this;
        }
        public String getDingReportSendCnt() {
            return this.dingReportSendCnt;
        }

        public GetDingReportDeptSummaryResponseBodyData setDingReportSendUsrCnt(String dingReportSendUsrCnt) {
            this.dingReportSendUsrCnt = dingReportSendUsrCnt;
            return this;
        }
        public String getDingReportSendUsrCnt() {
            return this.dingReportSendUsrCnt;
        }

    }

}
