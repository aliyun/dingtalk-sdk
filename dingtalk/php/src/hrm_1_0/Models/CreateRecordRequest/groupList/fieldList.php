<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models\CreateRecordRequest\groupList;

use AlibabaCloud\Tea\Model;

class fieldList extends Model
{
    /**
     * @example contract.contract_type
     *
     * @var string
     */
    public $fieldCode;

    /**
     * @example 合同类型
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
     * @example 劳动合同
     *
     * @var string
     */
    public $fieldValue;

    /**
     * @example [{\"label\":\"劳动合同\",\"value\":\"劳动合同\"},{\"label\":\"培训协议\",\"value\":\"培训协议\"}]
     *
     * @var string
     */
    public $options;

    /**
     * @example 劳动合同
     *
     * @var string
     */
    public $optionId;

    /**
     * @example contract
     *
     * @var string
     */
    public $groupId;
    protected $_name = [
        'fieldCode' => 'fieldCode',
        'fieldName' => 'fieldName',
        'fieldType' => 'fieldType',
        'fieldValue' => 'fieldValue',
        'options' => 'options',
        'optionId' => 'optionId',
        'groupId' => 'groupId',
    ];

    public function validate() {}

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
        if (null !== $this->fieldValue) {
            $res['fieldValue'] = $this->fieldValue;
        }
        if (null !== $this->options) {
            $res['options'] = $this->options;
        }
        if (null !== $this->optionId) {
            $res['optionId'] = $this->optionId;
        }
        if (null !== $this->groupId) {
            $res['groupId'] = $this->groupId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return fieldList
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
        if (isset($map['fieldValue'])) {
            $model->fieldValue = $map['fieldValue'];
        }
        if (isset($map['options'])) {
            $model->options = $map['options'];
        }
        if (isset($map['optionId'])) {
            $model->optionId = $map['optionId'];
        }
        if (isset($map['groupId'])) {
            $model->groupId = $map['groupId'];
        }

        return $model;
    }
}
