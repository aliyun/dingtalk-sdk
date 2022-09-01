<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vtrip_1_0\Models;

use AlibabaCloud\Tea\Model;

class SyncBusinessSignInfoRequest extends Model
{
    /**
     * @description 签约企业所支持的订单类目，如机票、酒店、火车票、打车。
     * ["HOTEL","FLIGHT","TAXI","TRAIN"]
     * @var string[]
     */
    public $bizTypeList;

    /**
     * @description 开通企业支付的时间戳，毫秒
     *
     *
     * @var string
     */
    public $gmtOrgPay;

    /**
     * @description 签约时间戳，毫秒
     *
     *
     * @var string
     */
    public $gmtSign;

    /**
     * @description 开通企业支付状态
     *
     *
     * @var string
     */
    public $orgPayStatus;

    /**
     * @description 企业签约状态
     *
     * @var string
     */
    public $signStatus;

    /**
     * @description 签约企业corpId
     *
     * @var string
     */
    public $targetCorpId;
    protected $_name = [
        'bizTypeList'  => 'bizTypeList',
        'gmtOrgPay'    => 'gmtOrgPay',
        'gmtSign'      => 'gmtSign',
        'orgPayStatus' => 'orgPayStatus',
        'signStatus'   => 'signStatus',
        'targetCorpId' => 'targetCorpId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->bizTypeList) {
            $res['bizTypeList'] = $this->bizTypeList;
        }
        if (null !== $this->gmtOrgPay) {
            $res['gmtOrgPay'] = $this->gmtOrgPay;
        }
        if (null !== $this->gmtSign) {
            $res['gmtSign'] = $this->gmtSign;
        }
        if (null !== $this->orgPayStatus) {
            $res['orgPayStatus'] = $this->orgPayStatus;
        }
        if (null !== $this->signStatus) {
            $res['signStatus'] = $this->signStatus;
        }
        if (null !== $this->targetCorpId) {
            $res['targetCorpId'] = $this->targetCorpId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return SyncBusinessSignInfoRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['bizTypeList'])) {
            if (!empty($map['bizTypeList'])) {
                $model->bizTypeList = $map['bizTypeList'];
            }
        }
        if (isset($map['gmtOrgPay'])) {
            $model->gmtOrgPay = $map['gmtOrgPay'];
        }
        if (isset($map['gmtSign'])) {
            $model->gmtSign = $map['gmtSign'];
        }
        if (isset($map['orgPayStatus'])) {
            $model->orgPayStatus = $map['orgPayStatus'];
        }
        if (isset($map['signStatus'])) {
            $model->signStatus = $map['signStatus'];
        }
        if (isset($map['targetCorpId'])) {
            $model->targetCorpId = $map['targetCorpId'];
        }

        return $model;
    }
}
