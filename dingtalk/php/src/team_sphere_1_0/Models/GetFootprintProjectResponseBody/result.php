<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vteam_sphere_1_0\Models\GetFootprintProjectResponseBody;

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
     * @example 1234
     *
     * @var string
     */
    public $id;

    /**
     * @example true
     *
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
     * @example 6139cd1aba5b128516ec8c86
     *
     * @var string
     */
    public $organizationId;

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
        'created'        => 'created',
        'creatorId'      => 'creatorId',
        'description'    => 'description',
        'id'             => 'id',
        'isDeleted'      => 'isDeleted',
        'name'           => 'name',
        'organizationId' => 'organizationId',
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
        if (null !== $this->description) {
            $res['description'] = $this->description;
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
        if (null !== $this->organizationId) {
            $res['organizationId'] = $this->organizationId;
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
        if (isset($map['description'])) {
            $model->description = $map['description'];
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
        if (isset($map['organizationId'])) {
            $model->organizationId = $map['organizationId'];
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
