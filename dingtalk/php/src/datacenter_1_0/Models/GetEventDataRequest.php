<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetEventDataRequest extends Model
{
    /**
     * @var string
     */
    public $bizId;

    /**
     * @description This parameter is required.
     *
     * @example 819e50d7c32e9096
     *
     * @var string
     */
    public $eventUid;

    /**
     * @var string
     */
    public $subId;
    protected $_name = [
        'bizId'    => 'bizId',
        'eventUid' => 'eventUid',
        'subId'    => 'subId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->bizId) {
            $res['bizId'] = $this->bizId;
        }
        if (null !== $this->eventUid) {
            $res['eventUid'] = $this->eventUid;
        }
        if (null !== $this->subId) {
            $res['subId'] = $this->subId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetEventDataRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['bizId'])) {
            $model->bizId = $map['bizId'];
        }
        if (isset($map['eventUid'])) {
            $model->eventUid = $map['eventUid'];
        }
        if (isset($map['subId'])) {
            $model->subId = $map['subId'];
        }

        return $model;
    }
}
