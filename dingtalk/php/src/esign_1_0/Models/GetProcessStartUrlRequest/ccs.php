<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vesign_1_0\Models\GetProcessStartUrlRequest;

use AlibabaCloud\Tea\Model;

class ccs extends Model
{
    /**
     * @var string
     */
    public $accountType;

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
    public $account;

    /**
     * @var string
     */
    public $accountName;

    /**
     * @var string
     */
    public $orgName;
    protected $_name = [
        'accountType' => 'accountType',
        'dingCorpId'  => 'dingCorpId',
        'userId'      => 'userId',
        'account'     => 'account',
        'accountName' => 'accountName',
        'orgName'     => 'orgName',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->accountType) {
            $res['accountType'] = $this->accountType;
        }
        if (null !== $this->dingCorpId) {
            $res['dingCorpId'] = $this->dingCorpId;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }
        if (null !== $this->account) {
            $res['account'] = $this->account;
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
     * @return ccs
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['accountType'])) {
            $model->accountType = $map['accountType'];
        }
        if (isset($map['dingCorpId'])) {
            $model->dingCorpId = $map['dingCorpId'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }
        if (isset($map['account'])) {
            $model->account = $map['account'];
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
