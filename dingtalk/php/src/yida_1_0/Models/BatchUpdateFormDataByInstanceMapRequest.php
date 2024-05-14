<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models;

use AlibabaCloud\Tea\Model;

class BatchUpdateFormDataByInstanceMapRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example APP_XCE0EVXS6DYG3YDYC5RD
     *
     * @var string
     */
    public $appType;

    /**
     * @example true
     *
     * @var bool
     */
    public $asynchronousExecution;

    /**
     * @description This parameter is required.
     *
     * @example FORM-GX866MC1NC1VOFF6WVQW33FD16E23L3CPMKVKA
     *
     * @var string
     */
    public $formUuid;

    /**
     * @example true
     *
     * @var bool
     */
    public $ignoreEmpty;

    /**
     * @example true
     *
     * @var bool
     */
    public $noExecuteExpression;

    /**
     * @description This parameter is required.
     *
     * @example 09866181UTZVVD4R3DC955FNKIM52HVPU5WWK7
     *
     * @var string
     */
    public $systemToken;

    /**
     * @description This parameter is required.
     *
     * @example {"FINST-ANSFSNNDS2212NSKLKKSFD":"{\"rateField_l0c1cwis\":3,\"countrySelectField_l0c1cwiu\":[{\"value\":\"US\"}]}"}
     *
     * @var mixed[]
     */
    public $updateFormDataJsonMap;

    /**
     * @example false
     *
     * @var bool
     */
    public $useLatestFormSchemaVersion;

    /**
     * @description This parameter is required.
     *
     * @example ding173982232112232
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'appType'                    => 'appType',
        'asynchronousExecution'      => 'asynchronousExecution',
        'formUuid'                   => 'formUuid',
        'ignoreEmpty'                => 'ignoreEmpty',
        'noExecuteExpression'        => 'noExecuteExpression',
        'systemToken'                => 'systemToken',
        'updateFormDataJsonMap'      => 'updateFormDataJsonMap',
        'useLatestFormSchemaVersion' => 'useLatestFormSchemaVersion',
        'userId'                     => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->appType) {
            $res['appType'] = $this->appType;
        }
        if (null !== $this->asynchronousExecution) {
            $res['asynchronousExecution'] = $this->asynchronousExecution;
        }
        if (null !== $this->formUuid) {
            $res['formUuid'] = $this->formUuid;
        }
        if (null !== $this->ignoreEmpty) {
            $res['ignoreEmpty'] = $this->ignoreEmpty;
        }
        if (null !== $this->noExecuteExpression) {
            $res['noExecuteExpression'] = $this->noExecuteExpression;
        }
        if (null !== $this->systemToken) {
            $res['systemToken'] = $this->systemToken;
        }
        if (null !== $this->updateFormDataJsonMap) {
            $res['updateFormDataJsonMap'] = $this->updateFormDataJsonMap;
        }
        if (null !== $this->useLatestFormSchemaVersion) {
            $res['useLatestFormSchemaVersion'] = $this->useLatestFormSchemaVersion;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return BatchUpdateFormDataByInstanceMapRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['appType'])) {
            $model->appType = $map['appType'];
        }
        if (isset($map['asynchronousExecution'])) {
            $model->asynchronousExecution = $map['asynchronousExecution'];
        }
        if (isset($map['formUuid'])) {
            $model->formUuid = $map['formUuid'];
        }
        if (isset($map['ignoreEmpty'])) {
            $model->ignoreEmpty = $map['ignoreEmpty'];
        }
        if (isset($map['noExecuteExpression'])) {
            $model->noExecuteExpression = $map['noExecuteExpression'];
        }
        if (isset($map['systemToken'])) {
            $model->systemToken = $map['systemToken'];
        }
        if (isset($map['updateFormDataJsonMap'])) {
            $model->updateFormDataJsonMap = $map['updateFormDataJsonMap'];
        }
        if (isset($map['useLatestFormSchemaVersion'])) {
            $model->useLatestFormSchemaVersion = $map['useLatestFormSchemaVersion'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
