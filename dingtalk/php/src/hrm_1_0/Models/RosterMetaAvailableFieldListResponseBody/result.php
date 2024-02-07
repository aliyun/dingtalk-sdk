<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models\RosterMetaAvailableFieldListResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @example sys01-employeeType
     *
     * @var string
     */
    public $fieldCode;

    /**
     * @example 员工类型
     *
     * @var string
     */
    public $fieldName;

    /**
     * @example DDSelectField
     *
     * @var string
     */
    public $fieldType;

    /**
     * @example [{"value":"1","label":"男"},{"value":"2","label":"女"}]
     *
     * @var string
     */
    public $optionText;
    protected $_name = [
        'fieldCode'  => 'fieldCode',
        'fieldName'  => 'fieldName',
        'fieldType'  => 'fieldType',
        'optionText' => 'optionText',
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
        if (null !== $this->fieldType) {
            $res['fieldType'] = $this->fieldType;
        }
        if (null !== $this->optionText) {
            $res['optionText'] = $this->optionText;
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
        if (isset($map['fieldCode'])) {
            $model->fieldCode = $map['fieldCode'];
        }
        if (isset($map['fieldName'])) {
            $model->fieldName = $map['fieldName'];
        }
        if (isset($map['fieldType'])) {
            $model->fieldType = $map['fieldType'];
        }
        if (isset($map['optionText'])) {
            $model->optionText = $map['optionText'];
        }

        return $model;
    }
}
