// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class GetTemplateByIdRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("belong")
    public String belong;

    /**
     * <p>This parameter is required.</p>
     */
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
