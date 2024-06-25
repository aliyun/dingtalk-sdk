// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontract_1_0.models;

import com.aliyun.tea.*;

public class EsignQueryGrantInfoRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>dingd0c871e2dfc941a34ac5d6980864d335</p>
     */
    @NameInMap("corpId")
    public String corpId;

    @NameInMap("extension")
    public java.util.Map<String, String> extension;

    /**
     * <strong>example:</strong>
     * <p>PbnhW6rVXRg8u6T4NiiOwwQiEiE</p>
     */
    @NameInMap("unionId")
    public String unionId;

    public static EsignQueryGrantInfoRequest build(java.util.Map<String, ?> map) throws Exception {
        EsignQueryGrantInfoRequest self = new EsignQueryGrantInfoRequest();
        return TeaModel.build(map, self);
    }

    public EsignQueryGrantInfoRequest setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public EsignQueryGrantInfoRequest setExtension(java.util.Map<String, String> extension) {
        this.extension = extension;
        return this;
    }
    public java.util.Map<String, String> getExtension() {
        return this.extension;
    }

    public EsignQueryGrantInfoRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

}
