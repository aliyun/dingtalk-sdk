// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class DocUpdateContentRequest extends TeaModel {
    @NameInMap("content")
    public String content;

    @NameInMap("dataType")
    public String dataType;

    @NameInMap("operatorId")
    public String operatorId;

    public static DocUpdateContentRequest build(java.util.Map<String, ?> map) throws Exception {
        DocUpdateContentRequest self = new DocUpdateContentRequest();
        return TeaModel.build(map, self);
    }

    public DocUpdateContentRequest setContent(String content) {
        this.content = content;
        return this;
    }
    public String getContent() {
        return this.content;
    }

    public DocUpdateContentRequest setDataType(String dataType) {
        this.dataType = dataType;
        return this;
    }
    public String getDataType() {
        return this.dataType;
    }

    public DocUpdateContentRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

}
