// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalknotable_1_0.models;

import com.aliyun.tea.*;

public class GetImportEncryptPublicKeyRequest extends TeaModel {
    @NameInMap("keyVersion")
    public String keyVersion;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>union_id</p>
     */
    @NameInMap("operatorId")
    public String operatorId;

    public static GetImportEncryptPublicKeyRequest build(java.util.Map<String, ?> map) throws Exception {
        GetImportEncryptPublicKeyRequest self = new GetImportEncryptPublicKeyRequest();
        return TeaModel.build(map, self);
    }

    public GetImportEncryptPublicKeyRequest setKeyVersion(String keyVersion) {
        this.keyVersion = keyVersion;
        return this;
    }
    public String getKeyVersion() {
        return this.keyVersion;
    }

    public GetImportEncryptPublicKeyRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

}
