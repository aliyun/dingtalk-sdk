<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vtrip_1_0\Models\SyncTripProductConfigRequest\tripProductConfigList;

use AlibabaCloud\Tea\Model;

class tmcInfos extends Model
{
    /**
     * @var string
     */
    public $categoryType;

    /**
     * @var string
     */
    public $gmtOrgPay;

    /**
     * @var string
     */
    public $payType;

    /**
     * @var string
     */
    public $tmcCorpId;
    protected $_name = [
        'categoryType' => 'categoryType',
        'gmtOrgPay'    => 'gmtOrgPay',
        'payType'      => 'payType',
        'tmcCorpId'    => 'tmcCorpId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->categoryType) {
            $res['categoryType'] = $this->categoryType;
        }
        if (null !== $this->gmtOrgPay) {
            $res['gmtOrgPay'] = $this->gmtOrgPay;
        }
        if (null !== $this->payType) {
            $res['payType'] = $this->payType;
        }
        if (null !== $this->tmcCorpId) {
            $res['tmcCorpId'] = $this->tmcCorpId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return tmcInfos
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['categoryType'])) {
            $model->categoryType = $map['categoryType'];
        }
        if (isset($map['gmtOrgPay'])) {
            $model->gmtOrgPay = $map['gmtOrgPay'];
        }
        if (isset($map['payType'])) {
            $model->payType = $map['payType'];
        }
        if (isset($map['tmcCorpId'])) {
            $model->tmcCorpId = $map['tmcCorpId'];
        }

        return $model;
    }
}
