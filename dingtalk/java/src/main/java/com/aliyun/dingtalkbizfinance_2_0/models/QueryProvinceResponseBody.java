// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_2_0.models;

import com.aliyun.tea.*;

public class QueryProvinceResponseBody extends TeaModel {
    @NameInMap("provinces")
    public java.util.List<QueryProvinceResponseBodyProvinces> provinces;

    public static QueryProvinceResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryProvinceResponseBody self = new QueryProvinceResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryProvinceResponseBody setProvinces(java.util.List<QueryProvinceResponseBodyProvinces> provinces) {
        this.provinces = provinces;
        return this;
    }
    public java.util.List<QueryProvinceResponseBodyProvinces> getProvinces() {
        return this.provinces;
    }

    public static class QueryProvinceResponseBodyProvinces extends TeaModel {
        @NameInMap("name")
        public String name;

        public static QueryProvinceResponseBodyProvinces build(java.util.Map<String, ?> map) throws Exception {
            QueryProvinceResponseBodyProvinces self = new QueryProvinceResponseBodyProvinces();
            return TeaModel.build(map, self);
        }

        public QueryProvinceResponseBodyProvinces setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

    }

}
