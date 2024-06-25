// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class PreventCheatingCheckRiskRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>6.3.30</p>
     */
    @NameInMap("clientVer")
    public String clientVer;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>iOS</p>
     */
    @NameInMap("platform")
    public String platform;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>15</p>
     */
    @NameInMap("platformVer")
    public String platformVer;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>{&quot;lbsWuaToken&quot;: &quot;lbsWua&quot;,&quot;ddSec&quot;:&quot;ddSec&quot;}</p>
     */
    @NameInMap("sec")
    public String sec;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>user1</p>
     */
    @NameInMap("userId")
    public String userId;

    public static PreventCheatingCheckRiskRequest build(java.util.Map<String, ?> map) throws Exception {
        PreventCheatingCheckRiskRequest self = new PreventCheatingCheckRiskRequest();
        return TeaModel.build(map, self);
    }

    public PreventCheatingCheckRiskRequest setClientVer(String clientVer) {
        this.clientVer = clientVer;
        return this;
    }
    public String getClientVer() {
        return this.clientVer;
    }

    public PreventCheatingCheckRiskRequest setPlatform(String platform) {
        this.platform = platform;
        return this;
    }
    public String getPlatform() {
        return this.platform;
    }

    public PreventCheatingCheckRiskRequest setPlatformVer(String platformVer) {
        this.platformVer = platformVer;
        return this;
    }
    public String getPlatformVer() {
        return this.platformVer;
    }

    public PreventCheatingCheckRiskRequest setSec(String sec) {
        this.sec = sec;
        return this;
    }
    public String getSec() {
        return this.sec;
    }

    public PreventCheatingCheckRiskRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
