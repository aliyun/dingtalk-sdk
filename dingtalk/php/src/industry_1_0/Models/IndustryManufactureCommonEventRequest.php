<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models;

use AlibabaCloud\Tea\Model;

class IndustryManufactureCommonEventRequest extends Model
{
    /**
     * @var string
     */
    public $action;

    /**
     * @var string
     */
    public $appKey;

    /**
     * @var mixed[]
     */
    public $bizData;

    /**
     * @var string[]
     */
    public $eventType;
    protected $_name = [
        'action'    => 'action',
        'appKey'    => 'appKey',
        'bizData'   => 'bizData',
        'eventType' => 'eventType',
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
        if (null !== $this->appKey) {
            $res['appKey'] = $this->appKey;
        }
        if (null !== $this->bizData) {
            $res['bizData'] = $this->bizData;
        }
        if (null !== $this->eventType) {
            $res['eventType'] = $this->eventType;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return IndustryManufactureCommonEventRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['action'])) {
            $model->action = $map['action'];
        }
        if (isset($map['appKey'])) {
            $model->appKey = $map['appKey'];
        }
        if (isset($map['bizData'])) {
            $model->bizData = $map['bizData'];
        }
        if (isset($map['eventType'])) {
            if (!empty($map['eventType'])) {
                $model->eventType = $map['eventType'];
            }
        }

        return $model;
    }
}
