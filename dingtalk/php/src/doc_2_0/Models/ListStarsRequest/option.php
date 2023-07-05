<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\ListStarsRequest;

use AlibabaCloud\Tea\Model;

class option extends Model
{
    /**
     * @var string[]
     */
    public $contentTypeList;

    /**
     * @var string[]
     */
    public $filterDocTypes;

    /**
     * @example true
     *
     * @var bool
     */
    public $listV2;

    /**
     * @example 20
     *
     * @var int
     */
    public $maxResults;

    /**
     * @example next_token
     *
     * @var string
     */
    public $nextToken;

    /**
     * @example ASC
     *
     * @var string
     */
    public $order;

    /**
     * @example createTime
     *
     * @var string
     */
    public $orderBy;

    /**
     * @example true
     *
     * @var bool
     */
    public $withDentryCreatorInfo;

    /**
     * @example true
     *
     * @var bool
     */
    public $withDentryModifierInfo;

    /**
     * @example true
     *
     * @var bool
     */
    public $withDentryPermissionRole;

    /**
     * @example true
     *
     * @var bool
     */
    public $withSpaceDetail;

    /**
     * @example true
     *
     * @var bool
     */
    public $withSpacePermissionRole;

    /**
     * @example true
     *
     * @var bool
     */
    public $withTeamDetail;
    protected $_name = [
        'contentTypeList'          => 'contentTypeList',
        'filterDocTypes'           => 'filterDocTypes',
        'listV2'                   => 'listV2',
        'maxResults'               => 'maxResults',
        'nextToken'                => 'nextToken',
        'order'                    => 'order',
        'orderBy'                  => 'orderBy',
        'withDentryCreatorInfo'    => 'withDentryCreatorInfo',
        'withDentryModifierInfo'   => 'withDentryModifierInfo',
        'withDentryPermissionRole' => 'withDentryPermissionRole',
        'withSpaceDetail'          => 'withSpaceDetail',
        'withSpacePermissionRole'  => 'withSpacePermissionRole',
        'withTeamDetail'           => 'withTeamDetail',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->contentTypeList) {
            $res['contentTypeList'] = $this->contentTypeList;
        }
        if (null !== $this->filterDocTypes) {
            $res['filterDocTypes'] = $this->filterDocTypes;
        }
        if (null !== $this->listV2) {
            $res['listV2'] = $this->listV2;
        }
        if (null !== $this->maxResults) {
            $res['maxResults'] = $this->maxResults;
        }
        if (null !== $this->nextToken) {
            $res['nextToken'] = $this->nextToken;
        }
        if (null !== $this->order) {
            $res['order'] = $this->order;
        }
        if (null !== $this->orderBy) {
            $res['orderBy'] = $this->orderBy;
        }
        if (null !== $this->withDentryCreatorInfo) {
            $res['withDentryCreatorInfo'] = $this->withDentryCreatorInfo;
        }
        if (null !== $this->withDentryModifierInfo) {
            $res['withDentryModifierInfo'] = $this->withDentryModifierInfo;
        }
        if (null !== $this->withDentryPermissionRole) {
            $res['withDentryPermissionRole'] = $this->withDentryPermissionRole;
        }
        if (null !== $this->withSpaceDetail) {
            $res['withSpaceDetail'] = $this->withSpaceDetail;
        }
        if (null !== $this->withSpacePermissionRole) {
            $res['withSpacePermissionRole'] = $this->withSpacePermissionRole;
        }
        if (null !== $this->withTeamDetail) {
            $res['withTeamDetail'] = $this->withTeamDetail;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return option
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['contentTypeList'])) {
            if (!empty($map['contentTypeList'])) {
                $model->contentTypeList = $map['contentTypeList'];
            }
        }
        if (isset($map['filterDocTypes'])) {
            if (!empty($map['filterDocTypes'])) {
                $model->filterDocTypes = $map['filterDocTypes'];
            }
        }
        if (isset($map['listV2'])) {
            $model->listV2 = $map['listV2'];
        }
        if (isset($map['maxResults'])) {
            $model->maxResults = $map['maxResults'];
        }
        if (isset($map['nextToken'])) {
            $model->nextToken = $map['nextToken'];
        }
        if (isset($map['order'])) {
            $model->order = $map['order'];
        }
        if (isset($map['orderBy'])) {
            $model->orderBy = $map['orderBy'];
        }
        if (isset($map['withDentryCreatorInfo'])) {
            $model->withDentryCreatorInfo = $map['withDentryCreatorInfo'];
        }
        if (isset($map['withDentryModifierInfo'])) {
            $model->withDentryModifierInfo = $map['withDentryModifierInfo'];
        }
        if (isset($map['withDentryPermissionRole'])) {
            $model->withDentryPermissionRole = $map['withDentryPermissionRole'];
        }
        if (isset($map['withSpaceDetail'])) {
            $model->withSpaceDetail = $map['withSpaceDetail'];
        }
        if (isset($map['withSpacePermissionRole'])) {
            $model->withSpacePermissionRole = $map['withSpacePermissionRole'];
        }
        if (isset($map['withTeamDetail'])) {
            $model->withTeamDetail = $map['withTeamDetail'];
        }

        return $model;
    }
}
