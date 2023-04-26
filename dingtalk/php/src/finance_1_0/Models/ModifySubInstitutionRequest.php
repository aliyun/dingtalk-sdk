<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\ModifySubInstitutionRequest\contactInfo;
use AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\ModifySubInstitutionRequest\legalPersonCertInfo;
use AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\ModifySubInstitutionRequest\qualificationInfos;
use AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\ModifySubInstitutionRequest\settleInfo;
use AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\ModifySubInstitutionRequest\subInstAddressInfo;
use AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\ModifySubInstitutionRequest\subInstAuthInfo;
use AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\ModifySubInstitutionRequest\subInstBasicInfo;
use AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\ModifySubInstitutionRequest\subInstCertifyInfo;
use AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\ModifySubInstitutionRequest\subInstInvoiceInfo;
use AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\ModifySubInstitutionRequest\subInstShopInfo;
use AlibabaCloud\Tea\Model;

class ModifySubInstitutionRequest extends Model
{
    /**
     * @example asdf@163.com
     *
     * @var string
     */
    public $bindingAlipayLogonId;

    /**
     * @var contactInfo
     */
    public $contactInfo;

    /**
     * @example 202111090001
     *
     * @var string
     */
    public $instId;

    /**
     * @var legalPersonCertInfo
     */
    public $legalPersonCertInfo;

    /**
     * @example 2021000001
     *
     * @var string
     */
    public $outTradeNo;

    /**
     * @example ALIPAY
     *
     * @var string
     */
    public $payChannel;

    /**
     * @var qualificationInfos[]
     */
    public $qualificationInfos;

    /**
     * @var string[]
     */
    public $services;

    /**
     * @var settleInfo
     */
    public $settleInfo;

    /**
     * @var subInstAddressInfo
     */
    public $subInstAddressInfo;

    /**
     * @var subInstAuthInfo
     */
    public $subInstAuthInfo;

    /**
     * @var subInstBasicInfo
     */
    public $subInstBasicInfo;

    /**
     * @var subInstCertifyInfo
     */
    public $subInstCertifyInfo;

    /**
     * @example 1001
     *
     * @var string
     */
    public $subInstId;

    /**
     * @var subInstInvoiceInfo
     */
    public $subInstInvoiceInfo;

