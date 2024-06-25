// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class ListOperationLogsResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>{&quot;FINST-GW866DA1NHFZIPNE03UTM88NOAGQ27Q9VUP1L0&quot;:[{&quot;currentText&quot;:null,&quot;componentType&quot;:null,&quot;gmtModified&quot;:&quot;2022-04-08 11:15:34&quot;,&quot;preText&quot;:null,&quot;operationType&quot;:&quot;CREATE&quot;,&quot;componentName&quot;:&quot;&quot;,&quot;operator&quot;:{&quot;userInfo&quot;:null,&quot;tbWang&quot;:null,&quot;depDesc&quot;:null,&quot;displayName&quot;:&quot;娄修俊&quot;,&quot;mastedataDeptments&quot;:null,&quot;orderNum&quot;:null,&quot;displayEnName&quot;:null,&quot;userId&quot;:null,&quot;personalPhoto&quot;:null,&quot;status&quot;:null},&quot;fieldId&quot;:null}]}</p>
     */
    @NameInMap("operationLogMap")
    public java.util.Map<String, ?> operationLogMap;

    public static ListOperationLogsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ListOperationLogsResponseBody self = new ListOperationLogsResponseBody();
        return TeaModel.build(map, self);
    }

    public ListOperationLogsResponseBody setOperationLogMap(java.util.Map<String, ?> operationLogMap) {
        this.operationLogMap = operationLogMap;
        return this;
    }
    public java.util.Map<String, ?> getOperationLogMap() {
        return this.operationLogMap;
    }

}
