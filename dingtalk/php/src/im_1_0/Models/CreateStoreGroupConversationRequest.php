<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models;

use AlibabaCloud\Tea\Model;

class CreateStoreGroupConversationRequest extends Model
{
    /**
     * @example 1107****2120
     *
     * @var string
     */
    public $appUserId;

    /**
     * @example store1
     *
     * @var string
     */
    public $businessUniqueKey;

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
     * @example 8d42****nkld
     *
     * @var string
     */
    public $groupTemplateId;

    /**
     * @example 1107****2120
     *
     * @var string
     */
    public $operatorId;

    /**
     * @var string[]
     */
    public $userIds;
    protected $_name = [
        'appUserId'         => 'appUserId',
        'businessUniqueKey' => 'businessUniqueKey',
        'groupAvatar'       => 'groupAvatar',
        'groupName'         => 'groupName',
        'groupTemplateId'   => 'groupTemplateId',
        'operatorId'        => 'operatorId',
        'userIds'           => 'userIds',
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
        if (null !== $this->businessUniqueKey) {
            $res['businessUniqueKey'] = $this->businessUniqueKey;
        }
        if (null !== $this->groupAvatar) {
            $res['groupAvatar'] = $this->groupAvatar;
        }
        if (null !== $this->groupName) {
            $res['groupName'] = $this->groupName;
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
     * @return CreateStoreGroupConversationRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['appUserId'])) {
            $model->appUserId = $map['appUserId'];
        }
        if (isset($map['businessUniqueKey'])) {
            $model->businessUniqueKey = $map['businessUniqueKey'];
        }
        if (isset($map['groupAvatar'])) {
            $model->groupAvatar = $map['groupAvatar'];
        }
        if (isset($map['groupName'])) {
            $model->groupName = $map['groupName'];
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
