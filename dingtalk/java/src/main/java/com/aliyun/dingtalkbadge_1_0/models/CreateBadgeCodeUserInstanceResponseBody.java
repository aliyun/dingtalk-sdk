// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbadge_1_0.models;

import com.aliyun.tea.*;

public class CreateBadgeCodeUserInstanceResponseBody extends TeaModel {
    // 码详情跳转地址
    @NameInMap("codeDetailUrl")
    public String codeDetailUrl;

    // 码ID
    @NameInMap("codeId")
    public String codeId;

    public static CreateBadgeCodeUserInstanceResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CreateBadgeCodeUserInstanceResponseBody self = new CreateBadgeCodeUserInstanceResponseBody();
        return TeaModel.build(map, self);
    }

    public CreateBadgeCodeUserInstanceResponseBody setCodeDetailUrl(String codeDetailUrl) {
        this.codeDetailUrl = codeDetailUrl;
        return this;
    }
    public String getCodeDetailUrl() {
        return this.codeDetailUrl;
    }

    public CreateBadgeCodeUserInstanceResponseBody setCodeId(String codeId) {
        this.codeId = codeId;
        return this;
    }
    public String getCodeId() {
        return this.codeId;
    }

}
