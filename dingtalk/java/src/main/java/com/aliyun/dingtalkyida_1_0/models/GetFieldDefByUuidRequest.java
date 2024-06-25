// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class GetFieldDefByUuidRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>APP_PBKT0MFBEBTDO8T7SLVP</p>
     */
    @NameInMap("appType")
    public String appType;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>FORM-J7966ZA1XN940B88DYNMNABXUXNU3F3FMLJ8L5</p>
     */
    @NameInMap("formUuid")
    public String formUuid;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>FO866D71GM94CE3KBMAFL4Q6WDG93MG6MLJ8L64</p>
     */
    @NameInMap("systemToken")
    public String systemToken;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>5014533041684350</p>
     */
    @NameInMap("userId")
    public String userId;

    public static GetFieldDefByUuidRequest build(java.util.Map<String, ?> map) throws Exception {
        GetFieldDefByUuidRequest self = new GetFieldDefByUuidRequest();
        return TeaModel.build(map, self);
    }

    public GetFieldDefByUuidRequest setAppType(String appType) {
        this.appType = appType;
        return this;
    }
    public String getAppType() {
        return this.appType;
    }

    public GetFieldDefByUuidRequest setFormUuid(String formUuid) {
        this.formUuid = formUuid;
        return this;
    }
    public String getFormUuid() {
        return this.formUuid;
    }

    public GetFieldDefByUuidRequest setSystemToken(String systemToken) {
        this.systemToken = systemToken;
        return this;
    }
    public String getSystemToken() {
        return this.systemToken;
    }

    public GetFieldDefByUuidRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
