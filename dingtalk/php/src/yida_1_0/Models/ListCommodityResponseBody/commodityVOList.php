<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\ListCommodityResponseBody;

use AlibabaCloud\Tea\Model;

class commodityVOList extends Model
{
    /**
     * @description instanceId
     *
     * @var string
     */
    public $instanceId;

    /**
     * @description buyDate
     *
     * @var string
     */
    public $buyDateGMT;

    /**
     * @description expireDate
     *
     * @var string
     */
    public $expireDateGMT;

    /**
     * @description activationCode
     *
     * @var string
     */
    public $activationCode;

    /**
     * @description accountNum
     *
     * @var int
     */
    public $accountNumber;

    /**
     * @description accountDistributionNumber
     *
     * @var int
     */
    public $accountDistributionNumber;

    /**
     * @description version
     *
     * @var int
     */
    public $version;

    /**
     * @description status
     *
     * @var string
     */
    public $status;
    protected $_name = [
        'instanceId'                => 'instanceId',
        'buyDateGMT'                => 'buyDateGMT',
        'expireDateGMT'             => 'expireDateGMT',
        'activationCode'            => 'activationCode',
        'accountNumber'             => 'accountNumber',
        'accountDistributionNumber' => 'accountDistributionNumber',
        'version'                   => 'version',
        'status'                    => 'status',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->instanceId) {
            $res['instanceId'] = $this->instanceId;
        }
        if (null !== $this->buyDateGMT) {
            $res['buyDateGMT'] = $this->buyDateGMT;
        }
        if (null !== $this->expireDateGMT) {
            $res['expireDateGMT'] = $this->expireDateGMT;
        }
        if (null !== $this->activationCode) {
            $res['activationCode'] = $this->activationCode;
        }
        if (null !== $this->accountNumber) {
            $res['accountNumber'] = $this->accountNumber;
        }
        if (null !== $this->accountDistributionNumber) {
            $res['accountDistributionNumber'] = $this->accountDistributionNumber;
        }
        if (null !== $this->version) {
            $res['version'] = $this->version;
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return commodityVOList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['instanceId'])) {
            $model->instanceId = $map['instanceId'];
        }
        if (isset($map['buyDateGMT'])) {
            $model->buyDateGMT = $map['buyDateGMT'];
        }
        if (isset($map['expireDateGMT'])) {
            $model->expireDateGMT = $map['expireDateGMT'];
        }
        if (isset($map['activationCode'])) {
            $model->activationCode = $map['activationCode'];
        }
        if (isset($map['accountNumber'])) {
            $model->accountNumber = $map['accountNumber'];
        }
        if (isset($map['accountDistributionNumber'])) {
            $model->accountDistributionNumber = $map['accountDistributionNumber'];
        }
        if (isset($map['version'])) {
            $model->version = $map['version'];
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }

        return $model;
    }
}
