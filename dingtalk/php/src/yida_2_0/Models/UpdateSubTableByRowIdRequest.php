<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vyida_2_0\Models;

use AlibabaCloud\Tea\Model;

class UpdateSubTableByRowIdRequest extends Model
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
    public $formUuid;

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
    public $tableFieldId;

    /**
     * @description This parameter is required.
     *
     * @example [{"textField_md2x1jow":"更新子表通过rowId","textareaField_md2x1jox":"更新子表通过rowId","rowId":"xxxxxxxxxxxxxxxx"},{"textField_md2x1jow":"更新子表通过rowId","textareaField_md2x1jox":"更新子表通过rowId","rowId":"xxxxxxxxxxxxxxxx"}]
     *
     * @var string
     */
    public $updateSubTableDataJson;

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
        'formUuid' => 'formUuid',
        'systemToken' => 'systemToken',
        'tableFieldId' => 'tableFieldId',
        'updateSubTableDataJson' => 'updateSubTableDataJson',
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
        if (null !== $this->formUuid) {
            $res['formUuid'] = $this->formUuid;
        }
        if (null !== $this->systemToken) {
            $res['systemToken'] = $this->systemToken;
        }
        if (null !== $this->tableFieldId) {
            $res['tableFieldId'] = $this->tableFieldId;
        }
        if (null !== $this->updateSubTableDataJson) {
            $res['updateSubTableDataJson'] = $this->updateSubTableDataJson;
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
     * @return UpdateSubTableByRowIdRequest
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
        if (isset($map['formUuid'])) {
            $model->formUuid = $map['formUuid'];
        }
        if (isset($map['systemToken'])) {
            $model->systemToken = $map['systemToken'];
        }
        if (isset($map['tableFieldId'])) {
            $model->tableFieldId = $map['tableFieldId'];
        }
        if (isset($map['updateSubTableDataJson'])) {
            $model->updateSubTableDataJson = $map['updateSubTableDataJson'];
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
