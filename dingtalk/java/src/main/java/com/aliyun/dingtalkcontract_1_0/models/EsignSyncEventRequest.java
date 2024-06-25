// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontract_1_0.models;

import com.aliyun.tea.*;

public class EsignSyncEventRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>openEsign</p>
     */
    @NameInMap("action")
    public String action;

    /**
     * <strong>example:</strong>
     * <p>dingd0c871e2dfc941a34ac5d6980864d335</p>
     */
    @NameInMap("corpId")
    public String corpId;

    /**
     * <strong>example:</strong>
     * <p>{&quot;name&quot;: &quot;名字&quot;}</p>
     */
    @NameInMap("esignData")
    public String esignData;

    @NameInMap("extension")
    public java.util.Map<String, String> extension;

    /**
     * <strong>example:</strong>
     * <p>PbnhW6rVXRg8u6T4NiiOwwQiEiE</p>
     */
    @NameInMap("unionId")
    public String unionId;

    public static EsignSyncEventRequest build(java.util.Map<String, ?> map) throws Exception {
        EsignSyncEventRequest self = new EsignSyncEventRequest();
        return TeaModel.build(map, self);
    }

    public EsignSyncEventRequest setAction(String action) {
        this.action = action;
        return this;
    }
    public String getAction() {
        return this.action;
    }

    public EsignSyncEventRequest setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public EsignSyncEventRequest setEsignData(String esignData) {
        this.esignData = esignData;
        return this;
    }
    public String getEsignData() {
        return this.esignData;
    }

    public EsignSyncEventRequest setExtension(java.util.Map<String, String> extension) {
        this.extension = extension;
        return this;
    }
    public java.util.Map<String, String> getExtension() {
        return this.extension;
    }

    public EsignSyncEventRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

}
