<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models;

use AlibabaCloud\Tea\Model;

class CampusUpdateRenterRequest extends Model
{
    /**
     * @description 企业信用代码
     *
     * @var string
     */
    public $creditCode;

    /**
     * @description 租期开始时间
     *
     * @var int
     */
    public $endTime;

    /**
     * @description 扩展字段
     *
     * @var string
     */
    public $extend;

    /**
     * @description 租客名字
     *
     * @var string
     */
    public $name;

    /**
     * @description 租客ID
     *
     * @var int
     */
    public $renterId;

    /**
     * @description 租期结束时间
     *
     * @var int
     */
    public $startTime;

    /**
     * @description 启用状态
     *
     * @var int
     */
    public $state;
    protected $_name = [
        'creditCode' => 'creditCode',
        'endTime'    => 'endTime',
        'extend'     => 'extend',
        'name'       => 'name',
        'renterId'   => 'renterId',
        'startTime'  => 'startTime',
        'state'      => 'state',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->creditCode) {
            $res['creditCode'] = $this->creditCode;
        }
        if (null !== $this->endTime) {
            $res['endTime'] = $this->endTime;
        }
        if (null !== $this->extend) {
            $res['extend'] = $this->extend;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->renterId) {
            $res['renterId'] = $this->renterId;
        }
        if (null !== $this->startTime) {
            $res['startTime'] = $this->startTime;
        }
        if (null !== $this->state) {
            $res['state'] = $this->state;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CampusUpdateRenterRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['creditCode'])) {
            $model->creditCode = $map['creditCode'];
        }
        if (isset($map['endTime'])) {
            $model->endTime = $map['endTime'];
        }
        if (isset($map['extend'])) {
            $model->extend = $map['extend'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['renterId'])) {
            $model->renterId = $map['renterId'];
        }
        if (isset($map['startTime'])) {
            $model->startTime = $map['startTime'];
        }
        if (isset($map['state'])) {
            $model->state = $map['state'];
        }

        return $model;
    }
}
