<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models;

use AlibabaCloud\Tea\Model;

class UpdateMeetingRoomGroupRequest extends Model
{
    /**
     * @description 分组id
     *
     * @var int
     */
    public $groupId;

    /**
     * @description 分组名称
     *
     * @var string
     */
    public $groupName;

    /**
     * @description 操作人unionId
     *
     * @var string
     */
    public $unionId;
    protected $_name = [
        'groupId'   => 'groupId',
        'groupName' => 'groupName',
        'unionId'   => 'unionId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->groupId) {
            $res['groupId'] = $this->groupId;
        }
        if (null !== $this->groupName) {
            $res['groupName'] = $this->groupName;
        }
        if (null !== $this->unionId) {
            $res['unionId'] = $this->unionId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UpdateMeetingRoomGroupRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['groupId'])) {
            $model->groupId = $map['groupId'];
        }
        if (isset($map['groupName'])) {
            $model->groupName = $map['groupName'];
        }
        if (isset($map['unionId'])) {
            $model->unionId = $map['unionId'];
        }

        return $model;
    }
}
