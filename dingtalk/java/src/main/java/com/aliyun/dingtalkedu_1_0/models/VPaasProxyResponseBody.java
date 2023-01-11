// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class VPaasProxyResponseBody extends TeaModel {
    /**
     * <p>结果密文</p>
     */
    @NameInMap("result")
    public String result;

    /**
     * <p>公钥加密的盐</p>
     */
    @NameInMap("ticket")
    public String ticket;

    public static VPaasProxyResponseBody build(java.util.Map<String, ?> map) throws Exception {
        VPaasProxyResponseBody self = new VPaasProxyResponseBody();
        return TeaModel.build(map, self);
    }

    public VPaasProxyResponseBody setResult(String result) {
        this.result = result;
        return this;
    }
    public String getResult() {
        return this.result;
    }

    public VPaasProxyResponseBody setTicket(String ticket) {
        this.ticket = ticket;
        return this;
    }
    public String getTicket() {
        return this.ticket;
    }

}
