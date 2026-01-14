// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdvi_1_0.models;

import com.aliyun.tea.*;

public class ListTeamResponseBody extends TeaModel {
    @NameInMap("nextToken")
    public String nextToken;

    @NameInMap("result")
    public java.util.List<ListTeamResponseBodyResult> result;

    @NameInMap("totalCount")
    public Integer totalCount;

    public static ListTeamResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ListTeamResponseBody self = new ListTeamResponseBody();
        return TeaModel.build(map, self);
    }

    public ListTeamResponseBody setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public ListTeamResponseBody setResult(java.util.List<ListTeamResponseBodyResult> result) {
        this.result = result;
        return this;
    }
    public java.util.List<ListTeamResponseBodyResult> getResult() {
        return this.result;
    }

    public ListTeamResponseBody setTotalCount(Integer totalCount) {
        this.totalCount = totalCount;
        return this;
    }
    public Integer getTotalCount() {
        return this.totalCount;
    }

    public static class ListTeamResponseBodyResult extends TeaModel {
        @NameInMap("code")
        public String code;

        @NameInMap("name")
        public String name;

        public static ListTeamResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            ListTeamResponseBodyResult self = new ListTeamResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public ListTeamResponseBodyResult setCode(String code) {
            this.code = code;
            return this;
        }
        public String getCode() {
            return this.code;
        }

        public ListTeamResponseBodyResult setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

    }

}
