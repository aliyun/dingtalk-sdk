<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vjzcrm_1_0\Models;

use AlibabaCloud\Tea\Model;

class EditInvoiceResponseBody extends Model
{
    /**
     * @description 响应时间
     *
     * @var string
     */
    public $time;

    /**
     * @description 编辑数据的id
     *
     * @var int
     */
    public $msgid;
    protected $_name = [
        'time'  => 'time',
        'msgid' => 'msgid',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->time) {
            $res['time'] = $this->time;
        }
        if (null !== $this->msgid) {
            $res['msgid'] = $this->msgid;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return EditInvoiceResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['time'])) {
            $model->time = $map['time'];
        }
        if (isset($map['msgid'])) {
            $model->msgid = $map['msgid'];
        }

        return $model;
    }
}
