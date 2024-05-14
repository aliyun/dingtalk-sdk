<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models;

use AlibabaCloud\Tea\Model;

class DeleteGroupMembersFromGroupRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example GROUP：从群中删除；GROUP_SET：从群组中删除
     *
     * @var string
     */
    public $deleteGroupType;

    /**
     * @description This parameter is required.
     *
     * @example 8888
     *
     * @var string
     */
    public $memberUnionId;

    /**
     * @example cid**
     *
     * @var string
     */
    public $openConversationId;

    /**
     * @example 8888
     *
     * @var string
     */
    public $openGroupSetId;

    /**
     * @description This parameter is required.
     *
     * @example 8888
     *
     * @var string
     */
    public $openTeamId;
    protected $_name = [
        'deleteGroupType'    => 'deleteGroupType',
        'memberUnionId'      => 'memberUnionId',
        'openConversationId' => 'openConversationId',
        'openGroupSetId'     => 'openGroupSetId',
        'openTeamId'         => 'openTeamId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->deleteGroupType) {
            $res['deleteGroupType'] = $this->deleteGroupType;
        }
        if (null !== $this->memberUnionId) {
            $res['memberUnionId'] = $this->memberUnionId;
        }
        if (null !== $this->openConversationId) {
            $res['openConversationId'] = $this->openConversationId;
        }
        if (null !== $this->openGroupSetId) {
            $res['openGroupSetId'] = $this->openGroupSetId;
        }
        if (null !== $this->openTeamId) {
            $res['openTeamId'] = $this->openTeamId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return DeleteGroupMembersFromGroupRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['deleteGroupType'])) {
            $model->deleteGroupType = $map['deleteGroupType'];
        }
        if (isset($map['memberUnionId'])) {
            $model->memberUnionId = $map['memberUnionId'];
        }
        if (isset($map['openConversationId'])) {
            $model->openConversationId = $map['openConversationId'];
        }
        if (isset($map['openGroupSetId'])) {
            $model->openGroupSetId = $map['openGroupSetId'];
        }
        if (isset($map['openTeamId'])) {
            $model->openTeamId = $map['openTeamId'];
        }

        return $model;
    }
}
