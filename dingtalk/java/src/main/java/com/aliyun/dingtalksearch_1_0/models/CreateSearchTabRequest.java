// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalksearch_1_0.models;

import com.aliyun.tea.*;

public class CreateSearchTabRequest extends TeaModel {
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
     * <p>书籍</p>
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

    public static CreateSearchTabRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateSearchTabRequest self = new CreateSearchTabRequest();
        return TeaModel.build(map, self);
    }

    public CreateSearchTabRequest setDarkIcon(String darkIcon) {
        this.darkIcon = darkIcon;
        return this;
    }
    public String getDarkIcon() {
        return this.darkIcon;
    }

    public CreateSearchTabRequest setIcon(String icon) {
        this.icon = icon;
        return this;
    }
    public String getIcon() {
        return this.icon;
    }

    public CreateSearchTabRequest setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public CreateSearchTabRequest setPriority(Integer priority) {
        this.priority = priority;
        return this;
    }
    public Integer getPriority() {
        return this.priority;
    }

    public CreateSearchTabRequest setSource(String source) {
        this.source = source;
        return this;
    }
    public String getSource() {
        return this.source;
    }

    public CreateSearchTabRequest setStatus(Integer status) {
        this.status = status;
        return this;
    }
    public Integer getStatus() {
        return this.status;
    }

}
