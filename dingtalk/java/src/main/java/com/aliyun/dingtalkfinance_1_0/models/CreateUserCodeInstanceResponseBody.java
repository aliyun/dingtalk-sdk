// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkfinance_1_0.models;

import com.aliyun.tea.*;

public class CreateUserCodeInstanceResponseBody extends TeaModel {
    @NameInMap("codeDetailUrl")
    public String codeDetailUrl;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("codeId")
    public String codeId;

    public static CreateUserCodeInstanceResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CreateUserCodeInstanceResponseBody self = new CreateUserCodeInstanceResponseBody();
        return TeaModel.build(map, self);
    }

    public CreateUserCodeInstanceResponseBody setCodeDetailUrl(String codeDetailUrl) {
        this.codeDetailUrl = codeDetailUrl;
        return this;
    }
    public String getCodeDetailUrl() {
        return this.codeDetailUrl;
    }

    public CreateUserCodeInstanceResponseBody setCodeId(String codeId) {
        this.codeId = codeId;
        return this;
    }
    public String getCodeId() {
        return this.codeId;
    }

}
