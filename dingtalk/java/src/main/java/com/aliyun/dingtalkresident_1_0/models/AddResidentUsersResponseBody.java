// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkresident_1_0.models;

import com.aliyun.tea.*;

public class AddResidentUsersResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>1234</p>
     */
    @NameInMap("result")
    public String result;

    public static AddResidentUsersResponseBody build(java.util.Map<String, ?> map) throws Exception {
        AddResidentUsersResponseBody self = new AddResidentUsersResponseBody();
        return TeaModel.build(map, self);
    }

    public AddResidentUsersResponseBody setResult(String result) {
        this.result = result;
        return this;
    }
    public String getResult() {
        return this.result;
    }

}
