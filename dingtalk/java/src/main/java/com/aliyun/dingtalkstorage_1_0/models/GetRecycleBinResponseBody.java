// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_1_0.models;

import com.aliyun.tea.*;

public class GetRecycleBinResponseBody extends TeaModel {
    /**
     * <p>回收站信息</p>
     */
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
         * <p>回收站id</p>
         */
        @NameInMap("id")
        public String id;

        /**
         * <p>回收站范围类型</p>
         * <p>枚举值:</p>
         * <p>	ORG: 企业</p>
         * <p>	APP: 应用</p>
         * <p>	SPACE: 空间</p>
         */
        @NameInMap("scope")
        public String scope;

        /**
         * <p>回收站范围id</p>
         * <p>根据recycleBinScope传入对应的企业、应用、空间ID</p>
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
