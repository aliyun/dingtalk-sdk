<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vyida_2_0\Models\GetAgentTasksResponseBody;

use AlibabaCloud\Tea\Model;

class values extends Model
{
    /**
     * @var string
     */
    public $agentCategory;

    /**
     * @var string
     */
    public $agentCreateGMT;

    /**
     * @var string
     */
    public $agentEndGMT;

    /**
     * @var string
     */
    public $agentName;

    /**
     * @var string
     */
    public $agentRangeType;

    /**
     * @var string
     */
    public $agentRangeValue;

    /**
     * @var string
     */
    public $agentStartGMT;

    /**
     * @var string
     */
    public $agentType;

    /**
     * @var string
     */
    public $agentUserId;

    /**
     * @var string
     */
    public $agentUuid;

    /**
     * @var string
     */
    public $creator;

    /**
     * @var string
     */
    public $creatorName;

    /**
     * @var string
     */
    public $modifier;

    /**
     * @var string
     */
    public $needNoticePrincipal;

    /**
     * @var string
     */
    public $principalName;

    /**
     * @var string
     */
    public $principalUserId;

    /**
     * @var string
     */
    public $status;
    protected $_name = [
        'agentCategory' => 'agentCategory',
        'agentCreateGMT' => 'agentCreateGMT',
        'agentEndGMT' => 'agentEndGMT',
        'agentName' => 'agentName',
        'agentRangeType' => 'agentRangeType',
        'agentRangeValue' => 'agentRangeValue',
        'agentStartGMT' => 'agentStartGMT',
        'agentType' => 'agentType',
        'agentUserId' => 'agentUserId',
        'agentUuid' => 'agentUuid',
        'creator' => 'creator',
        'creatorName' => 'creatorName',
        'modifier' => 'modifier',
        'needNoticePrincipal' => 'needNoticePrincipal',
        'principalName' => 'principalName',
        'principalUserId' => 'principalUserId',
        'status' => 'status',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->agentCategory) {
            $res['agentCategory'] = $this->agentCategory;
        }
        if (null !== $this->agentCreateGMT) {
            $res['agentCreateGMT'] = $this->agentCreateGMT;
        }
        if (null !== $this->agentEndGMT) {
            $res['agentEndGMT'] = $this->agentEndGMT;
        }
        if (null !== $this->agentName) {
            $res['agentName'] = $this->agentName;
        }
        if (null !== $this->agentRangeType) {
            $res['agentRangeType'] = $this->agentRangeType;
        }
        if (null !== $this->agentRangeValue) {
            $res['agentRangeValue'] = $this->agentRangeValue;
        }
        if (null !== $this->agentStartGMT) {
            $res['agentStartGMT'] = $this->agentStartGMT;
        }
        if (null !== $this->agentType) {
            $res['agentType'] = $this->agentType;
        }
        if (null !== $this->agentUserId) {
            $res['agentUserId'] = $this->agentUserId;
        }
        if (null !== $this->agentUuid) {
            $res['agentUuid'] = $this->agentUuid;
        }
        if (null !== $this->creator) {
            $res['creator'] = $this->creator;
        }
        if (null !== $this->creatorName) {
            $res['creatorName'] = $this->creatorName;
        }
        if (null !== $this->modifier) {
            $res['modifier'] = $this->modifier;
        }
        if (null !== $this->needNoticePrincipal) {
            $res['needNoticePrincipal'] = $this->needNoticePrincipal;
        }
        if (null !== $this->principalName) {
            $res['principalName'] = $this->principalName;
        }
        if (null !== $this->principalUserId) {
            $res['principalUserId'] = $this->principalUserId;
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return values
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['agentCategory'])) {
            $model->agentCategory = $map['agentCategory'];
        }
        if (isset($map['agentCreateGMT'])) {
            $model->agentCreateGMT = $map['agentCreateGMT'];
        }
        if (isset($map['agentEndGMT'])) {
            $model->agentEndGMT = $map['agentEndGMT'];
        }
        if (isset($map['agentName'])) {
            $model->agentName = $map['agentName'];
        }
        if (isset($map['agentRangeType'])) {
            $model->agentRangeType = $map['agentRangeType'];
        }
        if (isset($map['agentRangeValue'])) {
            $model->agentRangeValue = $map['agentRangeValue'];
        }
        if (isset($map['agentStartGMT'])) {
            $model->agentStartGMT = $map['agentStartGMT'];
        }
        if (isset($map['agentType'])) {
            $model->agentType = $map['agentType'];
        }
        if (isset($map['agentUserId'])) {
            $model->agentUserId = $map['agentUserId'];
        }
        if (isset($map['agentUuid'])) {
            $model->agentUuid = $map['agentUuid'];
        }
        if (isset($map['creator'])) {
            $model->creator = $map['creator'];
        }
        if (isset($map['creatorName'])) {
            $model->creatorName = $map['creatorName'];
        }
        if (isset($map['modifier'])) {
            $model->modifier = $map['modifier'];
        }
        if (isset($map['needNoticePrincipal'])) {
            $model->needNoticePrincipal = $map['needNoticePrincipal'];
        }
        if (isset($map['principalName'])) {
            $model->principalName = $map['principalName'];
        }
        if (isset($map['principalUserId'])) {
            $model->principalUserId = $map['principalUserId'];
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }

        return $model;
    }
}
