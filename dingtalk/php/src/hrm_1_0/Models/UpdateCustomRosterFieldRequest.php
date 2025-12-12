<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models;

use AlibabaCloud\Tea\Model;

class UpdateCustomRosterFieldRequest extends Model
{
    /**
     * @var bool
     */
    public $contactClientFlag;

    /**
     * @var bool
     */
    public $contactFlag;

    /**
     * @var int
     */
    public $contactSource;

    /**
     * @var bool
     */
    public $contactSystemFlag;

    /**
     * @var bool
     */
    public $deleted;

    /**
     * @var bool
     */
    public $derived;

    /**
     * @var int
     */
    public $disabled;

    /**
     * @description This parameter is required.
     *
     * @var bool
     */
    public $editFromEmployeeFlag;

    /**
     * @var bool
     */
    public $editableByHr;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $fieldCode;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $fieldName;

    /**
     * @var string
     */
    public $fieldTip;

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
    public $historyField;

    /**
     * @var int
     */
    public $index;

    /**
     * @var bool
     */
    public $modifyOptions;

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
     * @var string
     */
    public $sourceFieldCode;

    /**
     * @var bool
     */
    public $systemFlag;

    /**
     * @var bool
     */
    public $textToSelectField;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $updateUserId;

    /**
     * @var string
     */
    public $value;

    /**
     * @description This parameter is required.
     *
     * @var bool
     */
    public $visibleByEmp;
    protected $_name = [
        'contactClientFlag' => 'contactClientFlag',
        'contactFlag' => 'contactFlag',
        'contactSource' => 'contactSource',
        'contactSystemFlag' => 'contactSystemFlag',
        'deleted' => 'deleted',
        'derived' => 'derived',
        'disabled' => 'disabled',
        'editFromEmployeeFlag' => 'editFromEmployeeFlag',
        'editableByHr' => 'editableByHr',
        'fieldCode' => 'fieldCode',
        'fieldName' => 'fieldName',
        'fieldTip' => 'fieldTip',
        'fieldType' => 'fieldType',
        'groupId' => 'groupId',
        'hiddenFromEmployeeFlag' => 'hiddenFromEmployeeFlag',
        'hint' => 'hint',
        'historyField' => 'historyField',
        'index' => 'index',
        'modifyOptions' => 'modifyOptions',
        'noWatermark' => 'noWatermark',
        'numberDecimalPlace' => 'numberDecimalPlace',
        'numberFormatType' => 'numberFormatType',
        'numberValueType' => 'numberValueType',
        'optionText' => 'optionText',
        'required' => 'required',
        'sourceFieldCode' => 'sourceFieldCode',
        'systemFlag' => 'systemFlag',
        'textToSelectField' => 'textToSelectField',
        'updateUserId' => 'updateUserId',
        'value' => 'value',
        'visibleByEmp' => 'visibleByEmp',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->contactClientFlag) {
            $res['contactClientFlag'] = $this->contactClientFlag;
        }
        if (null !== $this->contactFlag) {
            $res['contactFlag'] = $this->contactFlag;
        }
        if (null !== $this->contactSource) {
            $res['contactSource'] = $this->contactSource;
        }
        if (null !== $this->contactSystemFlag) {
            $res['contactSystemFlag'] = $this->contactSystemFlag;
        }
        if (null !== $this->deleted) {
            $res['deleted'] = $this->deleted;
        }
        if (null !== $this->derived) {
            $res['derived'] = $this->derived;
        }
        if (null !== $this->disabled) {
            $res['disabled'] = $this->disabled;
        }
        if (null !== $this->editFromEmployeeFlag) {
            $res['editFromEmployeeFlag'] = $this->editFromEmployeeFlag;
        }
        if (null !== $this->editableByHr) {
            $res['editableByHr'] = $this->editableByHr;
        }
        if (null !== $this->fieldCode) {
            $res['fieldCode'] = $this->fieldCode;
        }
        if (null !== $this->fieldName) {
            $res['fieldName'] = $this->fieldName;
        }
        if (null !== $this->fieldTip) {
            $res['fieldTip'] = $this->fieldTip;
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
        if (null !== $this->historyField) {
            $res['historyField'] = $this->historyField;
        }
        if (null !== $this->index) {
            $res['index'] = $this->index;
        }
        if (null !== $this->modifyOptions) {
            $res['modifyOptions'] = $this->modifyOptions;
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
        if (null !== $this->sourceFieldCode) {
            $res['sourceFieldCode'] = $this->sourceFieldCode;
        }
        if (null !== $this->systemFlag) {
            $res['systemFlag'] = $this->systemFlag;
        }
        if (null !== $this->textToSelectField) {
            $res['textToSelectField'] = $this->textToSelectField;
        }
        if (null !== $this->updateUserId) {
            $res['updateUserId'] = $this->updateUserId;
        }
        if (null !== $this->value) {
            $res['value'] = $this->value;
        }
        if (null !== $this->visibleByEmp) {
            $res['visibleByEmp'] = $this->visibleByEmp;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UpdateCustomRosterFieldRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['contactClientFlag'])) {
            $model->contactClientFlag = $map['contactClientFlag'];
        }
        if (isset($map['contactFlag'])) {
            $model->contactFlag = $map['contactFlag'];
        }
        if (isset($map['contactSource'])) {
            $model->contactSource = $map['contactSource'];
        }
        if (isset($map['contactSystemFlag'])) {
            $model->contactSystemFlag = $map['contactSystemFlag'];
        }
        if (isset($map['deleted'])) {
            $model->deleted = $map['deleted'];
        }
        if (isset($map['derived'])) {
            $model->derived = $map['derived'];
        }
        if (isset($map['disabled'])) {
            $model->disabled = $map['disabled'];
        }
        if (isset($map['editFromEmployeeFlag'])) {
            $model->editFromEmployeeFlag = $map['editFromEmployeeFlag'];
        }
        if (isset($map['editableByHr'])) {
            $model->editableByHr = $map['editableByHr'];
        }
        if (isset($map['fieldCode'])) {
            $model->fieldCode = $map['fieldCode'];
        }
        if (isset($map['fieldName'])) {
            $model->fieldName = $map['fieldName'];
        }
        if (isset($map['fieldTip'])) {
            $model->fieldTip = $map['fieldTip'];
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
        if (isset($map['historyField'])) {
            $model->historyField = $map['historyField'];
        }
        if (isset($map['index'])) {
            $model->index = $map['index'];
        }
        if (isset($map['modifyOptions'])) {
            $model->modifyOptions = $map['modifyOptions'];
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
        if (isset($map['sourceFieldCode'])) {
            $model->sourceFieldCode = $map['sourceFieldCode'];
        }
        if (isset($map['systemFlag'])) {
            $model->systemFlag = $map['systemFlag'];
        }
        if (isset($map['textToSelectField'])) {
            $model->textToSelectField = $map['textToSelectField'];
        }
        if (isset($map['updateUserId'])) {
            $model->updateUserId = $map['updateUserId'];
        }
        if (isset($map['value'])) {
            $model->value = $map['value'];
        }
        if (isset($map['visibleByEmp'])) {
            $model->visibleByEmp = $map['visibleByEmp'];
        }

        return $model;
    }
}
