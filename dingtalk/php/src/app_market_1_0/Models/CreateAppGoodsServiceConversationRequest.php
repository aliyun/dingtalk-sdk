<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vapp_market_1_0\Models;

use AlibabaCloud\Tea\Model;

class CreateAppGoodsServiceConversationRequest extends Model
{
    /**
     * @var int
     */
    public $orderId;

    /**
     * @var string
     */
    public $isvUserId;
    protected $_name = [
        'orderId'   => 'orderId',
        'isvUserId' => 'isvUserId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->orderId) {
            $res['orderId'] = $this->orderId;
        }
        if (null !== $this->isvUserId) {
            $res['isvUserId'] = $this->isvUserId;
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
        if (isset($map['orderId'])) {
            $model->orderId = $map['orderId'];
        }
        if (isset($map['isvUserId'])) {
            $model->isvUserId = $map['isvUserId'];
        }

        return $model;
    }
}
