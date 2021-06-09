// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcustomer_service_1_0.models;

import com.aliyun.tea.*;

public class GetUserSourceListResponseBody extends TeaModel {
    @NameInMap("result")
    public java.util.List<GetUserSourceListResponseBodyResult> result;

    public static GetUserSourceListResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetUserSourceListResponseBody self = new GetUserSourceListResponseBody();
        return TeaModel.build(map, self);
    }

    public GetUserSourceListResponseBody setResult(java.util.List<GetUserSourceListResponseBodyResult> result) {
        this.result = result;
        return this;
    }
    public java.util.List<GetUserSourceListResponseBodyResult> getResult() {
        return this.result;
    }

    public static class GetUserSourceListResponseBodyResult extends TeaModel {
        @NameInMap("id")
        public Long id;

        @NameInMap("status")
        public Integer status;

        @NameInMap("description")
        public String description;

        @NameInMap("config")
        public String config;

        @NameInMap("vendor")
        public String vendor;

        @NameInMap("name")
        public String name;

        public static GetUserSourceListResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            GetUserSourceListResponseBodyResult self = new GetUserSourceListResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public GetUserSourceListResponseBodyResult setId(Long id) {
            this.id = id;
            return this;
        }
        public Long getId() {
            return this.id;
        }

        public GetUserSourceListResponseBodyResult setStatus(Integer status) {
            this.status = status;
            return this;
        }
        public Integer getStatus() {
            return this.status;
        }

        public GetUserSourceListResponseBodyResult setDescription(String description) {
            this.description = description;
            return this;
        }
        public String getDescription() {
            return this.description;
        }

        public GetUserSourceListResponseBodyResult setConfig(String config) {
            this.config = config;
            return this;
        }
        public String getConfig() {
            return this.config;
        }

        public GetUserSourceListResponseBodyResult setVendor(String vendor) {
            this.vendor = vendor;
            return this;
        }
        public String getVendor() {
            return this.vendor;
        }

        public GetUserSourceListResponseBodyResult setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

    }

}
