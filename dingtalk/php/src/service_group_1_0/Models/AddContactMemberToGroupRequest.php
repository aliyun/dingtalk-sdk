<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models;

use AlibabaCloud\Tea\Model;

class AddContactMemberToGroupRequest extends Model
{
    /**
     * @description 裂变方式
     *
     * @var string
     */
    public $fissionType;

    /**
     * @description 员工unionId
     *
     * @var string
     */
    public $memberUnionId;

    /**
     * @description 员工成员ID
     *
     * @var string
     */
    public $memberUserId;

    /**
     * @description 群会话ID
     *
     * @var string
     */
    public $openConversationId;

    /**
     * @description 开放团队ID
     *
     * @var string
     */
    public $openTeamId;
    protected $_name = [
        'fissionType'        => 'fissionType',
        'memberUnionId'      => 'memberUnionId',
        'memberUserId'       => 'memberUserId',
        'openConversationId' => 'openConversationId',
        'openTeamId'         => 'openTeamId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->fissionType) {
            $res['fissionType'] = $this->fissionType;
        }
        if (null !== $this->memberUnionId) {
            $res['memberUnionId'] = $this->memberUnionId;
        }
        if (null !== $this->memberUserId) {
            $res['memberUserId'] = $this->memberUserId;
        }
        if (null !== $this->openConversationId) {
            $res['openConversationId'] = $this->openConversationId;
        }
        if (null !== $this->openTeamId) {
            $res['openTeamId'] = $this->openTeamId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return AddContactMemberToGroupRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['fissionType'])) {
            $model->fissionType = $map['fissionType'];
        }
        if (isset($map['memberUnionId'])) {
            $model->memberUnionId = $map['memberUnionId'];
        }
        if (isset($map['memberUserId'])) {
            $model->memberUserId = $map['memberUserId'];
        }
        if (isset($map['openConversationId'])) {
            $model->openConversationId = $map['openConversationId'];
        }
        if (isset($map['openTeamId'])) {
            $model->openTeamId = $map['openTeamId'];
        }

        return $model;
    }
}
