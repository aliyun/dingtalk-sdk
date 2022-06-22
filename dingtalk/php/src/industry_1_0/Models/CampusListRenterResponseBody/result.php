<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CampusListRenterResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @description 绑定钉钉组织ID
     *
     * @var string
     */
    public $bindRenterCorpId;

    /**
     * @description 绑定时间
     *
     * @var int
     */
    public $bindTime;

    /**
     * @description 企业信用代码
     *
     * @var string
     */
    public $creditCode;

    /**
     * @description 到期时间
     *
     * @var int
     */
    public $endTime;

    /**
     * @description 扩展信息
     *
     * @var string
     */
    public $extend;

    /**
     * @description 租客名称
     *
     * @var string
     */
    public $name;

    /**
     * @description 租客部门ID
     *
     * @var int
     */
    public $renterDeptId;

    /**
     * @description 起始时间
     *
     * @var int
     */
    public $startTime;

    /**
     * @description 状态
     *
     * @var int
     */
    public $state;
    protected $_name = [
        'bindRenterCorpId' => 'bindRenterCorpId',
        'bindTime'         => 'bindTime',
        'creditCode'       => 'creditCode',
        'endTime'          => 'endTime',
        'extend'           => 'extend',
        'name'             => 'name',
        'renterDeptId'     => 'renterDeptId',
        'startTime'        => 'startTime',
        'state'            => 'state',
    ];

    public function validate()
    {
    }

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
