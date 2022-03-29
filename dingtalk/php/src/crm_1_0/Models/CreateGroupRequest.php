<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models;

use AlibabaCloud\Tea\Model;

class CreateGroupRequest extends Model
{
    /**
     * @description 群名称
     *
     * @var string
     */
    public $groupName;

    /**
     * @description 群成员id
     *
     * @var string
     */
    public $memberUserIds;

    /**
     * @description 群主id
     *
     * @var string
     */
    public $ownerUserId;

    /**
     * @description 关系类型
     *
     * @var string
     */
    public $relationType;
    protected $_name = [
        'groupName'     => 'groupName',
        'memberUserIds' => 'memberUserIds',
        'ownerUserId'   => 'ownerUserId',
        'relationType'  => 'relationType',
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
        if (null !== $this->memberUserIds) {
            $res['memberUserIds'] = $this->memberUserIds;
        }
        if (null !== $this->ownerUserId) {
            $res['ownerUserId'] = $this->ownerUserId;
        }
        if (null !== $this->relationType) {
            $res['relationType'] = $this->relationType;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreateGroupRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['groupName'])) {
            $model->groupName = $map['groupName'];
        }
        if (isset($map['memberUserIds'])) {
            $model->memberUserIds = $map['memberUserIds'];
        }
        if (isset($map['ownerUserId'])) {
            $model->ownerUserId = $map['ownerUserId'];
        }
        if (isset($map['relationType'])) {
            $model->relationType = $map['relationType'];
        }

        return $model;
    }
}