    /**
     * @var subInstShopInfo
     */
    public $subInstShopInfo;
    protected $_name = [
        'bindingAlipayLogonId' => 'bindingAlipayLogonId',
        'contactInfo'          => 'contactInfo',
        'instId'               => 'instId',
        'legalPersonCertInfo'  => 'legalPersonCertInfo',
        'outTradeNo'           => 'outTradeNo',
        'payChannel'           => 'payChannel',
        'qualificationInfos'   => 'qualificationInfos',
        'services'             => 'services',
        'settleInfo'           => 'settleInfo',
        'subInstAddressInfo'   => 'subInstAddressInfo',
        'subInstAuthInfo'      => 'subInstAuthInfo',
        'subInstBasicInfo'     => 'subInstBasicInfo',
        'subInstCertifyInfo'   => 'subInstCertifyInfo',
        'subInstId'            => 'subInstId',
        'subInstInvoiceInfo'   => 'subInstInvoiceInfo',
        'subInstShopInfo'      => 'subInstShopInfo',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->bindingAlipayLogonId) {
            $res['bindingAlipayLogonId'] = $this->bindingAlipayLogonId;
        }
        if (null !== $this->contactInfo) {
            $res['contactInfo'] = null !== $this->contactInfo ? $this->contactInfo->toMap() : null;
        }
        if (null !== $this->instId) {
            $res['instId'] = $this->instId;
        }
        if (null !== $this->legalPersonCertInfo) {
            $res['legalPersonCertInfo'] = null !== $this->legalPersonCertInfo ? $this->legalPersonCertInfo->toMap() : null;
        }
        if (null !== $this->outTradeNo) {
            $res['outTradeNo'] = $this->outTradeNo;
        }
        if (null !== $this->payChannel) {
            $res['payChannel'] = $this->payChannel;
        }
        if (null !== $this->qualificationInfos) {
            $res['qualificationInfos'] = [];
            if (null !== $this->qualificationInfos && \is_array($this->qualificationInfos)) {
                $n = 0;
                foreach ($this->qualificationInfos as $item) {
                    $res['qualificationInfos'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->services) {
            $res['services'] = $this->services;
        }
        if (null !== $this->settleInfo) {
            $res['settleInfo'] = null !== $this->settleInfo ? $this->settleInfo->toMap() : null;
        }
        if (null !== $this->subInstAddressInfo) {
            $res['subInstAddressInfo'] = null !== $this->subInstAddressInfo ? $this->subInstAddressInfo->toMap() : null;
        }
        if (null !== $this->subInstAuthInfo) {
            $res['subInstAuthInfo'] = null !== $this->subInstAuthInfo ? $this->subInstAuthInfo->toMap() : null;
        }
        if (null !== $this->subInstBasicInfo) {
            $res['subInstBasicInfo'] = null !== $this->subInstBasicInfo ? $this->subInstBasicInfo->toMap() : null;
        }
        if (null !== $this->subInstCertifyInfo) {
            $res['subInstCertifyInfo'] = null !== $this->subInstCertifyInfo ? $this->subInstCertifyInfo->toMap() : null;
        }
        if (null !== $this->subInstId) {
            $res['subInstId'] = $this->subInstId;
        }
        if (null !== $this->subInstInvoiceInfo) {
            $res['subInstInvoiceInfo'] = null !== $this->subInstInvoiceInfo ? $this->subInstInvoiceInfo->toMap() : null;
        }
        if (null !== $this->subInstShopInfo) {
            $res['subInstShopInfo'] = null !== $this->subInstShopInfo ? $this->subInstShopInfo->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ModifySubInstitutionRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['bindingAlipayLogonId'])) {
            $model->bindingAlipayLogonId = $map['bindingAlipayLogonId'];
        }
        if (isset($map['contactInfo'])) {
            $model->contactInfo = contactInfo::fromMap($map['contactInfo']);
        }
        if (isset($map['instId'])) {
            $model->instId = $map['instId'];
        }
        if (isset($map['legalPersonCertInfo'])) {
            $model->legalPersonCertInfo = legalPersonCertInfo::fromMap($map['legalPersonCertInfo']);
        }
        if (isset($map['outTradeNo'])) {
            $model->outTradeNo = $map['outTradeNo'];
        }
        if (isset($map['payChannel'])) {
            $model->payChannel = $map['payChannel'];
        }
        if (isset($map['qualificationInfos'])) {
            if (!empty($map['qualificationInfos'])) {
                $model->qualificationInfos = [];
                $n                         = 0;
                foreach ($map['qualificationInfos'] as $item) {
                    $model->qualificationInfos[$n++] = null !== $item ? qualificationInfos::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['services'])) {
            if (!empty($map['services'])) {
                $model->services = $map['services'];
            }
        }
        if (isset($map['settleInfo'])) {
            $model->settleInfo = settleInfo::fromMap($map['settleInfo']);
        }
        if (isset($map['subInstAddressInfo'])) {
            $model->subInstAddressInfo = subInstAddressInfo::fromMap($map['subInstAddressInfo']);
        }
        if (isset($map['subInstAuthInfo'])) {
            $model->subInstAuthInfo = subInstAuthInfo::fromMap($map['subInstAuthInfo']);
        }
        if (isset($map['subInstBasicInfo'])) {
            $model->subInstBasicInfo = subInstBasicInfo::fromMap($map['subInstBasicInfo']);
        }
        if (isset($map['subInstCertifyInfo'])) {
            $model->subInstCertifyInfo = subInstCertifyInfo::fromMap($map['subInstCertifyInfo']);
        }
        if (isset($map['subInstId'])) {
            $model->subInstId = $map['subInstId'];
        }
        if (isset($map['subInstInvoiceInfo'])) {
            $model->subInstInvoiceInfo = subInstInvoiceInfo::fromMap($map['subInstInvoiceInfo']);
        }
        if (isset($map['subInstShopInfo'])) {
            $model->subInstShopInfo = subInstShopInfo::fromMap($map['subInstShopInfo']);
        }

        return $model;
    }
}
