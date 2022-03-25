<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\ListPunchScheduleByConditionWithPagingResponseBody;

use AlibabaCloud\Tea\Model;

class list_ extends Model
{
    /**
     * @description 巡点业务id，同个巡点id同一个用户最多会有两条记录，一条签到，一条签退
     *
     * @var string
     */
    public $bizOuterId;

    /**
     * @description 打卡巡点机名称
     *
     * @var string
     */
    public $positionName;

    /**
     * @description 巡点类型（checkIn-签到，checkOut-签退）
     *
     * @var string
     */
    public $punchSymbol;

    /**
     * @description 用户id
     *
     * @var string
     */
    public $userId;

    /**
     * @description 用户巡点打卡时间
     *
     * @var int
     */
    public $userPunchTime;
    protected $_name = [
        'bizOuterId'    => 'bizOuterId',
        'positionName'  => 'positionName',
        'punchSymbol'   => 'punchSymbol',
        'userId'        => 'userId',
        'userPunchTime' => 'userPunchTime',
    ];

    public function validate()
    {
    }

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
