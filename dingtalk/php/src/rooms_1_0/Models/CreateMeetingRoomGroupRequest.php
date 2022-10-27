<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models;

use AlibabaCloud\Tea\Model;

class CreateMeetingRoomGroupRequest extends Model
{
    /**
     * @description 分组名称
     *
     * @var string
     */
    public $groupName;

    /**
     * @description 父分组id
     *
     * @var int
     */
    public $parentGroupId;

    /**
     * @description 操作人unionId
     *
     * @var string
     */
    public $unionId;
    protected $_name = [
        'groupName'     => 'groupName',
        'parentGroupId' => 'parentGroupId',
        'unionId'       => 'unionId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->groupName) {
            $res['groupName'] = $this->groupName;
        }
        if (null !== $this->parentGroupId) {
            $res['parentGroupId'] = $this->parentGroupId;
        }
        if (null !== $this->unionId) {
            $res['unionId'] = $this->unionId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreateMeetingRoomGroupRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['groupName'])) {
            $model->groupName = $map['groupName'];
        }
        if (isset($map['parentGroupId'])) {
            $model->parentGroupId = $map['parentGroupId'];
        }
        if (isset($map['unionId'])) {
            $model->unionId = $map['unionId'];
        }

        return $model;
    }
}
