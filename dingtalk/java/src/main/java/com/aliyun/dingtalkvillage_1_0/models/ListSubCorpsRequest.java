// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkvillage_1_0.models;

import com.aliyun.tea.*;

public class ListSubCorpsRequest extends TeaModel {
    /**
     * <p>是否查询直接下级</p>
     */
    @NameInMap("isOnlyDirect")
    public Boolean isOnlyDirect;

    /**
     * <p>下属组织的组织ID，比如下属镇、村的corpId</p>
     */
    @NameInMap("subCorpId")
    public String subCorpId;

    /**
     * <p>下级指定组织层级列表，组织层级为county,town,community,residential，依次为区/县、乡/镇/街道、社区/村、小区，如果查多个用 '|' 分隔</p>
     */
    @NameInMap("types")
    public String types;

    public static ListSubCorpsRequest build(java.util.Map<String, ?> map) throws Exception {
        ListSubCorpsRequest self = new ListSubCorpsRequest();
        return TeaModel.build(map, self);
    }

    public ListSubCorpsRequest setIsOnlyDirect(Boolean isOnlyDirect) {
        this.isOnlyDirect = isOnlyDirect;
        return this;
    }
    public Boolean getIsOnlyDirect() {
        return this.isOnlyDirect;
    }

    public ListSubCorpsRequest setSubCorpId(String subCorpId) {
        this.subCorpId = subCorpId;
        return this;
    }
    public String getSubCorpId() {
        return this.subCorpId;
    }

    public ListSubCorpsRequest setTypes(String types) {
        this.types = types;
        return this;
    }
    public String getTypes() {
        return this.types;
    }

}
