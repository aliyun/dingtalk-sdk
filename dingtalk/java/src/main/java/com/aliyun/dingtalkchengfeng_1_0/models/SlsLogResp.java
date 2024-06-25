// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkchengfeng_1_0.models;

import com.aliyun.tea.*;

public class SlsLogResp extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>新增</p>
     */
    @NameInMap("action")
    public String action;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>HolidayChangeRecord</p>
     */
    @NameInMap("entity")
    public String entity;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>0ba35cd517156543461401313d12b4|null</p>
     */
    @NameInMap("header")
    public String header;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>123</p>
     */
    @NameInMap("id")
    public String id;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>提交申请</p>
     */
    @NameInMap("info")
    public String info;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>维同</p>
     */
    @NameInMap("operator")
    public String operator;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>橙奕科技</p>
     */
    @NameInMap("tenant")
    public String tenant;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>2</p>
     */
    @NameInMap("tenantId")
    public String tenantId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>1638892800000</p>
     */
    @NameInMap("time")
    public Long time;

    public static SlsLogResp build(java.util.Map<String, ?> map) throws Exception {
        SlsLogResp self = new SlsLogResp();
        return TeaModel.build(map, self);
    }

    public SlsLogResp setAction(String action) {
        this.action = action;
        return this;
    }
    public String getAction() {
        return this.action;
    }

    public SlsLogResp setEntity(String entity) {
        this.entity = entity;
        return this;
    }
    public String getEntity() {
        return this.entity;
    }

    public SlsLogResp setHeader(String header) {
        this.header = header;
        return this;
    }
    public String getHeader() {
        return this.header;
    }

    public SlsLogResp setId(String id) {
        this.id = id;
        return this;
    }
    public String getId() {
        return this.id;
    }

    public SlsLogResp setInfo(String info) {
        this.info = info;
        return this;
    }
    public String getInfo() {
        return this.info;
    }

    public SlsLogResp setOperator(String operator) {
        this.operator = operator;
        return this;
    }
    public String getOperator() {
        return this.operator;
    }

    public SlsLogResp setTenant(String tenant) {
        this.tenant = tenant;
        return this;
    }
    public String getTenant() {
        return this.tenant;
    }

    public SlsLogResp setTenantId(String tenantId) {
        this.tenantId = tenantId;
        return this;
    }
    public String getTenantId() {
        return this.tenantId;
    }

    public SlsLogResp setTime(Long time) {
        this.time = time;
        return this;
    }
    public Long getTime() {
        return this.time;
    }

}
