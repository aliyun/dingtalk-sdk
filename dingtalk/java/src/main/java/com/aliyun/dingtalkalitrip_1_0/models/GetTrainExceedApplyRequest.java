// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkalitrip_1_0.models;

import com.aliyun.tea.*;

public class GetTrainExceedApplyRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>12345</p>
     */
    @NameInMap("applyId")
    public String applyId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>ding1234</p>
     */
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
