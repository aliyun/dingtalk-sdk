// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdingmi_1_0.models;

import com.aliyun.tea.*;

public class AskRobotResponseBody extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>{&quot;sessionUuid&quot;:&quot;op_2c35e603af6c4e62bcf5xxxx&quot;,&quot;answerType&quot;:&quot;recommendAnswer&quot;,&quot;recommendAnswerContent&quot;:[&quot;通讯录上人员可以排序吗？&quot;]}</p>
     */
    @NameInMap("result")
    public String result;

    public static AskRobotResponseBody build(java.util.Map<String, ?> map) throws Exception {
        AskRobotResponseBody self = new AskRobotResponseBody();
        return TeaModel.build(map, self);
    }

    public AskRobotResponseBody setResult(String result) {
        this.result = result;
        return this;
    }
    public String getResult() {
        return this.result;
    }

}
