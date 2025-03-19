<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\QuerySchemaByProcessCodeResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\QuerySchemaByProcessCodeResponseBody\result\schemaContent;
use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 0
     *
     * @var int
     */
    public $appType;

    /**
     * @description This parameter is required.
     *
     * @example xxxx
     *
     * @var string
     */
    public $appUuid;

    /**
     * @example hrm.xxxx
     *
     * @var string
     */
    public $bizType;

    /**
     * @description This parameter is required.
     *
     * @example 26652461xxxx5992
     *
     * @var string
     */
    public $creatorUserId;

    /**
     * @example null
     *
     * @var string
     */
    public $customSetting;

    /**
     * @example 0
     *
     * @var int
     */
    public $engineType;

    /**
     * @description This parameter is required.
     *
     * @example PROC-17428B8C-6C60-470E-xxxx-64F1037AE067
     *
     * @var string
     */
    public $formCode;

    /**
     * @description This parameter is required.
     *
     * @example FORM-28215C3E-00E3-4118-xxxx-4091F828AF2F
     *
     * @var string
     */
    public $formUuid;

    /**
     * @description This parameter is required.
     *
     * @example 2021-12-01T10:49Z
     *
     * @var string
     */
    public $gmtCreate;

    /**
     * @description This parameter is required.
     *
     * @example 2021-12-01T10:49Z
     *
     * @var string
     */
    public $gmtModified;

    /**
     * @example null
     *
     * @var string
     */
    public $icon;

    /**
     * @example 1
     *
     * @var int
     */
    public $listOrder;

    /**
     * @example xxxx
     *
     * @var string
     */
    public $memo;

    /**
     * @example 示例模板
     *
     * @var string
     */
    public $name;

    /**
     * @description This parameter is required.
     *
     * @example 25xxxx01
     *
     * @var string
     */
    public $ownerIdType;

    /**
     * @example inner
     *
     * @var string
     */
    public $procType;

    /**
     * @description This parameter is required.
     *
     * @var schemaContent
     */
    public $schemaContent;

    /**
     * @example PUBLISHED
     *
     * @var string
     */
    public $status;

    /**
     * @example PRIVATE
     *
     * @var string
     */
    public $visibleRange;
    protected $_name = [
        'appType' => 'appType',
        'appUuid' => 'appUuid',
        'bizType' => 'bizType',
        'creatorUserId' => 'creatorUserId',
        'customSetting' => 'customSetting',
        'engineType' => 'engineType',
        'formCode' => 'formCode',
        'formUuid' => 'formUuid',
        'gmtCreate' => 'gmtCreate',
        'gmtModified' => 'gmtModified',
        'icon' => 'icon',
        'listOrder' => 'listOrder',
        'memo' => 'memo',
        'name' => 'name',
        'ownerIdType' => 'ownerIdType',
        'procType' => 'procType',
        'schemaContent' => 'schemaContent',
        'status' => 'status',
        'visibleRange' => 'visibleRange',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->appType) {
            $res['appType'] = $this->appType;
        }
        if (null !== $this->appUuid) {
            $res['appUuid'] = $this->appUuid;
        }
        if (null !== $this->bizType) {
            $res['bizType'] = $this->bizType;
        }
        if (null !== $this->creatorUserId) {
            $res['creatorUserId'] = $this->creatorUserId;
        }
        if (null !== $this->customSetting) {
            $res['customSetting'] = $this->customSetting;
        }
        if (null !== $this->engineType) {
            $res['engineType'] = $this->engineType;
        }
        if (null !== $this->formCode) {
            $res['formCode'] = $this->formCode;
        }
        if (null !== $this->formUuid) {
            $res['formUuid'] = $this->formUuid;
        }
        if (null !== $this->gmtCreate) {
            $res['gmtCreate'] = $this->gmtCreate;
        }
        if (null !== $this->gmtModified) {
            $res['gmtModified'] = $this->gmtModified;
        }
        if (null !== $this->icon) {
            $res['icon'] = $this->icon;
        }
        if (null !== $this->listOrder) {
            $res['listOrder'] = $this->listOrder;
        }
        if (null !== $this->memo) {
            $res['memo'] = $this->memo;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->ownerIdType) {
            $res['ownerIdType'] = $this->ownerIdType;
        }
        if (null !== $this->procType) {
            $res['procType'] = $this->procType;
        }
        if (null !== $this->schemaContent) {
            $res['schemaContent'] = null !== $this->schemaContent ? $this->schemaContent->toMap() : null;
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }
        if (null !== $this->visibleRange) {
            $res['visibleRange'] = $this->visibleRange;
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
        if (isset($map['appType'])) {
            $model->appType = $map['appType'];
        }
        if (isset($map['appUuid'])) {
            $model->appUuid = $map['appUuid'];
        }
        if (isset($map['bizType'])) {
            $model->bizType = $map['bizType'];
        }
        if (isset($map['creatorUserId'])) {
            $model->creatorUserId = $map['creatorUserId'];
        }
        if (isset($map['customSetting'])) {
            $model->customSetting = $map['customSetting'];
        }
        if (isset($map['engineType'])) {
            $model->engineType = $map['engineType'];
        }
        if (isset($map['formCode'])) {
            $model->formCode = $map['formCode'];
        }
        if (isset($map['formUuid'])) {
            $model->formUuid = $map['formUuid'];
        }
        if (isset($map['gmtCreate'])) {
            $model->gmtCreate = $map['gmtCreate'];
        }
        if (isset($map['gmtModified'])) {
            $model->gmtModified = $map['gmtModified'];
        }
        if (isset($map['icon'])) {
            $model->icon = $map['icon'];
        }
        if (isset($map['listOrder'])) {
            $model->listOrder = $map['listOrder'];
        }
        if (isset($map['memo'])) {
            $model->memo = $map['memo'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['ownerIdType'])) {
            $model->ownerIdType = $map['ownerIdType'];
        }
        if (isset($map['procType'])) {
            $model->procType = $map['procType'];
        }
        if (isset($map['schemaContent'])) {
            $model->schemaContent = schemaContent::fromMap($map['schemaContent']);
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }
        if (isset($map['visibleRange'])) {
            $model->visibleRange = $map['visibleRange'];
        }

        return $model;
    }
}
