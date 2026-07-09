// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalknotable_1_0.models;

import com.aliyun.tea.*;

public class MarkExternalAuthControlledSheetRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("externalAuthType")
    public String externalAuthType;

    @NameInMap("externalConfig")
    public String externalConfig;

    @NameInMap("clientToken")
    public String clientToken;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>union_id</p>
     */
    @NameInMap("operatorId")
    public String operatorId;

    public static MarkExternalAuthControlledSheetRequest build(java.util.Map<String, ?> map) throws Exception {
        MarkExternalAuthControlledSheetRequest self = new MarkExternalAuthControlledSheetRequest();
        return TeaModel.build(map, self);
    }

    public MarkExternalAuthControlledSheetRequest setExternalAuthType(String externalAuthType) {
        this.externalAuthType = externalAuthType;
        return this;
    }
    public String getExternalAuthType() {
        return this.externalAuthType;
    }

    public MarkExternalAuthControlledSheetRequest setExternalConfig(String externalConfig) {
        this.externalConfig = externalConfig;
        return this;
    }
    public String getExternalConfig() {
        return this.externalConfig;
    }

    public MarkExternalAuthControlledSheetRequest setClientToken(String clientToken) {
        this.clientToken = clientToken;
        return this;
    }
    public String getClientToken() {
        return this.clientToken;
    }

    public MarkExternalAuthControlledSheetRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

}
