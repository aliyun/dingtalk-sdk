<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models\MasterDataQueryResponseBody\result;

use AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models\MasterDataQueryResponseBody\result\viewEntityFieldVOList\fieldDataVO;
use AlibabaCloud\Tea\Model;

class viewEntityFieldVOList extends Model
{
    /**
     * @var string
     */
    public $fieldCode;

    /**
     * @var fieldDataVO
     */
    public $fieldDataVO;

    /**
     * @var string
     */
    public $fieldName;

    /**
     * @var string
     */
    public $fieldType;

    /**
     * @var mixed[][]
     */
    public $attrs;
    protected $_name = [
        'fieldCode'   => 'fieldCode',
        'fieldDataVO' => 'fieldDataVO',
        'fieldName'   => 'fieldName',
        'fieldType'   => 'fieldType',
        'attrs'       => 'attrs',
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
        if (null !== $this->fieldDataVO) {
            $res['fieldDataVO'] = null !== $this->fieldDataVO ? $this->fieldDataVO->toMap() : null;
        }
        if (null !== $this->fieldName) {
            $res['fieldName'] = $this->fieldName;
        }
        if (null !== $this->fieldType) {
            $res['fieldType'] = $this->fieldType;
        }
        if (null !== $this->attrs) {
            $res['attrs'] = $this->attrs;
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
        if (isset($map['attrs'])) {
            $model->attrs = $map['attrs'];
        }

        return $model;
    }
}
