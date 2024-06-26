// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class BanOrOpenGroupWordsRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("banWordsType")
    public Integer banWordsType;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("openConverationId")
    public String openConverationId;

    public static BanOrOpenGroupWordsRequest build(java.util.Map<String, ?> map) throws Exception {
        BanOrOpenGroupWordsRequest self = new BanOrOpenGroupWordsRequest();
        return TeaModel.build(map, self);
    }

    public BanOrOpenGroupWordsRequest setBanWordsType(Integer banWordsType) {
        this.banWordsType = banWordsType;
        return this;
    }
    public Integer getBanWordsType() {
        return this.banWordsType;
    }

    public BanOrOpenGroupWordsRequest setOpenConverationId(String openConverationId) {
        this.openConverationId = openConverationId;
        return this;
    }
    public String getOpenConverationId() {
        return this.openConverationId;
    }

}
