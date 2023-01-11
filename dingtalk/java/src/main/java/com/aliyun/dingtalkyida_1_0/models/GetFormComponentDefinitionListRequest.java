// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class GetFormComponentDefinitionListRequest extends TeaModel {
    /**
     * <p>语言</p>
     */
    @NameInMap("language")
    public String language;

    /**
     * <p>应用秘钥</p>
     */
    @NameInMap("systemToken")
    public String systemToken;

    /**
     * <p>钉钉的userId</p>
     */
    @NameInMap("userId")
    public String userId;

    /**
     * <p>表单版本</p>
     */
    @NameInMap("version")
    public Long version;

    public static GetFormComponentDefinitionListRequest build(java.util.Map<String, ?> map) throws Exception {
        GetFormComponentDefinitionListRequest self = new GetFormComponentDefinitionListRequest();
        return TeaModel.build(map, self);
    }

    public GetFormComponentDefinitionListRequest setLanguage(String language) {
        this.language = language;
        return this;
    }
    public String getLanguage() {
        return this.language;
    }

    public GetFormComponentDefinitionListRequest setSystemToken(String systemToken) {
        this.systemToken = systemToken;
        return this;
    }
    public String getSystemToken() {
        return this.systemToken;
    }

    public GetFormComponentDefinitionListRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

    public GetFormComponentDefinitionListRequest setVersion(Long version) {
        this.version = version;
        return this;
    }
    public Long getVersion() {
        return this.version;
    }

}
