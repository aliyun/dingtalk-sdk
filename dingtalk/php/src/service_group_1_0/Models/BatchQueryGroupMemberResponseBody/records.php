<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\BatchQueryGroupMemberResponseBody;

use AlibabaCloud\Tea\Model;

class records extends Model
{
    /**
     * @var bool
     */
    public $innerStaff;

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
        'innerStaff' => 'innerStaff',
        'nickName'   => 'nickName',
        'owner'      => 'owner',
        'unionId'    => 'unionId',
        'userId'     => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->innerStaff) {
            $res['innerStaff'] = $this->innerStaff;
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
     * @return records
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['innerStaff'])) {
            $model->innerStaff = $map['innerStaff'];
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
