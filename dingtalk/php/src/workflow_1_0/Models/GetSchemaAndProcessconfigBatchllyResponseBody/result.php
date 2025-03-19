<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\GetSchemaAndProcessconfigBatchllyResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @var string
     */
    public $appUuid;

    /**
     * @var string
     */
    public $bizCategoryId;

    /**
     * @var string
     */
    public $createTime;

    /**
     * @var string
     */
    public $creatorUserId;

    /**
     * @var string
     */
    public $formUuid;

    /**
     * @var string
     */
    public $managerList;

    /**
     * @var string
     */
    public $memo;

    /**
     * @var string
     */
    public $name;

    /**
     * @var string
     */
    public $processCode;

    /**
     * @var string
     */
    public $processConfig;

    /**
     * @var int
     */
    public $processId;

    /**
     * @var string
     */
    public $properties;

    /**
     * @var string
     */
    public $schemaContent;

    /**
     * @var string
     */
    public $visibleScope;
    protected $_name = [
        'appUuid' => 'appUuid',
        'bizCategoryId' => 'bizCategoryId',
        'createTime' => 'createTime',
        'creatorUserId' => 'creatorUserId',
        'formUuid' => 'formUuid',
        'managerList' => 'managerList',
        'memo' => 'memo',
        'name' => 'name',
        'processCode' => 'processCode',
        'processConfig' => 'processConfig',
        'processId' => 'processId',
        'properties' => 'properties',
        'schemaContent' => 'schemaContent',
        'visibleScope' => 'visibleScope',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->appUuid) {
            $res['appUuid'] = $this->appUuid;
        }
        if (null !== $this->bizCategoryId) {
            $res['bizCategoryId'] = $this->bizCategoryId;
        }
        if (null !== $this->createTime) {
            $res['createTime'] = $this->createTime;
        }
        if (null !== $this->creatorUserId) {
            $res['creatorUserId'] = $this->creatorUserId;
        }
        if (null !== $this->formUuid) {
            $res['formUuid'] = $this->formUuid;
        }
        if (null !== $this->managerList) {
            $res['managerList'] = $this->managerList;
        }
        if (null !== $this->memo) {
            $res['memo'] = $this->memo;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->processCode) {
            $res['processCode'] = $this->processCode;
        }
        if (null !== $this->processConfig) {
            $res['processConfig'] = $this->processConfig;
        }
        if (null !== $this->processId) {
            $res['processId'] = $this->processId;
        }
        if (null !== $this->properties) {
            $res['properties'] = $this->properties;
        }
        if (null !== $this->schemaContent) {
            $res['schemaContent'] = $this->schemaContent;
        }
        if (null !== $this->visibleScope) {
            $res['visibleScope'] = $this->visibleScope;
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
        if (isset($map['appUuid'])) {
            $model->appUuid = $map['appUuid'];
        }
        if (isset($map['bizCategoryId'])) {
            $model->bizCategoryId = $map['bizCategoryId'];
        }
        if (isset($map['createTime'])) {
            $model->createTime = $map['createTime'];
        }
        if (isset($map['creatorUserId'])) {
            $model->creatorUserId = $map['creatorUserId'];
        }
        if (isset($map['formUuid'])) {
            $model->formUuid = $map['formUuid'];
        }
        if (isset($map['managerList'])) {
            $model->managerList = $map['managerList'];
        }
        if (isset($map['memo'])) {
            $model->memo = $map['memo'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['processCode'])) {
            $model->processCode = $map['processCode'];
        }
        if (isset($map['processConfig'])) {
            $model->processConfig = $map['processConfig'];
        }
        if (isset($map['processId'])) {
            $model->processId = $map['processId'];
        }
        if (isset($map['properties'])) {
            $model->properties = $map['properties'];
        }
        if (isset($map['schemaContent'])) {
            $model->schemaContent = $map['schemaContent'];
        }
        if (isset($map['visibleScope'])) {
            $model->visibleScope = $map['visibleScope'];
        }

        return $model;
    }
}
