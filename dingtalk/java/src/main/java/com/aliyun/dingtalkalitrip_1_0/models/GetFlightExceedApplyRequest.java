// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkalitrip_1_0.models;

import com.aliyun.tea.*;

public class GetFlightExceedApplyRequest extends TeaModel {
    // 第三方企业id
    @NameInMap("corpId")
    public String corpId;

    // 商旅超标审批单id
    @NameInMap("applyId")
    public String applyId;

    public static GetFlightExceedApplyRequest build(java.util.Map<String, ?> map) throws Exception {
        GetFlightExceedApplyRequest self = new GetFlightExceedApplyRequest();
        return TeaModel.build(map, self);
    }

    public GetFlightExceedApplyRequest setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public GetFlightExceedApplyRequest setApplyId(String applyId) {
        this.applyId = applyId;
        return this;
    }
    public String getApplyId() {
        return this.applyId;
    }

}
