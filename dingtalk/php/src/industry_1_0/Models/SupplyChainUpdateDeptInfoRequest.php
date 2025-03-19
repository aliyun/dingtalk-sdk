<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models;

use AlibabaCloud\Tea\Model;

class SupplyChainUpdateDeptInfoRequest extends Model
{
    /**
     * @example 名称
     *
     * @var string
     */
    public $name;

    /**
     * @example 123
     *
     * @var string
     */
    public $partnerNumber;

    /**
     * @var int[]
     */
    public $partnerTypeList;

    /**
     * @example 1231
     *
     * @var int
     */
    public $superId;

    /**
     * @description This parameter is required.
     *
     * @example 576488112
     *
     * @var int
     */
    public $supplyDeptId;
    protected $_name = [
        'name' => 'name',
        'partnerNumber' => 'partnerNumber',
        'partnerTypeList' => 'partnerTypeList',
        'superId' => 'superId',
        'supplyDeptId' => 'supplyDeptId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->partnerNumber) {
            $res['partnerNumber'] = $this->partnerNumber;
        }
        if (null !== $this->partnerTypeList) {
            $res['partnerTypeList'] = $this->partnerTypeList;
        }
        if (null !== $this->superId) {
            $res['superId'] = $this->superId;
        }
        if (null !== $this->supplyDeptId) {
            $res['supplyDeptId'] = $this->supplyDeptId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return SupplyChainUpdateDeptInfoRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['partnerNumber'])) {
            $model->partnerNumber = $map['partnerNumber'];
        }
        if (isset($map['partnerTypeList'])) {
            if (!empty($map['partnerTypeList'])) {
                $model->partnerTypeList = $map['partnerTypeList'];
            }
        }
        if (isset($map['superId'])) {
            $model->superId = $map['superId'];
        }
        if (isset($map['supplyDeptId'])) {
            $model->supplyDeptId = $map['supplyDeptId'];
        }

        return $model;
    }
}
