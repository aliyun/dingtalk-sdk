// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkapp_market_1_0.models;

import com.aliyun.tea.*;

public class EnsureUserLicenseAccessRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>encrypted_union_id_example</p>
     */
    @NameInMap("unionId")
    public String unionId;

    public static EnsureUserLicenseAccessRequest build(java.util.Map<String, ?> map) throws Exception {
        EnsureUserLicenseAccessRequest self = new EnsureUserLicenseAccessRequest();
        return TeaModel.build(map, self);
    }

    public EnsureUserLicenseAccessRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

}
