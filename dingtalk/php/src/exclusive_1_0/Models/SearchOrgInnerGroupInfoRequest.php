<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models;

use AlibabaCloud\Tea\Model;

class SearchOrgInnerGroupInfoRequest extends Model
{
    /**
     * @description groupMembersCntEnd
     *
     * @var int
     */
    public $groupMembersCountEnd;

    /**
     * @description syncToDingpan
     *
     * @var int
     */
    public $syncToDingpan;

    /**
     * @description groupOwner
     *
     * @var string
     */
    public $groupOwner;

    /**
     * @description createTimeEnd
     *
     * @var int
     */
    public $createTimeEnd;

    /**
     * @description pageSize
     *
     * @var int
     */
    public $pageSize;

    /**
     * @description createTimeStart
     *
     * @var int
     */
    public $createTimeStart;

    /**
     * @description uuid
     *
     * @var string
     */
    public $uuid;

    /**
     * @description groupMembersCntStart
     *
     * @var int
     */
    public $groupMembersCountStart;

    /**
     * @description lastActiveTimeEnd
     *
     * @var int
     */
    public $lastActiveTimeEnd;

    /**
     * @description operatorUserId
     *
     * @var string
     */
    public $operatorUserId;

    /**
     * @description groupName
     *
     * @var string
     */
    public $groupName;

    /**
     * @description pageStart
     *
     * @var int
     */
    public $pageStart;

    /**
     * @description lastActiveTimeStart
     *
     * @var int
     */
    public $lastActiveTimeStart;
    protected $_name = [
        'groupMembersCountEnd'   => 'groupMembersCountEnd',
        'syncToDingpan'          => 'syncToDingpan',
        'groupOwner'             => 'groupOwner',
        'createTimeEnd'          => 'createTimeEnd',
        'pageSize'               => 'pageSize',
        'createTimeStart'        => 'createTimeStart',
        'uuid'                   => 'uuid',
        'groupMembersCountStart' => 'groupMembersCountStart',
        'lastActiveTimeEnd'      => 'lastActiveTimeEnd',
        'operatorUserId'         => 'operatorUserId',
        'groupName'              => 'groupName',
        'pageStart'              => 'pageStart',
        'lastActiveTimeStart'    => 'lastActiveTimeStart',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->groupMembersCountEnd) {
            $res['groupMembersCountEnd'] = $this->groupMembersCountEnd;
        }
        if (null !== $this->syncToDingpan) {
            $res['syncToDingpan'] = $this->syncToDingpan;
        }
        if (null !== $this->groupOwner) {
            $res['groupOwner'] = $this->groupOwner;
        }
        if (null !== $this->createTimeEnd) {
            $res['createTimeEnd'] = $this->createTimeEnd;
        }
        if (null !== $this->pageSize) {
            $res['pageSize'] = $this->pageSize;
        }
        if (null !== $this->createTimeStart) {
            $res['createTimeStart'] = $this->createTimeStart;
        }
        if (null !== $this->uuid) {
            $res['uuid'] = $this->uuid;
        }
        if (null !== $this->groupMembersCountStart) {
            $res['groupMembersCountStart'] = $this->groupMembersCountStart;
        }
        if (null !== $this->lastActiveTimeEnd) {
            $res['lastActiveTimeEnd'] = $this->lastActiveTimeEnd;
        }
        if (null !== $this->operatorUserId) {
            $res['operatorUserId'] = $this->operatorUserId;
        }
        if (null !== $this->groupName) {
            $res['groupName'] = $this->groupName;
        }
        if (null !== $this->pageStart) {
            $res['pageStart'] = $this->pageStart;
        }
        if (null !== $this->lastActiveTimeStart) {
            $res['lastActiveTimeStart'] = $this->lastActiveTimeStart;
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
        if (isset($map['groupMembersCountEnd'])) {
            $model->groupMembersCountEnd = $map['groupMembersCountEnd'];
        }
        if (isset($map['syncToDingpan'])) {
            $model->syncToDingpan = $map['syncToDingpan'];
        }
        if (isset($map['groupOwner'])) {
            $model->groupOwner = $map['groupOwner'];
        }
        if (isset($map['createTimeEnd'])) {
            $model->createTimeEnd = $map['createTimeEnd'];
        }
        if (isset($map['pageSize'])) {
            $model->pageSize = $map['pageSize'];
        }
        if (isset($map['createTimeStart'])) {
            $model->createTimeStart = $map['createTimeStart'];
        }
        if (isset($map['uuid'])) {
            $model->uuid = $map['uuid'];
        }
        if (isset($map['groupMembersCountStart'])) {
            $model->groupMembersCountStart = $map['groupMembersCountStart'];
        }
        if (isset($map['lastActiveTimeEnd'])) {
            $model->lastActiveTimeEnd = $map['lastActiveTimeEnd'];
        }
        if (isset($map['operatorUserId'])) {
            $model->operatorUserId = $map['operatorUserId'];
        }
        if (isset($map['groupName'])) {
            $model->groupName = $map['groupName'];
        }
        if (isset($map['pageStart'])) {
            $model->pageStart = $map['pageStart'];
        }
        if (isset($map['lastActiveTimeStart'])) {
            $model->lastActiveTimeStart = $map['lastActiveTimeStart'];
        }

        return $model;
    }
}
