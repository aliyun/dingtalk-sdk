// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class GetProcessDesignByCodeRequest extends TeaModel {
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
     */
    @NameInMap("processCode")
    public String processCode;

    /**
     * <strong>example:</strong>
     * <p>36679675117</p>
     */
    @NameInMap("processId")
    public Long processId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>hexxx</p>
     */
    @NameInMap("systemToken")
    public String systemToken;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>02465454670427591261</p>
     */
    @NameInMap("userId")
    public String userId;

    public static GetProcessDesignByCodeRequest build(java.util.Map<String, ?> map) throws Exception {
        GetProcessDesignByCodeRequest self = new GetProcessDesignByCodeRequest();
        return TeaModel.build(map, self);
    }

    public GetProcessDesignByCodeRequest setAppType(String appType) {
        this.appType = appType;
        return this;
    }
    public String getAppType() {
        return this.appType;
    }

    public GetProcessDesignByCodeRequest setProcessCode(String processCode) {
        this.processCode = processCode;
        return this;
    }
    public String getProcessCode() {
        return this.processCode;
    }

    public GetProcessDesignByCodeRequest setProcessId(Long processId) {
        this.processId = processId;
        return this;
    }
    public Long getProcessId() {
        return this.processId;
    }

    public GetProcessDesignByCodeRequest setSystemToken(String systemToken) {
        this.systemToken = systemToken;
        return this;
    }
    public String getSystemToken() {
        return this.systemToken;
    }

    public GetProcessDesignByCodeRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
