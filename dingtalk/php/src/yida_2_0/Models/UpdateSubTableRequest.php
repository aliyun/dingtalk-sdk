<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vyida_2_0\Models;

use AlibabaCloud\Tea\Model;

class UpdateSubTableRequest extends Model
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
     * @description This parameter is required.
     *
     * @example FINST-J8766S91O2UYN87ZX3XOF1MY8MBA2912BSV0L24
     *
     * @var string
     */
    public $formInstanceId;

    /**
     * @var string
     */
    public $language;

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
     * @var string
     */
    public $tableFieldIds;

    /**
     * @description This parameter is required.
     *
     * @example {"countrySelectField_l0c1cwiu":[{"value":"US"}],"addressField_l0c1cwiy":{"address":"111","regionIds":[460000,469027,469023401],"regionText":[{"en_US":"hai+nan+sheng","zh_CN":"海南省"},{"en_US":"cheng+mai+xian","zh_CN":"澄迈县"},{"en_US":"guo+ying+hong+gang+nong+chang","zh_CN":"国营红岗农场"}]}}
     *
     * @var string
     */
    public $updateFormDataJson;

    /**
     * @var bool
     */
    public $useAlias;

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
        'appType' => 'appType',
        'formInstanceId' => 'formInstanceId',
        'language' => 'language',
        'noExecuteExpression' => 'noExecuteExpression',
        'systemToken' => 'systemToken',
        'tableFieldIds' => 'tableFieldIds',
        'updateFormDataJson' => 'updateFormDataJson',
        'useAlias' => 'useAlias',
        'useLatestFormSchemaVersion' => 'useLatestFormSchemaVersion',
        'userId' => 'userId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->appType) {
            $res['appType'] = $this->appType;
        }
        if (null !== $this->formInstanceId) {
            $res['formInstanceId'] = $this->formInstanceId;
        }
        if (null !== $this->language) {
            $res['language'] = $this->language;
        }
        if (null !== $this->noExecuteExpression) {
            $res['noExecuteExpression'] = $this->noExecuteExpression;
        }
        if (null !== $this->systemToken) {
            $res['systemToken'] = $this->systemToken;
        }
        if (null !== $this->tableFieldIds) {
            $res['tableFieldIds'] = $this->tableFieldIds;
        }
        if (null !== $this->updateFormDataJson) {
            $res['updateFormDataJson'] = $this->updateFormDataJson;
        }
        if (null !== $this->useAlias) {
            $res['useAlias'] = $this->useAlias;
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
     * @return UpdateSubTableRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['appType'])) {
            $model->appType = $map['appType'];
        }
        if (isset($map['formInstanceId'])) {
            $model->formInstanceId = $map['formInstanceId'];
        }
        if (isset($map['language'])) {
            $model->language = $map['language'];
        }
        if (isset($map['noExecuteExpression'])) {
            $model->noExecuteExpression = $map['noExecuteExpression'];
        }
        if (isset($map['systemToken'])) {
            $model->systemToken = $map['systemToken'];
        }
        if (isset($map['tableFieldIds'])) {
            $model->tableFieldIds = $map['tableFieldIds'];
        }
        if (isset($map['updateFormDataJson'])) {
            $model->updateFormDataJson = $map['updateFormDataJson'];
        }
        if (isset($map['useAlias'])) {
            $model->useAlias = $map['useAlias'];
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
