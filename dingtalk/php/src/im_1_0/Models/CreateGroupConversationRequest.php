<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models;

use AlibabaCloud\Tea\Model;

class CreateGroupConversationRequest extends Model
{
    /**
     * @description 钉外成员列表。
     *
     * @var string[]
     */
    public $appUserIds;

    /**
     * @description 群头像地址。
     *
     * @var string
     */
    public $groupAvatar;

    /**
     * @description 群名称。
     *
     * @var string
     */
    public $groupName;

    /**
     * @description 群主在业务系统内的唯一标识
     *
     * @var string
     */
    public $groupOwnerId;

    /**
     * @description 群主类型<2.钉内用户类型 3.钉外用户类型>，如果不指定的话，默认是钉钉用户类型
     *
     * @var int
     */
    public $groupOwnerType;

    /**
     * @description 群模板Id。
     *
     * @var string
     */
    public $groupTemplateId;

    /**
     * @description 操作者在业务系统内的唯一标识。
     *
     * @var string
     */
    public $operatorId;

    /**
     * @description 钉内成员列表。
     *
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
