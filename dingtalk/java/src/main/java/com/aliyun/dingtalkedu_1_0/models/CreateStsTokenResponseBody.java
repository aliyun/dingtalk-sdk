// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class CreateStsTokenResponseBody extends TeaModel {
    /**
     * <p>keyId</p>
     */
    @NameInMap("accessKeyId")
    public String accessKeyId;

    /**
     * <p>KeySecret</p>
     */
    @NameInMap("accessKeySecret")
    public String accessKeySecret;

    /**
     * <p>过期时间，默认1小时过期</p>
     */
    @NameInMap("expiration")
    public String expiration;

    /**
     * <p>扩展信息</p>
     */
    @NameInMap("extInfo")
    public String extInfo;

    /**
     * <p>授权的token</p>
     */
    @NameInMap("securityToken")
    public String securityToken;

    /**
     * <p>状态</p>
     */
    @NameInMap("status")
    public String status;

    public static CreateStsTokenResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CreateStsTokenResponseBody self = new CreateStsTokenResponseBody();
        return TeaModel.build(map, self);
    }

    public CreateStsTokenResponseBody setAccessKeyId(String accessKeyId) {
        this.accessKeyId = accessKeyId;
        return this;
    }
    public String getAccessKeyId() {
        return this.accessKeyId;
    }

    public CreateStsTokenResponseBody setAccessKeySecret(String accessKeySecret) {
        this.accessKeySecret = accessKeySecret;
        return this;
    }
    public String getAccessKeySecret() {
        return this.accessKeySecret;
    }

    public CreateStsTokenResponseBody setExpiration(String expiration) {
        this.expiration = expiration;
        return this;
    }
    public String getExpiration() {
        return this.expiration;
    }

    public CreateStsTokenResponseBody setExtInfo(String extInfo) {
        this.extInfo = extInfo;
        return this;
    }
    public String getExtInfo() {
        return this.extInfo;
    }

    public CreateStsTokenResponseBody setSecurityToken(String securityToken) {
        this.securityToken = securityToken;
        return this;
    }
    public String getSecurityToken() {
        return this.securityToken;
    }

    public CreateStsTokenResponseBody setStatus(String status) {
        this.status = status;
        return this;
    }
    public String getStatus() {
        return this.status;
    }

}
