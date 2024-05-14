<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models;

use AlibabaCloud\Tea\Model;

class UpdateTheGroupRolesOfGroupMemberRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example cidXXXXXXX
     *
     * @var string
     */
    public $openConversationId;

    /**
     * @var string[]
     */
    public $openRoleIds;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'openConversationId' => 'openConversationId',
        'openRoleIds'        => 'openRoleIds',
        'userId'             => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->openConversationId) {
            $res['openConversationId'] = $this->openConversationId;
        }
        if (null !== $this->openRoleIds) {
            $res['openRoleIds'] = $this->openRoleIds;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UpdateTheGroupRolesOfGroupMemberRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['openConversationId'])) {
            $model->openConversationId = $map['openConversationId'];
        }
        if (isset($map['openRoleIds'])) {
            if (!empty($map['openRoleIds'])) {
                $model->openRoleIds = $map['openRoleIds'];
            }
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
