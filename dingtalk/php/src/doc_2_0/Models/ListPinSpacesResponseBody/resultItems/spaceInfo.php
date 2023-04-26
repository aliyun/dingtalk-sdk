<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\ListPinSpacesResponseBody\resultItems;

use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\ListPinSpacesResponseBody\resultItems\spaceInfo\creator;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\ListPinSpacesResponseBody\resultItems\spaceInfo\iconVO;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\ListPinSpacesResponseBody\resultItems\spaceInfo\modifier;
use AlibabaCloud\Tea\Model;

class spaceInfo extends Model
{
    /**
     * @example space_cover
     *
     * @var string
     */
    public $cover;

    /**
     * @example 2022-01-01T10:00:00Z
     *
     * @var string
     */
    public $createTime;

    /**
     * @var creator
     */
    public $creator;

    /**
     * @example description
     *
     * @var string
     */
    public $description;

    /**
     * @var iconVO
     */
    public $iconVO;

    /**
     * @example space_id
     *
     * @var string
     */
    public $id;

    /**
     * @example mobile_url
     *
     * @var string
     */
    public $mobileUrl;

    /**
     * @example 2022-01-01T10:00:00Z
     *
     * @var string
     */
    public $modifiedTime;

    /**
     * @var modifier
     */
    public $modifier;

    /**
     * @example space_name
     *
     * @var string
     */
    public $name;

    /**
     * @example pc_url
     *
     * @var string
     */
    public $pcUrl;
    protected $_name = [
        'cover'        => 'cover',
        'createTime'   => 'createTime',
        'creator'      => 'creator',
        'description'  => 'description',
        'iconVO'       => 'iconVO',
        'id'           => 'id',
        'mobileUrl'    => 'mobileUrl',
        'modifiedTime' => 'modifiedTime',
        'modifier'     => 'modifier',
        'name'         => 'name',
        'pcUrl'        => 'pcUrl',
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
        if (null !== $this->createTime) {
            $res['createTime'] = $this->createTime;
        }
        if (null !== $this->creator) {
            $res['creator'] = null !== $this->creator ? $this->creator->toMap() : null;
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
        if (null !== $this->mobileUrl) {
            $res['mobileUrl'] = $this->mobileUrl;
        }
        if (null !== $this->modifiedTime) {
            $res['modifiedTime'] = $this->modifiedTime;
        }
        if (null !== $this->modifier) {
            $res['modifier'] = null !== $this->modifier ? $this->modifier->toMap() : null;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->pcUrl) {
            $res['pcUrl'] = $this->pcUrl;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return spaceInfo
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['cover'])) {
            $model->cover = $map['cover'];
        }
        if (isset($map['createTime'])) {
            $model->createTime = $map['createTime'];
        }
        if (isset($map['creator'])) {
            $model->creator = creator::fromMap($map['creator']);
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
        if (isset($map['mobileUrl'])) {
            $model->mobileUrl = $map['mobileUrl'];
        }
        if (isset($map['modifiedTime'])) {
            $model->modifiedTime = $map['modifiedTime'];
        }
        if (isset($map['modifier'])) {
            $model->modifier = modifier::fromMap($map['modifier']);
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['pcUrl'])) {
            $model->pcUrl = $map['pcUrl'];
        }

        return $model;
    }
}
