// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class GetPrintDictionaryRequest extends TeaModel {
    /**
     * <p>应用代码</p>
     */
    @NameInMap("appType")
    public String appType;

    /**
     * <p>表单id</p>
     */
    @NameInMap("formUuid")
    public String formUuid;

    /**
     * <p>用户id</p>
     */
    @NameInMap("userId")
    public String userId;

    /**
     * <p>版本</p>
     */
    @NameInMap("version")
    public Long version;

    public static GetPrintDictionaryRequest build(java.util.Map<String, ?> map) throws Exception {
        GetPrintDictionaryRequest self = new GetPrintDictionaryRequest();
        return TeaModel.build(map, self);
    }

    public GetPrintDictionaryRequest setAppType(String appType) {
        this.appType = appType;
        return this;
    }
    public String getAppType() {
        return this.appType;
    }

    public GetPrintDictionaryRequest setFormUuid(String formUuid) {
        this.formUuid = formUuid;
        return this;
    }
    public String getFormUuid() {
        return this.formUuid;
    }

    public GetPrintDictionaryRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

    public GetPrintDictionaryRequest setVersion(Long version) {
        this.version = version;
        return this;
    }
    public Long getVersion() {
        return this.version;
    }

}
