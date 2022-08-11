// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class AddProjectMemberResponseBody extends TeaModel {
    @NameInMap("result")
    public java.util.List<AddProjectMemberResponseBodyResult> result;

    public static AddProjectMemberResponseBody build(java.util.Map<String, ?> map) throws Exception {
        AddProjectMemberResponseBody self = new AddProjectMemberResponseBody();
        return TeaModel.build(map, self);
    }

    public AddProjectMemberResponseBody setResult(java.util.List<AddProjectMemberResponseBodyResult> result) {
        this.result = result;
        return this;
    }
    public java.util.List<AddProjectMemberResponseBodyResult> getResult() {
        return this.result;
    }

    public static class AddProjectMemberResponseBodyResult extends TeaModel {
        @NameInMap("joined")
        public String joined;

        @NameInMap("nickname")
        public String nickname;

        public static AddProjectMemberResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            AddProjectMemberResponseBodyResult self = new AddProjectMemberResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public AddProjectMemberResponseBodyResult setJoined(String joined) {
            this.joined = joined;
            return this;
        }
        public String getJoined() {
            return this.joined;
        }

        public AddProjectMemberResponseBodyResult setNickname(String nickname) {
            this.nickname = nickname;
            return this;
        }
        public String getNickname() {
            return this.nickname;
        }

    }

}
