// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontract_1_0.models;

import com.aliyun.tea.*;

public class EsignSyncEventRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("action")
    public String action;

    @NameInMap("corpId")
    public String corpId;

    @NameInMap("esignData")
    public String esignData;

    @NameInMap("extension")
    public java.util.Map<String, String> extension;

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
