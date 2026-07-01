// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdvi_1_0.models;

import com.aliyun.tea.*;

public class CreateTeamResponseBody extends TeaModel {
    @NameInMap("result")
    public CreateTeamResponseBodyResult result;

    public static CreateTeamResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CreateTeamResponseBody self = new CreateTeamResponseBody();
        return TeaModel.build(map, self);
    }

    public CreateTeamResponseBody setResult(CreateTeamResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public CreateTeamResponseBodyResult getResult() {
        return this.result;
    }

    public static class CreateTeamResponseBodyResult extends TeaModel {
        @NameInMap("name")
        public String name;

        @NameInMap("teamCode")
        public String teamCode;

        public static CreateTeamResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            CreateTeamResponseBodyResult self = new CreateTeamResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public CreateTeamResponseBodyResult setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public CreateTeamResponseBodyResult setTeamCode(String teamCode) {
            this.teamCode = teamCode;
            return this;
        }
        public String getTeamCode() {
            return this.teamCode;
        }

    }

}
