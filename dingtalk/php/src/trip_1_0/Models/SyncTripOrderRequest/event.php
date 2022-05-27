<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vtrip_1_0\Models\SyncTripOrderRequest;

use AlibabaCloud\Tea\Model;

class event extends Model
{
    /**
     * @description 订单事件
     *
     * @var string
     */
    public $action;

    /**
     * @description 事件时间
     *
     * @var string
     */
    public $gmtAction;
    protected $_name = [
        'action'    => 'action',
        'gmtAction' => 'gmtAction',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->action) {
            $res['action'] = $this->action;
        }
        if (null !== $this->gmtAction) {
            $res['gmtAction'] = $this->gmtAction;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return event
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['action'])) {
            $model->action = $map['action'];
        }
        if (isset($map['gmtAction'])) {
            $model->gmtAction = $map['gmtAction'];
        }

        return $model;
    }
}
