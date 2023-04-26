// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class AddSchoolConfigResponseBody extends TeaModel {
    @NameInMap("result")
    public Boolean result;

    public static AddSchoolConfigResponseBody build(java.util.Map<String, ?> map) throws Exception {
        AddSchoolConfigResponseBody self = new AddSchoolConfigResponseBody();
        return TeaModel.build(map, self);
    }

    public AddSchoolConfigResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
