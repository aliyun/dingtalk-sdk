<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models;

use AlibabaCloud\Tea\Model;

class SearchOrgInnerGroupInfoRequest extends Model
{
    /**
     * @example 创建时间查询最大时间戳
     *
     * @var int
     */
    public $createTimeEnd;

    /**
     * @example 创建时间查询最小时间戳
     *
     * @var int
     */
    public $createTimeStart;

    /**
     * @example 群人数范围最大值，例如100
     *
     * @var int
     */
    public $groupMembersCountEnd;

    /**
     * @example 群人数范围最小值，例如1
     *
     * @var int
     */
    public $groupMembersCountStart;

    /**
     * @example 群名称
     *
     * @var string
     */
    public $groupName;

    /**
     * @example 群主userId
     *
     * @var string
     */
    public $groupOwner;

    /**
     * @example 最后一次活跃时间戳最大值
     *
     * @var int
     */
    public $lastActiveTimeEnd;

    /**
     * @example 最后一次活跃时间戳最小值
     *
     * @var int
     */
    public $lastActiveTimeStart;

    /**
     * @example 当前查询人的userId
     *
     * @var string
     */
    public $operatorUserId;

    /**
     * @example 分页大小，最大不能超过100
     *
     * @var int
     */
    public $pageSize;

    /**
     * @example 分页号，从1开始
     *
     * @var int
     */
    public $pageStart;

    /**
     * @example 是否同步到钉盘 0不同步 1同步
     *
     * @var int
     */
    public $syncToDingpan;

    /**
     * @example 每次查询唯一标识，保证每次分页查询时该值不变
     *
     * @var string
     */
    public $uuid;
    protected $_name = [
        'createTimeEnd'          => 'createTimeEnd',
        'createTimeStart'        => 'createTimeStart',
        'groupMembersCountEnd'   => 'groupMembersCountEnd',
        'groupMembersCountStart' => 'groupMembersCountStart',
        'groupName'              => 'groupName',
        'groupOwner'             => 'groupOwner',
        'lastActiveTimeEnd'      => 'lastActiveTimeEnd',
        'lastActiveTimeStart'    => 'lastActiveTimeStart',
        'operatorUserId'         => 'operatorUserId',
        'pageSize'               => 'pageSize',
        'pageStart'              => 'pageStart',
        'syncToDingpan'          => 'syncToDingpan',
        'uuid'                   => 'uuid',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->createTimeEnd) {
            $res['createTimeEnd'] = $this->createTimeEnd;
        }
        if (null !== $this->createTimeStart) {
            $res['createTimeStart'] = $this->createTimeStart;
        }
        if (null !== $this->groupMembersCountEnd) {
            $res['groupMembersCountEnd'] = $this->groupMembersCountEnd;
        }
        if (null !== $this->groupMembersCountStart) {
            $res['groupMembersCountStart'] = $this->groupMembersCountStart;
        }
        if (null !== $this->groupName) {
            $res['groupName'] = $this->groupName;
        }
        if (null !== $this->groupOwner) {
            $res['groupOwner'] = $this->groupOwner;
        }
        if (null !== $this->lastActiveTimeEnd) {
            $res['lastActiveTimeEnd'] = $this->lastActiveTimeEnd;
        }
        if (null !== $this->lastActiveTimeStart) {
            $res['lastActiveTimeStart'] = $this->lastActiveTimeStart;
        }
        if (null !== $this->operatorUserId) {
            $res['operatorUserId'] = $this->operatorUserId;
        }
        if (null !== $this->pageSize) {
            $res['pageSize'] = $this->pageSize;
        }
        if (null !== $this->pageStart) {
            $res['pageStart'] = $this->pageStart;
        }
        if (null !== $this->syncToDingpan) {
            $res['syncToDingpan'] = $this->syncToDingpan;
        }
        if (null !== $this->uuid) {
            $res['uuid'] = $this->uuid;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return SearchOrgInnerGroupInfoRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['createTimeEnd'])) {
            $model->createTimeEnd = $map['createTimeEnd'];
        }
        if (isset($map['createTimeStart'])) {
            $model->createTimeStart = $map['createTimeStart'];
        }
        if (isset($map['groupMembersCountEnd'])) {
            $model->groupMembersCountEnd = $map['groupMembersCountEnd'];
        }
        if (isset($map['groupMembersCountStart'])) {
            $model->groupMembersCountStart = $map['groupMembersCountStart'];
        }
        if (isset($map['groupName'])) {
            $model->groupName = $map['groupName'];
        }
        if (isset($map['groupOwner'])) {
            $model->groupOwner = $map['groupOwner'];
        }
        if (isset($map['lastActiveTimeEnd'])) {
            $model->lastActiveTimeEnd = $map['lastActiveTimeEnd'];
        }
        if (isset($map['lastActiveTimeStart'])) {
            $model->lastActiveTimeStart = $map['lastActiveTimeStart'];
        }
        if (isset($map['operatorUserId'])) {
            $model->operatorUserId = $map['operatorUserId'];
        }
        if (isset($map['pageSize'])) {
            $model->pageSize = $map['pageSize'];
        }
        if (isset($map['pageStart'])) {
            $model->pageStart = $map['pageStart'];
        }
        if (isset($map['syncToDingpan'])) {
            $model->syncToDingpan = $map['syncToDingpan'];
        }
        if (isset($map['uuid'])) {
            $model->uuid = $map['uuid'];
        }

        return $model;
    }
}
