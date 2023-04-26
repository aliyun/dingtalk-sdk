// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkalitrip_1_0.models;

import com.aliyun.tea.*;

public class ApproveCityCarApplyResponseBody extends TeaModel {
    @NameInMap("approveResult")
    public Boolean approveResult;

    public static ApproveCityCarApplyResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ApproveCityCarApplyResponseBody self = new ApproveCityCarApplyResponseBody();
        return TeaModel.build(map, self);
    }

    public ApproveCityCarApplyResponseBody setApproveResult(Boolean approveResult) {
        this.approveResult = approveResult;
        return this;
    }
    public Boolean getApproveResult() {
        return this.approveResult;
    }

}
