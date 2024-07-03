// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class GetDataDeliverRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>DELIVER-3e1a2d2f-fa76-45e8-XXXX-7fd29307c859</p>
     */
    @NameInMap("deliverId")
    public String deliverId;

    /**
     * <strong>example:</strong>
     * <p>RT</p>
     */
    @NameInMap("dispatchingItemType")
    public String dispatchingItemType;

    public static GetDataDeliverRequest build(java.util.Map<String, ?> map) throws Exception {
        GetDataDeliverRequest self = new GetDataDeliverRequest();
        return TeaModel.build(map, self);
    }

    public GetDataDeliverRequest setDeliverId(String deliverId) {
        this.deliverId = deliverId;
        return this;
    }
    public String getDeliverId() {
        return this.deliverId;
    }

    public GetDataDeliverRequest setDispatchingItemType(String dispatchingItemType) {
        this.dispatchingItemType = dispatchingItemType;
        return this;
    }
    public String getDispatchingItemType() {
        return this.dispatchingItemType;
    }

}
