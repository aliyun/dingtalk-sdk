<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models\GetEmployeeRosterByFieldResponseBody\result;

use AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models\GetEmployeeRosterByFieldResponseBody\result\fieldDataList\fieldValueList;
use AlibabaCloud\Tea\Model;

class fieldDataList extends Model
{
    /**
     * @example sys01-employeeStatus
     *
     * @var string
     */
    public $fieldCode;

    /**
     * @example 员工状态
     *
     * @var string
     */
    public $fieldName;

    /**
     * @var fieldValueList[]
     */
    public $fieldValueList;

    /**
     * @example sys01
     *
     * @var string
     */
    public $groupId;
    protected $_name = [
        'fieldCode'      => 'fieldCode',
        'fieldName'      => 'fieldName',
        'fieldValueList' => 'fieldValueList',
        'groupId'        => 'groupId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->fieldCode) {
            $res['fieldCode'] = $this->fieldCode;
        }
        if (null !== $this->fieldName) {
            $res['fieldName'] = $this->fieldName;
        }
        if (null !== $this->fieldValueList) {
            $res['fieldValueList'] = [];
            if (null !== $this->fieldValueList && \is_array($this->fieldValueList)) {
                $n = 0;
                foreach ($this->fieldValueList as $item) {
                    $res['fieldValueList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->groupId) {
            $res['groupId'] = $this->groupId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return fieldDataList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['fieldCode'])) {
            $model->fieldCode = $map['fieldCode'];
        }
        if (isset($map['fieldName'])) {
            $model->fieldName = $map['fieldName'];
        }
        if (isset($map['fieldValueList'])) {
            if (!empty($map['fieldValueList'])) {
                $model->fieldValueList = [];
                $n                     = 0;
                foreach ($map['fieldValueList'] as $item) {
                    $model->fieldValueList[$n++] = null !== $item ? fieldValueList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['groupId'])) {
            $model->groupId = $map['groupId'];
        }

        return $model;
    }
}
