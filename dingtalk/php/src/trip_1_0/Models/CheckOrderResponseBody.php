<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vtrip_1_0\Models;

use AlibabaCloud\Tea\Model;

class CheckOrderResponseBody extends Model
{
    /**
     * @var string
     */
    public $errMsg;

    /**
     * @var bool
     */
    public $result;
    protected $_name = [
        'errMsg' => 'errMsg',
        'result' => 'result',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->errMsg) {
            $res['errMsg'] = $this->errMsg;
        }
        if (null !== $this->result) {
            $res['result'] = $this->result;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CheckOrderResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['errMsg'])) {
            $model->errMsg = $map['errMsg'];
        }
        if (isset($map['result'])) {
            $model->result = $map['result'];
        }

        return $model;
    }
}
