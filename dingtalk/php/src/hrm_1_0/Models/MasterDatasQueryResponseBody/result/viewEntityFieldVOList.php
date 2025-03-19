<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models\MasterDatasQueryResponseBody\result;

use AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models\MasterDatasQueryResponseBody\result\viewEntityFieldVOList\fieldDataVO;
use AlibabaCloud\Tea\Model;

class viewEntityFieldVOList extends Model
{
    /**
     * @example performanceValue
     *
     * @var string
     */
    public $fieldCode;

    /**
     * @var fieldDataVO
     */
    public $fieldDataVO;

    /**
     * @example 绩效等级
     *
     * @var string
     */
    public $fieldName;

    /**
     * @example 1
     *
     * @var string
     */
    public $fieldType;
    protected $_name = [
        'fieldCode' => 'fieldCode',
        'fieldDataVO' => 'fieldDataVO',
        'fieldName' => 'fieldName',
        'fieldType' => 'fieldType',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->fieldCode) {
            $res['fieldCode'] = $this->fieldCode;
        }
        if (null !== $this->fieldDataVO) {
            $res['fieldDataVO'] = null !== $this->fieldDataVO ? $this->fieldDataVO->toMap() : null;
        }
        if (null !== $this->fieldName) {
            $res['fieldName'] = $this->fieldName;
        }
        if (null !== $this->fieldType) {
            $res['fieldType'] = $this->fieldType;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return viewEntityFieldVOList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['fieldCode'])) {
            $model->fieldCode = $map['fieldCode'];
        }
        if (isset($map['fieldDataVO'])) {
            $model->fieldDataVO = fieldDataVO::fromMap($map['fieldDataVO']);
        }
        if (isset($map['fieldName'])) {
            $model->fieldName = $map['fieldName'];
        }
        if (isset($map['fieldType'])) {
            $model->fieldType = $map['fieldType'];
        }

        return $model;
    }
}
