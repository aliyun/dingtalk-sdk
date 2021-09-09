// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class GetDingReportDeptSummaryResponseBody extends TeaModel {
    // 部门维度发布日志信息
    @NameInMap("data")
    public java.util.List<GetDingReportDeptSummaryResponseBodyData> data;

    // 下一次请求的分页游标
    @NameInMap("nextToken")
    public Long nextToken;

    // 是否有更多数据
    @NameInMap("hasMore")
    public Boolean hasMore;

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

    public GetDingReportDeptSummaryResponseBody setNextToken(Long nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public Long getNextToken() {
        return this.nextToken;
    }

    public GetDingReportDeptSummaryResponseBody setHasMore(Boolean hasMore) {
        this.hasMore = hasMore;
        return this;
    }
    public Boolean getHasMore() {
        return this.hasMore;
    }

    public static class GetDingReportDeptSummaryResponseBodyData extends TeaModel {
        // 部门id
        @NameInMap("deptId")
        public String deptId;

        // 部门名称
        @NameInMap("deptName")
        public String deptName;

        // 最近1天累计创建日志人数
        @NameInMap("dingReportSendUsrCnt")
        public String dingReportSendUsrCnt;

        // 最近1天累计创建日志数
        @NameInMap("dingReportSendCnt")
        public String dingReportSendCnt;

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

        public GetDingReportDeptSummaryResponseBodyData setDingReportSendUsrCnt(String dingReportSendUsrCnt) {
            this.dingReportSendUsrCnt = dingReportSendUsrCnt;
            return this;
        }
        public String getDingReportSendUsrCnt() {
            return this.dingReportSendUsrCnt;
        }

        public GetDingReportDeptSummaryResponseBodyData setDingReportSendCnt(String dingReportSendCnt) {
            this.dingReportSendCnt = dingReportSendCnt;
            return this;
        }
        public String getDingReportSendCnt() {
            return this.dingReportSendCnt;
        }

    }

}
