// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_2_0.models;

import com.aliyun.tea.*;

public class SetPermissionShareScopeRequest extends TeaModel {
    @NameInMap("option")
    public SetPermissionShareScopeRequestOption option;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>ORG_READ</p>
     */
    @NameInMap("scope")
    public String scope;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>union_id</p>
     */
    @NameInMap("unionId")
    public String unionId;

    public static SetPermissionShareScopeRequest build(java.util.Map<String, ?> map) throws Exception {
        SetPermissionShareScopeRequest self = new SetPermissionShareScopeRequest();
        return TeaModel.build(map, self);
    }

    public SetPermissionShareScopeRequest setOption(SetPermissionShareScopeRequestOption option) {
        this.option = option;
        return this;
    }
    public SetPermissionShareScopeRequestOption getOption() {
        return this.option;
    }

    public SetPermissionShareScopeRequest setScope(String scope) {
        this.scope = scope;
        return this;
    }
    public String getScope() {
        return this.scope;
    }

    public SetPermissionShareScopeRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

    public static class SetPermissionShareScopeRequestOption extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>true</p>
         */
        @NameInMap("canSearch")
        public Boolean canSearch;

        public static SetPermissionShareScopeRequestOption build(java.util.Map<String, ?> map) throws Exception {
            SetPermissionShareScopeRequestOption self = new SetPermissionShareScopeRequestOption();
            return TeaModel.build(map, self);
        }

        public SetPermissionShareScopeRequestOption setCanSearch(Boolean canSearch) {
            this.canSearch = canSearch;
            return this;
        }
        public Boolean getCanSearch() {
            return this.canSearch;
        }

    }

}
