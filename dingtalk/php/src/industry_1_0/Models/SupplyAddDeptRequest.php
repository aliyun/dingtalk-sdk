<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models;

use AlibabaCloud\Tea\Model;

class SupplyAddDeptRequest extends Model
{
    /**
     * @description 部门名字
     *
     * @var string
     */
    public $deptName;

    /**
     * @description 供应商编号
     *
     * @var string
     */
    public $partnerNumber;

    /**
     * @description 上级部门id
     *
     * @var int
     */
    public $superDeptId;

    /**
     * @description 供应链部门类型
     *
     * @var string
     */
    public $supplyDeptType;
    protected $_name = [
        'deptName'       => 'deptName',
        'partnerNumber'  => 'partnerNumber',
        'superDeptId'    => 'superDeptId',
        'supplyDeptType' => 'supplyDeptType',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->deptName) {
            $res['deptName'] = $this->deptName;
        }
        if (null !== $this->partnerNumber) {
            $res['partnerNumber'] = $this->partnerNumber;
        }
        if (null !== $this->superDeptId) {
            $res['superDeptId'] = $this->superDeptId;
        }
        if (null !== $this->supplyDeptType) {
            $res['supplyDeptType'] = $this->supplyDeptType;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return SupplyAddDeptRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['deptName'])) {
            $model->deptName = $map['deptName'];
        }
        if (isset($map['partnerNumber'])) {
            $model->partnerNumber = $map['partnerNumber'];
        }
        if (isset($map['superDeptId'])) {
            $model->superDeptId = $map['superDeptId'];
        }
        if (isset($map['supplyDeptType'])) {
            $model->supplyDeptType = $map['supplyDeptType'];
        }

        return $model;
    }
}
