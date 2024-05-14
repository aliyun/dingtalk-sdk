// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkalitrip_1_0.models;

import com.aliyun.tea.*;

public class GetHotelExceedApplyRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("applyId")
    public String applyId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("corpId")
    public String corpId;

    public static GetHotelExceedApplyRequest build(java.util.Map<String, ?> map) throws Exception {
        GetHotelExceedApplyRequest self = new GetHotelExceedApplyRequest();
        return TeaModel.build(map, self);
    }

    public GetHotelExceedApplyRequest setApplyId(String applyId) {
        this.applyId = applyId;
        return this;
    }
    public String getApplyId() {
        return this.applyId;
    }

    public GetHotelExceedApplyRequest setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

}
