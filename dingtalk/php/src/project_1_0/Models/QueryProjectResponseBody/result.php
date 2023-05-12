<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\QueryProjectResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\QueryProjectResponseBody\result\customFields;
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
     * @example 0715153011125xxxx
     *
     * @var string
     */
    public $creatorId;

    /**
     * @var customFields[]
     */
    public $customFields;

    /**
     * @example 描述内容
     *
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
     * @example false
     *
     * @var bool
     */
    public $isArchived;

    /**
     * @example false
     *
     * @var bool
     */
    public $isSuspended;

    /**
     * @example false
     *
     * @var bool
     */
    public $isTemplate;

    /**
     * @example http://xxxxx
     *
     * @var string
     */
    public $logo;

    /**
     * @example 测试项目
     *
     * @var string
     */
    public $name;

    /**
     * @example dingc23b7b9682b4xxxx
     *
     * @var string
     */
    public $organizationId;

    /**
     * @example 64ba333e4206372f3f5cxxxx
     *
     * @var string
     */
    public $projectId;

    /**
     * @example 2022-07-04T03:29:34.770Z
     *
     * @var string
     */
    public $startDate;

    /**
     * @example UNI
     *
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
     * @example organization
     *
     * @var string
     */
    public $visibility;
    protected $_name = [
        'created'        => 'created',
        'creatorId'      => 'creatorId',
        'customFields'   => 'customFields',
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
        if (null !== $this->customFields) {
            $res['customFields'] = [];
            if (null !== $this->customFields && \is_array($this->customFields)) {
                $n = 0;
                foreach ($this->customFields as $item) {
                    $res['customFields'][$n++] = null !== $item ? $item->toMap() : $item;
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
        if (isset($map['customFields'])) {
            if (!empty($map['customFields'])) {
                $model->customFields = [];
                $n                   = 0;
                foreach ($map['customFields'] as $item) {
                    $model->customFields[$n++] = null !== $item ? customFields::fromMap($item) : $item;
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
