<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vesign_2_0\Models\ProcessStartRequest;

use AlibabaCloud\Tea\Model;

class ccs extends Model
{
    /**
     * @description 用户类型（"DING_USER":钉钉用户，"OUTER_USER":外部用户）
     *
     * @var string
     */
    public $accountType;

    /**
     * @var string
     */
    public $dingCorpId;

    /**
     * @description DING_USER必填
     *
     * @var string
     */
    public $userId;

    /**
     * @description OUTER_USER必填
     *
     * @var string
     */
    public $account;

    /**
     * @description OUTER_USER必填
     *
     * @var string
     */
    public $accountName;

    /**
     * @description 发给企业方必填
     *
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
