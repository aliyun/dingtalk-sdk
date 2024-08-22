// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class AddCollegeAlumniUserInfoResponseBody extends TeaModel {
    @NameInMap("result")
    public AddCollegeAlumniUserInfoResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static AddCollegeAlumniUserInfoResponseBody build(java.util.Map<String, ?> map) throws Exception {
        AddCollegeAlumniUserInfoResponseBody self = new AddCollegeAlumniUserInfoResponseBody();
        return TeaModel.build(map, self);
    }

    public AddCollegeAlumniUserInfoResponseBody setResult(AddCollegeAlumniUserInfoResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public AddCollegeAlumniUserInfoResponseBodyResult getResult() {
        return this.result;
    }

    public AddCollegeAlumniUserInfoResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class AddCollegeAlumniUserInfoResponseBodyResult extends TeaModel {
        @NameInMap("success")
        public Boolean success;

        @NameInMap("type")
        public String type;

        public static AddCollegeAlumniUserInfoResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            AddCollegeAlumniUserInfoResponseBodyResult self = new AddCollegeAlumniUserInfoResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public AddCollegeAlumniUserInfoResponseBodyResult setSuccess(Boolean success) {
            this.success = success;
            return this;
        }
        public Boolean getSuccess() {
            return this.success;
        }

        public AddCollegeAlumniUserInfoResponseBodyResult setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

    }

}
