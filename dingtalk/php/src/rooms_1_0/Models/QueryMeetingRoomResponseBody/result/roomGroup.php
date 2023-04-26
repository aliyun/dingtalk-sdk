<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\QueryMeetingRoomResponseBody\result;

use AlibabaCloud\Tea\Model;

class roomGroup extends Model
{
    /**
     * @example 1
     *
     * @var int
     */
    public $groupId;

    /**
     * @example 测试分组
     *
     * @var string
     */
    public $groupName;

    /**
     * @example 0
     *
     * @var int
     */
    public $parentId;
    protected $_name = [
        'groupId'   => 'groupId',
        'groupName' => 'groupName',
        'parentId'  => 'parentId',
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
        if (null !== $this->parentId) {
            $res['parentId'] = $this->parentId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return roomGroup
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
        if (isset($map['parentId'])) {
            $model->parentId = $map['parentId'];
        }

        return $model;
    }
}
