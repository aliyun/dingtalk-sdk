// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontract_1_0.models;

import com.aliyun.tea.*;

public class EsignUserVerifyRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>dingbfc7ac3ddee0c1acffe93478753d9884</p>
     */
    @NameInMap("corpId")
    public String corpId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>1Wgkx59vuKA8u6T4NiiOwwQiEiE</p>
     */
    @NameInMap("unionId")
    public String unionId;

    public static EsignUserVerifyRequest build(java.util.Map<String, ?> map) throws Exception {
        EsignUserVerifyRequest self = new EsignUserVerifyRequest();
        return TeaModel.build(map, self);
    }

    public EsignUserVerifyRequest setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public EsignUserVerifyRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

}
