// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class CampusUpdateRenterMemberRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>扩展</p>
     */
    @NameInMap("extend")
    public String extend;

    /**
     * <strong>example:</strong>
     * <p>张三组</p>
     */
    @NameInMap("name")
    public String name;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>41239123</p>
     */
    @NameInMap("renterId")
    public Long renterId;

    /**
     * <strong>example:</strong>
     * <p>1</p>
     */
    @NameInMap("type")
    public String type;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>fksif91273</p>
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
