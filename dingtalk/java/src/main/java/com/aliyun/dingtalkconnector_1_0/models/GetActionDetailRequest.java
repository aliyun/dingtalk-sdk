// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconnector_1_0.models;

import com.aliyun.tea.*;

public class GetActionDetailRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
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
