// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconnector_1_0.models;

import com.aliyun.tea.*;

public class InvokeInstanceRequest extends TeaModel {
    /**
     * <p>连接资产标识</p>
     */
    @NameInMap("connectAssetUri")
    public String connectAssetUri;

    /**
     * <p>入参JSON文本</p>
     */
    @NameInMap("inputJsonString")
    public String inputJsonString;

    /**
     * <p>外部实例唯一标识</p>
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
