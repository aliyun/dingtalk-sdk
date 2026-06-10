<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vstorage_2_0\Models\ListStarsResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vstorage_2_0\Models\ListStarsResponseBody\starList\resource;
use AlibabaCloud\Tea\Model;

class starList extends Model
{
    /**
     * @var string
     */
    public $createTime;

    /**
     * @var string
     */
    public $id;

    /**
     * @var string
     */
    public $location;

    /**
     * @var resource
     */
    public $resource;

    /**
     * @var string
     */
    public $resourceType;

    /**
     * @var int
     */
    public $starType;
    protected $_name = [
        'createTime' => 'createTime',
        'id' => 'id',
        'location' => 'location',
        'resource' => 'resource',
        'resourceType' => 'resourceType',
        'starType' => 'starType',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->createTime) {
            $res['createTime'] = $this->createTime;
        }
        if (null !== $this->id) {
            $res['id'] = $this->id;
        }
        if (null !== $this->location) {
            $res['location'] = $this->location;
        }
        if (null !== $this->resource) {
            $res['resource'] = null !== $this->resource ? $this->resource->toMap() : null;
        }
        if (null !== $this->resourceType) {
            $res['resourceType'] = $this->resourceType;
        }
        if (null !== $this->starType) {
            $res['starType'] = $this->starType;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return starList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['createTime'])) {
            $model->createTime = $map['createTime'];
        }
        if (isset($map['id'])) {
            $model->id = $map['id'];
        }
        if (isset($map['location'])) {
            $model->location = $map['location'];
        }
        if (isset($map['resource'])) {
            $model->resource = resource::fromMap($map['resource']);
        }
        if (isset($map['resourceType'])) {
            $model->resourceType = $map['resourceType'];
        }
        if (isset($map['starType'])) {
            $model->starType = $map['starType'];
        }

        return $model;
    }
}
