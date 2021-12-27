<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\QuerySchemaByProcessCodeResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\QuerySchemaByProcessCodeResponseBody\result\schemaContent;
use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @description 创建人 userId。
     *
     * @var string
     */
    public $creatorUserId;

    /**
     * @description 创建人 uid。
     *
     * @var int
     */
    public $creatorUid;

    /**
     * @description 表单应用 uuid 或者 corpId。
     *
     * @var string
     */
    public $appUuid;

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
     * @description 表单名称。
     *
     * @var string
     */
    public $name;

    /**
     * @description 说明文案。
     *
     * @var string
     */
    public $memo;

    /**
     * @description 数据归属者的 id。
     *
     * @var string
     */
    public $ownerId;

    /**
     * @description 数据归属者的 id 类型。企业(orgId), 群(cid), 人(uid)。
     *
     * @var string
     */
    public $ownerIdType;

    /**
     * @description 表单 schema 详情。
     *
     * @var schemaContent
     */
    public $schemaContent;

    /**
     * @description 图标。
     *
     * @var string
     */
    public $icon;

    /**
     * @description 表单类型。
     *
     * @var int
     */
    public $appType;

    /**
     * @description 代表表单业务含义的类型。
     *
     * @var string
     */
    public $bizType;

    /**
     * @description 引擎类型，表单：0，页面：1
     *
     * @var int
     */
    public $engineType;

    /**
     * @description 状态, PUBLISHED(启用), INVALID(停用), SAVED(草稿)
     *
     * @var string
     */
    public $status;

    /**
     * @description 排序 id。
     *
     * @var int
     */
    public $listOrder;

    /**
     * @description 业务自定义设置数据。
     *
     * @var string
     */
    public $customSetting;

    /**
     * @description 目标类型: inner, outer, customer。
     *
     * @var string
     */
    public $procType;

    /**
     * @description 可见范围类型。
     *
     * @var string
     */
    public $visibleRange;

    /**
     * @description 创建时间的时间戳。
     *
     * @var int
     */
    public $gmtCreate;

    /**
     * @description 修改时间的时间戳。
     *
     * @var int
     */
    public $gmtModified;
    protected $_name = [
        'creatorUserId' => 'creatorUserId',
        'creatorUid'    => 'creatorUid',
        'appUuid'       => 'appUuid',
        'formCode'      => 'formCode',
        'formUuid'      => 'formUuid',
        'name'          => 'name',
        'memo'          => 'memo',
        'ownerId'       => 'ownerId',
        'ownerIdType'   => 'ownerIdType',
        'schemaContent' => 'schemaContent',
        'icon'          => 'icon',
        'appType'       => 'appType',
        'bizType'       => 'bizType',
        'engineType'    => 'engineType',
        'status'        => 'status',
        'listOrder'     => 'listOrder',
        'customSetting' => 'customSetting',
        'procType'      => 'procType',
        'visibleRange'  => 'visibleRange',
        'gmtCreate'     => 'gmtCreate',
        'gmtModified'   => 'gmtModified',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->creatorUserId) {
            $res['creatorUserId'] = $this->creatorUserId;
        }
        if (null !== $this->creatorUid) {
            $res['creatorUid'] = $this->creatorUid;
        }
        if (null !== $this->appUuid) {
            $res['appUuid'] = $this->appUuid;
        }
        if (null !== $this->formCode) {
            $res['formCode'] = $this->formCode;
        }
        if (null !== $this->formUuid) {
            $res['formUuid'] = $this->formUuid;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->memo) {
            $res['memo'] = $this->memo;
        }
        if (null !== $this->ownerId) {
            $res['ownerId'] = $this->ownerId;
        }
        if (null !== $this->ownerIdType) {
            $res['ownerIdType'] = $this->ownerIdType;
        }
        if (null !== $this->schemaContent) {
            $res['schemaContent'] = null !== $this->schemaContent ? $this->schemaContent->toMap() : null;
        }
        if (null !== $this->icon) {
            $res['icon'] = $this->icon;
        }
        if (null !== $this->appType) {
            $res['appType'] = $this->appType;
        }
        if (null !== $this->bizType) {
            $res['bizType'] = $this->bizType;
        }
        if (null !== $this->engineType) {
            $res['engineType'] = $this->engineType;
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }
        if (null !== $this->listOrder) {
            $res['listOrder'] = $this->listOrder;
        }
        if (null !== $this->customSetting) {
            $res['customSetting'] = $this->customSetting;
        }
        if (null !== $this->procType) {
            $res['procType'] = $this->procType;
        }
        if (null !== $this->visibleRange) {
            $res['visibleRange'] = $this->visibleRange;
        }
        if (null !== $this->gmtCreate) {
            $res['gmtCreate'] = $this->gmtCreate;
        }
        if (null !== $this->gmtModified) {
            $res['gmtModified'] = $this->gmtModified;
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
        if (isset($map['creatorUserId'])) {
            $model->creatorUserId = $map['creatorUserId'];
        }
        if (isset($map['creatorUid'])) {
            $model->creatorUid = $map['creatorUid'];
        }
        if (isset($map['appUuid'])) {
            $model->appUuid = $map['appUuid'];
        }
        if (isset($map['formCode'])) {
            $model->formCode = $map['formCode'];
        }
        if (isset($map['formUuid'])) {
            $model->formUuid = $map['formUuid'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['memo'])) {
            $model->memo = $map['memo'];
        }
        if (isset($map['ownerId'])) {
            $model->ownerId = $map['ownerId'];
        }
        if (isset($map['ownerIdType'])) {
            $model->ownerIdType = $map['ownerIdType'];
        }
        if (isset($map['schemaContent'])) {
            $model->schemaContent = schemaContent::fromMap($map['schemaContent']);
        }
        if (isset($map['icon'])) {
            $model->icon = $map['icon'];
        }
        if (isset($map['appType'])) {
            $model->appType = $map['appType'];
        }
        if (isset($map['bizType'])) {
            $model->bizType = $map['bizType'];
        }
        if (isset($map['engineType'])) {
            $model->engineType = $map['engineType'];
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }
        if (isset($map['listOrder'])) {
            $model->listOrder = $map['listOrder'];
        }
        if (isset($map['customSetting'])) {
            $model->customSetting = $map['customSetting'];
        }
        if (isset($map['procType'])) {
            $model->procType = $map['procType'];
        }
        if (isset($map['visibleRange'])) {
            $model->visibleRange = $map['visibleRange'];
        }
        if (isset($map['gmtCreate'])) {
            $model->gmtCreate = $map['gmtCreate'];
        }
        if (isset($map['gmtModified'])) {
            $model->gmtModified = $map['gmtModified'];
        }

        return $model;
    }
}
