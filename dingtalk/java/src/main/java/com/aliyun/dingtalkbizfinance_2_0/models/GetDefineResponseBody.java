// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_2_0.models;

import com.aliyun.tea.*;

public class GetDefineResponseBody extends TeaModel {
    @NameInMap("hasMore")
    public Boolean hasMore;

    @NameInMap("list")
    public java.util.List<GetDefineResponseBodyList> list;

    @NameInMap("totalCount")
    public Long totalCount;

    public static GetDefineResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetDefineResponseBody self = new GetDefineResponseBody();
        return TeaModel.build(map, self);
    }

    public GetDefineResponseBody setHasMore(Boolean hasMore) {
        this.hasMore = hasMore;
        return this;
    }
    public Boolean getHasMore() {
        return this.hasMore;
    }

    public GetDefineResponseBody setList(java.util.List<GetDefineResponseBodyList> list) {
        this.list = list;
        return this;
    }
    public java.util.List<GetDefineResponseBodyList> getList() {
        return this.list;
    }

    public GetDefineResponseBody setTotalCount(Long totalCount) {
        this.totalCount = totalCount;
        return this;
    }
    public Long getTotalCount() {
        return this.totalCount;
    }

    public static class GetDefineResponseBodyList extends TeaModel {
        @NameInMap("code")
        public String code;

        @NameInMap("name")
        public String name;

        public static GetDefineResponseBodyList build(java.util.Map<String, ?> map) throws Exception {
            GetDefineResponseBodyList self = new GetDefineResponseBodyList();
            return TeaModel.build(map, self);
        }

        public GetDefineResponseBodyList setCode(String code) {
            this.code = code;
            return this;
        }
        public String getCode() {
            return this.code;
        }

        public GetDefineResponseBodyList setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

    }

}
