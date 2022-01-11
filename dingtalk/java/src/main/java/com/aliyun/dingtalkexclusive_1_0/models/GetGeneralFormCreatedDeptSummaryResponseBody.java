// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class GetGeneralFormCreatedDeptSummaryResponseBody extends TeaModel {
    // 用户版本分布情况列表
    @NameInMap("data")
    public java.util.List<GetGeneralFormCreatedDeptSummaryResponseBodyData> data;

    // 是否有更多数据
    @NameInMap("hasMore")
    public Boolean hasMore;

    // 下一次请 求的分页游标
    @NameInMap("nextToken")
    public Long nextToken;

    public static GetGeneralFormCreatedDeptSummaryResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetGeneralFormCreatedDeptSummaryResponseBody self = new GetGeneralFormCreatedDeptSummaryResponseBody();
        return TeaModel.build(map, self);
    }

    public GetGeneralFormCreatedDeptSummaryResponseBody setData(java.util.List<GetGeneralFormCreatedDeptSummaryResponseBodyData> data) {
        this.data = data;
        return this;
    }
    public java.util.List<GetGeneralFormCreatedDeptSummaryResponseBodyData> getData() {
        return this.data;
    }

    public GetGeneralFormCreatedDeptSummaryResponseBody setHasMore(Boolean hasMore) {
        this.hasMore = hasMore;
        return this;
    }
    public Boolean getHasMore() {
        return this.hasMore;
    }

    public GetGeneralFormCreatedDeptSummaryResponseBody setNextToken(Long nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public Long getNextToken() {
        return this.nextToken;
    }

    public static class GetGeneralFormCreatedDeptSummaryResponseBodyData extends TeaModel {
        // 部门id
        @NameInMap("deptId")
        public String deptId;

        // 部门名称
        @NameInMap("deptName")
        public String deptName;

        // 最近1天累计发布智能填表数
        @NameInMap("generalFormCreateCnt1d")
        public String generalFormCreateCnt1d;

        public static GetGeneralFormCreatedDeptSummaryResponseBodyData build(java.util.Map<String, ?> map) throws Exception {
            GetGeneralFormCreatedDeptSummaryResponseBodyData self = new GetGeneralFormCreatedDeptSummaryResponseBodyData();
            return TeaModel.build(map, self);
        }

        public GetGeneralFormCreatedDeptSummaryResponseBodyData setDeptId(String deptId) {
            this.deptId = deptId;
            return this;
        }
        public String getDeptId() {
            return this.deptId;
        }

        public GetGeneralFormCreatedDeptSummaryResponseBodyData setDeptName(String deptName) {
            this.deptName = deptName;
            return this;
        }
        public String getDeptName() {
            return this.deptName;
        }

        public GetGeneralFormCreatedDeptSummaryResponseBodyData setGeneralFormCreateCnt1d(String generalFormCreateCnt1d) {
            this.generalFormCreateCnt1d = generalFormCreateCnt1d;
            return this;
        }
        public String getGeneralFormCreateCnt1d() {
            return this.generalFormCreateCnt1d;
        }

    }

}
