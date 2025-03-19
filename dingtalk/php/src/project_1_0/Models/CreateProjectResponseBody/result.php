<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\CreateProjectResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\CreateProjectResponseBody\result\customFields;
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
     * @example 0517xxxxxxx
     *
     * @var string
     */
    public $creatorId;

    /**
     * @var customFields[]
     */
    public $customFields;

    /**
     * @example 6398042ec98a4e4e33xxxxxx
     *
     * @var string
     */
    public $defaultCollectionId;

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
     * @example "https://tcs-ga.teambition.net/thumb/xxxxxxx
     *
     * @var string
     */
    public $logo;

    /**
     * @example 项目1
     *
     * @var string
     */
    public $name;

    /**
     * @example taskflow
     *
     * @var string
     */
    public $normalType;

    /**
     * @example 62c25e3b376ecxxxxxxx
     *
     * @var string
     */
    public $projectId;

    /**
     * @example 6398042ec98a4e4e33
     *
     * @var string
     */
    public $rootCollectionId;

    /**
     * @example 62c25e3b376ecxxxxxxx
     *
     * @var string
     */
    public $sourceId;

    /**
     * @example ""
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
     * @example project
     *
     * @var string
     */
    public $visibility;
    protected $_name = [
        'created' => 'created',
        'creatorId' => 'creatorId',
        'customFields' => 'customFields',
        'defaultCollectionId' => 'defaultCollectionId',
        'isArchived' => 'isArchived',
        'isSuspended' => 'isSuspended',
        'isTemplate' => 'isTemplate',
        'logo' => 'logo',
        'name' => 'name',
        'normalType' => 'normalType',
        'projectId' => 'projectId',
        'rootCollectionId' => 'rootCollectionId',
        'sourceId' => 'sourceId',
        'uniqueIdPrefix' => 'uniqueIdPrefix',
        'updated' => 'updated',
        'visibility' => 'visibility',
    ];

    public function validate() {}

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
        if (null !== $this->defaultCollectionId) {
            $res['defaultCollectionId'] = $this->defaultCollectionId;
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
        if (null !== $this->normalType) {
            $res['normalType'] = $this->normalType;
        }
        if (null !== $this->projectId) {
            $res['projectId'] = $this->projectId;
        }
        if (null !== $this->rootCollectionId) {
            $res['rootCollectionId'] = $this->rootCollectionId;
        }
        if (null !== $this->sourceId) {
            $res['sourceId'] = $this->sourceId;
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
                $n = 0;
                foreach ($map['customFields'] as $item) {
                    $model->customFields[$n++] = null !== $item ? customFields::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['defaultCollectionId'])) {
            $model->defaultCollectionId = $map['defaultCollectionId'];
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
        if (isset($map['normalType'])) {
            $model->normalType = $map['normalType'];
        }
        if (isset($map['projectId'])) {
            $model->projectId = $map['projectId'];
        }
        if (isset($map['rootCollectionId'])) {
            $model->rootCollectionId = $map['rootCollectionId'];
        }
        if (isset($map['sourceId'])) {
            $model->sourceId = $map['sourceId'];
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
