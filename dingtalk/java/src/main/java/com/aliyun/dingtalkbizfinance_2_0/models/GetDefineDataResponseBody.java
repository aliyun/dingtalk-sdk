// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_2_0.models;

import com.aliyun.tea.*;

public class GetDefineDataResponseBody extends TeaModel {
    @NameInMap("hasMore")
    public Boolean hasMore;

    @NameInMap("list")
    public java.util.List<GetDefineDataResponseBodyList> list;

    @NameInMap("totalCount")
    public Long totalCount;

    public static GetDefineDataResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetDefineDataResponseBody self = new GetDefineDataResponseBody();
        return TeaModel.build(map, self);
    }

    public GetDefineDataResponseBody setHasMore(Boolean hasMore) {
        this.hasMore = hasMore;
        return this;
    }
    public Boolean getHasMore() {
        return this.hasMore;
    }

    public GetDefineDataResponseBody setList(java.util.List<GetDefineDataResponseBodyList> list) {
        this.list = list;
        return this;
    }
    public java.util.List<GetDefineDataResponseBodyList> getList() {
        return this.list;
    }

    public GetDefineDataResponseBody setTotalCount(Long totalCount) {
        this.totalCount = totalCount;
        return this;
    }
    public Long getTotalCount() {
        return this.totalCount;
    }

    public static class GetDefineDataResponseBodyList extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>DA_123456</p>
         */
        @NameInMap("dataCode")
        public String dataCode;

        /**
         * <strong>example:</strong>
         * <p>DEF_123456</p>
         */
        @NameInMap("defineCode")
        public String defineCode;

        /**
         * <strong>example:</strong>
         * <p>xx路1号门店</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <strong>example:</strong>
         * <p>-1</p>
         */
        @NameInMap("parentDataCode")
        public String parentDataCode;

        /**
         * <strong>example:</strong>
         * <p>valid</p>
         */
        @NameInMap("status")
        public String status;

        public static GetDefineDataResponseBodyList build(java.util.Map<String, ?> map) throws Exception {
            GetDefineDataResponseBodyList self = new GetDefineDataResponseBodyList();
            return TeaModel.build(map, self);
        }

        public GetDefineDataResponseBodyList setDataCode(String dataCode) {
            this.dataCode = dataCode;
            return this;
        }
        public String getDataCode() {
            return this.dataCode;
        }

        public GetDefineDataResponseBodyList setDefineCode(String defineCode) {
            this.defineCode = defineCode;
            return this;
        }
        public String getDefineCode() {
            return this.defineCode;
        }

        public GetDefineDataResponseBodyList setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public GetDefineDataResponseBodyList setParentDataCode(String parentDataCode) {
            this.parentDataCode = parentDataCode;
            return this;
        }
        public String getParentDataCode() {
            return this.parentDataCode;
        }

        public GetDefineDataResponseBodyList setStatus(String status) {
            this.status = status;
            return this;
        }
        public String getStatus() {
            return this.status;
        }

    }

}
