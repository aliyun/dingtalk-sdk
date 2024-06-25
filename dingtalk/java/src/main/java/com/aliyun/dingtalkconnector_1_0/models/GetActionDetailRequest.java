// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconnector_1_0.models;

import com.aliyun.tea.*;

public class GetActionDetailRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>dca://ding32fff839a3e0105d.connect.dingtalk.com/ding32fff839a3e0105d/action/G-ACT-101FDEBD3C6E213DB474000P</p>
     */
    @NameInMap("connectAssetUri")
    public String connectAssetUri;

    public static GetActionDetailRequest build(java.util.Map<String, ?> map) throws Exception {
        GetActionDetailRequest self = new GetActionDetailRequest();
        return TeaModel.build(map, self);
    }

    public GetActionDetailRequest setConnectAssetUri(String connectAssetUri) {
        this.connectAssetUri = connectAssetUri;
        return this;
    }
    public String getConnectAssetUri() {
        return this.connectAssetUri;
    }

}
