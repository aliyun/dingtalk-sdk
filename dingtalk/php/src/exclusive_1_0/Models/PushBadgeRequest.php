<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\PushBadgeRequest\badgeItems;
use AlibabaCloud\Tea\Model;

class PushBadgeRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 110000000
     *
     * @var string
     */
    public $agentId;

    /**
     * @var badgeItems[]
     */
    public $badgeItems;

    /**
     * @description This parameter is required.
     *
     * @example 0
     *
     * @var string
     */
    public $pushType;
    protected $_name = [
        'agentId' => 'agentId',
        'badgeItems' => 'badgeItems',
        'pushType' => 'pushType',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->agentId) {
            $res['agentId'] = $this->agentId;
        }
        if (null !== $this->badgeItems) {
            $res['badgeItems'] = [];
            if (null !== $this->badgeItems && \is_array($this->badgeItems)) {
                $n = 0;
                foreach ($this->badgeItems as $item) {
                    $res['badgeItems'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->pushType) {
            $res['pushType'] = $this->pushType;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return PushBadgeRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['agentId'])) {
            $model->agentId = $map['agentId'];
        }
        if (isset($map['badgeItems'])) {
            if (!empty($map['badgeItems'])) {
                $model->badgeItems = [];
                $n = 0;
                foreach ($map['badgeItems'] as $item) {
                    $model->badgeItems[$n++] = null !== $item ? badgeItems::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['pushType'])) {
            $model->pushType = $map['pushType'];
        }

        return $model;
    }
}
