<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\QueryGroupMemberResponseBody\result;

use AlibabaCloud\Tea\Model;

class groupMemberList extends Model
{
    /**
     * @var string
     */
    public $avatarMediaId;

    /**
     * @var bool
     */
    public $isUser;

    /**
     * @var string
     */
    public $nickName;

    /**
     * @var bool
     */
    public $owner;

    /**
     * @var string
     */
    public $unionId;

    /**
     * @var string
     */
    public $userId;
    protected $_name = [
        'avatarMediaId' => 'avatarMediaId',
        'isUser'        => 'isUser',
        'nickName'      => 'nickName',
        'owner'         => 'owner',
        'unionId'       => 'unionId',
        'userId'        => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->avatarMediaId) {
            $res['avatarMediaId'] = $this->avatarMediaId;
        }
        if (null !== $this->isUser) {
            $res['isUser'] = $this->isUser;
        }
        if (null !== $this->nickName) {
            $res['nickName'] = $this->nickName;
        }
        if (null !== $this->owner) {
            $res['owner'] = $this->owner;
        }
        if (null !== $this->unionId) {
            $res['unionId'] = $this->unionId;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return groupMemberList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['avatarMediaId'])) {
            $model->avatarMediaId = $map['avatarMediaId'];
        }
        if (isset($map['isUser'])) {
            $model->isUser = $map['isUser'];
        }
        if (isset($map['nickName'])) {
            $model->nickName = $map['nickName'];
        }
        if (isset($map['owner'])) {
            $model->owner = $map['owner'];
        }
        if (isset($map['unionId'])) {
            $model->unionId = $map['unionId'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
