<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\QueryProjectResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\QueryProjectResponseBody\result\customfields;
use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @description 创建时间。
     *
     * @var string
     */
    public $created;

    /**
     * @description 创建人ID。
     *
     * @var string
     */
    public $creatorId;

    /**
     * @description 自定义字段值集合。
     *
     * @var customfields[]
     */
    public $customfields;

    /**
     * @description 项目描述。
     *
     * @var string
     */
    public $description;

    /**
     * @description 项目结束时间。
     *
     * @var string
     */
    public $endDate;

    /**
     * @description 是否放入回收站。
     *
     * @var bool
     */
    public $isArchived;

    /**
     * @description 是否归档。
     *
     * @var bool
     */
    public $isSuspended;

    /**
     * @description 是模版项目。
     *
     * @var bool
     */
    public $isTemplate;

    /**
     * @description 项目LOGO。
     *
     * @var string
     */
    public $logo;

    /**
     * @description 项目名称。
     *
     * @var string
     */
    public $name;

    /**
     * @description 企业ID。
     *
     * @var string
     */
    public $organizationId;

    /**
     * @description 项目ID。
     *
     * @var string
     */
    public $projectId;

    /**
     * @description 项目开始时间。
     *
     * @var string
     */
    public $startDate;

    /**
     * @description 任务ID前缀。
     *
     * @var string
     */
    public $uniqueIdPrefix;

    /**
     * @description 更新时间。
     *
     * @var string
     */
    public $updated;

    /**
     * @description 可见性，project | organization。
     *
     * @var string
     */
    public $visibility;
    protected $_name = [
        'created'        => 'created',
        'creatorId'      => 'creatorId',
        'customfields'   => 'customfields',
        'description'    => 'description',
        'endDate'        => 'endDate',
        'isArchived'     => 'isArchived',
        'isSuspended'    => 'isSuspended',
        'isTemplate'     => 'isTemplate',
        'logo'           => 'logo',
        'name'           => 'name',
        'organizationId' => 'organizationId',
        'projectId'      => 'projectId',
        'startDate'      => 'startDate',
        'uniqueIdPrefix' => 'uniqueIdPrefix',
        'updated'        => 'updated',
        'visibility'     => 'visibility',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->created) {
            $res['created'] = $this->created;
        }
        if (null !== $this->creatorId) {
            $res['creatorId'] = $this->creatorId;
        }
        if (null !== $this->customfields) {
            $res['customfields'] = [];
            if (null !== $this->customfields && \is_array($this->customfields)) {
                $n = 0;
                foreach ($this->customfields as $item) {
                    $res['customfields'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->description) {
            $res['description'] = $this->description;
        }
        if (null !== $this->endDate) {
            $res['endDate'] = $this->endDate;
        }
        if (null !== $this->isArchived) {
            $res['isArchived'] = $this->isArchived;
        }
        if (null !== $this->isSuspended) {
            $res['isSuspended'] = $this->isSuspended;
        }
        if (null !== $this->isTemplate) {
            $res['isTemplate'] = $this->isTemplate;
        }
        if (null !== $this->logo) {
            $res['logo'] = $this->logo;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->organizationId) {
            $res['organizationId'] = $this->organizationId;
        }
        if (null !== $this->projectId) {
            $res['projectId'] = $this->projectId;
        }
        if (null !== $this->startDate) {
            $res['startDate'] = $this->startDate;
        }
        if (null !== $this->uniqueIdPrefix) {
            $res['uniqueIdPrefix'] = $this->uniqueIdPrefix;
        }
        if (null !== $this->updated) {
            $res['updated'] = $this->updated;
        }
        if (null !== $this->visibility) {
            $res['visibility'] = $this->visibility;
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
        if (isset($map['created'])) {
            $model->created = $map['created'];
        }
        if (isset($map['creatorId'])) {
            $model->creatorId = $map['creatorId'];
        }
        if (isset($map['customfields'])) {
            if (!empty($map['customfields'])) {
                $model->customfields = [];
                $n                   = 0;
                foreach ($map['customfields'] as $item) {
                    $model->customfields[$n++] = null !== $item ? customfields::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['description'])) {
            $model->description = $map['description'];
        }
        if (isset($map['endDate'])) {
            $model->endDate = $map['endDate'];
        }
        if (isset($map['isArchived'])) {
            $model->isArchived = $map['isArchived'];
        }
        if (isset($map['isSuspended'])) {
            $model->isSuspended = $map['isSuspended'];
        }
        if (isset($map['isTemplate'])) {
            $model->isTemplate = $map['isTemplate'];
        }
        if (isset($map['logo'])) {
            $model->logo = $map['logo'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['organizationId'])) {
            $model->organizationId = $map['organizationId'];
        }
        if (isset($map['projectId'])) {
            $model->projectId = $map['projectId'];
        }
        if (isset($map['startDate'])) {
            $model->startDate = $map['startDate'];
        }
        if (isset($map['uniqueIdPrefix'])) {
            $model->uniqueIdPrefix = $map['uniqueIdPrefix'];
        }
        if (isset($map['updated'])) {
            $model->updated = $map['updated'];
        }
        if (isset($map['visibility'])) {
            $model->visibility = $map['visibility'];
        }

        return $model;
    }
}
