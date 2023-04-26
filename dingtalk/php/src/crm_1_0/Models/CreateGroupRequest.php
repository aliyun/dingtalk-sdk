<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models;

use AlibabaCloud\Tea\Model;

class CreateGroupRequest extends Model
{
    /**
     * @example abc
     *
     * @var string
     */
    public $groupName;

    /**
     * @example a,b,c
     *
     * @var string
     */
    public $memberUserIds;

    /**
     * @example abc123
     *
     * @var string
     */
    public $ownerUserId;

    /**
     * @example abc
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
