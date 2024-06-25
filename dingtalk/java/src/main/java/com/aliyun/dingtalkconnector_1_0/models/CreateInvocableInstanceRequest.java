// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconnector_1_0.models;

import com.aliyun.tea.*;

public class CreateInvocableInstanceRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>dca://ding32fff839a3e0105d.connect.dingtalk.com/ding32fff839a3e0105d/action/G-ACT-101FDEBD3C6E213DB474000P</p>
     */
    @NameInMap("connectAssetUri")
    public String connectAssetUri;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>SAMPLE</p>
     */
    @NameInMap("instanceKey")
    public String instanceKey;

    public static CreateInvocableInstanceRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateInvocableInstanceRequest self = new CreateInvocableInstanceRequest();
        return TeaModel.build(map, self);
    }

    public CreateInvocableInstanceRequest setConnectAssetUri(String connectAssetUri) {
        this.connectAssetUri = connectAssetUri;
        return this;
    }
    public String getConnectAssetUri() {
        return this.connectAssetUri;
    }

    public CreateInvocableInstanceRequest setInstanceKey(String instanceKey) {
        this.instanceKey = instanceKey;
        return this;
    }
    public String getInstanceKey() {
        return this.instanceKey;
    }

}
