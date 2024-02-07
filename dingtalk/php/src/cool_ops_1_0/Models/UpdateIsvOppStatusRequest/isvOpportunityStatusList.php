<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcool_ops_1_0\Models\UpdateIsvOppStatusRequest;

use AlibabaCloud\Tea\Model;

class isvOpportunityStatusList extends Model
{
    /**
     * @var string
     */
    public $isvCorpId;

    /**
     * @var string
     */
    public $microAppId;

    /**
     * @var string
     */
    public $name;

    /**
     * @var string
     */
    public $note;

    /**
     * @var string
     */
    public $operCorpId;

    /**
     * @var string
     */
    public $operName;

    /**
     * @var string
     */
    public $operTime;

    /**
     * @var string
     */
    public $operUserId;

    /**
     * @var string
     */
    public $oppSourceCorpId;

    /**
     * @var string
     */
    public $opportunityStatus;

    /**
     * @var string
     */
    public $userId;
    protected $_name = [
        'isvCorpId'         => 'isvCorpId',
        'microAppId'        => 'microAppId',
        'name'              => 'name',
        'note'              => 'note',
        'operCorpId'        => 'operCorpId',
        'operName'          => 'operName',
        'operTime'          => 'operTime',
        'operUserId'        => 'operUserId',
        'oppSourceCorpId'   => 'oppSourceCorpId',
        'opportunityStatus' => 'opportunityStatus',
        'userId'            => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->isvCorpId) {
            $res['isvCorpId'] = $this->isvCorpId;
        }
        if (null !== $this->microAppId) {
            $res['microAppId'] = $this->microAppId;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->note) {
            $res['note'] = $this->note;
        }
        if (null !== $this->operCorpId) {
            $res['operCorpId'] = $this->operCorpId;
        }
        if (null !== $this->operName) {
            $res['operName'] = $this->operName;
        }
        if (null !== $this->operTime) {
            $res['operTime'] = $this->operTime;
        }
        if (null !== $this->operUserId) {
            $res['operUserId'] = $this->operUserId;
        }
        if (null !== $this->oppSourceCorpId) {
            $res['oppSourceCorpId'] = $this->oppSourceCorpId;
        }
        if (null !== $this->opportunityStatus) {
            $res['opportunityStatus'] = $this->opportunityStatus;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return isvOpportunityStatusList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['isvCorpId'])) {
            $model->isvCorpId = $map['isvCorpId'];
        }
        if (isset($map['microAppId'])) {
            $model->microAppId = $map['microAppId'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['note'])) {
            $model->note = $map['note'];
        }
        if (isset($map['operCorpId'])) {
            $model->operCorpId = $map['operCorpId'];
        }
        if (isset($map['operName'])) {
            $model->operName = $map['operName'];
        }
        if (isset($map['operTime'])) {
            $model->operTime = $map['operTime'];
        }
        if (isset($map['operUserId'])) {
            $model->operUserId = $map['operUserId'];
        }
        if (isset($map['oppSourceCorpId'])) {
            $model->oppSourceCorpId = $map['oppSourceCorpId'];
        }
        if (isset($map['opportunityStatus'])) {
            $model->opportunityStatus = $map['opportunityStatus'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
