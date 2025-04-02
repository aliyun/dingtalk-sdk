// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmail_1_0.models;

import com.aliyun.tea.*;

public class GetMessageRequest extends TeaModel {
    @NameInMap("selectFields")
    public String selectFields;

    public static GetMessageRequest build(java.util.Map<String, ?> map) throws Exception {
        GetMessageRequest self = new GetMessageRequest();
        return TeaModel.build(map, self);
    }

    public GetMessageRequest setSelectFields(String selectFields) {
        this.selectFields = selectFields;
        return this;
    }
    public String getSelectFields() {
        return this.selectFields;
    }

}
