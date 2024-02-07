<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vwatt_1_0\Models;

use AlibabaCloud\Tea\Model;

class SendPopupResponseBody extends Model
{
    /**
     * @var mixed[]
     */
    public $arguments;

    /**
     * @var bool
     */
    public $success;
    protected $_name = [
        'arguments' => 'arguments',
        'success'   => 'success',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->arguments) {
            $res['arguments'] = $this->arguments;
        }
        if (null !== $this->success) {
            $res['success'] = $this->success;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return SendPopupResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['arguments'])) {
            if (!empty($map['arguments'])) {
                $model->arguments = $map['arguments'];
            }
        }
        if (isset($map['success'])) {
            $model->success = $map['success'];
        }

        return $model;
    }
}
