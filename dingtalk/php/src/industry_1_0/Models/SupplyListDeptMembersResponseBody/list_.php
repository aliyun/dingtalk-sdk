<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\SupplyListDeptMembersResponseBody;

use AlibabaCloud\Tea\Model;

class list_ extends Model
{
    /**
     * @example NORMAL
     *
     * @var string
     */
    public $dingMemberStatus;

    /**
     * @example true
     *
     * @var bool
     */
    public $isActive;

    /**
     * @example 李白
     *
     * @var string
     */
    public $memberName;

    /**
     * @example 123
     *
     * @var string
     */
    public $memberWorkNumber;

    /**
     * @example 123abc
     *
     * @var string
     */
    public $unionId;

    /**
     * @example 123344
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'dingMemberStatus' => 'dingMemberStatus',
        'isActive'         => 'isActive',
        'memberName'       => 'memberName',
        'memberWorkNumber' => 'memberWorkNumber',
        'unionId'          => 'unionId',
        'userId'           => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->dingMemberStatus) {
            $res['dingMemberStatus'] = $this->dingMemberStatus;
        }
        if (null !== $this->isActive) {
            $res['isActive'] = $this->isActive;
        }
        if (null !== $this->memberName) {
            $res['memberName'] = $this->memberName;
        }
        if (null !== $this->memberWorkNumber) {
            $res['memberWorkNumber'] = $this->memberWorkNumber;
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
     * @return list_
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['dingMemberStatus'])) {
            $model->dingMemberStatus = $map['dingMemberStatus'];
        }
        if (isset($map['isActive'])) {
            $model->isActive = $map['isActive'];
        }
        if (isset($map['memberName'])) {
            $model->memberName = $map['memberName'];
        }
        if (isset($map['memberWorkNumber'])) {
            $model->memberWorkNumber = $map['memberWorkNumber'];
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
