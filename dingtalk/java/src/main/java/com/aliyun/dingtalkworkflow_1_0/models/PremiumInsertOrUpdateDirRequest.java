// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class PremiumInsertOrUpdateDirRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>administeration</p>
     */
    @NameInMap("bizGroup")
    public String bizGroup;

    /**
     * <strong>example:</strong>
     * <p>分组描述信息</p>
     */
    @NameInMap("description")
    public String description;

    /**
     * <strong>example:</strong>
     * <p>行政管理</p>
     */
    @NameInMap("name")
    public String name;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>{&quot;en_US&quot;:&quot;test&quot;,&quot;ja_JP&quot;:&quot;test&quot;,&quot;vi_VN&quot;:&quot;test&quot;,&quot;zh_CN&quot;:&quot;测试&quot;,&quot;zh_HK&quot;:&quot;测试&quot;,&quot;zh_TW&quot;:&quot;测试&quot;}</p>
     */
    @NameInMap("name18n")
    public String name18n;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>user001</p>
     */
    @NameInMap("operateUserId")
    public String operateUserId;

    public static PremiumInsertOrUpdateDirRequest build(java.util.Map<String, ?> map) throws Exception {
        PremiumInsertOrUpdateDirRequest self = new PremiumInsertOrUpdateDirRequest();
        return TeaModel.build(map, self);
    }

    public PremiumInsertOrUpdateDirRequest setBizGroup(String bizGroup) {
        this.bizGroup = bizGroup;
        return this;
    }
    public String getBizGroup() {
        return this.bizGroup;
    }

    public PremiumInsertOrUpdateDirRequest setDescription(String description) {
        this.description = description;
        return this;
    }
    public String getDescription() {
        return this.description;
    }

    public PremiumInsertOrUpdateDirRequest setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public PremiumInsertOrUpdateDirRequest setName18n(String name18n) {
        this.name18n = name18n;
        return this;
    }
    public String getName18n() {
        return this.name18n;
    }

    public PremiumInsertOrUpdateDirRequest setOperateUserId(String operateUserId) {
        this.operateUserId = operateUserId;
        return this;
    }
    public String getOperateUserId() {
        return this.operateUserId;
    }

}
