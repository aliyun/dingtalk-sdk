<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vteam_sphere_1_0\Models\SearchProjectsV3ResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vteam_sphere_1_0\Models\SearchProjectsV3ResponseBody\result\customfields;
use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @example 2022-07-04T03:29:34.770Z
     *
     * @var string
     */
    public $created;

    /**
     * @var string
     */
    public $creatorId;

    /**
     * @var customfields[]
     */
    public $customfields;

    /**
     * @var string
     */
    public $description;

    /**
     * @example 2022-07-04T03:29:34.770Z
     *
     * @var string
     */
    public $endDate;

    /**
     * @var string
     */
    public $id;

    /**
     * @var bool
     */
    public $isArchived;

    /**
     * @var bool
     */
    public $isSuspended;

    /**
     * @var bool
     */
    public $isTemplate;

    /**
     * @var string
     */
    public $logo;

    /**
     * @var string
     */
    public $name;

    /**
     * @var string
     */
    public $organizationId;

    /**
     * @var string
     */
    public $sourceId;

    /**
     * @example 2022-07-04T03:29:34.770Z
     *
     * @var string
     */
    public $startDate;

    /**
     * @var string
     */
    public $uniqueIdPrefix;

    /**
     * @example 2022-07-04T03:29:34.770Z
     *
     * @var string
     */
    public $updated;

    /**
     * @var string
     */
    public $visibility;
    protected $_name = [
        'created'        => 'created',
        'creatorId'      => 'creatorId',
        'customfields'   => 'customfields',
        'description'    => 'description',
        'endDate'        => 'endDate',
        'id'             => 'id',
        'isArchived'     => 'isArchived',
        'isSuspended'    => 'isSuspended',
        'isTemplate'     => 'isTemplate',
        'logo'           => 'logo',
        'name'           => 'name',
        'organizationId' => 'organizationId',
        'sourceId'       => 'sourceId',
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
        if (null !== $this->id) {
            $res['id'] = $this->id;
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
        if (null !== $this->sourceId) {
            $res['sourceId'] = $this->sourceId;
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
        if (isset($map['id'])) {
            $model->id = $map['id'];
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
        if (isset($map['sourceId'])) {
            $model->sourceId = $map['sourceId'];
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
