// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkresident_1_0.models;

import com.aliyun.tea.*;

public class CreateResidentBlackBoardResponseBody extends TeaModel {
    @NameInMap("blackBoardId")
    public String blackBoardId;

    public static CreateResidentBlackBoardResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CreateResidentBlackBoardResponseBody self = new CreateResidentBlackBoardResponseBody();
        return TeaModel.build(map, self);
    }

    public CreateResidentBlackBoardResponseBody setBlackBoardId(String blackBoardId) {
        this.blackBoardId = blackBoardId;
        return this;
    }
    public String getBlackBoardId() {
        return this.blackBoardId;
    }

}
