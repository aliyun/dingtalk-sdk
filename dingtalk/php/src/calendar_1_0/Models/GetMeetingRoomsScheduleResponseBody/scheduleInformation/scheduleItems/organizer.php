<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\GetMeetingRoomsScheduleResponseBody\scheduleInformation\scheduleItems;

use AlibabaCloud\Tea\Model;

class organizer extends Model
{
    /**
     * @description 组织者名称。
     *
     * @var string
     */
    public $displayName;

    /**
     * @description 组织者unionId。
     *
     * @var string
     */
    public $id;
    protected $_name = [
        'displayName' => 'displayName',
        'id'          => 'id',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->displayName) {
            $res['displayName'] = $this->displayName;
        }
        if (null !== $this->id) {
            $res['id'] = $this->id;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return organizer
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['displayName'])) {
            $model->displayName = $map['displayName'];
        }
        if (isset($map['id'])) {
            $model->id = $map['id'];
        }

        return $model;
    }
}
