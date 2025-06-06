// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class DocUpdateContentWithDelegatedPermissionRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>content</p>
     */
    @NameInMap("content")
    public String content;

    /**
     * <strong>example:</strong>
     * <p>data_type</p>
     */
    @NameInMap("dataType")
    public String dataType;

    public static DocUpdateContentWithDelegatedPermissionRequest build(java.util.Map<String, ?> map) throws Exception {
        DocUpdateContentWithDelegatedPermissionRequest self = new DocUpdateContentWithDelegatedPermissionRequest();
        return TeaModel.build(map, self);
    }

    public DocUpdateContentWithDelegatedPermissionRequest setContent(String content) {
        this.content = content;
        return this;
    }
    public String getContent() {
        return this.content;
    }

    public DocUpdateContentWithDelegatedPermissionRequest setDataType(String dataType) {
        this.dataType = dataType;
        return this;
    }
    public String getDataType() {
        return this.dataType;
    }

}
