// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_1_0.models;

import com.aliyun.tea.*;

public class GetRecycleBinResponseBody extends TeaModel {
    @NameInMap("recycleBin")
    public GetRecycleBinResponseBodyRecycleBin recycleBin;

    public static GetRecycleBinResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetRecycleBinResponseBody self = new GetRecycleBinResponseBody();
        return TeaModel.build(map, self);
    }

    public GetRecycleBinResponseBody setRecycleBin(GetRecycleBinResponseBodyRecycleBin recycleBin) {
        this.recycleBin = recycleBin;
        return this;
    }
    public GetRecycleBinResponseBodyRecycleBin getRecycleBin() {
        return this.recycleBin;
    }

    public static class GetRecycleBinResponseBodyRecycleBin extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>recyclebin_id</p>
         */
        @NameInMap("id")
        public String id;

        /**
         * <strong>example:</strong>
         * <p>SPACE</p>
         */
        @NameInMap("scope")
        public String scope;

        /**
         * <strong>example:</strong>
         * <p>scope_id</p>
         */
        @NameInMap("scopeId")
        public String scopeId;

        public static GetRecycleBinResponseBodyRecycleBin build(java.util.Map<String, ?> map) throws Exception {
            GetRecycleBinResponseBodyRecycleBin self = new GetRecycleBinResponseBodyRecycleBin();
            return TeaModel.build(map, self);
        }

        public GetRecycleBinResponseBodyRecycleBin setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public GetRecycleBinResponseBodyRecycleBin setScope(String scope) {
            this.scope = scope;
            return this;
        }
        public String getScope() {
            return this.scope;
        }

        public GetRecycleBinResponseBodyRecycleBin setScopeId(String scopeId) {
            this.scopeId = scopeId;
            return this;
        }
        public String getScopeId() {
            return this.scopeId;
        }

    }

}
