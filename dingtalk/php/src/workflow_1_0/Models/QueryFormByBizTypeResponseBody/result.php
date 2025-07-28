<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\QueryFormByBizTypeResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 应用类型
     *
     * @var int
     */
    public $appType;

    /**
     * @example SWAPP-abcdef-example
     *
     * @var string
     */
    public $appUuid;

    /**
     * @example 表单业务标识
     *
     * @var string
     */
    public $bizType;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $content;

    /**
     * @example 1635151039000
     *
     * @var int
     */
    public $createTime;

    /**
     * @example 02501234567890
     *
     * @var string
     */
    public $creator;

    /**
     * @description This parameter is required.
     *
     * @example PROC-abcdef-example
     *
     * @var string
     */
    public $formCode;

    /**
     * @description This parameter is required.
     *
     * @example FORM-example
     *
     * @var string
     */
    public $formUuid;

    /**
     * @example 用于收集休假信息
     *
     * @var string
     */
    public $memo;

    /**
     * @example 1635151039000
     *
     * @var int
     */
    public $modifedTime;

    /**
     * @description This parameter is required.
     *
     * @example 休假申请
     *
     * @var string
     */
    public $name;

    /**
     * @example 02501234567890
     *
     * @var string
     */
    public $ownerId;

    /**
     * @description This parameter is required.
     *
     * @example PUBLISHED(启用), INVALID(停用), SAVED(草稿)
     *
     * @var string
     */
    public $status;
    protected $_name = [
        'appType' => 'appType',
        'appUuid' => 'appUuid',
        'bizType' => 'bizType',
        'content' => 'content',
        'createTime' => 'createTime',
        'creator' => 'creator',
        'formCode' => 'formCode',
        'formUuid' => 'formUuid',
        'memo' => 'memo',
        'modifedTime' => 'modifedTime',
        'name' => 'name',
        'ownerId' => 'ownerId',
        'status' => 'status',
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
        if (null !== $this->content) {
            $res['content'] = $this->content;
        }
        if (null !== $this->createTime) {
            $res['createTime'] = $this->createTime;
        }
        if (null !== $this->creator) {
            $res['creator'] = $this->creator;
        }
        if (null !== $this->formCode) {
            $res['formCode'] = $this->formCode;
        }
        if (null !== $this->formUuid) {
            $res['formUuid'] = $this->formUuid;
        }
        if (null !== $this->memo) {
            $res['memo'] = $this->memo;
        }
        if (null !== $this->modifedTime) {
            $res['modifedTime'] = $this->modifedTime;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->ownerId) {
            $res['ownerId'] = $this->ownerId;
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
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
        if (isset($map['content'])) {
            $model->content = $map['content'];
        }
        if (isset($map['createTime'])) {
            $model->createTime = $map['createTime'];
        }
        if (isset($map['creator'])) {
            $model->creator = $map['creator'];
        }
        if (isset($map['formCode'])) {
            $model->formCode = $map['formCode'];
        }
        if (isset($map['formUuid'])) {
            $model->formUuid = $map['formUuid'];
        }
        if (isset($map['memo'])) {
            $model->memo = $map['memo'];
        }
        if (isset($map['modifedTime'])) {
            $model->modifedTime = $map['modifedTime'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['ownerId'])) {
            $model->ownerId = $map['ownerId'];
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }

        return $model;
    }
}
