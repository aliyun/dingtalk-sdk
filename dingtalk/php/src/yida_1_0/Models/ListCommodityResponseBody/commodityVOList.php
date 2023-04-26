<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\ListCommodityResponseBody;

use AlibabaCloud\Tea\Model;

class commodityVOList extends Model
{
    /**
     * @var int
     */
    public $accountDistributionNumber;

    /**
     * @var int
     */
    public $accountNumber;

    /**
     * @var string
     */
    public $activationCode;

    /**
     * @var string
     */
    public $buyDateGMT;

    /**
     * @var string
     */
    public $expireDateGMT;

    /**
     * @var string
     */
    public $instanceId;

    /**
     * @var string
     */
    public $status;

    /**
     * @var int
     */
    public $version;
    protected $_name = [
        'accountDistributionNumber' => 'accountDistributionNumber',
        'accountNumber'             => 'accountNumber',
        'activationCode'            => 'activationCode',
        'buyDateGMT'                => 'buyDateGMT',
        'expireDateGMT'             => 'expireDateGMT',
        'instanceId'                => 'instanceId',
        'status'                    => 'status',
        'version'                   => 'version',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->accountDistributionNumber) {
            $res['accountDistributionNumber'] = $this->accountDistributionNumber;
        }
        if (null !== $this->accountNumber) {
            $res['accountNumber'] = $this->accountNumber;
        }
        if (null !== $this->activationCode) {
            $res['activationCode'] = $this->activationCode;
        }
        if (null !== $this->buyDateGMT) {
            $res['buyDateGMT'] = $this->buyDateGMT;
        }
        if (null !== $this->expireDateGMT) {
            $res['expireDateGMT'] = $this->expireDateGMT;
        }
        if (null !== $this->instanceId) {
            $res['instanceId'] = $this->instanceId;
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }
        if (null !== $this->version) {
            $res['version'] = $this->version;
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
        if (isset($map['accountDistributionNumber'])) {
            $model->accountDistributionNumber = $map['accountDistributionNumber'];
        }
        if (isset($map['accountNumber'])) {
            $model->accountNumber = $map['accountNumber'];
        }
        if (isset($map['activationCode'])) {
            $model->activationCode = $map['activationCode'];
        }
        if (isset($map['buyDateGMT'])) {
            $model->buyDateGMT = $map['buyDateGMT'];
        }
        if (isset($map['expireDateGMT'])) {
            $model->expireDateGMT = $map['expireDateGMT'];
        }
        if (isset($map['instanceId'])) {
            $model->instanceId = $map['instanceId'];
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }
        if (isset($map['version'])) {
            $model->version = $map['version'];
        }

        return $model;
    }
}
