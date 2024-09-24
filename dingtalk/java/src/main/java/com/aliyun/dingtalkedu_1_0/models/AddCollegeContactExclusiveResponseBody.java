// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class AddCollegeContactExclusiveResponseBody extends TeaModel {
    @NameInMap("result")
    public AddCollegeContactExclusiveResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static AddCollegeContactExclusiveResponseBody build(java.util.Map<String, ?> map) throws Exception {
        AddCollegeContactExclusiveResponseBody self = new AddCollegeContactExclusiveResponseBody();
        return TeaModel.build(map, self);
    }

    public AddCollegeContactExclusiveResponseBody setResult(AddCollegeContactExclusiveResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public AddCollegeContactExclusiveResponseBodyResult getResult() {
        return this.result;
    }

    public AddCollegeContactExclusiveResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class AddCollegeContactExclusiveResponseBodyResult extends TeaModel {
        @NameInMap("createResult")
        public Integer createResult;

        @NameInMap("unionId")
        public String unionId;

        @NameInMap("userid")
        public String userid;

        public static AddCollegeContactExclusiveResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            AddCollegeContactExclusiveResponseBodyResult self = new AddCollegeContactExclusiveResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public AddCollegeContactExclusiveResponseBodyResult setCreateResult(Integer createResult) {
            this.createResult = createResult;
            return this;
        }
        public Integer getCreateResult() {
            return this.createResult;
        }

        public AddCollegeContactExclusiveResponseBodyResult setUnionId(String unionId) {
            this.unionId = unionId;
            return this;
        }
        public String getUnionId() {
            return this.unionId;
        }

        public AddCollegeContactExclusiveResponseBodyResult setUserid(String userid) {
            this.userid = userid;
            return this;
        }
        public String getUserid() {
            return this.userid;
        }

    }

}
