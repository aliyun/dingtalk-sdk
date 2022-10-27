<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\QueryMeetingRoomGroupListResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
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
     * @description 父分组id
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
     * @return result
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
