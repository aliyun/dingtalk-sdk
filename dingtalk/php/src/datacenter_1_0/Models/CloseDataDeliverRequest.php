<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models;

use AlibabaCloud\Tea\Model;

class CloseDataDeliverRequest extends Model
{
    /**
     * @example DELIVER-3e1a2d2f-fa76-45e8-XXXX-7fd29307c859
     *
     * @var string
     */
    public $deliverId;

    /**
     * @example RT
     *
     * @var string
     */
    public $dispatchingItemType;
    protected $_name = [
        'deliverId'           => 'deliverId',
        'dispatchingItemType' => 'dispatchingItemType',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->deliverId) {
            $res['deliverId'] = $this->deliverId;
        }
        if (null !== $this->dispatchingItemType) {
            $res['dispatchingItemType'] = $this->dispatchingItemType;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CloseDataDeliverRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['deliverId'])) {
            $model->deliverId = $map['deliverId'];
        }
        if (isset($map['dispatchingItemType'])) {
            $model->dispatchingItemType = $map['dispatchingItemType'];
        }

        return $model;
    }
}
