// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontract_1_0.models;

import com.aliyun.tea.*;

public class EsignQueryIdentityByTicketRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>dingd0c871e2dfc941a34ac5d6980864d335</p>
     */
    @NameInMap("corpId")
    public String corpId;

    @NameInMap("extension")
    public java.util.Map<String, String> extension;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>feb4b8e5-d6d9-4d22-a6b8-c8e26823a73a</p>
     */
    @NameInMap("ticket")
    public String ticket;

    public static EsignQueryIdentityByTicketRequest build(java.util.Map<String, ?> map) throws Exception {
        EsignQueryIdentityByTicketRequest self = new EsignQueryIdentityByTicketRequest();
        return TeaModel.build(map, self);
    }

    public EsignQueryIdentityByTicketRequest setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public EsignQueryIdentityByTicketRequest setExtension(java.util.Map<String, String> extension) {
        this.extension = extension;
        return this;
    }
    public java.util.Map<String, String> getExtension() {
        return this.extension;
    }

    public EsignQueryIdentityByTicketRequest setTicket(String ticket) {
        this.ticket = ticket;
        return this;
    }
    public String getTicket() {
        return this.ticket;
    }

}
