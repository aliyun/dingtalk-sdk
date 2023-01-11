// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class CampusUpdateRenterMemberRequest extends TeaModel {
    /**
     * <p>扩展字段</p>
     */
    @NameInMap("extend")
    public String extend;

    /**
     * <p>名字</p>
     */
    @NameInMap("name")
    public String name;

    /**
     * <p>租客id</p>
     */
    @NameInMap("renterId")
    public Long renterId;

    /**
     * <p>类型</p>
     */
    @NameInMap("type")
    public String type;

    /**
     * <p>人员唯一标识</p>
     */
    @NameInMap("unionId")
    public String unionId;

    public static CampusUpdateRenterMemberRequest build(java.util.Map<String, ?> map) throws Exception {
        CampusUpdateRenterMemberRequest self = new CampusUpdateRenterMemberRequest();
        return TeaModel.build(map, self);
    }

    public CampusUpdateRenterMemberRequest setExtend(String extend) {
        this.extend = extend;
        return this;
    }
    public String getExtend() {
        return this.extend;
    }

    public CampusUpdateRenterMemberRequest setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public CampusUpdateRenterMemberRequest setRenterId(Long renterId) {
        this.renterId = renterId;
        return this;
    }
    public Long getRenterId() {
        return this.renterId;
    }

    public CampusUpdateRenterMemberRequest setType(String type) {
        this.type = type;
        return this;
    }
    public String getType() {
        return this.type;
    }

    public CampusUpdateRenterMemberRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

}
