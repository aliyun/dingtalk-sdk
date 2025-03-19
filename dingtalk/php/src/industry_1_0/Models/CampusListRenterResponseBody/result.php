<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CampusListRenterResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @example ding3242423
     *
     * @var string
     */
    public $bindRenterCorpId;

    /**
     * @example 1655704317794
     *
     * @var int
     */
    public $bindTime;

    /**
     * @example 1313131414
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
     * @example 扩展信息
     *
     * @var string
     */
    public $extend;

    /**
     * @example 测试租客
     *
     * @var string
     */
    public $name;

    /**
     * @example 100
     *
     * @var int
     */
    public $renterDeptId;

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
        'bindRenterCorpId' => 'bindRenterCorpId',
        'bindTime' => 'bindTime',
        'creditCode' => 'creditCode',
        'endTime' => 'endTime',
        'extend' => 'extend',
        'name' => 'name',
        'renterDeptId' => 'renterDeptId',
        'startTime' => 'startTime',
        'state' => 'state',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->bindRenterCorpId) {
            $res['bindRenterCorpId'] = $this->bindRenterCorpId;
        }
        if (null !== $this->bindTime) {
            $res['bindTime'] = $this->bindTime;
        }
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
        if (null !== $this->renterDeptId) {
            $res['renterDeptId'] = $this->renterDeptId;
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
     * @return result
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['bindRenterCorpId'])) {
            $model->bindRenterCorpId = $map['bindRenterCorpId'];
        }
        if (isset($map['bindTime'])) {
            $model->bindTime = $map['bindTime'];
        }
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
        if (isset($map['renterDeptId'])) {
            $model->renterDeptId = $map['renterDeptId'];
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
