<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models;

use AlibabaCloud\Tea\Model;

class DeleteMeetingRoomControlPanelRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var string[]
     */
    public $roomIds;

    /**
     * @description This parameter is required.
     *
     * @example A1FAxxxxx
     *
     * @var string
     */
    public $unionId;
    protected $_name = [
        'roomIds' => 'roomIds',
        'unionId' => 'unionId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->roomIds) {
            $res['roomIds'] = $this->roomIds;
        }
        if (null !== $this->unionId) {
            $res['unionId'] = $this->unionId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return DeleteMeetingRoomControlPanelRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['roomIds'])) {
            if (!empty($map['roomIds'])) {
                $model->roomIds = $map['roomIds'];
            }
        }
        if (isset($map['unionId'])) {
            $model->unionId = $map['unionId'];
        }

        return $model;
    }
}
