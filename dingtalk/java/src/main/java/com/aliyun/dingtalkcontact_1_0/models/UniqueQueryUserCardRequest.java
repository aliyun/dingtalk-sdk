// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class UniqueQueryUserCardRequest extends TeaModel {
    // 名片模版id
    @NameInMap("templateId")
    public String templateId;

    // 用户unionId
    @NameInMap("unionId")
    public String unionId;

    public static UniqueQueryUserCardRequest build(java.util.Map<String, ?> map) throws Exception {
        UniqueQueryUserCardRequest self = new UniqueQueryUserCardRequest();
        return TeaModel.build(map, self);
    }

    public UniqueQueryUserCardRequest setTemplateId(String templateId) {
        this.templateId = templateId;
        return this;
    }
    public String getTemplateId() {
        return this.templateId;
    }

    public UniqueQueryUserCardRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

}
