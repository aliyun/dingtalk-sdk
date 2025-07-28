<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\ListPunchScheduleByConditionWithPagingResponseBody;

use AlibabaCloud\Tea\Model;

class list_ extends Model
{
    /**
     * @example be0d84e04316488cxxxxxxxx129522b0
     *
     * @var string
     */
    public $bizOuterId;

    /**
     * @example 测试打卡机
     *
     * @var string
     */
    public $positionName;

    /**
     * @example checkIn
     *
     * @var string
     */
    public $punchSymbol;

    /**
     * @example 200003
     *
     * @var string
     */
    public $userId;

    /**
     * @example 1647333408000
     *
     * @var int
     */
    public $userPunchTime;
    protected $_name = [
        'bizOuterId' => 'bizOuterId',
        'positionName' => 'positionName',
        'punchSymbol' => 'punchSymbol',
        'userId' => 'userId',
        'userPunchTime' => 'userPunchTime',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->bizOuterId) {
            $res['bizOuterId'] = $this->bizOuterId;
        }
        if (null !== $this->positionName) {
            $res['positionName'] = $this->positionName;
        }
        if (null !== $this->punchSymbol) {
            $res['punchSymbol'] = $this->punchSymbol;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }
        if (null !== $this->userPunchTime) {
            $res['userPunchTime'] = $this->userPunchTime;
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
        if (isset($map['bizOuterId'])) {
            $model->bizOuterId = $map['bizOuterId'];
        }
        if (isset($map['positionName'])) {
            $model->positionName = $map['positionName'];
        }
        if (isset($map['punchSymbol'])) {
            $model->punchSymbol = $map['punchSymbol'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }
        if (isset($map['userPunchTime'])) {
            $model->userPunchTime = $map['userPunchTime'];
        }

        return $model;
    }
}
