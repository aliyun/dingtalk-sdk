<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vesign_2_0\Models\CreateProcessRequest;

use AlibabaCloud\Tea\Model;

class participants extends Model
{
    /**
     * @var string
     */
    public $signRequirements;

    /**
     * @var int
     */
    public $signOrder;

    /**
     * @var string
     */
    public $accountType;

    /**
     * @var string
     */
    public $account;

    /**
     * @var string
     */
    public $dingCorpId;

    /**
     * @var string
     */
    public $userId;

    /**
     * @var string
     */
    public $accountName;

    /**
     * @var string
     */
    public $orgName;
    protected $_name = [
        'signRequirements' => 'signRequirements',
        'signOrder'        => 'signOrder',
        'accountType'      => 'accountType',
        'account'          => 'account',
        'dingCorpId'       => 'dingCorpId',
        'userId'           => 'userId',
        'accountName'      => 'accountName',
        'orgName'          => 'orgName',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->signRequirements) {
            $res['signRequirements'] = $this->signRequirements;
        }
        if (null !== $this->signOrder) {
            $res['signOrder'] = $this->signOrder;
        }
        if (null !== $this->accountType) {
            $res['accountType'] = $this->accountType;
        }
        if (null !== $this->account) {
            $res['account'] = $this->account;
        }
        if (null !== $this->dingCorpId) {
            $res['dingCorpId'] = $this->dingCorpId;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }
        if (null !== $this->accountName) {
            $res['accountName'] = $this->accountName;
        }
        if (null !== $this->orgName) {
            $res['orgName'] = $this->orgName;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return participants
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['signRequirements'])) {
            $model->signRequirements = $map['signRequirements'];
        }
        if (isset($map['signOrder'])) {
            $model->signOrder = $map['signOrder'];
        }
        if (isset($map['accountType'])) {
            $model->accountType = $map['accountType'];
        }
        if (isset($map['account'])) {
            $model->account = $map['account'];
        }
        if (isset($map['dingCorpId'])) {
            $model->dingCorpId = $map['dingCorpId'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }
        if (isset($map['accountName'])) {
            $model->accountName = $map['accountName'];
        }
        if (isset($map['orgName'])) {
            $model->orgName = $map['orgName'];
        }

        return $model;
    }
}
