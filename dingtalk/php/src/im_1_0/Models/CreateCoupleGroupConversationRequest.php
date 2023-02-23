<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models;

use AlibabaCloud\Tea\Model;

class CreateCoupleGroupConversationRequest extends Model
{
    /**
     * @description 钉外账号在业务系统内的唯一标识。
     *
     * @var string
     */
    public $appUserId;

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
    protected $_name = [
        'appUserId'       => 'appUserId',
        'groupAvatar'     => 'groupAvatar',
        'groupName'       => 'groupName',
        'groupOwnerId'    => 'groupOwnerId',
        'groupTemplateId' => 'groupTemplateId',
        'operatorId'      => 'operatorId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->appUserId) {
            $res['appUserId'] = $this->appUserId;
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
        if (null !== $this->groupTemplateId) {
            $res['groupTemplateId'] = $this->groupTemplateId;
        }
        if (null !== $this->operatorId) {
            $res['operatorId'] = $this->operatorId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreateCoupleGroupConversationRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['appUserId'])) {
            $model->appUserId = $map['appUserId'];
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
        if (isset($map['groupTemplateId'])) {
            $model->groupTemplateId = $map['groupTemplateId'];
        }
        if (isset($map['operatorId'])) {
            $model->operatorId = $map['operatorId'];
        }

        return $model;
    }
}
