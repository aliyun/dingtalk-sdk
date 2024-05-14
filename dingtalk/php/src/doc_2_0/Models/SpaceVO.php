<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\SpaceVO\iconVO;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\SpaceVO\owner;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\SpaceVO\visitorInfo;
use AlibabaCloud\Tea\Model;

class SpaceVO extends Model
{
    /**
     * @var string
     */
    public $cover;

    /**
     * @var string
     */
    public $description;

    /**
     * @var iconVO
     */
    public $iconVO;

    /**
     * @description This parameter is required.
     *
     * @example abc
     *
     * @var string
     */
    public $id;

    /**
     * @description This parameter is required.
     *
     * @example hello
     *
     * @var string
     */
    public $name;

    /**
     * @var owner
     */
    public $owner;

    /**
     * @example 1
     *
     * @var int
     */
    public $type;

    /**
     * @example https://xx.yy
     *
     * @var string
     */
    public $url;

    /**
     * @var visitorInfo
     */
    public $visitorInfo;
    protected $_name = [
        'cover'       => 'cover',
        'description' => 'description',
        'iconVO'      => 'iconVO',
        'id'          => 'id',
        'name'        => 'name',
        'owner'       => 'owner',
        'type'        => 'type',
        'url'         => 'url',
        'visitorInfo' => 'visitorInfo',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->cover) {
            $res['cover'] = $this->cover;
        }
        if (null !== $this->description) {
            $res['description'] = $this->description;
        }
        if (null !== $this->iconVO) {
            $res['iconVO'] = null !== $this->iconVO ? $this->iconVO->toMap() : null;
        }
        if (null !== $this->id) {
            $res['id'] = $this->id;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->owner) {
            $res['owner'] = null !== $this->owner ? $this->owner->toMap() : null;
        }
        if (null !== $this->type) {
            $res['type'] = $this->type;
        }
        if (null !== $this->url) {
            $res['url'] = $this->url;
        }
        if (null !== $this->visitorInfo) {
            $res['visitorInfo'] = null !== $this->visitorInfo ? $this->visitorInfo->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return SpaceVO
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['cover'])) {
            $model->cover = $map['cover'];
        }
        if (isset($map['description'])) {
            $model->description = $map['description'];
        }
        if (isset($map['iconVO'])) {
            $model->iconVO = iconVO::fromMap($map['iconVO']);
        }
        if (isset($map['id'])) {
            $model->id = $map['id'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['owner'])) {
            $model->owner = owner::fromMap($map['owner']);
        }
        if (isset($map['type'])) {
            $model->type = $map['type'];
        }
        if (isset($map['url'])) {
            $model->url = $map['url'];
        }
        if (isset($map['visitorInfo'])) {
            $model->visitorInfo = visitorInfo::fromMap($map['visitorInfo']);
        }

        return $model;
    }
}
