<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models;

use AlibabaCloud\Tea\Model;

class AddCustomRosterFieldRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var bool
     */
    public $editFromEmployeeFlag;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $fieldName;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $fieldType;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $groupId;

    /**
     * @description This parameter is required.
     *
     * @var bool
     */
    public $hiddenFromEmployeeFlag;

    /**
     * @var string
     */
    public $hint;

    /**
     * @var bool
     */
    public $noWatermark;

    /**
     * @var int
     */
    public $numberDecimalPlace;

    /**
     * @var string
     */
    public $numberFormatType;

    /**
     * @var string
     */
    public $numberValueType;

    /**
     * @var string
     */
    public $optionText;

    /**
     * @description This parameter is required.
     *
     * @var bool
     */
    public $required;

    /**
     * @description This parameter is required.
     *
     * @var bool
     */
    public $visibleByEmp;
    protected $_name = [
        'editFromEmployeeFlag' => 'editFromEmployeeFlag',
        'fieldName' => 'fieldName',
        'fieldType' => 'fieldType',
        'groupId' => 'groupId',
        'hiddenFromEmployeeFlag' => 'hiddenFromEmployeeFlag',
        'hint' => 'hint',
        'noWatermark' => 'noWatermark',
        'numberDecimalPlace' => 'numberDecimalPlace',
        'numberFormatType' => 'numberFormatType',
        'numberValueType' => 'numberValueType',
        'optionText' => 'optionText',
        'required' => 'required',
        'visibleByEmp' => 'visibleByEmp',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->editFromEmployeeFlag) {
            $res['editFromEmployeeFlag'] = $this->editFromEmployeeFlag;
        }
        if (null !== $this->fieldName) {
            $res['fieldName'] = $this->fieldName;
        }
        if (null !== $this->fieldType) {
            $res['fieldType'] = $this->fieldType;
        }
        if (null !== $this->groupId) {
            $res['groupId'] = $this->groupId;
        }
        if (null !== $this->hiddenFromEmployeeFlag) {
            $res['hiddenFromEmployeeFlag'] = $this->hiddenFromEmployeeFlag;
        }
        if (null !== $this->hint) {
            $res['hint'] = $this->hint;
        }
        if (null !== $this->noWatermark) {
            $res['noWatermark'] = $this->noWatermark;
        }
        if (null !== $this->numberDecimalPlace) {
            $res['numberDecimalPlace'] = $this->numberDecimalPlace;
        }
        if (null !== $this->numberFormatType) {
            $res['numberFormatType'] = $this->numberFormatType;
        }
        if (null !== $this->numberValueType) {
            $res['numberValueType'] = $this->numberValueType;
        }
        if (null !== $this->optionText) {
            $res['optionText'] = $this->optionText;
        }
        if (null !== $this->required) {
            $res['required'] = $this->required;
        }
        if (null !== $this->visibleByEmp) {
            $res['visibleByEmp'] = $this->visibleByEmp;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return AddCustomRosterFieldRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['editFromEmployeeFlag'])) {
            $model->editFromEmployeeFlag = $map['editFromEmployeeFlag'];
        }
        if (isset($map['fieldName'])) {
            $model->fieldName = $map['fieldName'];
        }
        if (isset($map['fieldType'])) {
            $model->fieldType = $map['fieldType'];
        }
        if (isset($map['groupId'])) {
            $model->groupId = $map['groupId'];
        }
        if (isset($map['hiddenFromEmployeeFlag'])) {
            $model->hiddenFromEmployeeFlag = $map['hiddenFromEmployeeFlag'];
        }
        if (isset($map['hint'])) {
            $model->hint = $map['hint'];
        }
        if (isset($map['noWatermark'])) {
            $model->noWatermark = $map['noWatermark'];
        }
        if (isset($map['numberDecimalPlace'])) {
            $model->numberDecimalPlace = $map['numberDecimalPlace'];
        }
        if (isset($map['numberFormatType'])) {
            $model->numberFormatType = $map['numberFormatType'];
        }
        if (isset($map['numberValueType'])) {
            $model->numberValueType = $map['numberValueType'];
        }
        if (isset($map['optionText'])) {
            $model->optionText = $map['optionText'];
        }
        if (isset($map['required'])) {
            $model->required = $map['required'];
        }
        if (isset($map['visibleByEmp'])) {
            $model->visibleByEmp = $map['visibleByEmp'];
        }

        return $model;
    }
}
