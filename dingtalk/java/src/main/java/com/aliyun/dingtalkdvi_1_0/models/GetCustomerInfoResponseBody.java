// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdvi_1_0.models;

import com.aliyun.tea.*;

public class GetCustomerInfoResponseBody extends TeaModel {
    @NameInMap("result")
    public GetCustomerInfoResponseBodyResult result;

    public static GetCustomerInfoResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetCustomerInfoResponseBody self = new GetCustomerInfoResponseBody();
        return TeaModel.build(map, self);
    }

    public GetCustomerInfoResponseBody setResult(GetCustomerInfoResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public GetCustomerInfoResponseBodyResult getResult() {
        return this.result;
    }

    public static class GetCustomerInfoResponseBodyResult extends TeaModel {
        @NameInMap("createAt")
        public String createAt;

        @NameInMap("id")
        public String id;

        @NameInMap("name")
        public String name;

        @NameInMap("ownerUserId")
        public String ownerUserId;

        @NameInMap("teamCode")
        public String teamCode;

        public static GetCustomerInfoResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            GetCustomerInfoResponseBodyResult self = new GetCustomerInfoResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public GetCustomerInfoResponseBodyResult setCreateAt(String createAt) {
            this.createAt = createAt;
            return this;
        }
        public String getCreateAt() {
            return this.createAt;
        }

        public GetCustomerInfoResponseBodyResult setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public GetCustomerInfoResponseBodyResult setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public GetCustomerInfoResponseBodyResult setOwnerUserId(String ownerUserId) {
            this.ownerUserId = ownerUserId;
            return this;
        }
        public String getOwnerUserId() {
            return this.ownerUserId;
        }

        public GetCustomerInfoResponseBodyResult setTeamCode(String teamCode) {
            this.teamCode = teamCode;
            return this;
        }
        public String getTeamCode() {
            return this.teamCode;
        }

    }

}
