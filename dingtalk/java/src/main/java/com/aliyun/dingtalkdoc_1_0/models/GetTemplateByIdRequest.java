// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class GetTemplateByIdRequest extends TeaModel {
    // 模版归属
    // public_template //公共模板
    // team_template //团队模板
    // user_template //个人模板
    @NameInMap("belong")
    public String belong;

    // 操作用户unionId
    @NameInMap("operatorId")
    public String operatorId;

    public static GetTemplateByIdRequest build(java.util.Map<String, ?> map) throws Exception {
        GetTemplateByIdRequest self = new GetTemplateByIdRequest();
        return TeaModel.build(map, self);
    }

    public GetTemplateByIdRequest setBelong(String belong) {
        this.belong = belong;
        return this;
    }
    public String getBelong() {
        return this.belong;
    }

    public GetTemplateByIdRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

}
