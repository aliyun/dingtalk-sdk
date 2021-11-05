<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\ManagementBuyQuotaRequest\order;
use AlibabaCloud\Tea\Model;

class ManagementBuyQuotaRequest extends Model
{
    /**
     * @description token
     *
     * @var string
     */
    public $token;

    /**
     * @description 用户id
     *
     * @var string
     */
    public $unionId;

    /**
     * @description 订单
     *
     * @var order
     */
    public $order;
    protected $_name = [
        'token'   => 'token',
        'unionId' => 'unionId',
        'order'   => 'order',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->token) {
            $res['token'] = $this->token;
        }
        if (null !== $this->unionId) {
            $res['unionId'] = $this->unionId;
        }
        if (null !== $this->order) {
            $res['order'] = null !== $this->order ? $this->order->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ManagementBuyQuotaRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['token'])) {
            $model->token = $map['token'];
        }
        if (isset($map['unionId'])) {
            $model->unionId = $map['unionId'];
        }
        if (isset($map['order'])) {
            $model->order = order::fromMap($map['order']);
        }

        return $model;
    }
}
