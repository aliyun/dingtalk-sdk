// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconnector_1_0.models;

import com.aliyun.tea.*;

public class InvokeInstanceRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>dca://ding32fff839a3e0105d.connect.dingtalk.com/ding32fff839a3e0105d/action/G-ACT-101FDEBD3C6E213DB474000P</p>
     */
    @NameInMap("connectAssetUri")
    public String connectAssetUri;

    /**
     * <strong>example:</strong>
     * <p>{}</p>
     * 
     * <strong>if can be null:</strong>
     * <p>true</p>
     */
    @NameInMap("inputJsonString")
    public String inputJsonString;

    /**
     * <strong>example:</strong>
     * <p>SAMPLE</p>
     */
    @NameInMap("instanceKey")
    public String instanceKey;

    public static InvokeInstanceRequest build(java.util.Map<String, ?> map) throws Exception {
        InvokeInstanceRequest self = new InvokeInstanceRequest();
        return TeaModel.build(map, self);
    }

    public InvokeInstanceRequest setConnectAssetUri(String connectAssetUri) {
        this.connectAssetUri = connectAssetUri;
        return this;
    }
    public String getConnectAssetUri() {
        return this.connectAssetUri;
    }

    public InvokeInstanceRequest setInputJsonString(String inputJsonString) {
        this.inputJsonString = inputJsonString;
        return this;
    }
    public String getInputJsonString() {
        return this.inputJsonString;
    }

    public InvokeInstanceRequest setInstanceKey(String instanceKey) {
        this.instanceKey = instanceKey;
        return this;
    }
    public String getInstanceKey() {
        return this.instanceKey;
    }

}
