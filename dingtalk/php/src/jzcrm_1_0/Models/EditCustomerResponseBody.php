<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vjzcrm_1_0\Models;

use AlibabaCloud\Tea\Model;

class EditCustomerResponseBody extends Model
{
    /**
     * @var int
     */
    public $msgid;

    /**
     * @var string
     */
    public $time;
    protected $_name = [
        'msgid' => 'msgid',
        'time'  => 'time',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->msgid) {
            $res['msgid'] = $this->msgid;
        }
        if (null !== $this->time) {
            $res['time'] = $this->time;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return EditCustomerResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['msgid'])) {
            $model->msgid = $map['msgid'];
        }
        if (isset($map['time'])) {
            $model->time = $map['time'];
        }

        return $model;
    }
}
