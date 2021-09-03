// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class GetActiveUserSummaryResponseBody extends TeaModel {
    // 月活跃人数
    @NameInMap("actUsrCnt1m")
    public String actUsrCnt1m;

    public static GetActiveUserSummaryResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetActiveUserSummaryResponseBody self = new GetActiveUserSummaryResponseBody();
        return TeaModel.build(map, self);
    }

    public GetActiveUserSummaryResponseBody setActUsrCnt1m(String actUsrCnt1m) {
        this.actUsrCnt1m = actUsrCnt1m;
        return this;
    }
    public String getActUsrCnt1m() {
        return this.actUsrCnt1m;
    }

}
