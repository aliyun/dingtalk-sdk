// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalksearch_1_0.models;

import com.aliyun.tea.*;

public class UpdateSearchTabRequest extends TeaModel {
    @NameInMap("darkIcon")
    public String darkIcon;

    /**
     * <strong>if can be null:</strong>
     * <p>false</p>
     */
    @NameInMap("icon")
    public String icon;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>专辑</p>
     */
    @NameInMap("name")
    public String name;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>1</p>
     */
    @NameInMap("priority")
    public Integer priority;

    @NameInMap("source")
    public String source;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>1</p>
     */
    @NameInMap("status")
    public Integer status;

    public static UpdateSearchTabRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateSearchTabRequest self = new UpdateSearchTabRequest();
        return TeaModel.build(map, self);
    }

    public UpdateSearchTabRequest setDarkIcon(String darkIcon) {
        this.darkIcon = darkIcon;
        return this;
    }
    public String getDarkIcon() {
        return this.darkIcon;
    }

    public UpdateSearchTabRequest setIcon(String icon) {
        this.icon = icon;
        return this;
    }
    public String getIcon() {
        return this.icon;
    }

    public UpdateSearchTabRequest setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public UpdateSearchTabRequest setPriority(Integer priority) {
        this.priority = priority;
        return this;
    }
    public Integer getPriority() {
        return this.priority;
    }

    public UpdateSearchTabRequest setSource(String source) {
        this.source = source;
        return this;
    }
    public String getSource() {
        return this.source;
    }

    public UpdateSearchTabRequest setStatus(Integer status) {
        this.status = status;
        return this;
    }
    public Integer getStatus() {
        return this.status;
    }

}
