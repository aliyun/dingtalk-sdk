<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models\AddRosterFieldFormResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @var int
     */
    public $bizGroupId;

    /**
     * @var string
     */
    public $content;

    /**
     * @var string
     */
    public $corpId;

    /**
     * @var string
     */
    public $deleteFlag;

    /**
     * @var bool
     */
    public $detail;

    /**
     * @var string
     */
    public $formId;

    /**
     * @var mixed
     */
    public $gmtCreate;

    /**
     * @var mixed
     */
    public $gmtModified;

    /**
     * @var string
     */
    public $icon;

    /**
     * @var int
     */
    public $id;

    /**
     * @var string
     */
    public $memo;

    /**
     * @var string
     */
    public $name;

    /**
     * @var int
     */
    public $sortOrder;

    /**
     * @var int
     */
    public $versionId;
    protected $_name = [
        'bizGroupId' => 'bizGroupId',
        'content' => 'content',
        'corpId' => 'corpId',
        'deleteFlag' => 'deleteFlag',
        'detail' => 'detail',
        'formId' => 'formId',
        'gmtCreate' => 'gmtCreate',
        'gmtModified' => 'gmtModified',
        'icon' => 'icon',
        'id' => 'id',
        'memo' => 'memo',
        'name' => 'name',
        'sortOrder' => 'sortOrder',
        'versionId' => 'versionId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->bizGroupId) {
            $res['bizGroupId'] = $this->bizGroupId;
        }
        if (null !== $this->content) {
            $res['content'] = $this->content;
        }
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->deleteFlag) {
            $res['deleteFlag'] = $this->deleteFlag;
        }
        if (null !== $this->detail) {
            $res['detail'] = $this->detail;
        }
        if (null !== $this->formId) {
            $res['formId'] = $this->formId;
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
        if (null !== $this->id) {
            $res['id'] = $this->id;
        }
        if (null !== $this->memo) {
            $res['memo'] = $this->memo;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->sortOrder) {
            $res['sortOrder'] = $this->sortOrder;
        }
        if (null !== $this->versionId) {
            $res['versionId'] = $this->versionId;
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
        if (isset($map['bizGroupId'])) {
            $model->bizGroupId = $map['bizGroupId'];
        }
        if (isset($map['content'])) {
            $model->content = $map['content'];
        }
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['deleteFlag'])) {
            $model->deleteFlag = $map['deleteFlag'];
        }
        if (isset($map['detail'])) {
            $model->detail = $map['detail'];
        }
        if (isset($map['formId'])) {
            $model->formId = $map['formId'];
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
        if (isset($map['id'])) {
            $model->id = $map['id'];
        }
        if (isset($map['memo'])) {
            $model->memo = $map['memo'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['sortOrder'])) {
            $model->sortOrder = $map['sortOrder'];
        }
        if (isset($map['versionId'])) {
            $model->versionId = $map['versionId'];
        }

        return $model;
    }
}
