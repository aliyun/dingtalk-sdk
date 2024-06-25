// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class AppLoginCodeGenRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("appKey")
    public String appKey;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("signTimestampStr")
    public String signTimestampStr;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("signature")
    public String signature;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p><a href="https://www.aliwork.com/APP_xx/workbench">https://www.aliwork.com/APP_xx/workbench</a></p>
     */
    @NameInMap("fullUrl")
    public String fullUrl;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>123456</p>
     */
    @NameInMap("userId")
    public String userId;

    public static AppLoginCodeGenRequest build(java.util.Map<String, ?> map) throws Exception {
        AppLoginCodeGenRequest self = new AppLoginCodeGenRequest();
        return TeaModel.build(map, self);
    }

    public AppLoginCodeGenRequest setAppKey(String appKey) {
        this.appKey = appKey;
        return this;
    }
    public String getAppKey() {
        return this.appKey;
    }

    public AppLoginCodeGenRequest setSignTimestampStr(String signTimestampStr) {
        this.signTimestampStr = signTimestampStr;
        return this;
    }
    public String getSignTimestampStr() {
        return this.signTimestampStr;
    }

    public AppLoginCodeGenRequest setSignature(String signature) {
        this.signature = signature;
        return this;
    }
    public String getSignature() {
        return this.signature;
    }

    public AppLoginCodeGenRequest setFullUrl(String fullUrl) {
        this.fullUrl = fullUrl;
        return this;
    }
    public String getFullUrl() {
        return this.fullUrl;
    }

    public AppLoginCodeGenRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
