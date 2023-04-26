// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconnector_1_0.models;

import com.aliyun.tea.*;

public class CreateInvocableInstanceResponseBody extends TeaModel {
    @NameInMap("connectAssetUri")
    public String connectAssetUri;

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
