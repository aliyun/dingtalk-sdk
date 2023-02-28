<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\ListStarsRequest;

use AlibabaCloud\Tea\Model;

class option extends Model
{
    /**
     * @description 文档类型
     * 20
     * @var string[]
     */
    public $filterDocTypes;

    /**
     * @description 分页大小
     * 20
     * @var int
     */
    public $maxResults;

    /**
     * @description 分页游标
     *
     * @var string
     */
    public $nextToken;

    /**
     * @description 排序规则, 升降或降序
     * ASC
     * @var string
     */
    public $order;

    /**
     * @description 排序字段, 根据选择字段排序
     * CREATE_TIME: createTime
     * @var string
     */
    public $orderBy;

    /**
     * @description 是否获取文档创建者名称
     * false
     * @var bool
     */
    public $withDentryCreatorInfo;

    /**
     * @description 是否获取文档修改者名称
     * false
     * @var bool
     */
    public $withDentryModifierInfo;

    /**
     * @description 是否获取文档权限
     * false
     * @var bool
     */
    public $withDentryPermissionRole;

    /**
     * @description 是否获取知识库信息
     * false
     * @var bool
     */
    public $withSpaceDetail;

    /**
     * @description 是否获取知识库权限
     * false
     * @var bool
     */
    public $withSpacePermissionRole;

    /**
     * @description 是否获取小组信息
     * false
     * @var bool
     */
    public $withTeamDetail;
    protected $_name = [
        'filterDocTypes'           => 'filterDocTypes',
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
        if (null !== $this->filterDocTypes) {
            $res['filterDocTypes'] = $this->filterDocTypes;
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
        if (isset($map['filterDocTypes'])) {
            if (!empty($map['filterDocTypes'])) {
                $model->filterDocTypes = $map['filterDocTypes'];
            }
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
