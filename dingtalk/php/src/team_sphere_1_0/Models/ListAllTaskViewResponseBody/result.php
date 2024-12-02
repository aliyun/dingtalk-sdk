<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vteam_sphere_1_0\Models\ListAllTaskViewResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vteam_sphere_1_0\Models\ListAllTaskViewResponseBody\result\groupType;
use AlibabaCloud\SDK\Dingtalk\Vteam_sphere_1_0\Models\ListAllTaskViewResponseBody\result\orderType;
use AlibabaCloud\SDK\Dingtalk\Vteam_sphere_1_0\Models\ListAllTaskViewResponseBody\result\showType;
use AlibabaCloud\SDK\Dingtalk\Vteam_sphere_1_0\Models\ListAllTaskViewResponseBody\result\viewSetting;
use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @var string
     */
    public $boundToObjectId;

    /**
     * @example user
     *
     * @var string
     */
    public $boundToObjectType;

    /**
     * @example 2022-07-04T03:29:34.770Z
     *
     * @var string
     */
    public $created;

    /**
     * @example 5f687406f05b283425ea8f6f
     *
     * @var string
     */
    public $creatorId;

    /**
     * @example xxxx
     *
     * @var string
     */
    public $description;

    /**
     * @var groupType
     */
    public $groupType;

    /**
     * @var string
     */
    public $id;

    /**
     * @var bool
     */
    public $isDeleted;

    /**
     * @example x项目
     *
     * @var string
     */
    public $name;

    /**
     * @var orderType
     */
    public $orderType;

    /**
     * @example 6139cd1aba5b128516ec8c86
     *
     * @var string
     */
    public $organizationId;

    /**
     * @var showType
     */
    public $showType;

    /**
     * @example 2022-07-04T03:29:34.770Z
     *
     * @var string
     */
    public $updated;

    /**
     * @var viewSetting
     */
    public $viewSetting;
    protected $_name = [
        'boundToObjectId'   => 'boundToObjectId',
        'boundToObjectType' => 'boundToObjectType',
        'created'           => 'created',
        'creatorId'         => 'creatorId',
        'description'       => 'description',
        'groupType'         => 'groupType',
        'id'                => 'id',
        'isDeleted'         => 'isDeleted',
        'name'              => 'name',
        'orderType'         => 'orderType',
        'organizationId'    => 'organizationId',
        'showType'          => 'showType',
        'updated'           => 'updated',
        'viewSetting'       => 'viewSetting',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->boundToObjectId) {
            $res['boundToObjectId'] = $this->boundToObjectId;
        }
        if (null !== $this->boundToObjectType) {
            $res['boundToObjectType'] = $this->boundToObjectType;
        }
        if (null !== $this->created) {
            $res['created'] = $this->created;
        }
        if (null !== $this->creatorId) {
            $res['creatorId'] = $this->creatorId;
        }
        if (null !== $this->description) {
            $res['description'] = $this->description;
        }
        if (null !== $this->groupType) {
            $res['groupType'] = null !== $this->groupType ? $this->groupType->toMap() : null;
        }
        if (null !== $this->id) {
            $res['id'] = $this->id;
        }
        if (null !== $this->isDeleted) {
            $res['isDeleted'] = $this->isDeleted;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->orderType) {
            $res['orderType'] = null !== $this->orderType ? $this->orderType->toMap() : null;
        }
        if (null !== $this->organizationId) {
            $res['organizationId'] = $this->organizationId;
        }
        if (null !== $this->showType) {
            $res['showType'] = null !== $this->showType ? $this->showType->toMap() : null;
        }
        if (null !== $this->updated) {
            $res['updated'] = $this->updated;
        }
        if (null !== $this->viewSetting) {
            $res['viewSetting'] = null !== $this->viewSetting ? $this->viewSetting->toMap() : null;
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
        if (isset($map['boundToObjectId'])) {
            $model->boundToObjectId = $map['boundToObjectId'];
        }
        if (isset($map['boundToObjectType'])) {
            $model->boundToObjectType = $map['boundToObjectType'];
        }
        if (isset($map['created'])) {
            $model->created = $map['created'];
        }
        if (isset($map['creatorId'])) {
            $model->creatorId = $map['creatorId'];
        }
        if (isset($map['description'])) {
            $model->description = $map['description'];
        }
        if (isset($map['groupType'])) {
            $model->groupType = groupType::fromMap($map['groupType']);
        }
        if (isset($map['id'])) {
            $model->id = $map['id'];
        }
        if (isset($map['isDeleted'])) {
            $model->isDeleted = $map['isDeleted'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['orderType'])) {
            $model->orderType = orderType::fromMap($map['orderType']);
        }
        if (isset($map['organizationId'])) {
            $model->organizationId = $map['organizationId'];
        }
        if (isset($map['showType'])) {
            $model->showType = showType::fromMap($map['showType']);
        }
        if (isset($map['updated'])) {
            $model->updated = $map['updated'];
        }
        if (isset($map['viewSetting'])) {
            $model->viewSetting = viewSetting::fromMap($map['viewSetting']);
        }

        return $model;
    }
}
