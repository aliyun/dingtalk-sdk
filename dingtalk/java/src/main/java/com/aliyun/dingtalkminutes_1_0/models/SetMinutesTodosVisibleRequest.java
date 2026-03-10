// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkminutes_1_0.models;

import com.aliyun.tea.*;

public class SetMinutesTodosVisibleRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>false</p>
     */
    @NameInMap("todosVisible")
    public Boolean todosVisible;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>lJcRnm39OsU4jlFVmRGXXXXX</p>
     */
    @NameInMap("unionId")
    public String unionId;

    public static SetMinutesTodosVisibleRequest build(java.util.Map<String, ?> map) throws Exception {
        SetMinutesTodosVisibleRequest self = new SetMinutesTodosVisibleRequest();
        return TeaModel.build(map, self);
    }

    public SetMinutesTodosVisibleRequest setTodosVisible(Boolean todosVisible) {
        this.todosVisible = todosVisible;
        return this;
    }
    public Boolean getTodosVisible() {
        return this.todosVisible;
    }

    public SetMinutesTodosVisibleRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

}
