// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class AddCollegeContactUserResponseBody extends TeaModel {
    @NameInMap("result")
    public AddCollegeContactUserResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static AddCollegeContactUserResponseBody build(java.util.Map<String, ?> map) throws Exception {
        AddCollegeContactUserResponseBody self = new AddCollegeContactUserResponseBody();
        return TeaModel.build(map, self);
    }

    public AddCollegeContactUserResponseBody setResult(AddCollegeContactUserResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public AddCollegeContactUserResponseBodyResult getResult() {
        return this.result;
    }

    public AddCollegeContactUserResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class AddCollegeContactUserResponseBodyResult extends TeaModel {
        @NameInMap("createResult")
        public Integer createResult;

        @NameInMap("unionId")
        public String unionId;

        @NameInMap("userid")
        public String userid;

        public static AddCollegeContactUserResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            AddCollegeContactUserResponseBodyResult self = new AddCollegeContactUserResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public AddCollegeContactUserResponseBodyResult setCreateResult(Integer createResult) {
            this.createResult = createResult;
            return this;
        }
        public Integer getCreateResult() {
            return this.createResult;
        }

        public AddCollegeContactUserResponseBodyResult setUnionId(String unionId) {
            this.unionId = unionId;
            return this;
        }
        public String getUnionId() {
            return this.unionId;
        }

        public AddCollegeContactUserResponseBodyResult setUserid(String userid) {
            this.userid = userid;
            return this;
        }
        public String getUserid() {
            return this.userid;
        }

    }

}
