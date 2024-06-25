// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class AddCollegeAlumniUserInfoResponseBody extends TeaModel {
    @NameInMap("success")
    public Boolean success;

    @NameInMap("type")
    public String type;

    public static AddCollegeAlumniUserInfoResponseBody build(java.util.Map<String, ?> map) throws Exception {
        AddCollegeAlumniUserInfoResponseBody self = new AddCollegeAlumniUserInfoResponseBody();
        return TeaModel.build(map, self);
    }

    public AddCollegeAlumniUserInfoResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public AddCollegeAlumniUserInfoResponseBody setType(String type) {
        this.type = type;
        return this;
    }
    public String getType() {
        return this.type;
    }

}
