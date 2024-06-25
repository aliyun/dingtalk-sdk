// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class ListFormRemarksResponseBody extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>{&quot;FINST-GW866DA1NHFZIPNE03UTM88NOAGQ27Q9VUP1L0&quot;:[{&quot;creator&quot;:&quot;manager9358&quot;,&quot;replyUserId&quot;:null,&quot;images&quot;:&quot;[]&quot;,&quot;formInstId&quot;:&quot;FINST-GW866DA1NHFZIPNE03UTM88NOAGQ27Q9VUP1L0&quot;,&quot;replyId&quot;:null,&quot;files&quot;:&quot;[]&quot;,&quot;id&quot;:3261500001,&quot;gmtCreate&quot;:1649387753000,&quot;class&quot;:&quot;com.alibaba.work.tianshu.api.model.form.RemarkVO&quot;,&quot;atUserId&quot;:null,&quot;content&quot;:&quot;评论1&quot;}],&quot;FINST-96766PB1LBZYTVGI52J857AFKWWR3MX3CS41LXM6&quot;:[{&quot;creator&quot;:&quot;manager9358&quot;,&quot;replyUserId&quot;:null,&quot;images&quot;:&quot;[]&quot;,&quot;formInstId&quot;:&quot;FINST-96766PB1LBZYTVGI52J857AFKWWR3MX3CS41LXM6&quot;,&quot;replyId&quot;:null,&quot;files&quot;:&quot;[]&quot;,&quot;id&quot;:3261500003,&quot;gmtCreate&quot;:1649387988000,&quot;class&quot;:&quot;com.alibaba.work.tianshu.api.model.form.RemarkVO&quot;,&quot;atUserId&quot;:null,&quot;content&quot;:&quot;评论4&quot;}]}</p>
     */
    @NameInMap("formRemarkVoMap")
    public java.util.Map<String, ?> formRemarkVoMap;

    public static ListFormRemarksResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ListFormRemarksResponseBody self = new ListFormRemarksResponseBody();
        return TeaModel.build(map, self);
    }

    public ListFormRemarksResponseBody setFormRemarkVoMap(java.util.Map<String, ?> formRemarkVoMap) {
        this.formRemarkVoMap = formRemarkVoMap;
        return this;
    }
    public java.util.Map<String, ?> getFormRemarkVoMap() {
        return this.formRemarkVoMap;
    }

}
