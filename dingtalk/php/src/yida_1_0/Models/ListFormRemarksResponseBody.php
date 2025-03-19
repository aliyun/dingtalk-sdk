<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models;

use AlibabaCloud\Tea\Model;

class ListFormRemarksResponseBody extends Model
{
    /**
     * @example {"FINST-GW866DA1NHFZIPNE03UTM88NOAGQ27Q9VUP1L0":[{"creator":"manager9358","replyUserId":null,"images":"[]","formInstId":"FINST-GW866DA1NHFZIPNE03UTM88NOAGQ27Q9VUP1L0","replyId":null,"files":"[]","id":3261500001,"gmtCreate":1649387753000,"class":"com.alibaba.work.tianshu.api.model.form.RemarkVO","atUserId":null,"content":"评论1"}],"FINST-96766PB1LBZYTVGI52J857AFKWWR3MX3CS41LXM6":[{"creator":"manager9358","replyUserId":null,"images":"[]","formInstId":"FINST-96766PB1LBZYTVGI52J857AFKWWR3MX3CS41LXM6","replyId":null,"files":"[]","id":3261500003,"gmtCreate":1649387988000,"class":"com.alibaba.work.tianshu.api.model.form.RemarkVO","atUserId":null,"content":"评论4"}]}
     *
     * @var mixed[]
     */
    public $formRemarkVoMap;
    protected $_name = [
        'formRemarkVoMap' => 'formRemarkVoMap',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->formRemarkVoMap) {
            $res['formRemarkVoMap'] = $this->formRemarkVoMap;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ListFormRemarksResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['formRemarkVoMap'])) {
            $model->formRemarkVoMap = $map['formRemarkVoMap'];
        }

        return $model;
    }
}
