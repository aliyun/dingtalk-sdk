<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\QuerySchemaByProcessCodeResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\QuerySchemaByProcessCodeResponseBody\result\schemaContent;
use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @description 表单类型。
     *
     * @var int
     */
    public $appType;

    /**
     * @description 表单应用 uuid 或者 corpId。
     *
     * @var string
     */
    public $appUuid;

    /**
     * @description 代表表单业务含义的类型。
     *
     * @var string
     */
    public $bizType;

    /**
     * @description 创建人 userId。
     *
     * @var string
     */
    public $creatorUserId;

    /**
     * @description 业务自定义设置数据。
     *
     * @var string
     */
    public $customSetting;

    /**
     * @description 引擎类型，表单：0，页面：1
     *
     * @var int
     */
    public $engineType;

    /**
     * @description 表单的唯一码。
     *
     * @var string
     */
    public $formCode;

    /**
     * @description 表单 uuid。
     *
     * @var string
     */
    public $formUuid;

    /**
     * @description 创建时间的时间戳。
     *
     * @var string
     */
    public $gmtCreate;

    /**
     * @description 修改时间的时间戳。
     *
     * @var string
     */
    public $gmtModified;

    /**
     * @description 图标。
     *
     * @var string
     */
    public $icon;

    /**
     * @description 排序 id。
     *
     * @var int
     */
    public $listOrder;

    /**
     * @description 说明文案。
     *
     * @var string
     */
    public $memo;

    /**
     * @description 表单名称。
     *
     * @var string
     */
    public $name;

    /**
     * @description 数据归属者的 id 类型。企业(orgId), 群(cid), 人(uid)。
     *
     * @var string
     */
    public $ownerIdType;

    /**
     * @description 目标类型: inner, outer, customer。
     *
     * @var string
     */
    public $procType;

    /**
     * @description 表单 schema 详情。
     *
     * @var schemaContent
     */
    public $schemaContent;

    /**
     * @description 状态, PUBLISHED(启用), INVALID(停用), SAVED(草稿)
     *
     * @var string
     */
    public $status;

    /**
     * @description 可见范围类型。
     *
     * @var string
     */
    public $visibleRange;
    protected $_name = [
        'appType'       => 'appType',
        'appUuid'       => 'appUuid',
        'bizType'       => 'bizType',
        'creatorUserId' => 'creatorUserId',
        'customSetting' => 'customSetting',
        'engineType'    => 'engineType',
        'formCode'      => 'formCode',
        'formUuid'      => 'formUuid',
        'gmtCreate'     => 'gmtCreate',
        'gmtModified'   => 'gmtModified',
        'icon'          => 'icon',
        'listOrder'     => 'listOrder',
        'memo'          => 'memo',
        'name'          => 'name',
        'ownerIdType'   => 'ownerIdType',
        'procType'      => 'procType',
        'schemaContent' => 'schemaContent',
        'status'        => 'status',
        'visibleRange'  => 'visibleRange',
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
