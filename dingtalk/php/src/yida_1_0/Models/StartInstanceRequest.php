<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models;

use AlibabaCloud\Tea\Model;

class StartInstanceRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example APP_PBKT0MFBEBTDO8T7SLVP
     *
     * @var string
     */
    public $appType;

    /**
     * @example 18295
     *
     * @var string
     */
    public $departmentId;

    /**
     * @description This parameter is required.
     *
     * @example {"textField_jcpm6agt": "单行","employeeField_jcos0sar": ["workno"]}
     *
     * @var string
     */
    public $formDataJson;

    /**
     * @description This parameter is required.
     *
     * @example FORM-NJYJZELV8YZRDEI2N5IQ7L6VEDMR1VE9GMPCJB
     *
     * @var string
     */
    public $formUuid;

    /**
     * @example zh_CN
     *
     * @var string
     */
    public $language;

    /**
     * @example TPROC--EF6Y4G8WO2FN0SUB43TDQ3CGC3FMFQ1G9400RCJ4
     *
     * @var string
     */
    public $processCode;

    /**
     * @example [{ 	"key": "__optionalApproval_node_ocltdztr2b1", 	"value": ["5014533041684350"] }, { 	"key": "__optionalApproval_node_ocltdztr2b3", 	"value": ["5014533041684350", "01536610064226180419"] }, { 	"key": "__optionalApproval_node_oclte07cwn1", 	"value": ["01432910392321237660"] }]
     *
     * @var string
     */
    public $processData;

    /**
     * @description This parameter is required.
     *
     * @example hexxx
     *
     * @var string
     */
    public $systemToken;

    /**
     * @description This parameter is required.
     *
     * @example 1731234567
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'appType' => 'appType',
        'departmentId' => 'departmentId',
        'formDataJson' => 'formDataJson',
        'formUuid' => 'formUuid',
        'language' => 'language',
        'processCode' => 'processCode',
        'processData' => 'processData',
        'systemToken' => 'systemToken',
        'userId' => 'userId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->appType) {
            $res['appType'] = $this->appType;
        }
        if (null !== $this->departmentId) {
            $res['departmentId'] = $this->departmentId;
        }
        if (null !== $this->formDataJson) {
            $res['formDataJson'] = $this->formDataJson;
        }
        if (null !== $this->formUuid) {
            $res['formUuid'] = $this->formUuid;
        }
        if (null !== $this->language) {
            $res['language'] = $this->language;
        }
        if (null !== $this->processCode) {
            $res['processCode'] = $this->processCode;
        }
        if (null !== $this->processData) {
            $res['processData'] = $this->processData;
        }
        if (null !== $this->systemToken) {
            $res['systemToken'] = $this->systemToken;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return StartInstanceRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['appType'])) {
            $model->appType = $map['appType'];
        }
        if (isset($map['departmentId'])) {
            $model->departmentId = $map['departmentId'];
        }
        if (isset($map['formDataJson'])) {
            $model->formDataJson = $map['formDataJson'];
        }
        if (isset($map['formUuid'])) {
            $model->formUuid = $map['formUuid'];
        }
        if (isset($map['language'])) {
            $model->language = $map['language'];
        }
        if (isset($map['processCode'])) {
            $model->processCode = $map['processCode'];
        }
        if (isset($map['processData'])) {
            $model->processData = $map['processData'];
        }
        if (isset($map['systemToken'])) {
            $model->systemToken = $map['systemToken'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
