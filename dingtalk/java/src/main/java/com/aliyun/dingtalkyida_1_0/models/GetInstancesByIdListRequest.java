// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class GetInstancesByIdListRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>APP_PBKT0MFBEBTDO8T7SLVP</p>
     */
    @NameInMap("appType")
    public String appType;

    /**
     * <strong>example:</strong>
     * <p>zh_CN</p>
     */
    @NameInMap("language")
    public String language;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>f30233fb-72e1-4af4-8cb8-c7e0ea9ee530,d230233fb-72e1-4af4-8cb8-c7e0ea9ee530</p>
     */
    @NameInMap("processInstanceIds")
    public String processInstanceIds;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>hexxyy</p>
     */
    @NameInMap("systemToken")
    public String systemToken;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>未知</p>
     */
    @NameInMap("userId")
    public String userId;

    public static GetInstancesByIdListRequest build(java.util.Map<String, ?> map) throws Exception {
        GetInstancesByIdListRequest self = new GetInstancesByIdListRequest();
        return TeaModel.build(map, self);
    }

    public GetInstancesByIdListRequest setAppType(String appType) {
        this.appType = appType;
        return this;
    }
    public String getAppType() {
        return this.appType;
    }

    public GetInstancesByIdListRequest setLanguage(String language) {
        this.language = language;
        return this;
    }
    public String getLanguage() {
        return this.language;
    }

    public GetInstancesByIdListRequest setProcessInstanceIds(String processInstanceIds) {
        this.processInstanceIds = processInstanceIds;
        return this;
    }
    public String getProcessInstanceIds() {
        return this.processInstanceIds;
    }

    public GetInstancesByIdListRequest setSystemToken(String systemToken) {
        this.systemToken = systemToken;
        return this;
    }
    public String getSystemToken() {
        return this.systemToken;
    }

    public GetInstancesByIdListRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
