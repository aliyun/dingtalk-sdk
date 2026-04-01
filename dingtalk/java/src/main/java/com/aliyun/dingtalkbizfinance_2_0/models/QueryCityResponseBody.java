// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_2_0.models;

import com.aliyun.tea.*;

public class QueryCityResponseBody extends TeaModel {
    @NameInMap("citys")
    public java.util.List<QueryCityResponseBodyCitys> citys;

    public static QueryCityResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryCityResponseBody self = new QueryCityResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryCityResponseBody setCitys(java.util.List<QueryCityResponseBodyCitys> citys) {
        this.citys = citys;
        return this;
    }
    public java.util.List<QueryCityResponseBodyCitys> getCitys() {
        return this.citys;
    }

    public static class QueryCityResponseBodyCitys extends TeaModel {
        @NameInMap("name")
        public String name;

        public static QueryCityResponseBodyCitys build(java.util.Map<String, ?> map) throws Exception {
            QueryCityResponseBodyCitys self = new QueryCityResponseBodyCitys();
            return TeaModel.build(map, self);
        }

        public QueryCityResponseBodyCitys setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

    }

}
