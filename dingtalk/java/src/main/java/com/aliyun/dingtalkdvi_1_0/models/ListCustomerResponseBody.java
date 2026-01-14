// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdvi_1_0.models;

import com.aliyun.tea.*;

public class ListCustomerResponseBody extends TeaModel {
    @NameInMap("nextToken")
    public String nextToken;

    @NameInMap("result")
    public java.util.List<ListCustomerResponseBodyResult> result;

    @NameInMap("totalCount")
    public Integer totalCount;

    public static ListCustomerResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ListCustomerResponseBody self = new ListCustomerResponseBody();
        return TeaModel.build(map, self);
    }

    public ListCustomerResponseBody setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public ListCustomerResponseBody setResult(java.util.List<ListCustomerResponseBodyResult> result) {
        this.result = result;
        return this;
    }
    public java.util.List<ListCustomerResponseBodyResult> getResult() {
        return this.result;
    }

    public ListCustomerResponseBody setTotalCount(Integer totalCount) {
        this.totalCount = totalCount;
        return this;
    }
    public Integer getTotalCount() {
        return this.totalCount;
    }

    public static class ListCustomerResponseBodyResult extends TeaModel {
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

        public static ListCustomerResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            ListCustomerResponseBodyResult self = new ListCustomerResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public ListCustomerResponseBodyResult setCreateAt(String createAt) {
            this.createAt = createAt;
            return this;
        }
        public String getCreateAt() {
            return this.createAt;
        }

        public ListCustomerResponseBodyResult setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public ListCustomerResponseBodyResult setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public ListCustomerResponseBodyResult setOwnerUserId(String ownerUserId) {
            this.ownerUserId = ownerUserId;
            return this;
        }
        public String getOwnerUserId() {
            return this.ownerUserId;
        }

        public ListCustomerResponseBodyResult setTeamCode(String teamCode) {
            this.teamCode = teamCode;
            return this;
        }
        public String getTeamCode() {
            return this.teamCode;
        }

    }

}
