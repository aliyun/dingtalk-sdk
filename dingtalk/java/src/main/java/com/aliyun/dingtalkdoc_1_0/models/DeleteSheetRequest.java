// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class DeleteSheetRequest extends TeaModel {
    /**
     * <p>操作人unionId</p>
     */
    @NameInMap("operatorId")
    public String operatorId;

    public static DeleteSheetRequest build(java.util.Map<String, ?> map) throws Exception {
        DeleteSheetRequest self = new DeleteSheetRequest();
        return TeaModel.build(map, self);
    }

    public DeleteSheetRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

}
