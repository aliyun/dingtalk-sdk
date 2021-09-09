// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class GetDocCreatedDeptSummaryResponseBody extends TeaModel {
    // 部门维度用户创建文档数
    @NameInMap("data")
    public java.util.List<GetDocCreatedDeptSummaryResponseBodyData> data;

    // 下一次请求的分页游标
    @NameInMap("nextToken")
    public Long nextToken;

    // 是否有更多数据
    @NameInMap("hasMore")
    public Boolean hasMore;

    public static GetDocCreatedDeptSummaryResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetDocCreatedDeptSummaryResponseBody self = new GetDocCreatedDeptSummaryResponseBody();
        return TeaModel.build(map, self);
    }

    public GetDocCreatedDeptSummaryResponseBody setData(java.util.List<GetDocCreatedDeptSummaryResponseBodyData> data) {
        this.data = data;
        return this;
    }
    public java.util.List<GetDocCreatedDeptSummaryResponseBodyData> getData() {
        return this.data;
    }

    public GetDocCreatedDeptSummaryResponseBody setNextToken(Long nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public Long getNextToken() {
        return this.nextToken;
    }

    public GetDocCreatedDeptSummaryResponseBody setHasMore(Boolean hasMore) {
        this.hasMore = hasMore;
        return this;
    }
    public Boolean getHasMore() {
        return this.hasMore;
    }

    public static class GetDocCreatedDeptSummaryResponseBodyData extends TeaModel {
        // 部门id
        @NameInMap("deptId")
        public String deptId;

        // 部门名称
        @NameInMap("deptName")
        public String deptName;

        // 最近1天累计钉钉文档创建数
        @NameInMap("docCreatedCnt")
        public String docCreatedCnt;

        public static GetDocCreatedDeptSummaryResponseBodyData build(java.util.Map<String, ?> map) throws Exception {
            GetDocCreatedDeptSummaryResponseBodyData self = new GetDocCreatedDeptSummaryResponseBodyData();
            return TeaModel.build(map, self);
        }

        public GetDocCreatedDeptSummaryResponseBodyData setDeptId(String deptId) {
            this.deptId = deptId;
            return this;
        }
        public String getDeptId() {
            return this.deptId;
        }

        public GetDocCreatedDeptSummaryResponseBodyData setDeptName(String deptName) {
            this.deptName = deptName;
            return this;
        }
        public String getDeptName() {
            return this.deptName;
        }

        public GetDocCreatedDeptSummaryResponseBodyData setDocCreatedCnt(String docCreatedCnt) {
            this.docCreatedCnt = docCreatedCnt;
            return this;
        }
        public String getDocCreatedCnt() {
            return this.docCreatedCnt;
        }

    }

}
