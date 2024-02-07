<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vtrip_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vtrip_1_0\Models\SyncBusinessSignInfoRequest\tmcProductDetailList;
use AlibabaCloud\SDK\Dingtalk\Vtrip_1_0\Models\SyncBusinessSignInfoRequest\tmcProductList;
use AlibabaCloud\Tea\Model;

class SyncBusinessSignInfoRequest extends Model
{
    /**
     * @var string[]
     */
    public $bizTypeList;

    /**
     * @example 1661927020219
     *
     * @var string
     */
    public $gmtOrgPay;

    /**
     * @example 1661927020219
     *
     * @var string
     */
    public $gmtSign;

    /**
     * @example ORG_PAY
     *
     * @var string
     */
    public $orgPayStatus;

    /**
     * @example SIGN
     *
     * @var string
     */
    public $signStatus;

    /**
     * @example ding89233847892ndkas
     *
     * @var string
     */
    public $targetCorpId;

    /**
     * @var tmcProductDetailList[]
     */
    public $tmcProductDetailList;

    /**
     * @var tmcProductList[]
     */
    public $tmcProductList;
    protected $_name = [
        'bizTypeList'          => 'bizTypeList',
        'gmtOrgPay'            => 'gmtOrgPay',
        'gmtSign'              => 'gmtSign',
        'orgPayStatus'         => 'orgPayStatus',
        'signStatus'           => 'signStatus',
        'targetCorpId'         => 'targetCorpId',
        'tmcProductDetailList' => 'tmcProductDetailList',
        'tmcProductList'       => 'tmcProductList',
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
        if (null !== $this->tmcProductDetailList) {
            $res['tmcProductDetailList'] = [];
            if (null !== $this->tmcProductDetailList && \is_array($this->tmcProductDetailList)) {
                $n = 0;
                foreach ($this->tmcProductDetailList as $item) {
                    $res['tmcProductDetailList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->tmcProductList) {
            $res['tmcProductList'] = [];
            if (null !== $this->tmcProductList && \is_array($this->tmcProductList)) {
                $n = 0;
                foreach ($this->tmcProductList as $item) {
                    $res['tmcProductList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
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
        if (isset($map['tmcProductDetailList'])) {
            if (!empty($map['tmcProductDetailList'])) {
                $model->tmcProductDetailList = [];
                $n                           = 0;
                foreach ($map['tmcProductDetailList'] as $item) {
                    $model->tmcProductDetailList[$n++] = null !== $item ? tmcProductDetailList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['tmcProductList'])) {
            if (!empty($map['tmcProductList'])) {
                $model->tmcProductList = [];
                $n                     = 0;
                foreach ($map['tmcProductList'] as $item) {
                    $model->tmcProductList[$n++] = null !== $item ? tmcProductList::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
