// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class BusinessMatchRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("businessInfo")
    public String businessInfo;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("corpName")
    public String corpName;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("userId")
    public String userId;

    public static BusinessMatchRequest build(java.util.Map<String, ?> map) throws Exception {
        BusinessMatchRequest self = new BusinessMatchRequest();
        return TeaModel.build(map, self);
    }

    public BusinessMatchRequest setBusinessInfo(String businessInfo) {
        this.businessInfo = businessInfo;
        return this;
    }
    public String getBusinessInfo() {
        return this.businessInfo;
    }

    public BusinessMatchRequest setCorpName(String corpName) {
        this.corpName = corpName;
        return this;
    }
    public String getCorpName() {
        return this.corpName;
    }

    public BusinessMatchRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
