// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class GetNavigationCatalogResponseBody extends TeaModel {
    @NameInMap("result")
    public GetNavigationCatalogResponseBodyResult result;

    public static GetNavigationCatalogResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetNavigationCatalogResponseBody self = new GetNavigationCatalogResponseBody();
        return TeaModel.build(map, self);
    }

    public GetNavigationCatalogResponseBody setResult(GetNavigationCatalogResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public GetNavigationCatalogResponseBodyResult getResult() {
        return this.result;
    }

    public static class GetNavigationCatalogResponseBodyResultNavCatalog extends TeaModel {
        @NameInMap("children")
        public Object children;

        @NameInMap("navCode")
        public String navCode;

        @NameInMap("navId")
        public String navId;

        @NameInMap("navName")
        public String navName;

        @NameInMap("navType")
        public String navType;

        public static GetNavigationCatalogResponseBodyResultNavCatalog build(java.util.Map<String, ?> map) throws Exception {
            GetNavigationCatalogResponseBodyResultNavCatalog self = new GetNavigationCatalogResponseBodyResultNavCatalog();
            return TeaModel.build(map, self);
        }

        public GetNavigationCatalogResponseBodyResultNavCatalog setChildren(Object children) {
            this.children = children;
            return this;
        }
        public Object getChildren() {
            return this.children;
        }

        public GetNavigationCatalogResponseBodyResultNavCatalog setNavCode(String navCode) {
            this.navCode = navCode;
            return this;
        }
        public String getNavCode() {
            return this.navCode;
        }

        public GetNavigationCatalogResponseBodyResultNavCatalog setNavId(String navId) {
            this.navId = navId;
            return this;
        }
        public String getNavId() {
            return this.navId;
        }

        public GetNavigationCatalogResponseBodyResultNavCatalog setNavName(String navName) {
            this.navName = navName;
            return this;
        }
        public String getNavName() {
            return this.navName;
        }

        public GetNavigationCatalogResponseBodyResultNavCatalog setNavType(String navType) {
            this.navType = navType;
            return this;
        }
        public String getNavType() {
            return this.navType;
        }

    }

    public static class GetNavigationCatalogResponseBodyResult extends TeaModel {
        @NameInMap("bizTraceId")
        public String bizTraceId;

        @NameInMap("module")
        public String module;

        @NameInMap("navCatalog")
        public java.util.List<GetNavigationCatalogResponseBodyResultNavCatalog> navCatalog;

        public static GetNavigationCatalogResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            GetNavigationCatalogResponseBodyResult self = new GetNavigationCatalogResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public GetNavigationCatalogResponseBodyResult setBizTraceId(String bizTraceId) {
            this.bizTraceId = bizTraceId;
            return this;
        }
        public String getBizTraceId() {
            return this.bizTraceId;
        }

        public GetNavigationCatalogResponseBodyResult setModule(String module) {
            this.module = module;
            return this;
        }
        public String getModule() {
            return this.module;
        }

        public GetNavigationCatalogResponseBodyResult setNavCatalog(java.util.List<GetNavigationCatalogResponseBodyResultNavCatalog> navCatalog) {
            this.navCatalog = navCatalog;
            return this;
        }
        public java.util.List<GetNavigationCatalogResponseBodyResultNavCatalog> getNavCatalog() {
            return this.navCatalog;
        }

    }

}
