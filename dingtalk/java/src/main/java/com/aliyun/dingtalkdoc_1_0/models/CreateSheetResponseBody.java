// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class CreateSheetResponseBody extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>sheet_id</p>
     */
    @NameInMap("id")
    public String id;

    /**
     * <strong>example:</strong>
     * <p>sheet_name</p>
     */
    @NameInMap("name")
    public String name;

    /**
     * <strong>example:</strong>
     * <p>visible</p>
     */
    @NameInMap("visibility")
    public String visibility;

    public static CreateSheetResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CreateSheetResponseBody self = new CreateSheetResponseBody();
        return TeaModel.build(map, self);
    }

    public CreateSheetResponseBody setId(String id) {
        this.id = id;
        return this;
    }
    public String getId() {
        return this.id;
    }

    public CreateSheetResponseBody setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public CreateSheetResponseBody setVisibility(String visibility) {
        this.visibility = visibility;
        return this;
    }
    public String getVisibility() {
        return this.visibility;
    }

}
