// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class GetGeneralFormCreatedSummaryResponseBody extends TeaModel {
    // 最近1天累计智能填表创建数
    @NameInMap("generalFormCreatedCnt")
    public String generalFormCreatedCnt;

    public static GetGeneralFormCreatedSummaryResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetGeneralFormCreatedSummaryResponseBody self = new GetGeneralFormCreatedSummaryResponseBody();
        return TeaModel.build(map, self);
    }

    public GetGeneralFormCreatedSummaryResponseBody setGeneralFormCreatedCnt(String generalFormCreatedCnt) {
        this.generalFormCreatedCnt = generalFormCreatedCnt;
        return this;
    }
    public String getGeneralFormCreatedCnt() {
        return this.generalFormCreatedCnt;
    }

}
