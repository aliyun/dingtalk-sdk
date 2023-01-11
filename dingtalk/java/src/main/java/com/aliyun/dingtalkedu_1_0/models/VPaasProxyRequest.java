// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class VPaasProxyRequest extends TeaModel {
    /**
     * <p>代理操作码</p>
     */
    @NameInMap("actionCode")
    public String actionCode;

    /**
     * <p>调用参数</p>
     */
    @NameInMap("params")
    public String params;

    /**
     * <p>Base64加密的公钥</p>
     */
    @NameInMap("publicKey")
    public String publicKey;

    public static VPaasProxyRequest build(java.util.Map<String, ?> map) throws Exception {
        VPaasProxyRequest self = new VPaasProxyRequest();
        return TeaModel.build(map, self);
    }

    public VPaasProxyRequest setActionCode(String actionCode) {
        this.actionCode = actionCode;
        return this;
    }
    public String getActionCode() {
        return this.actionCode;
    }

    public VPaasProxyRequest setParams(String params) {
        this.params = params;
        return this;
    }
    public String getParams() {
        return this.params;
    }

    public VPaasProxyRequest setPublicKey(String publicKey) {
        this.publicKey = publicKey;
        return this;
    }
    public String getPublicKey() {
        return this.publicKey;
    }

}
