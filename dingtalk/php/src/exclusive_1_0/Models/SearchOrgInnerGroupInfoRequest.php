<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models;

use AlibabaCloud\Tea\Model;

class SearchOrgInnerGroupInfoRequest extends Model
{
    /**
     * @description createTimeEnd
     *
     * @var int
     */
    public $createTimeEnd;

    /**
     * @description createTimeStart
     *
     * @var int
     */
    public $createTimeStart;

    /**
     * @description groupMembersCntEnd
     *
     * @var int
     */
    public $groupMembersCountEnd;

    /**
     * @description groupMembersCntStart
     *
     * @var int
     */
    public $groupMembersCountStart;

    /**
     * @description groupName
     *
     * @var string
     */
    public $groupName;

    /**
     * @description groupOwner
     *
     * @var string
     */
    public $groupOwner;

    /**
     * @description lastActiveTimeEnd
     *
     * @var int
     */
    public $lastActiveTimeEnd;

    /**
     * @description lastActiveTimeStart
     *
     * @var int
     */
    public $lastActiveTimeStart;

    /**
     * @description operatorUserId
     *
     * @var string
     */
    public $operatorUserId;

    /**
     * @description pageSize
     *
     * @var int
     */
    public $pageSize;

    /**
     * @description pageStart
     *
     * @var int
     */
    public $pageStart;

    /**
     * @description syncToDingpan
     *
     * @var int
     */
    public $syncToDingpan;

    /**
     * @description uuid
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
