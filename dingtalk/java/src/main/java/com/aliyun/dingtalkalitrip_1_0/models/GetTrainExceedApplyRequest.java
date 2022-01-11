// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkalitrip_1_0.models;

import com.aliyun.tea.*;

public class GetTrainExceedApplyRequest extends TeaModel {
    // 商旅超标审批单id
    @NameInMap("applyId")
    public String applyId;

    // 第三方企业id
    @NameInMap("corpId")
    public String corpId;

    public static GetTrainExceedApplyRequest build(java.util.Map<String, ?> map) throws Exception {
        GetTrainExceedApplyRequest self = new GetTrainExceedApplyRequest();
        return TeaModel.build(map, self);
    }

    public GetTrainExceedApplyRequest setApplyId(String applyId) {
        this.applyId = applyId;
        return this;
    }
    public String getApplyId() {
        return this.applyId;
    }

    public GetTrainExceedApplyRequest setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

}
