// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class GetGeneralFormCreatedSummaryResponseBody extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>100</p>
     */
    @NameInMap("generalFormCreatedCnt")
    public String generalFormCreatedCnt;

    /**
     * <strong>example:</strong>
     * <p>100</p>
     */
    @NameInMap("useGeneralFormUserCnt1d")
    public String useGeneralFormUserCnt1d;

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

    public GetGeneralFormCreatedSummaryResponseBody setUseGeneralFormUserCnt1d(String useGeneralFormUserCnt1d) {
        this.useGeneralFormUserCnt1d = useGeneralFormUserCnt1d;
        return this;
    }
    public String getUseGeneralFormUserCnt1d() {
        return this.useGeneralFormUserCnt1d;
    }

}
