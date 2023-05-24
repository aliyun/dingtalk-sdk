<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\SupplyChainQueryDeptInfoResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\SupplyChainQueryDeptInfoResponseBody\result\partnerTypeInfoList;
use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @example 1111
     *
     * @var int
     */
    public $deptId;

    /**
     * @example ROOT
     *
     * @var string
     */
    public $deptType;

    /**
     * @var bool
     */
    public $hasSubDept;

    /**
     * @example xxxx 有限公司
     *
     * @var string
     */
    public $name;

    /**
     * @example 111111
     *
     * @var string
     */
    public $partnerNumber;

    /**
     * @var partnerTypeInfoList[]
     */
    public $partnerTypeInfoList;

    /**
     * @example 1111
     *
     * @var int
     */
    public $superId;
    protected $_name = [
        'deptId'              => 'deptId',
        'deptType'            => 'deptType',
        'hasSubDept'          => 'hasSubDept',
        'name'                => 'name',
        'partnerNumber'       => 'partnerNumber',
        'partnerTypeInfoList' => 'partnerTypeInfoList',
        'superId'             => 'superId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->deptId) {
            $res['deptId'] = $this->deptId;
        }
        if (null !== $this->deptType) {
            $res['deptType'] = $this->deptType;
        }
        if (null !== $this->hasSubDept) {
            $res['hasSubDept'] = $this->hasSubDept;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->partnerNumber) {
            $res['partnerNumber'] = $this->partnerNumber;
        }
        if (null !== $this->partnerTypeInfoList) {
            $res['partnerTypeInfoList'] = [];
            if (null !== $this->partnerTypeInfoList && \is_array($this->partnerTypeInfoList)) {
                $n = 0;
                foreach ($this->partnerTypeInfoList as $item) {
                    $res['partnerTypeInfoList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->superId) {
            $res['superId'] = $this->superId;
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
        if (isset($map['deptId'])) {
            $model->deptId = $map['deptId'];
        }
        if (isset($map['deptType'])) {
            $model->deptType = $map['deptType'];
        }
        if (isset($map['hasSubDept'])) {
            $model->hasSubDept = $map['hasSubDept'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['partnerNumber'])) {
            $model->partnerNumber = $map['partnerNumber'];
        }
        if (isset($map['partnerTypeInfoList'])) {
            if (!empty($map['partnerTypeInfoList'])) {
                $model->partnerTypeInfoList = [];
                $n                          = 0;
                foreach ($map['partnerTypeInfoList'] as $item) {
                    $model->partnerTypeInfoList[$n++] = null !== $item ? partnerTypeInfoList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['superId'])) {
            $model->superId = $map['superId'];
        }

        return $model;
    }
}
