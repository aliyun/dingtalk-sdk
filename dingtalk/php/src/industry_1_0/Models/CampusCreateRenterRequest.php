<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models;

use AlibabaCloud\Tea\Model;

class CampusCreateRenterRequest extends Model
{
    /**
     * @example 231313
     *
     * @var string
     */
    public $creditCode;

    /**
     * @example 1655704317794
     *
     * @var int
     */
    public $endTime;

    /**
     * @example 扩展
     *
     * @var string
     */
    public $extend;

    /**
     * @description This parameter is required.
     *
     * @example 钉钉
     *
     * @var string
     */
    public $name;

    /**
     * @example 1655704317794
     *
     * @var int
     */
    public $startTime;

    /**
     * @example 1
     *
     * @var int
     */
    public $state;
    protected $_name = [
        'creditCode' => 'creditCode',
        'endTime'    => 'endTime',
        'extend'     => 'extend',
        'name'       => 'name',
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
     * @return CampusCreateRenterRequest
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
        if (isset($map['startTime'])) {
            $model->startTime = $map['startTime'];
        }
        if (isset($map['state'])) {
            $model->state = $map['state'];
        }

        return $model;
    }
}
