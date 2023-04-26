<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models;

use AlibabaCloud\Tea\Model;

class CreateGroupConversationRequest extends Model
{
    /**
     * @var string[]
     */
    public $appUserIds;

    /**
     * @example http://***.png
     *
     * @var string
     */
    public $groupAvatar;

    /**
     * @example 客户群
     *
     * @var string
     */
    public $groupName;

    /**
     * @example 1745****8777
     *
     * @var string
     */
    public $groupOwnerId;

    /**
     * @example 3
     *
     * @var int
     */
    public $groupOwnerType;

    /**
     * @example 8d42****nkld
     *
     * @var string
     */
    public $groupTemplateId;

    /**
     * @example 1745****8777
     *
     * @var string
     */
    public $operatorId;

    /**
     * @var string[]
     */
    public $userIds;
    protected $_name = [
        'appUserIds'      => 'appUserIds',
        'groupAvatar'     => 'groupAvatar',
        'groupName'       => 'groupName',
        'groupOwnerId'    => 'groupOwnerId',
        'groupOwnerType'  => 'groupOwnerType',
        'groupTemplateId' => 'groupTemplateId',
        'operatorId'      => 'operatorId',
        'userIds'         => 'userIds',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->appUserIds) {
            $res['appUserIds'] = $this->appUserIds;
        }
        if (null !== $this->groupAvatar) {
            $res['groupAvatar'] = $this->groupAvatar;
        }
        if (null !== $this->groupName) {
            $res['groupName'] = $this->groupName;
        }
        if (null !== $this->groupOwnerId) {
            $res['groupOwnerId'] = $this->groupOwnerId;
        }
        if (null !== $this->groupOwnerType) {
            $res['groupOwnerType'] = $this->groupOwnerType;
        }
        if (null !== $this->groupTemplateId) {
            $res['groupTemplateId'] = $this->groupTemplateId;
        }
        if (null !== $this->operatorId) {
            $res['operatorId'] = $this->operatorId;
        }
        if (null !== $this->userIds) {
            $res['userIds'] = $this->userIds;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreateGroupConversationRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['appUserIds'])) {
            if (!empty($map['appUserIds'])) {
                $model->appUserIds = $map['appUserIds'];
            }
        }
        if (isset($map['groupAvatar'])) {
            $model->groupAvatar = $map['groupAvatar'];
        }
        if (isset($map['groupName'])) {
            $model->groupName = $map['groupName'];
        }
        if (isset($map['groupOwnerId'])) {
            $model->groupOwnerId = $map['groupOwnerId'];
        }
        if (isset($map['groupOwnerType'])) {
            $model->groupOwnerType = $map['groupOwnerType'];
        }
        if (isset($map['groupTemplateId'])) {
            $model->groupTemplateId = $map['groupTemplateId'];
        }
        if (isset($map['operatorId'])) {
            $model->operatorId = $map['operatorId'];
        }
        if (isset($map['userIds'])) {
            if (!empty($map['userIds'])) {
                $model->userIds = $map['userIds'];
            }
        }

        return $model;
    }
}
