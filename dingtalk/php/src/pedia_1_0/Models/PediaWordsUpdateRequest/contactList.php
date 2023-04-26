<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vpedia_1_0\Models\PediaWordsUpdateRequest;

use AlibabaCloud\Tea\Model;

class contactList extends Model
{
    /**
     * @example @12312312
     *
     * @var string
     */
    public $avatarMediaId;

    /**
     * @example 名称
     *
     * @var string
     */
    public $nickName;

    /**
     * @example 12131312
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'avatarMediaId' => 'avatarMediaId',
        'nickName'      => 'nickName',
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
        if (null !== $this->nickName) {
            $res['nickName'] = $this->nickName;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return contactList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['avatarMediaId'])) {
            $model->avatarMediaId = $map['avatarMediaId'];
        }
        if (isset($map['nickName'])) {
            $model->nickName = $map['nickName'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
