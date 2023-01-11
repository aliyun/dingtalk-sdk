// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkalitrip_1_0.models;

import com.aliyun.tea.*;

public class GetFlightExceedApplyRequest extends TeaModel {
    /**
     * <p>商旅超标审批单id</p>
     */
    @NameInMap("applyId")
    public String applyId;

    /**
     * <p>第三方企业id</p>
     */
    @NameInMap("corpId")
    public String corpId;

    public static GetFlightExceedApplyRequest build(java.util.Map<String, ?> map) throws Exception {
        GetFlightExceedApplyRequest self = new GetFlightExceedApplyRequest();
        return TeaModel.build(map, self);
    }

    public GetFlightExceedApplyRequest setApplyId(String applyId) {
        this.applyId = applyId;
        return this;
    }
    public String getApplyId() {
        return this.applyId;
    }

    public GetFlightExceedApplyRequest setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

}
