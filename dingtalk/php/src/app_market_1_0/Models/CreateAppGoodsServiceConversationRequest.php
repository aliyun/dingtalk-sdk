<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vapp_market_1_0\Models;

use AlibabaCloud\Tea\Model;

class CreateAppGoodsServiceConversationRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $isvUserId;

    /**
     * @description This parameter is required.
     *
     * @var int
     */
    public $orderId;
    protected $_name = [
        'isvUserId' => 'isvUserId',
        'orderId'   => 'orderId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->isvUserId) {
            $res['isvUserId'] = $this->isvUserId;
        }
        if (null !== $this->orderId) {
            $res['orderId'] = $this->orderId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreateAppGoodsServiceConversationRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['isvUserId'])) {
            $model->isvUserId = $map['isvUserId'];
        }
        if (isset($map['orderId'])) {
            $model->orderId = $map['orderId'];
        }

        return $model;
    }
}
