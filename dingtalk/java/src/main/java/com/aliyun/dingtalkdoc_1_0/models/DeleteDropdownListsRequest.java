// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class DeleteDropdownListsRequest extends TeaModel {
    // 操作人unionId
    @NameInMap("operatorId")
    public String operatorId;

    public static DeleteDropdownListsRequest build(java.util.Map<String, ?> map) throws Exception {
        DeleteDropdownListsRequest self = new DeleteDropdownListsRequest();
        return TeaModel.build(map, self);
    }

    public DeleteDropdownListsRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

}
