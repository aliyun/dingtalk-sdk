// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontract_1_0.models;

import com.aliyun.tea.*;

public class EsignQueryApprovalInfoRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>dingd0c871e2dfc941a34ac5d6980864d335</p>
     */
    @NameInMap("corpId")
    public String corpId;

    /**
     * <strong>example:</strong>
     * <p>5556ae0359c64c4b9491c0c3c339341f</p>
     */
    @NameInMap("esignFlowId")
    public String esignFlowId;

    /**
     * <strong>example:</strong>
     * <p>PbnhW6rVXRg8u6T4NiiOwwQiEiE</p>
     */
    @NameInMap("unionId")
    public String unionId;

    public static EsignQueryApprovalInfoRequest build(java.util.Map<String, ?> map) throws Exception {
        EsignQueryApprovalInfoRequest self = new EsignQueryApprovalInfoRequest();
        return TeaModel.build(map, self);
    }

    public EsignQueryApprovalInfoRequest setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public EsignQueryApprovalInfoRequest setEsignFlowId(String esignFlowId) {
        this.esignFlowId = esignFlowId;
        return this;
    }
    public String getEsignFlowId() {
        return this.esignFlowId;
    }

    public EsignQueryApprovalInfoRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

}
