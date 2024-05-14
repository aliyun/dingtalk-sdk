// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkresident_1_0.models;

import com.aliyun.tea.*;

public class DeleteResidentBlackBoardRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("blackboardId")
    public String blackboardId;

    public static DeleteResidentBlackBoardRequest build(java.util.Map<String, ?> map) throws Exception {
        DeleteResidentBlackBoardRequest self = new DeleteResidentBlackBoardRequest();
        return TeaModel.build(map, self);
    }

    public DeleteResidentBlackBoardRequest setBlackboardId(String blackboardId) {
        this.blackboardId = blackboardId;
        return this;
    }
    public String getBlackboardId() {
        return this.blackboardId;
    }

}
