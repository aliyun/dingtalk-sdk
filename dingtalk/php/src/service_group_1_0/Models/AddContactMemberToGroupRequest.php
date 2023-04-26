<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models;

use AlibabaCloud\Tea\Model;

class AddContactMemberToGroupRequest extends Model
{
    /**
     * @example 不裂变：STANDARD；裂变：FISSION
     *
     * @var string
     */
    public $fissionType;

    /**
     * @example 888
     *
     * @var string
     */
    public $memberUnionId;

    /**
     * @example 1
     *
     * @var string
     */
    public $memberUserId;

    /**
     * @example cid***
     *
     * @var string
     */
    public $openConversationId;

    /**
     * @example 888
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
