<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models;

use AlibabaCloud\Tea\Model;

class GroupCapacityOrderConfirmRequest extends Model
{
    /**
     * @example 066224
     *
     * @var string
     */
    public $operator;

    /**
     * @example FAKE:0-28937rufhjdkslnawdkjsfk
     *
     * @var string
     */
    public $orderId;
    protected $_name = [
        'operator' => 'operator',
        'orderId' => 'orderId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->operator) {
            $res['operator'] = $this->operator;
        }
        if (null !== $this->orderId) {
            $res['orderId'] = $this->orderId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GroupCapacityOrderConfirmRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['operator'])) {
            $model->operator = $map['operator'];
        }
        if (isset($map['orderId'])) {
            $model->orderId = $map['orderId'];
        }

        return $model;
    }
}
