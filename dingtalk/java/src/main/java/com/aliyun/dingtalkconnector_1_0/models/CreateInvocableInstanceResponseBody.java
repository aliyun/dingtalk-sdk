// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconnector_1_0.models;

import com.aliyun.tea.*;

public class CreateInvocableInstanceResponseBody extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>dca://ding32fff839a3e0105d.connect.dingtalk.com/ding32fff839a3e0105d/action/G-ACT-101FDEBD3C6E213DB474000P</p>
     */
    @NameInMap("connectAssetUri")
    public String connectAssetUri;

    /**
     * <strong>example:</strong>
     * <p>G-ACT-VER-XXXACT</p>
     */
    @NameInMap("versionId")
    public String versionId;

    public static CreateInvocableInstanceResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CreateInvocableInstanceResponseBody self = new CreateInvocableInstanceResponseBody();
        return TeaModel.build(map, self);
    }

    public CreateInvocableInstanceResponseBody setConnectAssetUri(String connectAssetUri) {
        this.connectAssetUri = connectAssetUri;
        return this;
    }
    public String getConnectAssetUri() {
        return this.connectAssetUri;
    }

    public CreateInvocableInstanceResponseBody setVersionId(String versionId) {
        this.versionId = versionId;
        return this;
    }
    public String getVersionId() {
        return this.versionId;
    }

}
