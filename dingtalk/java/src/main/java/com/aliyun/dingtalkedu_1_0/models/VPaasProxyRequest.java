// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class VPaasProxyRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>init</p>
     */
    @NameInMap("actionCode")
    public String actionCode;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>{&quot;a&quot;:&quot;testA&quot;,&quot;b&quot;:&quot;testB&quot;}</p>
     */
    @NameInMap("params")
    public String params;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>MIGfMA0GCSqGSIb3DQEBAQUAA4GNADCBiQKBgQCVGpgpjjbBS1Pg1tYx23KDJiXokVdKFLdJznKxQe+fZcIOtcQDIYrfrBfHmiC/gASeF5NUTSrwjkr/i/2gqhIIxRinNJQm8L4GJ6fRGjN8tND7AfhfkGYIfOJCLFSiaYSa4TCM7WsmztkpR7DSvb4P+K/ppqYFfUB46a9nCcvecQIDAQAB</p>
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
