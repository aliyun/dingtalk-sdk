// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkattendance_1_0.models;

import com.aliyun.tea.*;

public class DingTalkSecurityCheckRequest extends TeaModel {
    /**
     * <p>客户端版本号</p>
     */
    @NameInMap("clientVer")
    public String clientVer;

    /**
     * <p>客户端平台类型(iOS,Android)</p>
     */
    @NameInMap("platform")
    public String platform;

    /**
     * <p>客户端平台平台版本</p>
     */
    @NameInMap("platformVer")
    public String platformVer;

    /**
     * <p>加密字符</p>
     */
    @NameInMap("sec")
    public String sec;

    /**
     * <p>用户id</p>
     */
    @NameInMap("userId")
    public String userId;

    public static DingTalkSecurityCheckRequest build(java.util.Map<String, ?> map) throws Exception {
        DingTalkSecurityCheckRequest self = new DingTalkSecurityCheckRequest();
        return TeaModel.build(map, self);
    }

    public DingTalkSecurityCheckRequest setClientVer(String clientVer) {
        this.clientVer = clientVer;
        return this;
    }
    public String getClientVer() {
        return this.clientVer;
    }

    public DingTalkSecurityCheckRequest setPlatform(String platform) {
        this.platform = platform;
        return this;
    }
    public String getPlatform() {
        return this.platform;
    }

    public DingTalkSecurityCheckRequest setPlatformVer(String platformVer) {
        this.platformVer = platformVer;
        return this;
    }
    public String getPlatformVer() {
        return this.platformVer;
    }

    public DingTalkSecurityCheckRequest setSec(String sec) {
        this.sec = sec;
        return this;
    }
    public String getSec() {
        return this.sec;
    }

    public DingTalkSecurityCheckRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
