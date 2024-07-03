// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class ListDataDeliversRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>RT</p>
     */
    @NameInMap("dispatchingItemType")
    public String dispatchingItemType;

    public static ListDataDeliversRequest build(java.util.Map<String, ?> map) throws Exception {
        ListDataDeliversRequest self = new ListDataDeliversRequest();
        return TeaModel.build(map, self);
    }

    public ListDataDeliversRequest setDispatchingItemType(String dispatchingItemType) {
        this.dispatchingItemType = dispatchingItemType;
        return this;
    }
    public String getDispatchingItemType() {
        return this.dispatchingItemType;
    }

}
