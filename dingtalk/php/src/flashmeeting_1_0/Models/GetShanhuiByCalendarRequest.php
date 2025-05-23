<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vflashmeeting_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetShanhuiByCalendarRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example VGZCWXpvTmxpQmorbUhiSXUveTB98Iok
     *
     * @var string
     */
    public $eventId;

    /**
     * @description This parameter is required.
     *
     * @example EUiSN7beu1Q2wR
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'eventId' => 'eventId',
        'userId' => 'userId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->eventId) {
            $res['eventId'] = $this->eventId;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetShanhuiByCalendarRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['eventId'])) {
            $model->eventId = $map['eventId'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
