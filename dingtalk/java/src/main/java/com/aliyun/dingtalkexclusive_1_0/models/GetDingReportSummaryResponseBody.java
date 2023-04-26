// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class GetDingReportSummaryResponseBody extends TeaModel {
    @NameInMap("reportCommentUserCnt1d")
    public String reportCommentUserCnt1d;

    public static GetDingReportSummaryResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetDingReportSummaryResponseBody self = new GetDingReportSummaryResponseBody();
        return TeaModel.build(map, self);
    }

    public GetDingReportSummaryResponseBody setReportCommentUserCnt1d(String reportCommentUserCnt1d) {
        this.reportCommentUserCnt1d = reportCommentUserCnt1d;
        return this;
    }
    public String getReportCommentUserCnt1d() {
        return this.reportCommentUserCnt1d;
    }

}
